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
    public partial class frmBuscarAfiliado : Form
    {

        public frmBuscarAfiliado()
        {
            InitializeComponent();
        }

        private void lblFiltroBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void frmModifcarAfiliadoGrupo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'listaDeAfiliados.Afiliado' Puede moverla o quitarla según sea necesario.
            //this.afiliadoTableAdapter.Fill(this.listaDeAfiliados.Afiliado);
            DataTable tabla = new DataTable();
            tabla =Afiliado.obtenerAfilidos();
            dataGridView1.DataSource  =tabla;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms();
            this.Hide();
            menuAbm.Show();
        }

        public string Operacion { get; set; }

        public Clases.Profesional profesional { get; set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaDeAfiliadosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void afiliadoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarAfiliado_Click(object sender, EventArgs e)
        {
            UInt64 nroAfil = UInt64.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            frmModificarAfiliado este = new frmModificarAfiliado(nroAfil);
            this.Hide();
            este.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void frmBuscarAfiliado_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Realmente desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
