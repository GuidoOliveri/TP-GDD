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
        private Clases.BaseDeDatosSQL bdd;
        string comando = "";
        string conexion = "Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016";


        public frmCancelarAtencionPaciente(string rol, string usuario, Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();
            this.rol = rol;
            this.usuario = usuario;
            this.bdd = bdd;
            warning1.Visible = false;
            warning2.Visible = false;
            cmbMotivoCancelacion.Enabled = false;
            cmbSeleccionTurno.Enabled = false;

            //SE CARGAN LOS TURNOS

            comando = "select nro_turno as 'Numero De Turno', fecha as 'Fecha' from NEXTGDD.Turno where nro_afiliado =" + "replace with nro afiliado";
            //cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, conexion, "Fecha"), cmbSeleccionTurno);

        }

        private void cargar(List<string> lista,ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Falta comprobar que no sea la fecha de hoy
            if (2 > 1)
            {
               
                //FALTA CREAR EL STORED PROCEDURE
                this.Dispose(false);

            }
            else
            {
                warning2.Visible = true;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
         
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms(rol, usuario, bdd);
            this.Hide();
            menuAbm.Show();
        }
    }
}
