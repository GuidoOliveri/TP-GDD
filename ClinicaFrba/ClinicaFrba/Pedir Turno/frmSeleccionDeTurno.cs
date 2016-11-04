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
        private Clases.BaseDeDatosSQL bdd;
        string comando = "";
        string nroAfiliado = "";
        string especialidad = "";
        string profesional = "";
        string fecha = "";

        public frmSeleccionDeTurno(Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();

            this.bdd = bdd;

            warning1.Visible=false;
            warning2.Visible = false;
            warning3.Visible = false;
            warning4.Visible = false;

            comando = "select descripcion from NEXTGDD.Especialidad order by descripcion ASC";
            List<string> lista = bdd.ObtenerLista(comando,"descripcion");
            for(int i=0;i<lista.Count;i++){
                cmbEspecialidad.Items.Add(lista.ElementAt(i));
            }
            cmbEspecialidad.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbProfesional.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbHorario.SelectedIndexChanged += OnSelectedIndexChanged;
            btnIngresarTurno.Click += new EventHandler(btnIngresarTurno_Click);
      
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void verificarTextbox()
        {
            nroAfiliado = txtNroAfiliado.Text;
            if (/*nroAfiliado.Length < 8 && */nroAfiliado!="")
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
            //nroAfiliado = txtNroAfiliado.Text;
            if (cmbEspecialidad.SelectedItem!=null && (string) cmbEspecialidad.SelectedItem!=especialidad)
            {
                warning3.Visible = false;
                verificarTextbox();   
                //INGRESA PROFESIONALES
                especialidad = (string) cmbEspecialidad.SelectedItem;
                cmbProfesional.Text = "";
                cmbProfesional.Items.Clear();
                comando = "select pers.nombre+' '+pers.apellido as nombre from NEXTGDD.Profesional p,NEXTGDD.Profesional_X_Especialidad pe,NEXTGDD.Especialidad e,NEXTGDD.Persona pers where pers.id_persona=p.id_persona and p.matricula=pe.matricula and pe.cod_especialidad=e.cod_especialidad and e.descripcion LIKE '" + cmbEspecialidad.SelectedItem + "' order by pers.nombre+' '+pers.apellido ASC";
                List<string> lista2 = bdd.ObtenerLista(comando, "nombre");
                for (int i = 0; i < lista2.Count; i++)
                {
                    cmbProfesional.Items.Add(lista2.ElementAt(i));
                }
            }
            if (cmbProfesional.SelectedItem != null)
            {
                warning3.Visible = false;
                profesional = (string) cmbProfesional.SelectedItem;
            }
            if (cmbHorario.SelectedItem != null)
            {
                warning3.Visible = false;
                fecha= (string) dtpFecha.Value.ToString("yyyy-MM-dd") + " "+ (string) cmbHorario.SelectedItem+":00.000";
                comando = "select isnull(count(*),0) from NEXTGDD.Turno t,NEXTGDD.Agenda a, NEXTGDD.Profesional p,NEXTGDD.Persona pers where t.fecha LIKE CONVERT(datetime,'" + fecha + "', 120) and (pers.nombre+' '+pers.apellido) LIKE '" + profesional + "' and pers.id_persona=p.id_persona and a.matricula=p.matricula and t.cod_agenda=a.cod_agenda";
                Console.Write(comando);
                if(!bdd.validarCampo(comando))
                {
                    warning2.Visible=false;
                }
                else
                {
                    warning2.Visible=true;
                }
            }

        }

        private void btnIngresarTurno_Click(object sender, EventArgs e)
        {
            nroAfiliado=(string) txtNroAfiliado.Text;
            this.verificarTextbox();
            if (nroAfiliado != "" && warning4.Visible==false && especialidad != "" && profesional != "" && fecha != "")
            {
                comando = "EXECUTE NEXTGDD.crearTurno @nroAf='"+nroAfiliado+"', @nombreEsp='"+especialidad+"', @nomProf='"+profesional+"', @fecha='"+fecha+"'";
                bdd.ExecStoredProcedure2(comando);

                frmSeleccionDeTurno NewForm=new frmSeleccionDeTurno(bdd);
                NewForm.Show();
                this.Dispose(false);

            }
            else
            {
                warning3.Visible = true;
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
    }
}
