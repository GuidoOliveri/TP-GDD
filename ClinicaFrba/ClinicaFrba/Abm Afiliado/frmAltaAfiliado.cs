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

        private void cargarTodoLimpio()
        {
            // limpio txt
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCantFam.Text = "";
            txtMail.Text = "";
            txtNroAfiliado.Text = "";
            txtNroDoc.Text = "";
            txtPlanMedico.Text = "";
            txtTel.Text = "";
            txtPlanMedico.Text = "";
            txtMotivo.Text = "";

            // limpio combo box
            cboEstadoCivil.SelectedIndex = -1;
            cboTipoDoc.SelectedIndex = -1;

            //limpio radio button
            optMasculino.Checked = false;
            optFemenino.Checked = false;

            //date time picker
            dtpFecNac.Value = Today;
            dtpFechaCambioPlan.Value = Today;
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cargarTodoLimpio();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == string.Empty || txtApellido.Text.Trim() == string.Empty || txtNroDoc.Text.Trim() == "" || txtDir.Text.Trim() == "" || txtTel.Text.Trim() == "" || txtMail.Text.Trim() == "" || txtCantFam.Text.Trim() == "" || int.Parse(txtCantFam.Text.Trim()) < 0 || cboEstadoCivil.SelectedIndex == -1 || cboTipoDoc.SelectedIndex == -1 || dtpFecNac.Value > dtpFechaCambioPlan.Value)
            {
                MessageBox.Show("Todos los campos no estan llenos o no estan llenos correctamente", "Alta afiliado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Registrado exitosamente! Desea Registrar a algun familiar?", "Alta afiliado", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    //aca tengo que enganchar el stored procedure de lo que hace el afiliado
                    cargarTodoLimpio();
                }
                else if (dialogResult == DialogResult.No)
                {
                    AbmRol.frmElegirAccionRol elegirOtra = new AbmRol.frmElegirAccionRol();
                    this.Hide();
                    elegirOtra.Show();
                }
            }

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
            AbmRol.frmElegirAccionRol elegir = new AbmRol.frmElegirAccionRol();
            this.Hide();
            elegir.Show();
        }

        private void btnHijo_Click(object sender, EventArgs e)
        {

        }

        private void btnConyuge_Click(object sender, EventArgs e)
        {

        }



        public DateTime Today { get; set; }
    }
}
