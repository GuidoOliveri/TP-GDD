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
using System.Data.SqlClient;
using ClinicaFrba.Abm_Afiliado;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class frmAltaAfiliado : Form
    {
        public frmAltaAfiliado()
        {
            InitializeComponent();
        }

        public String Operacion { get; set; }
        //public Afiliado Afiliado { get; set; }
        public String Miembro { get; set; }
        //public Afiliado nuevoAfil { get; set; }

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
            txtPlanMedico.Text = string.Empty;
            txtMotivo.Text = "";

            // limpio combo box
            cboEstadoCivil.SelectedIndex = -1;
            cboTipoDoc.SelectedIndex = -1;

            //limpio radio button
            optMasculino.Checked = false;
            optFemenino.Checked = false;

        }

        //analizo todos los campos 
        private Boolean analizarCampos()
        {
            string mensaje = string.Empty;
            if (txtNombre.Text.Trim() == string.Empty || txtApellido.Text.Trim() == string.Empty || txtNroDoc.Text.Trim() == "" || txtDir.Text.Trim() == "" || txtTel.Text.Trim() == "" || txtMail.Text.Trim() == "" || txtCantFam.Text.Trim() == "" || int.Parse(txtCantFam.Text.Trim()) < 0 || cboEstadoCivil.SelectedIndex==-1 || cboTipoDoc.SelectedIndex==-1 || dtpFecNac.Value>dtpFechaCambioPlan.Value)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
        }

        private void pnlDatosPersonales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void cboEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

      
    }
}
