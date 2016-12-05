using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class frmCancelarAtencionPaciente : Form
    {
        private string rol = "";
        private string usuario = "";
        private string idAfiliado = "";
        string comando = "";
        //string conexion = "Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016";


        public frmCancelarAtencionPaciente()
        {
            InitializeComponent();
            this.rol = Clases.Usuario.id_rol;
            this.usuario = Clases.Usuario.Name;

            cancelarMismoDiaWarning.Visible = false;
            faltanCamposWarning.Visible = false;
            cmbMotivoCancelacion.Enabled = false;
            cmbSeleccionTurno.Enabled = false;

            if (rol.Equals("Afiliado"))
            {
                lblNumeroAfiliado.Visible = false;
                txtNumeroAfiliado.Visible = false;
                btnCargarAfiliado.Visible = false;
                cargarDatosAfiliado(Clases.Usuario.obtenerNumeroAfiliado());
            }           
        }

        private void cargarDatosAfiliado(string idAfiliado)
        {
            //SE CARGAN LOS TURNOS

            comando = "select fecha from NEXTGDD.Turno where nro_afiliado = '" + idAfiliado + "'and isnull(cod_cancelacion,0)=0 and CONVERT(DATE,fecha)>'"+DateTime.Parse(Clases.FechaSistema.fechaSistema).ToString("yyyy-MM-dd")+"'";
            cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, "fecha"), cmbSeleccionTurno);

            comando = "select nombre from NEXTGDD.Tipo_cancelacion";
            cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, "nombre"), cmbMotivoCancelacion);
        }

        private void cargar(List<string> lista, ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }

            cmb.Enabled = true;
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

            if (cmbMotivoCancelacion.SelectedItem == null || cmbSeleccionTurno.SelectedItem == null)
            {
                faltanCamposWarning.Visible = true;
                return;
            }

            faltanCamposWarning.Visible = false;

            if (elTurnoEsHoy(cmbSeleccionTurno.SelectedItem.ToString()))
            {
                cancelarMismoDiaWarning.Visible = true;
                return;
            }

            // Cancelar el bono

            string nroTurno = Clases.BaseDeDatosSQL.buscarCampo("select nro_turno from NEXTGDD.Turno where fecha = '"+ 
                DateTime.Parse(cmbSeleccionTurno.SelectedItem.ToString()).ToString("yyyy-MM-dd HH:mm:ss") + "' and nro_afiliado = '" + idAfiliado + "'");
            string tipoCancelacion = Clases.BaseDeDatosSQL.buscarCampo("select tipo_cancelacion from NEXTGDD.Tipo_cancelacion where nombre = '"+
                cmbMotivoCancelacion.SelectedItem.ToString()+"'");

            comando = "EXECUTE NEXTGDD.cancelarTurno @nroTurno='" + nroTurno + "',@tipoCancelacion ='" + tipoCancelacion + 
                "', @motivo='" + txtBoxDetalleCancelacion.Text + "', @persona='Afiliado'";
            Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);

            MessageBox.Show("Turno Cancelado Exitosamente", "Cancelar Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmCancelarAtencionPaciente NewForm = new frmCancelarAtencionPaciente();
            NewForm.Show();
            this.Dispose(false);



        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms();
            this.Hide();
            menuAbm.Show();
        }

        private void frmCancelarAtencionPaciente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Realmente desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private Boolean elTurnoEsHoy(String turnoHoy)
        {
            return convertirFechaSinHoras(turnoHoy).Equals(convertirFechaSinHoras(Clases.FechaSistema.fechaSistema));
        }

        private string convertirFechaSinHoras(string fecha)
        {
            string fechaSinTiempo = fecha.Split(' ')[0];
            string dia = fechaSinTiempo.Split('/')[0];
            if (dia.Length == 1)
            {
                dia = '0' + dia;
            }
            string mes = fechaSinTiempo.Split('/')[1];
            if (mes.Length == 1)
            {
                mes = '0' + mes;
            }
            string año = fechaSinTiempo.Split('/')[2];
            return año + "/" + mes + "/" + dia + " ";
            //+ fecha.Split(' ')[1] si quiero tmb horas minutos seg
        }

        private void frmCancelarAtencionPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarAfiliado_Click(object sender, EventArgs e)
        {
            try
            {
                // Consulta generica para comprobar si existe el afiliado
                idAfiliado = txtNumeroAfiliado.Text;
                String queryString = "SELECT precio_bono_consulta FROM NEXTGDD.Afiliado RIGHT JOIN NEXTGDD.Plan_Medico ON Afiliado.cod_plan = Plan_Medico.cod_plan WHERE Afiliado.nro_afiliado ='" + idAfiliado + "'";
                Clases.BaseDeDatosSQL.buscarCampo(queryString);
                cargarDatosAfiliado(idAfiliado);
                MessageBox.Show("Usuario Cargado con Exito", "Buscar Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("No Se Encontro al afiliado", "Buscar Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroAfiliado.Text = "";

            }
        }
    }
}
