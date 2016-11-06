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
        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal principal = new frmVentanaPrincipal();
            this.Hide();
            principal.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmElegirAccionRol elegir = new frmElegirAccionRol();
            this.Hide();
            elegir.Show();
        }
    }
}
