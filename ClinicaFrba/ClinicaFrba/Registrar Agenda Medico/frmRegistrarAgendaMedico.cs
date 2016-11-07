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
        private string rol = "";
        private string usuario = "";
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

        public frmRegistrarAgendaMedico(string rol, string usuario, Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();
            warning1.Visible=false;
            warning2.Visible = false;
            warning3.Visible = false;
            this.rol = rol;
            this.usuario = usuario;
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

        public frmRegistrarAgendaMedico()
        {
            // TODO: Complete member initialization
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
                warning3.Visible = false;
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
            if (cmbEspecialidad.SelectedItem != null && (string)cmbEspecialidad.SelectedItem != especialidad)
            {
                especialidad = (string)cmbEspecialidad.SelectedItem;
                comando = "select isnull(count(*),0) from NEXTGDD.Agenda a,NEXTGDD.Profesional pr,NEXTGDD.Persona p,NEXTGDD.Especialidad e where p.nombre+' '+p.apellido LIKE '" + profesional + "' and p.id_persona=pr.id_persona and a.matricula=pr.matricula and a.cod_especialidad=e.cod_especialidad and e.descripcion LIKE '" + especialidad + "'";
                if (bdd.validarCampo(comando))
                {
                    warning3.Visible = false;
                }
                {
                    warning3.Visible = true;
                }
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
            Console.Write(dpFechaHasta.Value);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Equals(btnAgregar.Text))
            {
                diaHasta = (string)cmbDiaHasta.SelectedItem;
                int nroDiaHasta;
                for (nroDiaHasta = 0; nroDiaHasta < 6 && diaHasta != dias.ElementAt(nroDiaHasta);nroDiaHasta++){}
                horaHasta = (string)cmbHorarioHasta.SelectedItem;
                verificarRangoHospital();
                if(warning1.Visible==false)
                {
                    dgRangoAtencion.Rows.Add(cmbDiaDesde.SelectedIndex, nroDiaHasta, horaDesde, horaHasta);
                }

            }
            if (((Button)sender).Text.Equals(btnIngresar.Text))
            {
                especialidad = (string)cmbEspecialidad.SelectedItem;
                diaHasta = (string)cmbDiaHasta.SelectedItem;
                horaHasta = (string)cmbHorarioHasta.SelectedItem;
                fechaDesde =dpFechaDesde.Value.Date.ToString();
                fechaHasta = dpFechaHasta.Value.Date.ToString();
                if (especialidad != "" && profesional != "" && dgRangoAtencion.Rows.Count!=0 && fechaDesde!="" && fechaHasta!="" && warning1.Visible == false && warning2.Visible == false &&warning3.Visible==false)
                {
                    //FALTA CREAR EL STORED PROCEDURE
                    //Clases.BaseDeDatosSQL.ExecStoredProcedure2(comando, conexion);
                    comando = "EXECUTE NEXTGDD.registrarAgenda @nomProfesional='"+profesional+"', @nomEspecialidad='"+especialidad+"', @fechaD='"+convertirFecha(fechaDesde)+"', @fechaH='"+convertirFecha(fechaHasta)+"'";
                    bdd.ExecStoredProcedure2(comando);

                    comando = "select NEXTGDD.buscarCodigoAgenda('" + profesional + "','" + especialidad + "')";
                    string cod_agenda=bdd.buscarCampo(comando);

                    int nroRango = 0;
                    foreach(DataGridViewRow row in dgRangoAtencion.Rows)
                    {
                        comando = "EXECUTE NEXTGDD.registrarRangoHorario @cod_rango='"+nroRango+"', @codAgenda='" + cod_agenda+ "',@diaD='" + row.Cells[0].Value.ToString() + "',@diaH='" + row.Cells[1].Value.ToString() + "',@horaD='" + row.Cells[2].Value.ToString() + ":00',@horaH='" + row.Cells[3].Value.ToString() + ":00'";
                        bdd.ExecStoredProcedure2(comando);
                        nroRango++;
                    }

                    frmRegistrarAgendaMedico NewForm = new frmRegistrarAgendaMedico(rol,usuario,bdd);
                    NewForm.Show();
                    this.Dispose(false);
                }
                else
                {
                    warning2.Visible = true;
                }
            }

        }

        private string convertirFecha(string fecha)
        {
            string fechaSinTiempo = fecha.Split(' ')[0];
            string dia = fechaSinTiempo.Split('/')[0];
            string mes = fechaSinTiempo.Split('/')[1];
            string año = fechaSinTiempo.Split('/')[2];
            return año + "/" + mes + "/" + dia + " " + fecha.Split(' ')[1];
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

        private void warning3_Click(object sender, EventArgs e)
        {

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms(rol, usuario, bdd);
            this.Hide();
            menuAbm.Show();
        }

    }
}
