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
    public partial class frmSeleccionRolBajaOModificacion : Form
    {
        public frmSeleccionRolBajaOModificacion()
        {
            InitializeComponent();
        }

        //lista de roles que voy a tener para mostrar
        private List<Rol> listaDeRoles = new List<Rol>();

        //PARA SABER SI ES MODIFICACION O BAJA
        public string operacion { get; set; }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            operacion = "limpiar";
            Limpiar();
        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            ActualizarGrilla();
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                operacion = "buscar";
                ActualizarGrilla();
            }
            catch{ MessageBox.Show("Error en la busqueda de rol", "Error!", MessageBoxButtons.OK);}
        }


        private void lstSeleccionRol_Load(object sender, EventArgs e)
        {
            //genero las columnas de la grilla
            grillaRoles.AutoGenerateColumns = false;
            grillaRoles.MultiSelect = false;

            cargarGrilla();
            operacion = "";
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            if (txtNombre.Text != "" && operacion == "Baja")
            {
                //me traigo los roles que cumplen con el filtro
                listaDeRoles = Roles.ObtenerRolesActivo(txtNombre.Text);
            }
            else if (txtNombre.Text == "" && operacion == "Baja")
            {
                listaDeRoles = Roles.ObtenerTodosActivos();
            }
            else if (operacion != "Baja" && txtNombre.Text != "")
            {
                listaDeRoles = Roles.ObtenerRoles(txtNombre.Text);
            }
            else 
            { 
                listaDeRoles = Roles.ObtenerTodos(); 
            }
            
            //meto el resultado en la grilla
            grillaRoles.DataSource = listaDeRoles;
        }
        
        private void cargarGrilla()
        {
            DataGridViewTextBoxColumn ColNombre = new DataGridViewTextBoxColumn();
            ColNombre.DataPropertyName = "Nombre";
            ColNombre.HeaderText = "Nombre Rol";
            ColNombre.Width = 120;

            grillaRoles.Columns.Add(ColNombre);

        }

        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmElegirAccionRol elegiUna = new frmElegirAccionRol();
            this.Hide();
            elegiUna.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdBaja_Click(object sender, EventArgs e)
        {
            Rol unRol = (Rol)grillaRoles.CurrentRow.DataBoundItem;
            Roles.Eliminar(unRol.Id);
            MessageBox.Show("Se ha dado de baja el rol con éxito", "Enhorabuena!", MessageBoxButtons.OK);
            operacion = "Baja";
            Limpiar();

        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            Rol unRol = (Rol)grillaRoles.CurrentRow.DataBoundItem;
            if (grillaRoles.RowCount!=0)
            {

                //ABRO UN NUEVO FORM CON LAS FUNC DE ESE ROL
                frmModificacionRol formFunc = new frmModificacionRol();
                formFunc.unRol = unRol;
                this.Hide();
                formFunc.Show();
            }
            else
            {
                MessageBox.Show("No hay ningun rol para modificar", "Seleccion Roles", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void frmSeleccionRolBajaOModificacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Realmente desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void grillaRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
