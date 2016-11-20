using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.Clases;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class frmPrincipalAfiliado : Form
    {
        private string operacionMod = "Modificar";
        private string operacionBaja = "Eliminar";

        public frmPrincipalAfiliado()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms();
            this.Hide();
            menuAbm.Show();
        }


        private void cmdHistorialCambios_Click(object sender, EventArgs e)
        {
            frmHistorialCambios historial = new frmHistorialCambios();
            this.Hide();
            historial.Show();
        }

        private void cmdBuscarAfiliado_Click(object sender, EventArgs e)
        {
            
            frmBuscarAfiliado buscar = new frmBuscarAfiliado(operacionMod);
            this.Hide();
            buscar.Show();           
        }

        private void cmdBajaAfiliado_Click(object sender, EventArgs e)
        {
            frmBuscarAfiliado buscar = new frmBuscarAfiliado(operacionBaja);
            this.Hide();
            buscar.Show();
        }

        private void cmdAltaAfiliado_Click(object sender, EventArgs e)
        {
            frmAltaAfiliado alta = new frmAltaAfiliado();
            this.Hide();
            alta.Show();
        }

        private void frmPrincipalAfiliado_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmPrincipalAfiliado_Load(object sender, EventArgs e)
        {

        }
    }
}
