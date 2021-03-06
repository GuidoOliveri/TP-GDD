﻿using System;
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
        private string comando = "";
        private string profesional = "";
        private string especialidad = "";
        private string turno = "";//muestra fecha del turno
        private string bono = "";//nro bono
        private string horaLLegada = "";
        private string fechaLLegada = "";

        public frmRegistroLlegadaAfiliado()
        {
            InitializeComponent();

            cmbEspecialidad.Enabled = false;
            warning1.Visible = false;
            warning2.Visible = false;
            warning3.Visible = false;
            warning4.Visible = false;

            //SE CARGAN LOS PROF
            comando = "select (p.nombre+' '+p.apellido) as nombre from NEXTGDD.Persona p,NEXTGDD.Profesional pr where p.id_persona=pr.id_persona and pr.activo=1 order by p.nombre ASC";
            cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, "nombre"),cmbProfesional);

            //SE CARGAN LAS ESPEC
            comando = "select descripcion from NEXTGDD.Especialidad order by descripcion ASC";
            cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando,"descripcion"),cmbEspecialidad);

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
            warning1.Visible = false;
            warning2.Visible = false;
            if ((cmbProfesional.SelectedItem != null && (string) cmbProfesional.SelectedItem!=profesional && cmbEspecialidad.Enabled==false)
                || (cmbProfesional.SelectedItem != null && cmbEspecialidad.Enabled==true && (string)cmbProfesional.SelectedItem != profesional))
            {
                profesional = (string)cmbProfesional.SelectedItem;
                borrarTurno();
                /* FILTRA POR FECHA ACTUAL*/
                comando = "select * from NEXTGDD.buscarTurnosDelDia('"+profesional+"','"+convertirFecha(Clases.FechaSistema.fechaSistema)+"') order by fecha ASC";
                cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando,"fecha"), cmbTurno);
            }
            if (cmbEspecialidad.SelectedItem != null && (string) cmbEspecialidad.SelectedItem!=especialidad)
            {
                especialidad = (string) cmbEspecialidad.SelectedItem;
                cmbProfesional.Items.Clear();
                cmbProfesional.SelectedItem = null;
                profesional = "";
                borrarTurno();

                //Carga los profesionales según la especialidad
                comando = "select * from NEXTGDD.buscarProfesionales('" + especialidad + "') order by nombre ASC";
                cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando,"nombre"), cmbProfesional);
            }
            if (cmbTurno.SelectedItem !=null && (string)cmbTurno.SelectedItem!=turno)
            {
                turno = (string) cmbTurno.SelectedItem;
                borrarFecha();
                comando = "select NEXTGDD.validarUsoDelTurno('" + convertirFecha(turno) + "','" + profesional + "')";
                if (Clases.BaseDeDatosSQL.buscarCampo(comando)=="El turno no fue utilizado")
                {
                    borrarAfiliado();
                    comando = "select NEXTGDD.buscarAfiliadoTurno('"+convertirFecha(turno)+"','"+profesional+"')";
                    txtNroAfiliado.Text = Clases.BaseDeDatosSQL.buscarCampo(comando);
                    comando = "select * from NEXTGDD.buscarBonosDisponibles("+txtNroAfiliado.Text+") order by bono ASC";
                    cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, "bono"), cmbBono);
                    
                    txtFechaLlegada.Text = agregarCerosFecha(turno.Split(' ')[0]);
                    txtHoraLlegada.Text = turno.Split(' ')[1];
                }
                else
                {
                    warning1.Visible = true;
                    borrarAfiliado();
                }
                
            }
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
                mes = '0'+mes;
            }
            string año = fechaSinTiempo.Split('/')[2];
            return año + "/" + mes + "/" + dia + " " + fecha.Split(' ')[1];
        }

        private void rbBusqueda_Click(object sender, EventArgs e)
        {
            borrarTurno();
            cmbEspecialidad.Text = null;
            especialidad = "";
            profesional = "";
            cmbProfesional.Items.Clear();
            cmbProfesional.SelectedItem = null;
            if (cmbEspecialidad.Enabled == false)
            {
                rbBusqueda.Checked = true;
                cmbEspecialidad.Enabled = true;
            }
            else
            {
                rbBusqueda.Checked = false;
                //Carga de nuevo todos los profesionales
                comando = "select (p.nombre+' '+p.apellido) as nombre from NEXTGDD.Profesional pr,NEXTGDD.Persona p where p.id_persona=pr.id_persona and pr.activo=1 order by p.nombre ASC";
                cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, "nombre"),cmbProfesional);
                cmbEspecialidad.Enabled = false; 
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            warning2.Visible = false;
            warning3.Visible = false;
            warning4.Visible = false;
            bono = (string) cmbBono.SelectedItem;
            horaLLegada= txtHoraLlegada.Text;
            fechaLLegada = txtFechaLlegada.Text;
            verificarFecha(horaLLegada,':',warning3);
            verificarFecha(fechaLLegada, '/', warning4);
            if (warning3.Visible == false && warning4.Visible==false)
            {
                verificarLlegadaTarde();
            }
            if (cmbProfesional.SelectedItem != null && cmbTurno.SelectedItem != null && cmbBono.SelectedItem != null && horaLLegada != "" && warning2.Visible != true && warning4.Visible != true && warning3.Visible != true && warning1.Visible != true)
            {
                comando = "EXECUTE NEXTGDD.registrarConsulta @fechaLlegada='"+convertirFecha(fechaLLegada+' '+horaLLegada)+"',@nomProf='" + profesional + "', @fechaTurno='" +convertirFecha(turno) + "', @nroBono='" + bono+ "'";
                Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);

                comando = "select top 1 str(cod_consulta) from NEXTGDD.Consulta order by cod_consulta DESC";
                MessageBox.Show("La consulta se ha registrado correctamente \n Numero de consulta:  " + Clases.BaseDeDatosSQL.buscarCampo(comando), "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmRegistroLlegadaAfiliado NewForm = new frmRegistroLlegadaAfiliado();
                NewForm.Show();
                this.Dispose(false);

            }
            else
            {
                warning2.Visible = true;
            }

        }

        private string agregarCerosFecha(string fecha)
        {
            string dia = fecha.Split('/')[0];
            string mes = fecha.Split('/')[1];
            string año = fecha.Split('/')[2];
            if (dia.Length == 1)
            {
                dia = "0"+dia;
            }
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }
            return dia + '/'+mes +'/' +año ;
        }

        private void cargar(List<string> lista,ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }
        }

        private void verificarFecha(string str, char c, Label l)
        {
            string[] fechaPartida = str.Split(c);
            Boolean b = true;
            if (fechaPartida.Length == 3 && fechaPartida[0].Length == 2 && fechaPartida[1].Length == 2)
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
            //Se verifica que solo hayan numeros
            try
            {
                int.Parse(fechaPartida[0]);
                int.Parse(fechaPartida[1]);
                int.Parse(fechaPartida[2]);
            }
            catch
            {
                b = true;
            }
            l.Visible = b;
        }

        private void verificarLlegadaTarde()
        {
            if (DateTime.Parse(fechaLLegada + ' ' + horaLLegada) > DateTime.Parse(turno))
            {
                warning3.Text = "No se permiten llegadas tardes.";
                warning3.Visible = true;
            }
            else
            {
                warning3.Visible = false;
                warning3.Text = "Formato de fecha incorrecto.";
            }
        }

        private void borrarTurno()
        {
            warning1.Visible = false;
            cmbTurno.Items.Clear();
            cmbTurno.Text = "";
            borrarAfiliado();
            borrarFecha();
            turno = "";
        }

        private void borrarAfiliado()
        {
            txtNroAfiliado.Text = "";
            cmbBono.Items.Clear();
            cmbBono.Text = "";
            bono = "";
        }

        private void borrarFecha()
        {
            txtFechaLlegada.Text = "";
            txtHoraLlegada.Text = "";
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

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro que desea volver? Se perderán los datos.", "Volver al Menu", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms();
                this.Hide();
                menuAbm.Show();
            }
        }

        private void frmRegistroLlegadaAfiliado_FormClosing(object sender, FormClosingEventArgs e)
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
