using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class frmPrincipalAfiliado : Form
    {
        public frmPrincipalAfiliado()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            //Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms();
            //this.Hide();
            //menuAbm.Show();
        }

        private void cmdModificarAfiliado_Click(object sender, EventArgs e)
        {
            frmBuscarAfiliado mod = new frmBuscarAfiliado();
            this.Hide();
            mod.Show();
        }

        private void cmdHistorialCambios_Click(object sender, EventArgs e)
        {
            frmHistorialCambios historial = new frmHistorialCambios();
            this.Hide();
            historial.Show();
        }

        private void cmdBuscarAfiliado_Click(object sender, EventArgs e)
        {
            frmBuscarAfiliado buscar = new frmBuscarAfiliado();
            this.Hide();
            buscar.Show();           
        }

        private void cmdBajaAfiliado_Click(object sender, EventArgs e)
        {
            frmBajaAfiliado baja = new frmBajaAfiliado();
            this.Hide();
            baja.Show();
        }

        private void cmdAltaAfiliado_Click(object sender, EventArgs e)
        {
            frmAltaAfiliado alta = new frmAltaAfiliado();
            this.Hide();
            alta.Show();
        }
    }
}
