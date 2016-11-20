using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Login
{
    public partial class ingresoAdminComoProfesional : Form
    {
        string comando = "";

        public ingresoAdminComoProfesional()
        {
            InitializeComponent();

            warning1.Visible = false;

            comando = "select (p.nombre+' '+p.apellido) as nombre from NEXTGDD.Profesional pr,NEXTGDD.Persona p where p.id_persona=pr.id_persona and pr.activo<>1 order by (p.nombre+' '+p.apellido) ASC";
            cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, "nombre"), cmbProfesionales);

            btnIngresar.Click += new EventHandler(btnIngresar_OnClick);
            btnVolver.Click += new EventHandler(btnVolver_Click);

        }

        private void cargar(List<string> lista, ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }
        }

        private void btnIngresar_OnClick(object sender, EventArgs e)
        {
            warning1.Visible = false;
            if (cmbProfesionales.SelectedItem != null)
            {
                string profesional=(string) cmbProfesionales.SelectedItem;
                comando = "select pr.matricula from NEXTGDD.Profesional pr, NEXTGDD.Persona p where p.nombre+' '+p.apellido LIKE '" + profesional + "' and p.id_persona=pr.id_persona and pr.activo<>1";
                Clases.Usuario.Matricula = int.Parse(Clases.BaseDeDatosSQL.buscarCampo(comando));

                Registro_Resultado.frmRegistroResultado diagnostico = new Registro_Resultado.frmRegistroResultado();
                this.Hide();
                diagnostico.Show();
            }
            else
            {
                warning1.Visible = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms();
            this.Hide();
            menuAbm.Show();
        }


        private void ingresoAdminComoProfesional_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ingresoAdminComoProfesional_FormClosing(object sender, FormClosingEventArgs e)
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
