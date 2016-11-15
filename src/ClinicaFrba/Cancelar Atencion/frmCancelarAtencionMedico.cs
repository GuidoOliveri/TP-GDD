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
    public partial class frmCancelarAtencionMedico : Form
    {
        private string rol = "";
        private string usuario = "";
        //string conexion = "Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016";

        String comando;

        private String matriculaProfesional;
        private String especialidad;

        public frmCancelarAtencionMedico(string rol, string usuario)
        {
            InitializeComponent();
            this.rol = rol;
            this.usuario = usuario;

            matriculaProfesional = "1000";
            especialidad = "10000";
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

        public Clases.Profesional unProfesional { get; set; }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms(rol, usuario);
            this.Hide();
            menuAbm.Show();
        }

        private void frmCancelarAtencionMedico_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Realmente desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnCancelarTurnos_Click(object sender, EventArgs e)
        {
            if (pickerFecha.SelectionRange.Start == null)
            {
                warningSinSeleccionarFechas.Visible = true;
                return;
            }

            warningSinSeleccionarFechas.Visible = false;

            if (cmbMotivoCancelacion.SelectedItem == null)
            {
                faltanDatosWarning.Visible = true;
                return;
            }

            faltanDatosWarning.Visible = true;

            if (!sePuedeCancelarElRango(pickerFecha.SelectionStart))
            {
                warningNoSePuedeCancelarMismoDia.Visible = true;
                return;
            }

            String codAgenda = Clases.BaseDeDatosSQL.buscarCampo("select cod_agenda from NEXTGDD.Agenda where '" + matriculaProfesional
                        +"' = Agenda.matricula and '"+ especialidad +"' = Agenda.cod_especialidad");

            String tipoCancelacion = Clases.BaseDeDatosSQL.buscarCampo("select tipo_cancelacion from NEXTGDD.Tipo_cancelacion where nombre = '" +
                cmbMotivoCancelacion.SelectedItem.ToString() + "'");

            // Por cada dia (for each DateTime)
            DateTime dt = pickerFecha.SelectionStart;
            while (dt.Date <= pickerFecha.SelectionEnd.Date)
            {
                Console.Write("paso 1 dia");
                dt = dt.Date.AddDays(1);
            }
            // Otro for, esta vez dentro de un mismo dia, por cada uno de los posibles horarios
            //DateTime fecha = new DateTime();
            //String nroTurno = Clases.BaseDeDatosSQL.buscarCampo("select nro_turno from NEXTGDD.Turno where cod_agenda = '"+codAgenda
            //    +"' and fecha = '"+fecha.ToString()+"'");
            //cancelarTurnos(nroTurno, fecha, tipoCancelacion);


        }

        private bool sePuedeCancelarElRango(DateTime diaACancelar)
        {
            DateTime fechaActual = DateTime.Parse("07/11/2016 00:00:00");
            return diaACancelar.Date > fechaActual.Date;
        }

        private void cancelarTurnos(string nroTurno, DateTime fecha, String tipoCancelacion)
        {
            comando = "EXECUTE NEXTGDD.cancelarTurno @nroTurno='" + nroTurno + "',@tipoCancelacion'" + tipoCancelacion +
                "', @motivo='" + txtBoxDetalleCancelacion.Text + "'";
            Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);
        }

        private void frmCancelarAtencionMedico_Load(object sender, EventArgs e)
        {

        }
    }
}
