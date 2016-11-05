using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.AbmRol
{
    public partial class frmElegirAccionRol : Form
    {
        public frmElegirAccionRol()
        {
            InitializeComponent();
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            frmAgregarNuevoRol agrega = new frmAgregarNuevoRol();
            this.Hide();
            agrega.Show();
        }

        private void btnSeleccionRol_Click(object sender, EventArgs e)
        {
            frmSeleccionRolBajaOModificacion seleccion = new frmSeleccionRolBajaOModificacion();
            this.Hide();
            seleccion.Show();
        }

        private void btnVolverALoguearse_Click(object sender, EventArgs e)
        {
            Login.frmLogin loguin = new Login.frmLogin();
            this.Hide();
            loguin.Show();

        }
    }
}
