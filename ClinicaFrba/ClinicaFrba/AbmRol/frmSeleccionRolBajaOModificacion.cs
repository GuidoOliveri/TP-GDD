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
        private string rol = "";
        private string usuario = "";
        private Clases.BaseDeDatosSQL bdd;

        public frmSeleccionRolBajaOModificacion(string rol, string usuario, Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();
            this.rol = rol;
            this.usuario = usuario;
            this.bdd = bdd;
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
            frmElegirAccionRol elegiUna = new frmElegirAccionRol(rol,usuario,bdd);
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
                frmModificacionRol formFunc = new frmModificacionRol(usuario,rol,bdd);
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
            Application.Exit();
        }
    }
}
