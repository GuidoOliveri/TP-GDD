using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClinicaFrba.Registrar_Agenda_Medico
{
    public partial class frmRegistrarAgendaMedico : Form
    {
        private Clases.BaseDeDatosSQL bdd;
        private string comando = "";
        private string especialidad = "";
        private string profesional = "";
        private string diaDesde = "";
        private string diaHasta = "";
        private string horaDesde = "";
        private string horaHasta = "";
        private string fechaDesde = "";
        private string fechaHasta = "";
        private List<string> horarios = new List<string>();
        private List<string> dias = new List<string>();

        public frmRegistrarAgendaMedico(Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();
            warning1.Visible=false;
            warning2.Visible = false;

            this.bdd = bdd;

            cargarDias();
            cargarHorarios();

            cargar(dias, cmbDiaDesde);
            cargar(dias, cmbDiaHasta);
            cargar(horarios, cmbHorarioDesde);
            cargar(horarios, cmbHorarioHasta);
            comando = "select (p.nombre+' '+p.apellido) as nombre from NEXTGDD.Profesional pr,NEXTGDD.Persona p where p.id_persona=pr.id_persona order by (p.nombre+' '+p.apellido) ASC";
            cargar(bdd.ObtenerLista(comando,"nombre"), cmbProfesional);

            //cargarGrilla();

            cmbProfesional.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbEspecialidad.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbDiaDesde.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbDiaHasta.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbHorarioDesde.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbHorarioHasta.SelectedIndexChanged += OnSelectedIndexChanged;
           // dgRangoAtencion.CellValueChanged += new DataGridViewCellEventHandler(dgRangoAtencion_CellContentClick);
            dpFechaDesde.ValueChanged += new EventHandler(dpFechaDesde_ValueChanged);
            btnAgregar.Click += new EventHandler(btn_Click);
            btnIngresar.Click += new EventHandler(btn_Click);

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
/*
        private void cargarGrilla()
        {
            DataGridViewComboBoxColumn dgDiaDesde = new DataGridViewComboBoxColumn();
            dgDiaDesde.DataSource = dias;
            dgDiaDesde.HeaderText = "Dia (Desde)";
            dgDiaDesde.DataPropertyName = "Dia (Desde)";
            dgRangoAtencion.Columns.AddRange(dgDiaDesde);

            DataGridViewComboBoxColumn dgDiaHasta = new DataGridViewComboBoxColumn();
            dgDiaHasta.DataSource = dias;
            dgDiaHasta.HeaderText = "Dia (Hasta)";
            dgDiaHasta.DataPropertyName = "Dia (Hasta)";
            dgRangoAtencion.Columns.AddRange(dgDiaHasta);

            DataGridViewComboBoxColumn dgHoraDesde = new DataGridViewComboBoxColumn();
            dgHoraDesde.DataSource = horarios;
            dgHoraDesde.HeaderText = "Hora (Desde)";
            dgHoraDesde.DataPropertyName = "Hora (Desde)";
            dgRangoAtencion.Columns.AddRange(dgHoraDesde);

            DataGridViewComboBoxColumn dgHoraHasta = new DataGridViewComboBoxColumn();
            dgHoraHasta.DataSource = horarios;
            dgHoraHasta.HeaderText = "Hora (Hasta)";
            dgHoraHasta.DataPropertyName = "Hora (Hasta)";
            dgRangoAtencion.Columns.AddRange(dgHoraHasta);
        }
*/
        private void cargar(List<string> lista, ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProfesional.SelectedItem != null && (string)cmbProfesional.SelectedItem!=profesional)
            {
                warning2.Visible = false;
                cmbEspecialidad.Items.Clear();
                cmbEspecialidad.Text = "";
                profesional = (string) cmbProfesional.SelectedItem;
                comando = "select e.descripcion as descripcion from NEXTGDD.Persona persona,NEXTGDD.Profesional p,NEXTGDD.Profesional_X_Especialidad pe,NEXTGDD.Especialidad e where (persona.nombre+' '+persona.apellido) LIKE '"+profesional+"' and persona.id_persona=p.id_persona and pe.matricula=p.matricula and e.cod_especialidad=pe.cod_especialidad order by e.descripcion ASC;";
                cargar(bdd.ObtenerLista(comando, "descripcion"), cmbEspecialidad);
            }
            if (cmbDiaDesde.SelectedItem != null && (string)cmbDiaDesde.SelectedItem!=diaDesde)
            {
                warning2.Visible = false;
                diaDesde = (string)cmbDiaDesde.SelectedItem;
                filtrarFechas(cmbDiaDesde, cmbDiaHasta, dias);
            }
            if (cmbHorarioDesde.SelectedItem != null && (string)cmbHorarioDesde.SelectedItem != horaDesde)
            {
                warning2.Visible = false;
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

        private void dpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            dpFechaHasta.MinDate = dpFechaDesde.Value;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Equals(btnAgregar.Text))
            {
                diaHasta = (string)cmbDiaHasta.SelectedItem;
                horaHasta = (string)cmbHorarioHasta.SelectedItem;
                verificarRangoHospital();
                if(warning1.Visible==false)
                {
                    dgRangoAtencion.Rows.Add(diaDesde, diaHasta, horaDesde, horaHasta);
                }

            }
            if (((Button)sender).Text.Equals(btnIngresar.Text))
            {
                especialidad = (string)cmbEspecialidad.SelectedItem;
                diaHasta = (string)cmbDiaHasta.SelectedItem;
                horaHasta = (string)cmbHorarioHasta.SelectedItem;
                fechaDesde =dpFechaDesde.Value.Date.ToString();
                fechaHasta = dpFechaHasta.Value.Date.ToString();
                if (especialidad != "" && profesional != "" && dgRangoAtencion.Rows.Count!=0 && fechaDesde!="" && fechaHasta!="" && warning1.Visible == false && warning2.Visible == false)
                {
                    //FALTA CREAR EL STORED PROCEDURE
                    //Clases.BaseDeDatosSQL.ExecStoredProcedure2(comando, conexion);

                    frmRegistrarAgendaMedico NewForm = new frmRegistrarAgendaMedico(bdd);
                    NewForm.Show();
                    this.Dispose(false);
                }
                else
                {
                    warning2.Visible = true;
                }
            }

        }

        //0:Lunes 1:Martes 2:Miercoles 3:Jueves 4:Viernes 5:Sabado 
        private void verificarRangoHospital()
        {
            int dia;
            for (dia = 0; (dia < 6) && dias.ElementAt(dia)!=(string)cmbDiaHasta.SelectedItem; dia++) { };
            if (dia <= 4)
            {
                warning1.Visible = false;
            }
            else
            {
                if (DateTime.Compare(DateTime.Parse("2000/02/20 " + horaDesde + ":00"), DateTime.Parse("2000/02/20 10:00:00")) > 0
                    && DateTime.Compare(DateTime.Parse("2000/02/20 " + horaHasta + ":00"), DateTime.Parse("2000/02/20 15:00:00")) < 0)
                {
                    warning1.Visible = false;
                }
                else
                {
                    warning1.Visible = true;
                }
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

        public Clases.Profesional unProfesional { get; set; }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

        }

        private void dgRangoAtencion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            /*
            string a = "";
            a = (string)dgRangoAtencion.CurrentCell.Value;
            if (a != null)
            {
                Console.Write(a);
            }
            int nroColumna=dgRangoAtencion.CurrentCell.ColumnIndex;
            int nroFila = dgRangoAtencion.CurrentCell.RowIndex;
            if (nroColumna == 0)
            {
                DataGridViewComboBoxColumn dgDiaDesde = new DataGridViewComboBoxColumn();
                dgRangoAtencion[nroFila, nroColumna + 1].;
                dgRangoAtencion[nroFila, nroColumna + 1].DataSource = dias;
            }
             * */
            //if(dgRangoAtencion.CurrentCell.Value)
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

        }

    }
}
