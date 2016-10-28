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
        String comando = "";
       String conexion = "Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016";
        
        public frmSeleccionDeTurno()
        {
            InitializeComponent();
            warning1.Visible=false;
            warning2.Visible = false;

            comando = "select descripcion from NEXTGDD.Especialidad order by descripcion ASC";
            List<String> lista = Clases.BaseDeDatosSQL.ObtenerLista(comando,conexion,"descripcion");
            for(int i=0;i<lista.Count;i++){
                cmbEspecialidad.Items.Add(lista.ElementAt(i));
            }
            cmbEspecialidad.SelectedIndexChanged += OnSelectedIndexChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            //INGRESA PROFESIONALES
            cmbProfesional.Text="";
            cmbProfesional.Items.Clear();
            comando = "select p.nombre+' '+p.apellido as nombre from NEXTGDD.Profesional p,NEXTGDD.Profesional_X_Especialidad pe,NEXTGDD.Especialidad e where p.matricula=pe.matricula and pe.cod_especialidad=e.cod_especialidad and e.descripcion LIKE '" + cmbEspecialidad.SelectedItem + "' order by descripcion ASC";
            List<String> lista2 = Clases.BaseDeDatosSQL.ObtenerLista(comando,conexion, "nombre");
            for (int i = 0; i < lista2.Count; i++)
            {
                cmbProfesional.Items.Add(lista2.ElementAt(i));
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
