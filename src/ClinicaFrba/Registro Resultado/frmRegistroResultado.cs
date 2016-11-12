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
        private string rol = "";
        private string usuario = "";
        private Clases.BaseDeDatosSQL bdd;
        
        private string comando = "";
        private string consulta = "";
        private string afiliado = ""; //para filtrar
        private string fecha = "";
        private string hora = "";
        private string sintoma = "";
        private string enfermedad = "";
        private string descripcion = "";
        private string id_persona = ""; 

        public frmRegistroResultado(string rol, string usuario, Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();
            this.rol = rol;
            this.usuario = usuario;
            this.bdd = bdd;
            comando = "select u.id_persona as id from NEXTGDD.Usuario u where u.username LIKE '"+usuario+"'";
            id_persona = bdd.buscarCampo(comando);

            warning1.Visible = false;
            warning2.Visible = false;
            warning3.Visible = false;
            cmbAfiliado.Enabled = false;

            //Habria que filtrar por fecha actual
            comando = "select * from NEXTGDD.buscarConsultasAtendidas('"+id_persona+"') order by consulta ASC";
            cargar(bdd.ObtenerLista(comando,"consulta"),cmbConsulta);

            comando = "select sintoma from NEXTGDD.Sintoma ";
            cargar (bdd.ObtenerLista(comando,"sintoma"),cmbSintoma);

            comando = "select enfermedad from NEXTGDD.Enfermedad";
            cargar(bdd.ObtenerLista(comando, "enfermedad"), cmbEnfermedad);

            cmbConsulta.SelectedIndexChanged += OnSelectedIndexChanged;
            cmbAfiliado.SelectedIndexChanged += OnSelectedIndexChanged;
            rbFiltrarFecha.Click += new EventHandler(rbFiltrarFecha_Click);
            btnIngresar.Click += new EventHandler(btnIngresar_Click);

        }

        private void cargar(List<string> lista, ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }
        }

        private void rbFiltrarFecha_Click(object sender, EventArgs e)
        {
            if (cmbAfiliado.Enabled == false)
            {
                cmbAfiliado.Enabled = true;
                comando = "select * from NEXTGDD.buscarAfiliadosAtendidos('" + id_persona + "') order by nombre ASC";
                cargar(bdd.ObtenerLista(comando, "nombre"), cmbAfiliado);
            }
            else
            {
                cmbConsulta.Items.Clear();
                cmbConsulta.Text = "";
                comando = "select * from NEXTGDD.buscarConsultasAtendidas('" + id_persona + "') order by consulta ASC";
                cargar(bdd.ObtenerLista(comando, "consulta"), cmbConsulta);
                cmbAfiliado.Text = "";
                cmbAfiliado.Items.Clear();
                cmbAfiliado.Enabled = false;
            }

        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        { 
            if(cmbAfiliado.SelectedItem!=null && (string)cmbAfiliado.SelectedItem!=afiliado)
            {
                afiliado = (string)cmbAfiliado.SelectedItem;
                cmbConsulta.Items.Clear();
                cmbConsulta.Text = "";
                //Filtra las consultas
                comando = "select * from NEXTGDD.filtrarConsultasPorAfiliado('"+id_persona+"','"+afiliado+"') order by consulta ASC";
                cargar(bdd.ObtenerLista(comando, "consulta"), cmbConsulta);
            }
            if (cmbConsulta.SelectedItem != null && (string)cmbConsulta.SelectedItem != consulta)
            {
                consulta = (string)cmbConsulta.SelectedItem;
                string[] fecha = consulta.Split(' ');
                txtFecha.Text = fecha[0];
                txtHora.Text = fecha[1];
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            fecha=txtFecha.Text;
            hora=txtHora.Text;
            verificarFecha(fecha,'/',warning1);
            verificarFecha(hora, ':', warning2);
            descripcion = txtDescripcion.Text;
            sintoma = (string)cmbSintoma.SelectedItem;
            enfermedad = (string)cmbEnfermedad.SelectedItem;
            if (consulta != null && consulta!=""  && fecha != null && hora != null && enfermedad!=null && sintoma!= null && warning1.Visible==false && warning2.Visible==false)
            {
                comando = "EXECUTE NEXTGDD.registrarDiagnostico @medico='" + id_persona + "',@fechaConsulta='" + convertirFecha(consulta) + "', @fechaAtencion='" + convertirFecha(fecha+' '+hora) + "', @enfermedad='" + enfermedad + "',@sintoma='"+sintoma+"',@descripcion='"+descripcion+"'";
                bdd.ExecStoredProcedure2(comando);

                MessageBox.Show("El diagnóstico se ingreso correctamente.", "Diagnostico", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmRegistroResultado NewForm = new frmRegistroResultado(rol,usuario,bdd);
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
                mes = '0' + mes;
            }
            string año = fechaSinTiempo.Split('/')[2];
            return año + "/" + mes + "/" + dia + " " + fecha.Split(' ')[1];
        }

        private void frmRegistroResultado_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms(rol, usuario, bdd);
            this.Hide();
            menuAbm.Show();
        }

        private void frmRegistroResultado_FormClosing(object sender, FormClosingEventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
