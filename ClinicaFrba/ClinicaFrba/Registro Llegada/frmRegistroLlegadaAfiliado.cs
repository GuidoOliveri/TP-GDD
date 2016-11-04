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
        string comando = "";
        string conexion = "Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016";
        string profesional = "";
        string especialidad = "";
        string turno = "";//muestra fecha del turno
        string bono = "";//nro bono

        public frmRegistroLlegadaAfiliado()
        {
            InitializeComponent();
            cmbEspecialidad.Enabled = false;
            warning1.Visible = false;
            warning2.Visible = false;

            //SE CARGAN LOS PROF
            comando = "select (nombre+' '+apellido) as nombre from NEXTGDD.Profesional order by nombre ASC";
            cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, conexion, "nombre"),cmbProfesional);

            //SE CARGAN LAS ESPEC
            comando = "select descripcion from NEXTGDD.Especialidad order by descripcion ASC";
            cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, conexion, "descripcion"),cmbEspecialidad);

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
            if (cmbProfesional.SelectedItem != null && cmbProfesional.SelectedItem!=profesional)
            {
                profesional = (string)cmbProfesional.SelectedItem;
                cmbTurno.Items.Clear();
                cmbTurno.Text = "";
                comando = "select at.fecha as fecha from NEXTGDD.Agenda_X_Turno at,NEXTGDD.Agenda a,NEXTGDD.Profesional p,NEXTGDD.Especialidad where at.cod_agenda=a.cod_agenda and a.matricula=p.matricula and (p.nombre+' '+p.apellido LIKE '" + profesional + "') and month(at.fecha)=month(GETDATE()) and year(at.fecha)=(year(GETDATE())-1) group by at.fecha order by at.fecha ASC";
                cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, conexion, "fecha"), cmbTurno);
            }
            if (cmbProfesional.SelectedItem != null && especialidad != "")
            {
                profesional = (string)cmbProfesional.SelectedItem;
            }
            if (cmbEspecialidad.SelectedItem != null && cmbEspecialidad.SelectedItem!=especialidad)
            {
                especialidad = (string) cmbEspecialidad.SelectedItem;
                cmbProfesional.Items.Clear();
                cmbProfesional.Text = "";
                cmbTurno.Items.Clear();
                cmbTurno.Text = "";
                comando = "select (p.nombre+' '+p.apellido) as nombre from NEXTGDD.Profesional p,NEXTGDD.Profesional_X_Especialidad pe,NEXTGDD.Especialidad e where pe.matricula=p.matricula and pe.cod_especialidad=e.cod_especialidad and e.descripcion LIKE '" + especialidad + "' group by p.nombre,p.apellido order by nombre ASC";
                cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, conexion, "nombre"), cmbProfesional);
            }
            if (cmbTurno.SelectedItem !=null)
            {
                /*
                 * POR AHORA SE COMENTA ->YA SE USARON TODOS LOS TURNOS, VERIFICAR TURNO DEVUELVE FALSE SIEMPRE
                if (!verificarTurno())
                {
                 */
                    warning1.Visible = false;
                    if (cmbTurno.SelectedItem != turno)
                    {
                        cmbBono.Items.Clear();
                        cmbBono.Text = "";
                    }
                    turno = (string)cmbTurno.SelectedItem;
                    comando = "select b.nro_bono as bono from NEXTGDD.Turno t,NEXTGDD.Afiliado a,NEXTGDD.Bono_Consulta b,NEXTGDD.Agenda ag,NEXTGDD.Profesional p where (p.nombre+' '+p.apellido) LIKE '" + profesional + "' and p.matricula=ag.matricula and t.cod_agenda=ag.cod_agenda and t.fecha LIKE CONVERT(datetime,'" + turno + "',120) and t.nro_afiliado=a.nro_afiliado and b.nro_afiliado=a.nro_afiliado and (select isnull(count(*),0) from NEXTGDD.Consulta c where c.nro_bono=b.nro_bono)=0 order by b.nro_bono ASC";
                    cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, conexion, "bono"), cmbBono);
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
            comando = "select CASE WHEN isnull(count(*),0)=0 THEN 0 ELSE 1 END from NEXTGDD.Turno t,NEXTGDD.Agenda ag,NEXTGDD.Profesional p,NEXTGDD.Consulta c where (p.nombre+' '+p.apellido) LIKE 'KAREN Sosa' and p.matricula=ag.matricula and t.cod_agenda=ag.cod_agenda and t.fecha LIKE CONVERT(datetime,'2015-01-01 08:00:00.000',120) and c.nro_turno=t.nro_turno";
            return Clases.BaseDeDatosSQL.validarCampo(comando, conexion);
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
                comando = "select (nombre+' '+apellido) as nombre from NEXTGDD.Profesional order by nombre ASC";
                cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, conexion, "nombre"),cmbProfesional);
                cmbEspecialidad.Enabled = false; 
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bono = (string) cmbBono.SelectedItem;
            if (profesional != "" && turno != "" && bono != "")
            {
                //FALTA CREAR EL STORED PROCEDURE
                //comando = "EXECUTE NEXTGDD.registrarConsulta @nomProf='" + profesional + "', @fechaTurno='" +turno + "', @nroBono='" + bono+ "'";
                //Clases.BaseDeDatosSQL.ExecStoredProcedure2(comando, conexion);

                frmRegistroLlegadaAfiliado NewForm = new frmRegistroLlegadaAfiliado();
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
