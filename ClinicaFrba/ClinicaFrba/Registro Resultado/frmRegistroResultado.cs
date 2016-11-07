﻿using System;
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
        private Clases.BaseDeDatosSQL bdd;
        private string comando = "";
        private string consulta = "";
        private string afiliado = ""; //para filtrar
        private string fecha = "";
        private string hora = "";
        private string sintoma = "";
        private string enfermedad = "";
        private string descripcion = "";

        private string usuario = "";
        private string id_persona = ""; 

        public frmRegistroResultado(Clases.BaseDeDatosSQL bdd,string usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
            this.bdd = bdd;
            comando = "select u.id_persona as id from NEXTGDD.Usuario u where u.username LIKE '"+usuario+"'";
            id_persona = bdd.buscarCampo(comando);

            warning1.Visible = false;
            warning2.Visible = false;
            warning3.Visible = false;
            cmbAfiliado.Enabled = false;

            //Habria que filtrar por fecha actual
            comando = "select t.fecha as consulta from NEXTGDD.Profesional pr,NEXTGDD.Consulta c,NEXTGDD.Turno t,NEXTGDD.Agenda a where pr.id_persona LIKE '"+id_persona+"' and pr.matricula=a.matricula and c.nro_turno=t.nro_turno and t.cod_agenda=a.cod_agenda";
            cargar(bdd.ObtenerLista(comando,"consulta"),cmbConsulta);

            comando = "select p.nombre+' '+p.apellido as nombre from NEXTGDD.Afiliado a,NEXTGDD.Persona p,NEXTGDD.Profesional pr,NEXTGDD.Turno t,NEXTGDD.Agenda ag where p.id_persona=a.id_persona and t.nro_afiliado=a.nro_afiliado and t.cod_agenda=ag.cod_agenda and pr.matricula=ag.matricula and pr.id_persona LIKE '"+id_persona+"' group by p.nombre,p.apellido order by p.nombre ASC";
            cargar(bdd.ObtenerLista(comando, "nombre"), cmbAfiliado);

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
            }
            else
            {
                cmbConsulta.Items.Clear();
                cmbConsulta.Text = "";
                //Filtra las consultas
                comando = "select (p.nombre+' '+p.apellido) as nombre from NEXTGDD.Afiliado a,NEXTGDD.Persona p,NEXTGDD.Profesional pr,NEXTGDD.Turno t,NEXTGDD.Agenda ag where p.id_persona=a.id_persona and t.nro_afiliado=a.nro_afiliado and t.cod_agenda=ag.cod_agenda and pr.matricula=ag.matricula and pr.id_persona LIKE '" + id_persona + "' group by p.nombre,p.apellido order by p.nombre ASC";
                cargar(bdd.ObtenerLista(comando, "nombre"), cmbConsulta);
                cmbConsulta.Enabled = false;
            }

        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        { 
            if(cmbAfiliado.SelectedItem!=null && (string)cmbAfiliado.SelectedItem!=afiliado)
            {
                afiliado = (string)cmbAfiliado.SelectedItem;
                cmbConsulta.Items.Clear();
                cmbConsulta.Text = "";
                comando = "select t.fecha as consulta from NEXTGDD.Profesional pr,NEXTGDD.Consulta c,NEXTGDD.Turno t,NEXTGDD.Agenda a,NEXTGDD.Afiliado af,NEXTGDD.Persona p where pr.id_persona LIKE '"+id_persona+"' and pr.matricula=a.matricula and c.nro_turno=t.nro_turno and t.cod_agenda=a.cod_agenda and t.nro_afiliado=af.nro_afiliado and af.id_persona=p.id_persona and (p.nombre+' '+p.apellido) LIKE '"+afiliado+"' group by t.fecha order by t.fecha ASC";
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

                frmRegistroResultado NewForm = new frmRegistroResultado(bdd,usuario);
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
    }
}
