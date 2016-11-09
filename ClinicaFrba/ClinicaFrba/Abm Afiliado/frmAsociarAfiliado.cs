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
    public partial class frmAsociarAfiliado : Form
    {
        private string rol = "";
        private string usuario = "";
        private Clases.BaseDeDatosSQL bdd;

        public frmAsociarAfiliado(string rol, string usuario, Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();
            this.rol = rol;
            this.usuario = usuario;
            this.bdd = bdd;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmAltaAfiliado alta = new frmAltaAfiliado(rol,usuario,bdd);
            this.Hide();
            alta.Show();
        }

        private void btnAsociar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Asociado exitosamente", "Asociar Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
