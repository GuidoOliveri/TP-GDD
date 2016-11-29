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
      
        String comando;

        private String matriculaProfesional;
        private String especialidad;

        public frmCancelarAtencionMedico()
        {
            InitializeComponent();
            this.rol =Clases.Usuario.id_rol;
            this.usuario = Clases.Usuario.Name;

            DateTime fecha = DateTime.Parse(Clases.FechaSistema.fechaSistema).AddDays(1);
            pickerFecha.MinDate = fecha;

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
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms();
            this.Hide();
            menuAbm.Show();
        }

        private void frmCancelarAtencionMedico_FormClosing(object sender, FormClosingEventArgs e)
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
            List<String> listaDeTurnos = null;
            while (dt.Date <= pickerFecha.SelectionEnd.Date)
            {
                listaDeTurnos = Clases.BaseDeDatosSQL.ObtenerLista(("select t.nro_turno from NEXTGDD.Turno t where t.cod_agenda = '" + codAgenda + "' and CONVERT(date,t.fecha)= '" + dt.ToShortDateString() + "' and isnull(t.cod_cancelacion,0) =0  group by t.nro_turno"), "nro_turno");
                foreach(String turno in listaDeTurnos)
                {
                    // Otro for, esta vez dentro de un mismo dia, por cada uno de los posibles turnos
                    cancelarTurnos(turno, tipoCancelacion);
                }
                dt = dt.Date.AddDays(1);
            }

            // Registrar la cancelacion de un periodo.
            comando = "EXECUTE NEXTGDD.registrarCancelacionDePeriodo @fechaDesde='" + pickerFecha.SelectionStart + "', @fechaHasta ='" + pickerFecha.SelectionEnd +
                "',@codAgenda='" + codAgenda + "'";
            Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);
                MessageBox.Show("Cancelacion completada con exito!", "Cancelacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool sePuedeCancelarElRango(DateTime diaACancelar)
        {
            DateTime fechaActual = DateTime.Parse(Clases.FechaSistema.fechaSistema);
            return diaACancelar.Date > fechaActual.Date;
        }

        private void cancelarTurnos(string nroTurno, String tipoCancelacion)
        {
            comando = "EXECUTE NEXTGDD.cancelarTurno @nroTurno='" + nroTurno + "', @tipoCancelacion ='" + tipoCancelacion +
                "', @motivo='" + txtBoxDetalleCancelacion.Text + "'";
            Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);
        }

        private void frmCancelarAtencionMedico_Load(object sender, EventArgs e)
        {

        }
    }
}
