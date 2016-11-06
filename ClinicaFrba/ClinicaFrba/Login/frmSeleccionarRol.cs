using ClinicaFrba.Login;
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
    public partial class frmSeleccionarRol : Form
    {
        public frmSeleccionarRol()
        {
            InitializeComponent();
            warning.Visible = false;
        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal principal = new frmVentanaPrincipal();
            this.Hide();
            principal.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (cboRoles.SelectedItem != null)
            {
                frmMenuDeAbms abms = new frmMenuDeAbms();
                this.Hide();
                abms.Show();
            }
            else
            {
                warning.Visible = true;
            }
        }
    }
}
