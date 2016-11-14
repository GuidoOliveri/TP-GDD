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
        private string filtro = "";
        private List<String> años = new List<string>();

        public frmListado(string rol, string usuario)
        {
            InitializeComponent();

            this.rol = rol;
            this.usuario = usuario;

            warning.Visible = false;
            cmbFiltro.Enabled = false;

            comando = "select distinct year(fecha) as anio from NEXTGDD.Turno;";
            cargarSemestres(Clases.BaseDeDatosSQL.ObtenerLista(comando, "anio"), cmbSemestre);

            cmbListado.SelectedIndexChanged += OnSelectedIndexChanged;
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

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFiltro.Enabled = false;
            cmbFiltro.Items.Clear();
            cmbFiltro.Text = "";
            if (cmbListado.SelectedIndex == 0)
            {
                cmbFiltro.Enabled = true;
                cmbFiltro.Items.Add("Afiliado");
                cmbFiltro.Items.Add("Profesional");
                cmbFiltro.Items.Add("Ambos");
            }
            if (cmbListado.SelectedIndex == 1)
            {
                cmbFiltro.Enabled = true;
                comando="select descripcion as 'plan' from NEXTGDD.Plan_Medico order by descripcion ASC";
                cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando,"plan"),cmbFiltro);
            }
            if (cmbListado.SelectedIndex == 2)
            {
                cmbFiltro.Enabled = true;
                comando = "select descripcion as 'especialidad' from NEXTGDD.Especialidad order by descripcion ASC";
                cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, "especialidad"), cmbFiltro);
            }
        }

        private void cargar(List<string> lista, ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }
        }


        private void btnSeleccionar_OnClick(object sender, EventArgs e)
        {
            warning.Visible = false;
            semestre = (string)cmbSemestre.SelectedItem;
            listado = (string)cmbListado.SelectedItem;
            filtro = "";
            if (cmbFiltro.Enabled == true)
            {
                filtro = (string)cmbFiltro.SelectedItem;
            }
            if (semestre != null && listado != null && filtro!=null)
            {
                string[] parametros = semestre.Split(' ');
                List<string> campos = new List<string>();
                DataTable dt = new DataTable();

                if (cmbListado.SelectedIndex == 0)
                {
                    campos.Add("Especialidad");
                    campos.Add("Cantidad cancelaciones");
                    comando = evaluarListado(filtro,parametros,campos);
                    
                }
                if (cmbListado.SelectedIndex == 1)
                {
                    comando = "select * from NEXTGDD.listado2(" + parametros[2] + "," + parsearSemestre(parametros) + ",'"+filtro+"')";
                    campos.Add("Profesional");
                    campos.Add("Especialidad");
                    campos.Add("Veces consultado");
                }
                if (cmbListado.SelectedIndex == 2)
                {
                    comando = "select * from NEXTGDD.listado3(" + parametros[2] + "," + parsearSemestre(parametros) + ",'"+filtro+"')";
                    campos.Add("Profesional");
                    campos.Add("Horas Trabajadas");
                }
                if (cmbListado.SelectedIndex == 3)
                {
                    comando = "select * from NEXTGDD.listado4(" + parametros[2] + "," + parsearSemestre(parametros) + ")";
                    campos.Add("Nombre Afiliado");
                    campos.Add("Bonos Comprados");
                    campos.Add("Pertenece a Grupo Familiar");
                }
                if (cmbListado.SelectedIndex == 4)
                {
                    comando = "select * from NEXTGDD.listado5(" + parametros[2] + "," + parsearSemestre(parametros) + ")";
                    campos.Add("Especialidad");
                    campos.Add("Cantidad de Bonos");
                }
                dt = Clases.BaseDeDatosSQL.ObtenerTabla(comando, campos);
                dgListado.AutoGenerateColumns = true;
                dgListado.DataSource = dt;
            }
            else
            {
                warning.Visible = true;
            }

        }

        private string evaluarListado(string filtro,String[] parametros,List<String> campos)
        {
            if (filtro == "Ambos")
            {
                return "select * from NEXTGDD.listado1Ambos(" + parametros[2] + "," + parsearSemestre(parametros) + ")";
            }
            else
            {
                return "select * from NEXTGDD.listado1(" + parametros[2] + "," + parsearSemestre(parametros) + ",'" + filtro + "')";
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
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms(rol, usuario);
            this.Hide();
            menuAbm.Show();
        }

        private void frmListado_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Realmente desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}