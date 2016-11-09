using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Listados
{
    public partial class frmListado : Form
    {
        private string rol = "";
        private string usuario = "";
        private string comando = "";
        private string semestre = "";
        private string listado = "";
        private Clases.BaseDeDatosSQL bdd;
        private List<String> años = new List<string>();

        public frmListado(string rol, string usuario, Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();

            this.rol = rol;
            this.usuario = usuario;
            this.bdd = bdd;

            warning.Visible = false;

            comando="select distinct year(fecha) as anio from NEXTGDD.Turno;";
            cargarSemestres(bdd.ObtenerLista(comando,"anio"),cmbSemestre);

            btnSeleccionar.Click += new EventHandler(btnSeleccionar_OnClick);
        }

        private void cargarSemestres(List<string> lista, ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add("1er Semestre "+elemento);
                cmb.Items.Add("2ndo Semestre " + elemento);
            }
        }

        private void btnSeleccionar_OnClick(object sender, EventArgs e)
        {
            warning.Visible = false;
            semestre = (string)cmbSemestre.SelectedItem;
            listado = (string)cmbListado.SelectedItem;
            if (semestre != null && listado != null)
            {
                if (cmbListado.SelectedIndex == 4)
                {
                    /*
                    DataGridTextColumn esp = new DataGridTextColumn();
                    esp.HeaderText="Especialidad";
                    DataGridTextColumn bon = new DataGridTextColumn();
                    esp.HeaderText="Cantidad Bonos";
                    dgListado.Columns.Add(esp);
                    dgListado.Columns.Add(bon);
                    comando = "select top 5 e.descripcion as 'Especialidad',count(e.cod_especialidad) as 'Cantidad de Bonos'" +
                            "from NEXTGDD.Consulta c,NEXTGDD.Especialidad e,NEXTGDD.Turno t,NEXTGDD.Agenda a" +
                            "where c.nro_turno=t.nro_turno and t.cod_agenda=a.cod_agenda and a.cod_especialidad=e.cod_especialidad" +
                            "group by e.cod_especialidad,e.descripcion" +
                            "order by count(e.cod_especialidad) DESC";
                    bdd.ObtenerListado1(comando, "Especialidad", "Cantidad de Bonos",dgListado);
                     */
                }
            }
            else
            {
                warning.Visible = true;
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblFiltro1_Click(object sender, EventArgs e)
        {

        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2016DataSet.Maestra' Puede moverla o quitarla según sea necesario.
           // this.maestraTableAdapter.Fill(this.gD2C2016DataSet.Maestra);

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms(rol, usuario, bdd);
            this.Hide();
            menuAbm.Show();
        }

        private void frmListado_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
