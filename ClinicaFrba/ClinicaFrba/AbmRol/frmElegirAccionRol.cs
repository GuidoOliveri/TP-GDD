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
        private Clases.BaseDeDatosSQL bdd;

        public frmElegirAccionRol(string rol, string usuario, Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();
            this.rol = rol;
            this.usuario = usuario;
            this.bdd = bdd;
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            frmAgregarNuevoRol agrega = new frmAgregarNuevoRol(rol,usuario,bdd);
            this.Hide();
            agrega.Show();
        }

        private void btnSeleccionRol_Click(object sender, EventArgs e)
        {
            frmSeleccionRolBajaOModificacion seleccion = new frmSeleccionRolBajaOModificacion(rol,usuario,bdd);
            this.Hide();
            seleccion.Show();
        }

        private void btnVolverALoguearse_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menu = new Login.frmMenuDeAbms(rol,usuario,bdd);
            this.Hide();
            menu.Show();

        }

        private void cmdAbmAfiliados_Click(object sender, EventArgs e)
        {

        }

        private void frmElegirAccionRol_Load(object sender, EventArgs e)
        {

        }
    }
}
