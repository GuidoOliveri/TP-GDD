using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.Clases;

namespace ClinicaFrba.AbmRol
{
    public partial class frmAgregarNuevoRol : Form
    {

        public frmAgregarNuevoRol()
        {
            InitializeComponent();
        }

        private void frmRol_Load(object sender, EventArgs e)
        {
            //ME CARGO TODAS LAS FUNCIONALIDADES PARA PODER AGREGARLAS A LOS ROLES
            List<Funcionalidad> listaDeFuncionalidades = Funcionalidades.ObtenerFuncionalidades();
            cmbFuncionalidades.DataSource = listaDeFuncionalidades;
            cmbFuncionalidades.ValueMember = "Id";
            cmbFuncionalidades.DisplayMember = "Nombre";
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            deschequearElCheckBox();    
            txtNombre.Text = "";
        }

        public void deschequearElCheckBox()
        {
            bool state = false;
            for (int i = 0; i < cmbFuncionalidades.Items.Count; i++)
                cmbFuncionalidades.SetItemCheckState(i, (state ? CheckState.Checked : CheckState.Unchecked));
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && cmbFuncionalidades.CheckedItems != null) //VER SI CON NULL FUNCA
                {
                    //TOMO LAS FUNCIONALIDADES QUE SELECCIONO
                    List<Funcionalidad> listaDeFunc = new List<Funcionalidad>();
                    foreach (Funcionalidad unaFunc in cmbFuncionalidades.CheckedItems)
                    {
                        listaDeFunc.Add(unaFunc);
                    }
                    //DOY DE ALTA EL ROL
                    Roles.Agregar(txtNombre.Text, listaDeFunc);
                    MessageBox.Show("El rol fue agregado con éxito", "Enhorabuena!", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Inserte correctamente los campos", "Error!", MessageBoxButtons.OK);
                }
            }
            catch 
            {
                MessageBox.Show("Se ha producido un error,vuelva a intentarlo", "Error!", MessageBoxButtons.OK);
            }
        }

        private void cmdSeleccionarTodo_Click(object sender, EventArgs e)
        {
            bool state = true;
            for (int i = 0; i < cmbFuncionalidades.Items.Count; i++)
                cmbFuncionalidades.SetItemCheckState(i, (state ? CheckState.Checked : CheckState.Unchecked));
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmElegirAccionRol elegi = new frmElegirAccionRol();
            this.Hide();
            elegi.Show();
        }

        private void frmAgregarNuevoRol_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Realmente desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
