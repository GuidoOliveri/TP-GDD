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
using ClinicaFrba.Clases; 

namespace ClinicaFrba.AbmRol
{
    public partial class frmSeleccionarRol : Form
    {
        private string usuario = "";
        private string rol = "";

        public frmSeleccionarRol(List<string> roles)
        {
            InitializeComponent();
            warning.Visible = false;

            this.usuario = Clases.Usuario.Name;
            cargar(roles,cboRoles);

            cboRoles.SelectedIndexChanged += OnSelectedIndexChanged;
        }

        private void cargar(List<string> lista, ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            warning.Visible = false;
            rol = (string) cboRoles.SelectedItem;
            Usuario.id_rol = rol;
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

        private void frmSeleccionarRol_Load(object sender, EventArgs e)
        {

        }

        private void frmSeleccionarRol_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (MessageBox.Show("Realmente desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void cboRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
