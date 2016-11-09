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
        private string rol = "";
        private string usuario = "";
        private Clases.BaseDeDatosSQL bdd;
        
        public frmPrincipalAfiliado(string rol, string usuario, Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();
            this.rol = rol;
            this.usuario = usuario;
            this.bdd = bdd;
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms(rol, usuario,bdd);
            this.Hide();
            menuAbm.Show();
        }


        private void cmdHistorialCambios_Click(object sender, EventArgs e)
        {
            frmHistorialCambios historial = new frmHistorialCambios(rol,usuario,bdd);
            this.Hide();
            historial.Show();
        }

        private void cmdBuscarAfiliado_Click(object sender, EventArgs e)
        {
            frmBuscarAfiliado buscar = new frmBuscarAfiliado(rol,usuario,bdd);
            this.Hide();
            buscar.Show();           
        }

        private void cmdBajaAfiliado_Click(object sender, EventArgs e)
        {
            frmBajaAfiliado baja = new frmBajaAfiliado(rol,usuario,bdd);
            this.Hide();
            baja.Show();
        }

        private void cmdAltaAfiliado_Click(object sender, EventArgs e)
        {
            frmAltaAfiliado alta = new frmAltaAfiliado(rol,usuario,bdd);
            this.Hide();
            alta.Show();
        }

        private void frmPrincipalAfiliado_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
