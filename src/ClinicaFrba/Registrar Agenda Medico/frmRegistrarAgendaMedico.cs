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

        public frmRegistrarAgendaMedico()
        {
            InitializeComponent();
            warning1.Visible = false;
            warning2.Visible = false;
            warning3.Visible = false;

            dpFechaDesde.Value = DateTime.Parse(Clases.FechaSistema.fechaSistema);
            dpFechaDesde.MinDate = DateTime.Parse(Clases.FechaSistema.fechaSistema);
            dpFechaHasta.Value = DateTime.Parse(Clases.FechaSistema.fechaSistema);
            dpFechaHasta.MinDate = DateTime.Parse(Clases.FechaSistema.fechaSistema);

            cargarDias();

            cargar(dias, cmbDiaDesde);
            cargar(dias, cmbDiaHasta);
            cargar(horarios, cmbHorarioDesde);
            cargar(horarios, cmbHorarioHasta);
            comando = "select (p.nombre+' '+p.apellido) as nombre from NEXTGDD.Profesional pr,NEXTGDD.Persona p where p.id_persona=pr.id_persona order by (p.nombre+' '+p.apellido) ASC";
            cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, "nombre"), cmbProfesional);

            cmbProfesional.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbEspecialidad.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbDiaDesde.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbDiaHasta.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbHorarioDesde.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbHorarioHasta.SelectedIndexChanged += OnSelectedIndexChanged;
            dpFechaDesde.ValueChanged += new EventHandler(dpFechaDesde_ValueChanged);
            dpFechaHasta.ValueChanged += new EventHandler(dpFechaHasta_ValueChanged);
            btnAgregar.Click += new EventHandler(btn_Click);
            btnBorrar.Click += new EventHandler(btn_Click);
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

        private void cargar(List<string> lista, ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            warning1.Visible = false;
            warning2.Visible = false;
            if (cmbProfesional.SelectedItem != null && (string)cmbProfesional.SelectedItem != profesional)
            {
                warning3.Visible = false;
                dgRangoAtencion.Rows.Clear();
                cmbEspecialidad.Items.Clear();
                cmbEspecialidad.Text = "";
                profesional = (string)cmbProfesional.SelectedItem;
                comando = "select * from NEXTGDD.buscarEspecialidades('" + profesional + "') order by especialidad ASC";
                cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, "especialidad"), cmbEspecialidad);
            }
            if (cmbEspecialidad.SelectedItem != null && (string)cmbEspecialidad.SelectedItem != especialidad)
            {
                //Se busca si tiene una agenda que coincida con la fecha actual y se settea
                validarSiExisteAgenda();
            }
            if (cmbDiaDesde.SelectedItem != null && (string)cmbDiaDesde.SelectedItem != diaDesde)
            {
                diaDesde = (string)cmbDiaDesde.SelectedItem;
                filtrarFechas(cmbDiaDesde, cmbDiaHasta, dias);
            }
            if (cmbDiaHasta.SelectedItem != null && (string)cmbDiaHasta.SelectedItem != diaHasta)
            {
                diaHasta = (string)cmbDiaHasta.SelectedItem;
                cmbHorarioDesde.Text = "";
                cmbHorarioHasta.Text = "";
                cmbHorarioDesde.Items.Clear();
                cmbHorarioHasta.Items.Clear();
                DataTable rangos = buscarRangoAtencionClinica();
                cargarHorarios(rangos);
                cargar(horarios, cmbHorarioDesde);
                cargar(horarios, cmbHorarioHasta);
            }
            if (cmbHorarioDesde.SelectedItem != null && (string)cmbHorarioDesde.SelectedItem != horaDesde)
            {
                horaDesde = (string)cmbHorarioDesde.SelectedItem;
                filtrarFechas(cmbHorarioDesde, cmbHorarioHasta, horarios);
            }

        }

        private DataTable buscarRangoAtencionClinica()
        {
            diaHasta = (string)cmbDiaHasta.SelectedItem;
            int nroDiaHasta;
            for (nroDiaHasta = 0; nroDiaHasta < 6 && diaHasta != dias.ElementAt(nroDiaHasta); nroDiaHasta++) { }
            comando = "select * from NEXTGDD.obtenerRangoClinica(" + nroDiaHasta + ")";
            List<String> campos = new List<string>();
            campos.Add("horaD");
            campos.Add("horaH");
            return Clases.BaseDeDatosSQL.ObtenerTabla(comando, campos);
        }

        private void cargarHorarios(DataTable rangos)
        {
            horarios.Clear();
            foreach (DataRow fila in rangos.Rows)
            {
                //La fecha es cualquiera, solo se usa el tiempo
                DateTime dt = DateTime.Parse("3/11/2000 " + fila[0]);
                while (dt <= DateTime.Parse("3/11/2000 " + fila[1]))
                {
                    horarios.Add(dt.ToString("HH:mm"));
                    dt = dt.AddMinutes(30);
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
            dgRangoAtencion.Rows.Clear();
            dpFechaHasta.MinDate = dpFechaDesde.Value;
            dpFechaHasta.Value = dpFechaDesde.Value;
            if (cmbProfesional.SelectedItem != null && cmbEspecialidad.SelectedItem != null)
            {
                validarSiExisteAgenda();
            }
            else
            {
                warning3.Text = "Debe seleccionar profesional y especialidad.";
                warning3.Visible = true;
            }
        }

        private void dpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            if (cmbProfesional.SelectedItem != null && cmbEspecialidad.SelectedItem != null)
            {
                validarSiExisteAgenda();
            }
            else
            {
                warning3.Text = "Debe seleccionar profesional y especialidad.";
                warning3.Visible = true;
            }
        }

        private void validarSiExisteAgenda()
        {
            dgRangoAtencion.Rows.Clear();
            fechaDesde = (string)dpFechaDesde.Value.ToString();
            fechaHasta = (string)dpFechaHasta.Value.ToString();
            warning3.Text = "Ya existe una agenda para ese rango de fechas. Solo puede agregar rangos de atención.";
            especialidad = (string)cmbEspecialidad.SelectedItem;
            comando = "select NEXTGDD.validarAgendaUnica('" + especialidad + "','" + profesional + "','" + convertirFecha(fechaDesde) + "','" + convertirFecha(fechaHasta) + "')";
            string respuesta = Clases.BaseDeDatosSQL.buscarCampo(comando);
            if (Clases.BaseDeDatosSQL.buscarCampo(comando) == "")
            {
                warning3.Visible = false;
            }
            else
            {
                dpFechaDesde.Value = DateTime.Parse(respuesta.Split('|')[0]);
                dpFechaHasta.Value = DateTime.Parse(respuesta.Split('|')[1]);
                fechaDesde = (string)dpFechaDesde.Value.ToString();
                fechaHasta = (string)dpFechaHasta.Value.ToString();
                warning3.Visible = true;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Equals(btnAgregar.Text))
            {
                if (cmbProfesional.SelectedItem != null && cmbEspecialidad != null && dpFechaDesde.Value.ToString() != "" && dpFechaHasta.Value.ToString() != "")
                {
                    warning1.Text = "El rango horario no es válido. Seleccione otro.";
                    warning1.Visible = false;
                    diaHasta = (string)cmbDiaHasta.SelectedItem;
                    int nroDiaHasta;
                    for (nroDiaHasta = 0; nroDiaHasta < 6 && diaHasta != dias.ElementAt(nroDiaHasta); nroDiaHasta++) { }
                    nroDiaHasta++;
                    horaHasta = (string)cmbHorarioHasta.SelectedItem;
                    verificarRangoHospital();
                    verificarSuperposicionDeRangos();
                    profesional = (string)cmbProfesional.SelectedItem;
                    especialidad = (string)cmbEspecialidad.SelectedItem;
                    if (warning1.Visible == false)
                    {
                        verificarSuperposicionDeRangosEnBDD();
                        if (warning1.Visible == false)
                        {
                            dgRangoAtencion.Rows.Add(cmbDiaDesde.SelectedIndex+1, nroDiaHasta, horaDesde, horaHasta);
                            cmbDiaDesde.Text = "";
                            cmbDiaHasta.Text = "";
                            cmbHorarioDesde.Text = "";
                            cmbHorarioHasta.Text = "";
                        }
                    }
                }
                else
                {
                    warning1.Text = "Debe seleccionar profesional y especialidad, y rangos de fecha.";
                    warning1.Visible = true;
                }
            }
            if (((Button)sender).Text.Equals(btnBorrar.Text))
            {
                foreach (DataGridViewRow item in dgRangoAtencion.SelectedRows)
                {
                    dgRangoAtencion.Rows.RemoveAt(item.Index);
                }
            }
            if (((Button)sender).Text.Equals(btnIngresar.Text))
            {
                especialidad = (string)cmbEspecialidad.SelectedItem;
                diaHasta = (string)cmbDiaHasta.SelectedItem;
                horaHasta = (string)cmbHorarioHasta.SelectedItem;
                fechaDesde = dpFechaDesde.Value.Date.ToString();
                fechaHasta = dpFechaHasta.Value.Date.ToString();
                warning1.Text = "Faltan seleccionar campos";
                if (cmbEspecialidad.SelectedItem != null && cmbProfesional.SelectedItem != null && dgRangoAtencion.Rows.Count != 0 && fechaDesde != null && fechaHasta != null )
                {
                    verificarSumaHoras();
                    if (warning2.Visible == false && warning1.Visible == false)
                    {
                        string fechaD = "";
                        string fechaH = "";
                        if (dpFechaDesde.Enabled == true && dpFechaHasta.Enabled == true)
                        {
                            fechaD = convertirFecha(fechaDesde);
                            fechaH = convertirFecha(fechaHasta);
                        }

                        comando = "EXECUTE NEXTGDD.registrarAgenda @nomProfesional='" + profesional + "', @nomEspecialidad='" + especialidad + "', @fechaD='" + fechaD + "', @fechaH='" + fechaH + "'";
                        Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);

                        comando = "select NEXTGDD.buscarCodigoAgenda('" + profesional + "','" + especialidad + "')";
                        string cod_agenda = Clases.BaseDeDatosSQL.buscarCampo(comando);

                        comando = "select NEXTGDD.buscarCodigoRangoFecha(" + cod_agenda + ",'" + fechaD + "','" + fechaH + "')";
                        string cod_fecha = Clases.BaseDeDatosSQL.buscarCampo(comando);

                        foreach (DataGridViewRow row in dgRangoAtencion.Rows)
                        {
                            comando = "EXECUTE NEXTGDD.registrarRangoHorario @codAgenda='" + cod_agenda + "',@codFecha= '" + cod_fecha + "' ,@diaD='" + row.Cells[0].Value.ToString() + "',@diaH='" + row.Cells[1].Value.ToString() + "',@horaD='" + row.Cells[2].Value.ToString() + ":00',@horaH='" + row.Cells[3].Value.ToString() + ":00'";
                            Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);
                        }

                        MessageBox.Show("La agenda se ha registrado correctamente.", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmRegistrarAgendaMedico NewForm = new frmRegistrarAgendaMedico();
                        NewForm.Show();
                        this.Dispose(false);
                    }
                    else
                    {
                        warning2.Visible = true;
                    }
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


        //1:Lunes 2:Martes 3:Miercoles 4:Jueves 5:Viernes 6:Sabado 
        private void verificarRangoHospital()
        {
            DataTable dt = buscarRangoAtencionClinica();
            foreach (DataRow fila in dt.Rows)
            {
                if (DateTime.Parse(horaDesde) < DateTime.Parse((string)fila[0]) || DateTime.Parse(horaHasta) > DateTime.Parse((string)fila[1]))
                {
                    warning1.Text = "El rango horario no es válido. Seleccione otro.";
                    warning1.Visible = true;
                }
                else
                {
                    warning1.Visible = false;
                }
            }
        }

        private void verificarSuperposicionDeRangosEnBDD()
        {
            comando = "select * from NEXTGDD.obtenerRangosHorarios('"+profesional  +"','" + convertirFecha(fechaDesde) + "','" + convertirFecha(fechaHasta) + "')";
            List<string> campos = new List<string>();
            campos.Add("DD");
            campos.Add("DH");
            campos.Add("HD");
            campos.Add("HH");
            DataTable rangosBDD = Clases.BaseDeDatosSQL.ObtenerTabla(comando, campos);
            if (rangosBDD.Rows.Count != 0)
            {
                haySuperposicion(rangosBDD);
            }
        }

        private void verificarSuperposicionDeRangos()
        {
            warning1.Visible = false;
            int nroDesde = cmbDiaDesde.SelectedIndex+1;
            int nroDiaHasta;
            for (nroDiaHasta = 0; nroDiaHasta < 6 && diaHasta != dias.ElementAt(nroDiaHasta); nroDiaHasta++) { }
            nroDiaHasta++;
            List<int> rangoDias1 = buscarDiasIntermedios(nroDesde, nroDiaHasta);
            List<string> rangoHoras1 = buscarHorasIntermedias(horaDesde, horaHasta);

            foreach (DataGridViewRow fila in dgRangoAtencion.Rows)
            {
                List<int> rangoDias2 = buscarDiasIntermedios(int.Parse(fila.Cells[0].Value.ToString()), int.Parse(fila.Cells[1].Value.ToString()));
                List<string> rangoHoras2 = buscarHorasIntermedias((string)fila.Cells[2].Value, (string)fila.Cells[3].Value);
                IEnumerable<int> intersecDias = rangoDias1.Intersect(rangoDias2);
                IEnumerable<string> intersecHoras = rangoHoras1.Intersect(rangoHoras2);
                if (intersecDias.Count() != 0 && intersecHoras.Count() != 0)
                {
                    warning1.Text = "El rango horario no es válido, se superoponen rangos de atención.";
                    warning1.Visible = true;
                }
            }

        }

        private void haySuperposicion(DataTable dt)
        {
            warning1.Visible = false;
            int nroDesde = cmbDiaDesde.SelectedIndex+1;
            int nroDiaHasta;
            for (nroDiaHasta = 0; nroDiaHasta < 6 && diaHasta != dias.ElementAt(nroDiaHasta); nroDiaHasta++) { }
            nroDiaHasta++;
            List<int> rangoDias1 = buscarDiasIntermedios(nroDesde, nroDiaHasta);
            List<string> rangoHoras1 = buscarHorasIntermedias(horaDesde, horaHasta);

            foreach (DataRow fila in dt.Rows)
            {
                List<int> rangoDias2 = buscarDiasIntermedios(int.Parse(fila[0].ToString()), int.Parse(fila[1].ToString()));
                List<string> rangoHoras2 = buscarHorasIntermedias((string)fila[2], (string)fila[3]);
                IEnumerable<int> intersecDias = rangoDias1.Intersect(rangoDias2);
                IEnumerable<string> intersecHoras = rangoHoras1.Intersect(rangoHoras2);
                if (intersecDias.Count() != 0 && intersecHoras.Count() != 0)
                {
                    warning1.Text = "El rango horario no es válido, se superoponen rangos de atención.";
                    warning1.Visible = true;
                }
            }
        }

        private List<int> buscarDiasIntermedios(int nroDesde, int nroDiaHasta)
        {
            List<int> rangoDias = new List<int>();
            while (nroDesde <= nroDiaHasta)
            {
                rangoDias.Add(nroDesde);
                nroDesde++;
            }
            return rangoDias;
        }

        private List<string> buscarHorasIntermedias(string horaD, string horaH)
        {
            List<string> rangoHoras1 = new List<string>();
            DateTime dt = DateTime.Parse("3/11/2000 " + horaD);
            while (dt <= DateTime.Parse("3/11/2000 " + horaH))
            {
                rangoHoras1.Add(dt.ToString().Split(' ')[1]);
                dt = dt.AddMinutes(30);
            }
            return rangoHoras1;
        }

        private void verificarSumaHoras()
        {
            double horas=0;
            foreach(DataGridViewRow fila in dgRangoAtencion.Rows)
            {
                string horaD ="2/2/2000 "+(string) fila.Cells[2].Value;
                string horaH ="2/2/2000 "+ (string)fila.Cells[3].Value;
                TimeSpan diferencia = (DateTime.Parse(horaH)).Subtract(DateTime.Parse(horaD));
                int cantDias = (int)fila.Cells[1].Value - (int)fila.Cells[0].Value+1;
                horas = horas + diferencia.TotalHours*cantDias;
            }
            if (horas > 48)
            {
                warning2.Text = "No puede tener acumuladas más de 48hs laborales.";
                warning2.Visible = true;
            }
            else
            {
                comando = "select * from NEXTGDD.obtenerRangosHorarios('" + profesional + "','" + convertirFecha(fechaDesde) + "','" + convertirFecha(fechaHasta) + "')";
                List<string> campos = new List<string>();
                campos.Add("DD");
                campos.Add("DH");
                campos.Add("HD");
                campos.Add("HH");
                DataTable rangosBDD = Clases.BaseDeDatosSQL.ObtenerTabla(comando, campos);
                foreach (DataRow fila in rangosBDD.Rows)
                {
                    string horaD = "2/2/2000 "+(string)fila[2];
                    string horaH = "2/2/2000 " + (string)fila[3];
                    TimeSpan diferencia = (DateTime.Parse(horaH)).Subtract(DateTime.Parse(horaD));
                    int cantDias = int.Parse(fila[1].ToString()) - int.Parse(fila[0].ToString()) + 1;
                    horas = horas + diferencia.TotalHours*cantDias;
                }
                if (horas > 48)
                {
                    warning2.Text = "No puede tener acumuladas más de 48hs laborales.";
                    warning2.Visible = true;
                }
                else
                {
                    warning2.Text = "Faltan seleccionar campos";
                    warning2.Visible = false;
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
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

        }

        private void warning3_Click(object sender, EventArgs e)
        {

        }


        private void cmdVolver_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea volver? Se perderán los datos.", "Volver al Menu", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms();
                this.Hide();
                menuAbm.Show();
            }
        }
        private void frmRegistrarAgendaMedico_FormClosing(object sender, FormClosingEventArgs e)
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

    }
}
