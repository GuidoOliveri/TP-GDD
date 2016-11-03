using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registrar_Agenda_Medico
{
    public partial class frmRegistrarAgendaMedico : Form
    {
        string comando = "";
        string conexion = "Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016";
        string especialidad = "";
        string profesional = "";
        string diaDesde = "";
        string diaHasta = "";
        string horaDesde = "";
        string horaHasta = "";
        List<string> horarios = new List<string>();
        List<string> dias = new List<string>();

        public frmRegistrarAgendaMedico()
        {
            InitializeComponent();
            warning1.Visible=false;
            warning2.Visible = false;

            cargarDias();
            cargarHorarios();

            cargar(dias, cmbDiaDesde);
            cargar(dias, cmbDiaHasta);
            cargar(horarios, cmbHorarioDesde);
            cargar(horarios, cmbHorarioHasta);
            comando = "select (p.nombre+' '+p.apellido) as nombre from NEXTGDD.Profesional pr,NEXTGDD.Persona p where p.id_persona=pr.id_persona order by (p.nombre+' '+p.apellido) ASC";
            cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, conexion, "nombre"), cmbProfesional);

            cmbProfesional.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbEspecialidad.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbDiaDesde.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbDiaHasta.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbHorarioDesde.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbHorarioHasta.SelectedIndexChanged += OnSelectedIndexChanged;
            btnIngresar.Click += new EventHandler(btnIngresar_Click);

        }

        private void cargarDias()
        {
            dias.Clear();
            dias.Add("Lunes");
            dias.Add("Martes");
            dias.Add("Miercoles");
            dias.Add("Jueves");
            dias.Add("Viernes");
            dias.Add("Sabado");
        }

        private void cargarHorarios()
        {
            horarios.Clear();
            //La fecha es cualquiera, solo se usa el tiempo
            DateTime dt = new DateTime(2000, 11, 3, 7, 0, 0);
            while (dt<= new DateTime(2000,11,3,20,0,0))
            {
                horarios.Add(dt.ToString("HH:mm"));
                dt=dt.AddMinutes(30);
            }
        }

        private void cargar(List<string> lista, ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProfesional.SelectedItem != null && cmbProfesional.SelectedItem!=profesional)
            {
                cmbEspecialidad.Items.Clear();
                cmbEspecialidad.Text = "";
                profesional = (string) cmbProfesional.SelectedItem;
                comando = "select e.descripcion as descripcion from NEXTGDD.Persona persona,NEXTGDD.Profesional p,NEXTGDD.Profesional_X_Especialidad pe,NEXTGDD.Especialidad e where (persona.nombre+' '+persona.apellido) LIKE '"+profesional+"' and persona.id_persona=p.id_persona and pe.matricula=p.matricula and e.cod_especialidad=pe.cod_especialidad order by e.descripcion ASC;";
                cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, conexion, "descripcion"), cmbEspecialidad);
            }
            if (cmbDiaDesde.SelectedItem != null && cmbDiaDesde.SelectedItem!=diaDesde)
            {
                diaDesde = (string)cmbDiaDesde.SelectedItem;
                filtrarFechas(cmbDiaDesde, cmbDiaHasta, dias);
            }
            if (cmbHorarioDesde.SelectedItem != null && cmbHorarioDesde.SelectedItem != horaDesde)
            {
                horaDesde = (string)cmbHorarioDesde.SelectedItem;
                filtrarFechas(cmbHorarioDesde, cmbHorarioHasta, horarios);
            }

        }

        private void filtrarFechas(ComboBox cmbDesde, ComboBox cmbHasta, List<string> lista)
        {
            cmbHasta.Items.Clear();
            cmbHasta.Text = "";
            cargar(lista, cmbHasta);
            int i = cmbDesde.SelectedIndex;
            for (int j = 0; j < i; j++)
            {
                cmbHasta.Items.RemoveAt(0);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            especialidad = (string) cmbEspecialidad.SelectedItem;
            diaHasta = (string)cmbDiaHasta.SelectedItem;
            horaHasta = (string)cmbHorarioHasta.SelectedItem;
            if (especialidad != "" && profesional != "" && diaDesde != "" && diaHasta!="" && horaDesde!="" && horaHasta!="")
            {
                //FALTA CREAR EL STORED PROCEDURE
                //Clases.BaseDeDatosSQL.ExecStoredProcedure2(comando, conexion);

                frmRegistrarAgendaMedico NewForm = new frmRegistrarAgendaMedico();
                NewForm.Show();
                this.Dispose(false);

            }
            else
            {
                warning2.Visible = true;
            }

        }

        private void frmRegistrarAgendaMedico_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
