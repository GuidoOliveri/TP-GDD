using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Pedir_Turno
{

    public partial class frmSeleccionDeTurno : Form
    {
        private string rol = "";
        private string usuario = "";
        private Clases.BaseDeDatosSQL bdd;

        private string comando = "";
        private string nroAfiliado = "";
        private string especialidad = "";
        private string profesional = "";
        private string fecha = "";
        private List<String> horarios = new List<string>();

        public frmSeleccionDeTurno(string rol, string usuario,Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();

            this.rol = rol;
            this.usuario = usuario;
            this.bdd = bdd;

            warning1.Visible=false;
            warning2.Visible = false;
            warning3.Visible = false;
            warning4.Visible = false;

            //Carga especialidades
            comando = "select descripcion from NEXTGDD.Especialidad order by descripcion ASC";
            cargar(bdd.ObtenerLista(comando, "descripcion"), cmbEspecialidad);

            cmbEspecialidad.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbProfesional.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbHorario.SelectedIndexChanged += OnSelectedIndexChanged;
            dtpFecha.ValueChanged += new EventHandler(dtpFecha_ValueChanged);
            btnIngresarTurno.Click += new EventHandler(btnIngresarTurno_Click);
      
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cargar(List<string> lista, ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }
        }

        private void verificarTextbox()
        {
            nroAfiliado = txtNroAfiliado.Text;
            if (nroAfiliado!="")
            {
                comando = "select isnull(count(*),0) from NEXTGDD.Afiliado where nro_afiliado LIKE " + nroAfiliado;
                if (bdd.validarCampo(comando))
                {
                    warning4.Visible = false;
                }
                else
                {
                    warning4.Visible = true;
                }
            }
            else
            {
                warning4.Visible = true;
            }
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecialidad.SelectedItem!=null && (string) cmbEspecialidad.SelectedItem!=especialidad)
            {
                warning3.Visible = false;
                verificarTextbox();   
                especialidad = (string) cmbEspecialidad.SelectedItem;
                cmbProfesional.Text = "";
                cmbProfesional.Items.Clear();

                //Carga los profesionales según la especialidad
                comando = "select * from NEXTGDD.buscarProfesionales('"+especialidad+"')";
                cargar(bdd.ObtenerLista(comando,"nombre"), cmbProfesional);
            }
            if (cmbProfesional.SelectedItem != null)
            {
                warning3.Visible = false;
                profesional = (string) cmbProfesional.SelectedItem;
            }
            if (cmbHorario.SelectedItem != null)
            {
                warning3.Visible = false;
                verificarTurnoDisponible();
            }

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            //CARGA LOS HORARIOS A PARTIR DE LA FECHA SELECCIONADA
            warning1.Visible = false;
            cmbHorario.Items.Clear();
            cmbHorario.Text = "";
            DataTable rangos = buscarRangoAtencionClinica();
            cargarHorarios(rangos);
            cargar(horarios, cmbHorario);
            if (horarios.Count() == 0)
            {
                warning1.Visible = true;
            }
        }

        private DataTable buscarRangoAtencionClinica()
        {
            int diaSemana = (int)dtpFecha.Value.DayOfWeek - 1;
            comando = "select * from NEXTGDD.obtenerRangoClinica(" + diaSemana + ")";
            List<String> campos = new List<string>();
            campos.Add("hora_inicial");
            campos.Add("hora_final"); 
            return bdd.ObtenerTabla(comando, campos);
        }

        private void cargarHorarios(DataTable rangos)
        {
            horarios.Clear();
            foreach (DataRow fila in rangos.Rows)
            {
                //La fecha es cualquiera, solo se usa el tiempo
                DateTime dt = DateTime.Parse("3/11/2000 "+fila[0]);
                while (dt <= DateTime.Parse("3/11/2000 " + fila[1]))
                {
                    horarios.Add(dt.ToString("HH:mm"));
                    dt = dt.AddMinutes(30);
                }
            }
        }

        private void btnIngresarTurno_Click(object sender, EventArgs e)
        {
            nroAfiliado=(string) txtNroAfiliado.Text;
            this.verificarTextbox();
            verificarTurnoDisponible();
            verificarRangoHorario();
            if (nroAfiliado != "" && warning4.Visible==false && especialidad != "" && profesional != "" && fecha != "")
            {
                comando = "EXECUTE NEXTGDD.crearTurno @nroAf='"+nroAfiliado+"', @nombreEsp='"+especialidad+"', @nomProf='"+profesional+"', @fecha='"+fecha+"'";
                bdd.ExecStoredProcedure2(comando);

                comando="select top 1 str(nro_turno) from NEXTGDD.Turno order by nro_turno DESC";
                MessageBox.Show("El turno se ha igresado correctamente \n Numero de turno:  "+ bdd.buscarCampo(comando), "Turno", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmSeleccionDeTurno NewForm=new frmSeleccionDeTurno(rol,usuario,bdd);
                NewForm.Show();
                this.Dispose(false);

            }
            else
            {
                warning3.Visible = true;
            }

        }

        private void verificarTurnoDisponible()
        {
            fecha = (string)dtpFecha.Value.ToString("yyyy-MM-dd") + " " + (string)cmbHorario.SelectedItem + ":00";
            comando = "select NEXTGDD.validarTurnoDisponible('" + fecha + "','" + profesional + "')";
            if (bdd.buscarCampo(comando)=="true")
            {
                warning2.Visible = false;
            }
            else
            {
                warning2.Visible = true;
            }
        }

        private void verificarRangoHorario()
        {
            comando = "select NEXTGDD.tieneRangosHorarios('"+especialidad+"','"+profesional+"')";
            if (bdd.buscarCampo(comando)=="true")
            {
                comando = "select NEXTGDD.validarConRangoHorario('" + fecha + "','" + profesional + "','" + especialidad + "'," + ((int)dtpFecha.Value.DayOfWeek - 1) + ",'" + fecha.Split(' ')[1] + "')";
                if (bdd.buscarCampo(comando) == "fuera del rango horario")
                {
                    warning1.Visible = true;
                }
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnIngresarTurno_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms(rol, usuario, bdd);
            this.Hide();
            menuAbm.Show();
        }

        private void frmSeleccionDeTurno_FormClosing(object sender, FormClosingEventArgs e)
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
