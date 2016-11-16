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


namespace ClinicaFrba.Abm_Afiliado
{
    public partial class frmHistorialCambios : Form
    {
        private string rol = "";
        private string usuario = "";
        DataTable tabla;
        DataTable tablaAfil;
        DataTable tablagrupo;
        DataTable tablaAfilgrupo;

        public frmHistorialCambios(string rol, string usuario)
        {
            InitializeComponent();
            this.rol = rol;
            this.usuario = usuario;
        }

        private void frmHistorialCambios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'historialDeCambios.Historial' Puede moverla o quitarla según sea necesario.
            // this.historialTableAdapter.Fill(this.historialDeCambios.Historial);
            tabla = new DataTable();
            tabla = Afiliado.obtenerHistorial();
            dataGridView1.DataSource = tabla;
         
        }

        private void btnAceptarYVolver_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms(rol, usuario);
            this.Hide();
            menuAbm.Show();
        }

        private void frmHistorialCambios_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            dataGridView1.DataSource = tabla;
        }


        private void limpiar()
        {
            // limpio txt
            txtNroGrupo.Clear();
            txtNroAfiliado.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                return;
            }
            else
            {

                txtNroAfiliado.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtNroGrupo.Text =  txtNroAfiliado.Text.Substring(0, txtNroAfiliado.TextLength -2);
            
            
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtNroGrupo.Text) && String.IsNullOrEmpty(txtNroAfiliado.Text))
          {
                MessageBox.Show("Por favor, ingrese algun dato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
            else if ( String.IsNullOrEmpty(txtNroAfiliado.Text)  )
            {
                tablagrupo = new DataTable();
                tablagrupo = Afiliado.obtenerHistorialGrupo(UInt64.Parse(txtNroGrupo.Text));
                dataGridView1.DataSource = tablagrupo;
            }
            else if (String.IsNullOrEmpty(txtNroGrupo.Text) )
            {
                tablaAfil = new DataTable();
                tablaAfil = Afiliado.obtenerHistorial_Afil(UInt64.Parse(txtNroAfiliado.Text));
                dataGridView1.DataSource = tablaAfil;


            }
            else
            {
                tablaAfilgrupo = new DataTable();
                tablaAfilgrupo = Afiliado.mostrarHistorialAfil_grupo(UInt64.Parse(txtNroGrupo.Text), UInt64.Parse(txtNroAfiliado.Text));
                dataGridView1.DataSource = tablaAfilgrupo;
                // MessageBox.Show("Por favor, filtre por un campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
            
            }

        }
           // Int64 nroafil = Int64.Parse(txtNroAfiliado.Text);
           //tabla.DefaultView.RowFilter = ("nro_afiliado like '" + nroafil + " %'");
           //dataGridView1.DataSource = tabla.DefaultView;





        private void txtNroAfiliado_TextChanged(object sender, EventArgs e)
        {
            //Int64 nroafil = Int64.Parse(txtNroAfiliado.Text);
            //tabla.DefaultView.RowFilter = ("nro_afiliado like '" + txtNroAfiliado.Text + "%'");
            //dataGridView1.DataSource = tabla.DefaultView;
        }
    }
}