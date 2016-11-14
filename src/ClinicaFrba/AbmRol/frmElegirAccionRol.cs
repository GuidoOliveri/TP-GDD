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
        private string rol = "";
        private string usuario = "";

        public frmElegirAccionRol(string rol, string usuario)
        {
            InitializeComponent();
            this.rol = rol;
            this.usuario = usuario;
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            frmAgregarNuevoRol agrega = new frmAgregarNuevoRol(rol,usuario);
            this.Hide();
            agrega.Show();
        }

        private void btnSeleccionRol_Click(object sender, EventArgs e)
        {
            frmSeleccionRolBajaOModificacion seleccion = new frmSeleccionRolBajaOModificacion(rol,usuario);
            this.Hide();
            seleccion.Show();
        }

        private void btnVolverALoguearse_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menu = new Login.frmMenuDeAbms(rol,usuario);
            this.Hide();
            menu.Show();

        }

        private void cmdAbmAfiliados_Click(object sender, EventArgs e)
        {

        }

        private void frmElegirAccionRol_Load(object sender, EventArgs e)
        {

        }

        private void frmElegirAccionRol_FormClosing(object sender, FormClosingEventArgs e)
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
