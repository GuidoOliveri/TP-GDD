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
    public partial class frmAltaAfiliado : Form
    {
        public frmAltaAfiliado()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // limpio txt
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCantFam.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtNroAfiliado.Text = string.Empty;
            txtNroDoc.Text = string.Empty;
            txtPlanMedico.Text = string.Empty;
            txtTel.Text = string.Empty;

            // limpio combo box
            cboEstadoCivil.SelectedIndex = -1;
            cboTipoDoc.SelectedIndex = -1;

            //limpio radio button
            optMasculino.Checked = false;
            optFemenino.Checked = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

      
    }
}
