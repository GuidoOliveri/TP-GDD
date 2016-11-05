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

        public frmRegistroLlegadaAfiliado(Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();

            this.bdd = bdd;

            cmbEspecialidad.Enabled = false;
            warning1.Visible = false;
            warning2.Visible = false;

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
                comando = "select t.fecha as fecha from NEXTGDD.Agenda a,NEXTGDD.Turno t,NEXTGDD.Profesional p,NEXTGDD.Persona pe where t.cod_agenda=a.cod_agenda and a.matricula=p.matricula and p.id_persona=pe.id_persona and (pe.nombre+' '+pe.apellido LIKE '" + profesional + "') and month(t.fecha)=month(GETDATE()) and year(t.fecha)=(year(GETDATE())-1) group by t.fecha order by t.fecha ASC";
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
            if (cmbTurno.SelectedItem !=null)
            {
                warning2.Visible = false;
                /*
                 * POR AHORA SE COMENTA ->YA SE USARON TODOS LOS TURNOS, VERIFICAR TURNO DEVUELVE FALSE SIEMPRE
                if (!verificarTurno())
                {
                 */
                    warning1.Visible = false;
                    if ((string)cmbTurno.SelectedItem != turno)
                    {
                        cmbBono.Items.Clear();
                        cmbBono.Text = "";
                    }
                    turno = (string)cmbTurno.SelectedItem;
                    comando = "select b.nro_bono as bono from NEXTGDD.Turno t,NEXTGDD.Afiliado a,NEXTGDD.Bono_Consulta b,NEXTGDD.Agenda ag,NEXTGDD.Profesional pr,NEXTGDD.Persona p where (p.nombre+' '+p.apellido) LIKE '" + profesional + "' and pr.id_persona=p.id_persona and pr.matricula=ag.matricula and t.cod_agenda=ag.cod_agenda and t.fecha LIKE CONVERT(datetime,'" + turno + "',120) and t.nro_afiliado=a.nro_afiliado and b.nro_afiliado=a.nro_afiliado" /* and (select isnull(count(*),0) from NEXTGDD.Consulta c where c.nro_bono=b.nro_bono)=0*/+" order by b.nro_bono ASC";
                    cargar(bdd.ObtenerLista(comando, "bono"), cmbBono);
                /*
                }
                else
                {
                    warning1.Visible = true;
                    cmbBono.Items.Clear();
                    cmbBono.Text = "";
                }
                */
            }
            
        }

        private Boolean verificarTurno() 
        {
            //devuelve true si fue utilizado
            comando = "select CASE WHEN isnull(count(*),0)=0 THEN 0 ELSE 1 END from NEXTGDD.Turno t,NEXTGDD.Agenda ag,NEXTGDD.Profesional p,NEXTGDD.Consulta c,NEXTGDD.Persona pe where (pe.nombre+' '+pe.apellido) LIKE '"+profesional+"' and pe.id_persona=p.id_persona and p.matricula=ag.matricula and t.cod_agenda=ag.cod_agenda and t.fecha LIKE CONVERT(datetime,'"+turno+"',120) and c.nro_turno=t.nro_turno";
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
            bono = (string) cmbBono.SelectedItem;
            if (profesional != null && turno != null && bono != null && warning2.Visible!=true)
            {
                //FALTA CREAR EL STORED PROCEDURE
                //comando = "EXECUTE NEXTGDD.registrarConsulta @nomProf='" + profesional + "', @fechaTurno='" +turno + "', @nroBono='" + bono+ "'";
                //Clases.BaseDeDatosSQL.ExecStoredProcedure2(comando, conexion);

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
    }
}
