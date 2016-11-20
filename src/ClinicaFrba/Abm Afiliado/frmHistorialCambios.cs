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
        DataTable tabla;
        DataTable tablaAfil;
        DataTable tablagrupo;
        DataTable tablaAfilgrupo;

        public frmHistorialCambios()
        {
            InitializeComponent();
        }

        private void frmHistorialCambios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'historialDeCambios.Historial' Puede moverla o quitarla según sea necesario.
            // this.historialTableAdapter.Fill(this.historialDeCambios.Historial);
            tabla = new DataTable();
            tabla = Afiliado.obtenerHistorial();
            cargarGrilla();
            dataGridView1.DataSource = tabla;
            
        }

        private void btnAceptarYVolver_Click(object sender, EventArgs e)
        {
            frmPrincipalAfiliado pAfil = new frmPrincipalAfiliado();
            this.Hide();
            pAfil.Show();
        }

        private void frmHistorialCambios_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            tabla = Afiliado.obtenerHistorial();
            
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

            if (e.RowIndex == -1) 
                return;

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


        private void cargarGrilla()
        {

            DataGridViewTextBoxColumn ColNH = new DataGridViewTextBoxColumn();
            ColNH.DataPropertyName = "nro_historial";
            ColNH.HeaderText = "Nro Historial";
            ColNH.Width = 100;
            dataGridView1.Columns.Add(ColNH);

            DataGridViewTextBoxColumn ColFM = new DataGridViewTextBoxColumn();
            ColFM.DataPropertyName = "fecha_modificacion";
            ColFM.HeaderText = "Fecha Modificacion";
            ColFM.Width = 90;
            dataGridView1.Columns.Add(ColFM);

            DataGridViewTextBoxColumn ColPersona = new DataGridViewTextBoxColumn();
            ColPersona.DataPropertyName = "nro_afiliado";
            ColPersona.HeaderText = "Nro Afiliado";
            ColPersona.Width = 100;
            dataGridView1.Columns.Add(ColPersona);


            DataGridViewTextBoxColumn ColMM = new DataGridViewTextBoxColumn();
            ColMM.DataPropertyName = "motivo_modificacion";
            ColMM.HeaderText = "Motivo Modificacion";
            ColMM.Width = 250;
            dataGridView1.Columns.Add(ColMM);

            DataGridViewTextBoxColumn ColPlanA = new DataGridViewTextBoxColumn();
            ColPlanA.DataPropertyName = "cod_plan_viejo";
            ColPlanA.HeaderText = "Plan Medico Antiguo";
            ColPlanA.Width = 100;
            dataGridView1.Columns.Add(ColPlanA);

            DataGridViewTextBoxColumn ColPlanN = new DataGridViewTextBoxColumn();
            ColPlanN.DataPropertyName = "cod_plan_nuevo";
            ColPlanN.HeaderText = "Plan Medico Nuevo";
            ColPlanA.Width = 100;
            dataGridView1.Columns.Add(ColPlanN);
        }


        private void txtNroAfiliado_TextChanged(object sender, EventArgs e)
        {
            //Int64 nroafil = Int64.Parse(txtNroAfiliado.Text);
            //tabla.DefaultView.RowFilter = ("nro_afiliado like '" + txtNroAfiliado.Text + "%'");
            //dataGridView1.DataSource = tabla.DefaultView;
        }

        private void txtNroGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNroAfiliado_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}