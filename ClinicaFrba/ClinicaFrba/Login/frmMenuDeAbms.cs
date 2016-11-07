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

        private void cmdAbmRol_Click(object sender, EventArgs e)
        {
            AbmRol.frmElegirAccionRol rol = new AbmRol.frmElegirAccionRol();
            this.Hide();
            rol.Show();
        }

        private void btnEjecutar_OnClick(object sender, EventArgs e)
        {
            funcionalidad = (string)cmbFuncionalidades.SelectedItem;
            if (funcionalidad != null)
            {
                if (funcionalidad == "Pedido de turno")
                {
                    Pedir_Turno.frmSeleccionDeTurno func = new Pedir_Turno.frmSeleccionDeTurno(bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "ABM de roles")
                {
                    Pedir_Turno.frmSeleccionDeTurno func = new Pedir_Turno.frmSeleccionDeTurno(bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "ABM de afiliados")
                {
                    Pedir_Turno.frmSeleccionDeTurno func = new Pedir_Turno.frmSeleccionDeTurno(bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "ABM de profesionales")
                {
                    Pedir_Turno.frmSeleccionDeTurno func = new Pedir_Turno.frmSeleccionDeTurno(bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "ABM de usuarios")
                {
                    Pedir_Turno.frmSeleccionDeTurno func = new Pedir_Turno.frmSeleccionDeTurno(bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "ABM de especialidades medicas")
                {
                    Pedir_Turno.frmSeleccionDeTurno func = new Pedir_Turno.frmSeleccionDeTurno(bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "ABM de planes")
                {
                    Pedir_Turno.frmSeleccionDeTurno func = new Pedir_Turno.frmSeleccionDeTurno(bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "Compra de bonos")
                {
                    Pedir_Turno.frmSeleccionDeTurno func = new Pedir_Turno.frmSeleccionDeTurno(bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "Registrar agenda profesional")
                {
                    Registrar_Agenda_Medico.frmRegistrarAgendaMedico func = new Registrar_Agenda_Medico.frmRegistrarAgendaMedico(bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "Registro de llegada para atencion medica")
                {
                    Registro_Llegada.frmRegistroLlegadaAfiliado func = new Registro_Llegada.frmRegistroLlegadaAfiliado(bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "Registro de resultado para atencion medica")
                {
                    Registro_Resultado.frmRegistroResultado func = new Registro_Resultado.frmRegistroResultado(bdd,usuario);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "Cancelar atencion medica")
                {
                    Pedir_Turno.frmSeleccionDeTurno func = new Pedir_Turno.frmSeleccionDeTurno(bdd);
                    this.Hide();
                    func.Show();
                }
                if (funcionalidad == "Consultar listado estadistico")
                {
                    Pedir_Turno.frmSeleccionDeTurno func = new Pedir_Turno.frmSeleccionDeTurno(bdd);
                    this.Hide();
                    func.Show();
                }
            }
        }

        private void frmMenuDeAbms_Load(object sender, EventArgs e)
        {

        }
    }
}
