using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.AbmRol;
using ClinicaFrba.Clases;
using ClinicaFrba.Abm_Afiliado;
using ClinicaFrba.Registrar_Agenda_Medico;
using ClinicaFrba.Cancelar_Atencion;
using ClinicaFrba.Registro_Llegada;

namespace ClinicaFrba
{
    public partial class frmVentanaPrincipal : Form
    {
        Clases.BaseDeDatosSQL bdd;
        public frmVentanaPrincipal(Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();

            this.bdd = bdd;
        }

        public Usuario User { get; set; }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            Login.frmLogin ingresa = new Login.frmLogin(bdd);
            this.Hide();
            ingresa.Show();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
