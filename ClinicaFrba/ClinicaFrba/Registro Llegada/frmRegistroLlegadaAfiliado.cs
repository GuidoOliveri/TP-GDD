using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class frmRegistroLlegadaAfiliado : Form
    {
        private Clases.BaseDeDatosSQL bdd;
        private string comando = "";
        private string profesional = "";
        private string especialidad = "";
        private string turno = "";//muestra fecha del turno
        private string bono = "";//nro bono
        private string horaLLegada = "";

        public frmRegistroLlegadaAfiliado(Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();

            this.bdd = bdd;

            cmbEspecialidad.Enabled = false;
            warning1.Visible = false;
            warning2.Visible = false;
            warning3.Visible = false;

            //SE CARGAN LOS PROF
            comando = "select (p.nombre+' '+p.apellido) as nombre from NEXTGDD.Persona p,NEXTGDD.Profesional pr where p.id_persona=pr.id_persona order by p.nombre ASC";
            cargar(bdd.ObtenerLista(comando, "nombre"),cmbProfesional);

            //SE CARGAN LAS ESPEC
            comando = "select descripcion from NEXTGDD.Especialidad order by descripcion ASC";
            cargar(bdd.ObtenerLista(comando,"descripcion"),cmbEspecialidad);

            rbBusqueda.Click += new EventHandler(rbBusqueda_Click);
            cmbEspecialidad.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbProfesional.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbTurno.SelectedIndexChanged += OnSelectedIndexChanged;
            btnIngresar.Click += new EventHandler(btnIngresar_Click);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProfesional.SelectedItem != null && (string) cmbProfesional.SelectedItem!=profesional)
            {
                warning2.Visible = false;
                profesional = (string)cmbProfesional.SelectedItem;
                cmbTurno.Items.Clear();
                cmbTurno.Text = "";
                comando = "select t.fecha as fecha from NEXTGDD.Agenda a,NEXTGDD.Turno t,NEXTGDD.Profesional p,NEXTGDD.Persona pe where t.cod_agenda=a.cod_agenda and a.matricula=p.matricula and p.id_persona=pe.id_persona and (pe.nombre+' '+pe.apellido LIKE '" + profesional + "')  group by t.fecha order by t.fecha ASC";
                cargar(bdd.ObtenerLista(comando,"fecha"), cmbTurno);
            }
            if (cmbProfesional.SelectedItem != null && especialidad != "")
            {
                warning2.Visible = false;
                profesional = (string)cmbProfesional.SelectedItem;
            }
            if (cmbEspecialidad.SelectedItem != null && (string) cmbEspecialidad.SelectedItem!=especialidad)
            {
                warning2.Visible = false;
                especialidad = (string) cmbEspecialidad.SelectedItem;
                cmbTurno.Items.Clear();
                cmbTurno.Text = "";
                cmbBono.Items.Clear();
                cmbBono.Text = "";
                cmbProfesional.Items.Clear();
                cmbProfesional.Text = "";
                cmbTurno.Items.Clear();
                cmbTurno.Text = "";
                comando = "select (p.nombre+' '+p.apellido) as nombre from NEXTGDD.Persona p,NEXTGDD.Profesional pr,NEXTGDD.Profesional_X_Especialidad pe,NEXTGDD.Especialidad e where pr.id_persona=p.id_persona and pe.matricula=pr.matricula and pe.cod_especialidad=e.cod_especialidad and e.descripcion LIKE '" + especialidad + "' group by p.nombre,p.apellido order by nombre ASC";
                cargar(bdd.ObtenerLista(comando,"nombre"), cmbProfesional);
            }
            if (cmbTurno.SelectedItem !=null && (string)cmbTurno.SelectedItem!=turno)
            {
                warning2.Visible = false;
                turno = (string) cmbTurno.SelectedItem;
                if (!verificarTurno() )
                {
                    warning1.Visible = false;
                    if ((string)cmbTurno.SelectedItem != turno)
                    {
                        cmbBono.Items.Clear();
                        cmbBono.Text = "";
                    }
                    comando = "select b.nro_bono as bono from NEXTGDD.Turno t,NEXTGDD.Afiliado a,NEXTGDD.Bono_Consulta b,NEXTGDD.Agenda ag,NEXTGDD.Profesional pr,NEXTGDD.Persona p where (p.nombre+' '+p.apellido) LIKE '" + profesional + "' and pr.id_persona=p.id_persona and pr.matricula=ag.matricula and t.cod_agenda=ag.cod_agenda and t.fecha LIKE CONVERT(datetime,'" + convertirFecha(turno) + "',120) and t.nro_afiliado=a.nro_afiliado and b.nro_afiliado=a.nro_afiliado" /* and (select isnull(count(*),0) from NEXTGDD.Consulta c where c.nro_bono=b.nro_bono)=0*/+" order by b.nro_bono ASC";
                    cargar(bdd.ObtenerLista(comando, "bono"), cmbBono);
                }
                else
                {
                    warning1.Visible = true;
                    cmbBono.Items.Clear();
                    cmbBono.Text = "";
                }
                
            }
            
        }

        private string convertirFecha(string fecha)
        {
            string fechaSinTiempo = fecha.Split(' ')[0];
            string dia = fechaSinTiempo.Split('/')[0];
            if (dia.Length == 1)
            {
                dia = '0' + dia;
            }
            string mes = fechaSinTiempo.Split('/')[1];
            if (mes.Length == 1)
            {
                mes = '0'+mes;
            }
            string año = fechaSinTiempo.Split('/')[2];
            return año + "/" + mes + "/" + dia + " " + fecha.Split(' ')[1];
        }

        private Boolean verificarTurno() 
        {
            //devuelve true si fue utilizado
            comando = "select CASE WHEN isnull(count(*),0)=0 THEN 0 ELSE 1 END from NEXTGDD.Turno t,NEXTGDD.Agenda ag,NEXTGDD.Profesional p,NEXTGDD.Consulta c,NEXTGDD.Persona pe where (pe.nombre+' '+pe.apellido) LIKE '"+profesional+"' and pe.id_persona=p.id_persona and p.matricula=ag.matricula and t.cod_agenda=ag.cod_agenda and t.fecha LIKE CONVERT(datetime,'"+convertirFecha(turno)+"',120) and c.nro_turno=t.nro_turno";
            return bdd.validarCampo(comando);
        }

        private void rbBusqueda_Click(object sender, EventArgs e)
        {
            if (cmbEspecialidad.Enabled == false)
            {
                cmbEspecialidad.Enabled = true;
            }
            else
            {
                cmbProfesional.Items.Clear();
                cmbProfesional.Text = "";
                //Filtra los profesionales
                comando = "select (p.nombre+' '+p.apellido) as nombre from NEXTGDD.Profesional pr,NEXTGDD.Persona p where p.id_persona=pr.id_persona order by p.nombre ASC";
                cargar(bdd.ObtenerLista(comando, "nombre"),cmbProfesional);
                cmbEspecialidad.Enabled = false; 
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            warning2.Visible = false;
            bono = (string) cmbBono.SelectedItem;
            horaLLegada= txtHoraLlegada.Text;
            verificarFecha(horaLLegada,':',warning3);
            if (profesional != null && turno != null && bono != null && horaLLegada!="" && warning2.Visible!=true && warning3.Visible!=true && warning1.Visible!=true)
            {
                comando = "EXECUTE NEXTGDD.registrarConsulta @horaLlegada='"+horaLLegada+"',@nomProf='" + profesional + "', @fechaTurno='" +convertirFecha(turno) + "', @nroBono='" + bono+ "'";
                bdd.ExecStoredProcedure2(comando);

                frmRegistroLlegadaAfiliado NewForm = new frmRegistroLlegadaAfiliado(bdd);
                NewForm.Show();
                this.Dispose(false);

            }
            else
            {
                warning2.Visible = true;
            }

        }

        private void cargar(List<string> lista,ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }
        }

        private void verificarFecha(string str, char c, Label l)
        {
            string[] fechaPartida = str.Split(c);
            Boolean b = true;
            if (fechaPartida.Length == 3 && fechaPartida[0].Length == 2 && fechaPartida[1].Length == 2 && fechaPartida[2].Length == 2)
            {
                b = false;
            }
            l.Visible = b;
        }

        private void frmRegistroLlegadaAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public Clases.Profesional unProfesional { get; set; }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
