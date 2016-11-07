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
    public partial class frmModificarAfiliado : Form {

        private string rol = "";
        private string usuario = "";
        private Clases.BaseDeDatosSQL bdd;
        private string comando = "";
        private string profesional = "";

        public frmModificarAfiliado(int idPersona, string rol, string usuario, Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();
            this.rol = rol;
            this.usuario = usuario;
            this.bdd = bdd;
            Clases.BaseDeDatosSQL basedeDatos = new Clases.BaseDeDatosSQL();

            idPersona = 1123960; // Hardcode de prueba
            comando = "select * from GD2C2016.NEXTGDD.Persona where id_persona ="+idPersona;
         //   basedeDatos.ObtenerPersona(comando);
        }

        private void frmModificarAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void pnlModDatosPersonales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms(rol, usuario, bdd);
            this.Hide();
            menuAbm.Show();
        }

        private void frmModificarAfiliado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
