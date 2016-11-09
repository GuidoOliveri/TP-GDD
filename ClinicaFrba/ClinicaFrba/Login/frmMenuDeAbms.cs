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
    public partial class frmMenuDeAbms : Form
    {
        private string rol="";
        private string usuario="";
        private Clases.BaseDeDatosSQL bdd;
        private string comando = "";
        private string funcionalidad = "";

        public frmMenuDeAbms(string rol,string usuario,Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();

            this.rol = rol;
            this.usuario = usuario;
            this.bdd = bdd;

            comando = "select distinct f.nombre as funcionalidad from NEXTGDD.Funcionalidad f,NEXTGDD.Funcionalidad_X_Rol fr,NEXTGDD.Rol r where r.nombre LIKE '"+rol+"' and fr.id_rol=r.id_rol and fr.id_funcionalidad=f.id_funcionalidad";
            cargar(bdd.ObtenerLista(comando,"funcionalidad"),cmbFuncionalidades);

            btnEjecutar.Click += new EventHandler(btnEjecutar_OnClick);

        }

        public frmMenuDeAbms()
        {
            // TODO: Complete member initialization
        }

        private void cargar(List<string> lista, ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }
        }

        private void cmdLogueo_Click(object sender, EventArgs e)
        {
           frmLogin logueo = new frmLogin(bdd);
           this.Hide();
           logueo.Show();
        }



        private void btnEjecutar_OnClick(object sender, EventArgs e)
        {
            funcionalidad = (string)cmbFuncionalidades.SelectedItem;
            if (funcionalidad != null)
            {
                if (funcionalidad == "Pedido de turno")
                {
                    Pedir_Turno.frmSeleccionDeTurno func = new Pedir_Turno.frmSeleccionDeTurno(rol,usuario,bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "ABM de roles")
                {
                    AbmRol.frmElegirAccionRol func = new AbmRol.frmElegirAccionRol(rol, usuario,bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "ABM de afiliados")
                {
                    Abm_Afiliado.frmPrincipalAfiliado func = new Abm_Afiliado.frmPrincipalAfiliado(rol,usuario,bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "ABM de profesionales")
                {
                    MessageBox.Show("ABM Profesionales no tiene implementacion", "ABMs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (funcionalidad == "ABM de usuarios")
                {
                    MessageBox.Show("ABM Usuarios no tiene implementacion", "ABMs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (funcionalidad == "ABM de especialidades medicas")
                {
                    MessageBox.Show("ABM Especialidades Medicas no tiene implementacion", "ABMs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (funcionalidad == "ABM de planes")
                {
                    MessageBox.Show("ABM Planes no tiene implementacion", "ABMs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (funcionalidad == "Compra de bonos")
                {
                    Compra_Bono.frmCompraBonos func = new Compra_Bono.frmCompraBonos(rol,usuario,bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "Registrar agenda profesional")
                {
                    Registrar_Agenda_Medico.frmRegistrarAgendaMedico func = new Registrar_Agenda_Medico.frmRegistrarAgendaMedico(rol,usuario,bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "Registro de llegada para atencion medica")
                {
                    Registro_Llegada.frmRegistroLlegadaAfiliado func = new Registro_Llegada.frmRegistroLlegadaAfiliado(rol,usuario,bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "Registro de resultado para atencion medica")
                {
                    Registro_Resultado.frmRegistroResultado func = new Registro_Resultado.frmRegistroResultado(rol,usuario,bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "Cancelar atencion medica")
                {
                    Cancelar_Atencion.frmCancelarAtencionMedico func = new Cancelar_Atencion.frmCancelarAtencionMedico(rol,usuario,bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "Consultar listado estadistico")
                {
                    Listados.frmListado func = new Listados.frmListado(rol,usuario,bdd);
                    this.Hide();
                    func.Show();
                }
            }
        }

        private void frmMenuDeAbms_Load(object sender, EventArgs e)
        {

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {

        }

        private void cmbFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMenuDeAbms_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Realmente desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
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
