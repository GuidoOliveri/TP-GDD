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
        private string usuario = "";
        private string rol = "";
        private Clases.BaseDeDatosSQL bdd;

        public frmSeleccionarRol(List<string> roles,Clases.BaseDeDatosSQL bdd,string usuario)
        {
            InitializeComponent();
            warning.Visible = false;

            this.bdd = bdd;
            this.usuario = usuario;
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
        }

        private void btnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal principal = new frmVentanaPrincipal(bdd);
            this.Hide();
            principal.Show();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (cboRoles.SelectedItem != null)
            {
                frmMenuDeAbms abms = new frmMenuDeAbms(rol,usuario,bdd);
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
            Application.Exit();
        }
    }
}
