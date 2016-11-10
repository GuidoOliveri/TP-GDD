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

            comando = "select distinct year(fecha) as anio from NEXTGDD.Turno;";
            cargarSemestres(bdd.ObtenerLista(comando, "anio"), cmbSemestre);

            btnSeleccionar.Click += new EventHandler(btnSeleccionar_OnClick);
            btnLimpiar.Click += new EventHandler(btnLimpiar_OnClick);
            btnBorrar.Click += new EventHandler(btnBorrar_OnClick);
        }

        private void cargarSemestres(List<string> lista, ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add("1er Semestre " + elemento);
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
                string[] parametros = semestre.Split(' ');

                if (cmbListado.SelectedIndex == 0)
                {
                    comando = "select * from NEXTGDD.listado1(" + parametros[2] + "," + parsearSemestre(parametros) + ")";
                    List<string> campos = new List<string>();
                    campos.Add("Especialidad");
                    campos.Add("Cantidad cancelaciones");
                    DataTable dt = bdd.ObtenerListado(comando, campos);
                    dgListado.AutoGenerateColumns = true;
                    dgListado.DataSource = dt;
                }
                /*
                if (cmbListado.SelectedIndex == 1)
                {
                    comando = "select * from NEXTGDD.listado2(" + parametros[2] + "," + parsearSemestre(parametros) + ")";
                    List<string> campos = new List<string>();
                    campos.Add("Plan");
                    campos.Add("Profesional");
                    campos.Add("Especialidad");
                    DataTable dt = bdd.ObtenerListado(comando, campos);
                    dgListado.AutoGenerateColumns = true;
                    dgListado.DataSource = dt;
                }
                 */
                if (cmbListado.SelectedIndex == 2)
                {
                    comando = "select * from NEXTGDD.listado3(" + parametros[2] + "," + parsearSemestre(parametros) + ")";
                    List<string> campos = new List<string>();
                    campos.Add("Profesional");
                    campos.Add("Horas Trabajadas");
                    DataTable dt = bdd.ObtenerListado(comando, campos);
                    dgListado.AutoGenerateColumns = true;
                    dgListado.DataSource = dt;
                }
                if (cmbListado.SelectedIndex == 3)
                {
                    comando = "select * from NEXTGDD.listado4(" + parametros[2] + "," + parsearSemestre(parametros) + ")";
                    List<string> campos = new List<string>();
                    campos.Add("Nombre Afiliado");
                    campos.Add("Cantidad de Bonos Comprados");
                    DataTable dt = bdd.ObtenerListado(comando, campos);
                    dgListado.AutoGenerateColumns = true;
                    dgListado.DataSource = dt;
                }
                if (cmbListado.SelectedIndex == 4)
                {
                    comando = "select * from NEXTGDD.listado5(" + parametros[2] + "," + parsearSemestre(parametros) + ")";
                    List<string> campos = new List<string>();
                    campos.Add("Especialidad");
                    campos.Add("Cantidad de Bonos");
                    DataTable dt = bdd.ObtenerListado(comando, campos);
                    dgListado.AutoGenerateColumns = true;
                    dgListado.DataSource = dt;
                }

            }
            else
            {
                warning.Visible = true;
            }

        }

        private string parsearSemestre(string[] parametros)
        {
            if (parametros[0] == "1er")
            {
                return "1,6";
            }
            else
            {
                return "6,12";
            }
        }

        private void btnLimpiar_OnClick(object sender, EventArgs e)
        {
            dgListado.Columns.Clear();
        }

        private void btnBorrar_OnClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgListado.SelectedRows)
            {
                dgListado.Rows.RemoveAt(item.Index);
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