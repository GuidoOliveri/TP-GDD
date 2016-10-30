using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Resultado
{

    public partial class frmRegistroResultado : Form
    {
        string comando = "";
        string conexion = "Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016";
        string consulta = "";
        string fecha = "";
        string hora = "";
        string sintoma = "";
        string enfermedad = "";
        string descripcion = "";

        public frmRegistroResultado()
        {
            InitializeComponent();
            warning1.Visible = false;
            warning2.Visible = false;
            warning3.Visible = false;

            comando = "select sintoma from NEXTGDD.Sintoma ";
            cargar (Clases.BaseDeDatosSQL.ObtenerLista(comando,conexion,"sintoma"),cmbSintoma);

            comando = "select enfermedad from NEXTGDD.Enfermedad";
            cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, conexion, "enfermedad"), cmbEnfermedad);

            //VER COMO CARGAR CONSULTAS DE UN MEDICO LOGUEADO

            btnIngresar.Click += new EventHandler(btnIngresar_Click);

        }

        private void cargar(List<string> lista, ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            fecha=txtFecha.Text;
            hora=txtHora.Text;
            verificarFecha(fecha,'/',warning1);
            verificarFecha(hora, ':', warning2);  
            if (consulta != "" && fecha != "" && hora != "" && enfermedad!="" && sintoma!= "" && warning1.Visible==false && warning2.Visible==false)
            {
                //FALTA CREAR EL STORED PROCEDURE

                frmRegistroResultado NewForm = new frmRegistroResultado();
                NewForm.Show();
                this.Dispose(false);

            }
            else
            {
                warning3.Visible = true;
            }

        }

        private void verificarFecha(string str,char c,Label l)
        {
            string[] fechaPartida = str.Split(c);
            Boolean b = true;
            if(fechaPartida.Length==3 && fechaPartida[0].Length==2 && fechaPartida[1].Length==2)
            {
                if (c == '/')
                {
                    if (fechaPartida[2].Length == 4)
                    {
                        b = false;
                    }
                }
                if (c == ':')
                {
                    if (fechaPartida[2].Length == 2)
                    {
                        b = false;
                    }
                }
            }
            l.Visible = b;
        }


        private void frmRegistroResultado_Load(object sender, EventArgs e)
        {

        }
    }
}
