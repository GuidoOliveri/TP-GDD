﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.Clases;
using ClinicaFrba.Abm_Afiliado;
using System.Data.SqlClient;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class frmAltaAfiliado : Form
    {
        private string rol = "";
        private string usuario = "";
        private Clases.BaseDeDatosSQL bdd;
        private string comando = "";
        private string plan = "";
        private string estadoCivil = "";
        private string tipoDoc = "";
        private SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016");
        Int64 nroDoc;
         
        Int64 nroAfiliado;

        string nombre;
        string apellido ;
        char opcionSexo;  
        string direccion ;
        int telefono ;
           
        string mail;
        int cantFam ;
        Int64 retorno ;

        DateTime fechaF;

        public frmAltaAfiliado(string rol, string usuario, Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();
            this.rol = rol;
            this.usuario = usuario;
            this.bdd = bdd;
            plan = (string)cmbPlanMedico.SelectedItem;

            comando = "select distinct descripcion from NEXTGDD.Plan_Medico";
            cargar(bdd.ObtenerLista(comando, "descripcion"), cmbPlanMedico);

           // btnRegistrar.Click += new EventHandler(btnRegistrar_Click);
        }

        private void cargar(List<string> lista, ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }
        }

        public String Operacion { get; set; }
        //public Afiliado Afiliado { get; set; }
        public String Miembro { get; set; }
        //public Afiliado nuevoAfil { get; set; }

        private void cargarTodoLimpio()
        {
            // limpio txt
            txtNombre.Clear();
            txtApellido.Clear();
            txtCantFam.Clear();
            txtMail.Clear();
            txtNroDoc.Clear();
            txtTel.Clear();
            txtDir.Clear();
            // limpio combo box
            cmbEstadoCivil.SelectedIndex = -1;
            cmbTipoDoc.SelectedIndex = -1;
            cmbPlanMedico.SelectedIndex = -1;

            //limpio radio button
            optMasculino.Checked = false;
            optFemenino.Checked = false;

            dtpFecNac.ResetText();

        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cargarTodoLimpio();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtTel.Text) || String.IsNullOrEmpty(txtNroDoc.Text) || String.IsNullOrEmpty(txtDir.Text) || String.IsNullOrEmpty(txtCantFam.Text) || (cmbEstadoCivil.Items.Count <= 0) ||  (cmbTipoDoc.Items.Count <= 0) ||( cmbPlanMedico.Items.Count <= 0) ||( ( optMasculino.Checked = false) &&  (optFemenino.Checked = false) ))
            {
                MessageBox.Show("Por favor, Ingrese datos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cargarTodoLimpio();
            }
            else{
             nroAfiliado = 0;

             nombre = txtNombre.Text;
             apellido = txtApellido.Text;
          
            tipoDoc = (string)cmbTipoDoc.SelectedItem;
             nroDoc = Convert.ToInt64(txtNroDoc.Text);
            direccion = txtDir.Text;
             telefono = Convert.ToInt32(txtTel.Text);
            estadoCivil = (string)cmbEstadoCivil.SelectedItem;
            mail = txtMail.Text;
           cantFam = Convert.ToInt32(txtCantFam.Text);
            plan = (string)cmbPlanMedico.SelectedItem;
            retorno = 0;

            if(optMasculino.Checked == true){
                opcionSexo = 'H';
            } else
            {
                opcionSexo = 'M';
            }
            /*
                        if (txtNombre.Text == null || txtApellido.Text == null || txtNroDoc.Text == null || int.Parse(txtNroDoc.Text) <= 0 || txtDir.Text == null || txtTel.Text == null || txtMail.Text == null || txtCantFam.Text == null || int.Parse(txtCantFam.Text) < 0 || plan == null || tipoDoc == null || estadoCivil == null || !validarEmail(txtMail.Text))
                        {
                            MessageBox.Show("Todos los campos no estan llenos correctamente o estan vacios", "Alta afiliado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {*/
            //aca tengo que enganchar el stored procedure de lo que hace el afiliado
                    conn.Open();
                    SqlCommand command = new SqlCommand("NEXTGDD.agregarAfiliadoPrincipal", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    //int estadoCivil2 = 1;
                    //int plan2 = 555555;
                  //  DateTime fechaF = DateTime.Parse(dtpFecNac.Text.ToString());              //Convert.ToDateTime(SqlDbType.Date).Date;
            //        DateTime fechaF = Convert.ToDateTime(dtpFecNac.Value).Date;   
          //      DateTime.Parse(dtpFechaNacimiento.Text.ToString())
                //Fecha.ToShortDateString();
                    SqlParameter parNombre = new SqlParameter("@nombre", nombre );                
                    SqlParameter parApellido = new SqlParameter("@apellido", apellido);
                    SqlParameter parFecNac = new SqlParameter("@fecha_nac", SqlDbType.Date);
                    SqlParameter parSexo = new SqlParameter("@sexo", opcionSexo );
                    SqlParameter parTipoDoc = new SqlParameter("@tipo_doc", tipoDoc);
                    SqlParameter parNroDoc = new SqlParameter("@nrodocumento", nroDoc);
                    parNroDoc.Direction = ParameterDirection.Input;
                    parNroDoc.SqlDbType = SqlDbType.Decimal;
                    SqlParameter parDomicilio = new SqlParameter("@domicilio", direccion);
                    SqlParameter parTel = new SqlParameter("@telefono", telefono);
                    SqlParameter parEstadoCivil = new SqlParameter("@estado_civil", estadoCivil);
                    SqlParameter parMail = new SqlParameter("@mail", mail);
                    SqlParameter parCantFam = new SqlParameter("@cant_familiares",cantFam);
                    SqlParameter parCodMedico = new SqlParameter("@cod_medico",plan);
                    SqlParameter parRet = new SqlParameter("@ret", retorno);

                    parRet.Direction = ParameterDirection.Output;
                    parRet.SqlDbType = SqlDbType.Decimal;
                    parFecNac.Value = dtpFecNac.Value;

                    command.Parameters.Add(parNombre);
                    command.Parameters.Add(parApellido);
                    command.Parameters.Add(parFecNac);
                    command.Parameters.Add(parSexo);
                    command.Parameters.Add(parTipoDoc);
                    command.Parameters.Add(parNroDoc);
                    command.Parameters.Add(parDomicilio);
                    command.Parameters.Add(parTel);
                    command.Parameters.Add(parEstadoCivil);
                    command.Parameters.Add(parMail);
                    command.Parameters.Add(parCantFam);
                    command.Parameters.Add(parCodMedico);
                    command.Parameters.Add(parRet);

                    command.ExecuteNonQuery();
                   // SqlDataReader dr = command.ExecuteReader();
                    //dr.Read();
                    //dr.Close();

                    Int64 resu = Int64.Parse(command.Parameters["@ret"].Value.ToString());
                    conn.Close();
                    if (resu.Equals(-1))
                    {
                        cargarTodoLimpio();
                        MessageBox.Show("Lo sentimos, no podemos procesar tu solicitud. Inténtalo de nuevo más tarde.", "Alta Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cargarTodoLimpio();
                    }
                    else 
                    {
                        nroAfiliado = resu;

                        MessageBox.Show( "Registrado exitosamente!\nTu nro de afiliado es:  " + nroAfiliado+"\nNombre de usuario:  " + nroAfiliado +"@NEXTGDD"+  "\nContraseña:  " + nroAfiliado, "AltaAfiliado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarTodoLimpio();
                    }
                  
          }

        }

        private void pnlDatosPersonales_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void cboEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms abm = new Login.frmMenuDeAbms(rol,usuario,bdd);
            this.Hide();
            abm.Show();
        }

        private void btnHijo_Click(object sender, EventArgs e)
        {

        }

        private void btnConyuge_Click(object sender, EventArgs e)
        {

        }



        public DateTime Today { get; set; }

        private void frmAltaAfiliado_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cmdAsociarAfiliado_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtTel.Text) || String.IsNullOrEmpty(txtNroDoc.Text) || String.IsNullOrEmpty(txtDir.Text) || String.IsNullOrEmpty(txtCantFam.Text) || (cmbEstadoCivil.Items.Count <= 0) || (cmbTipoDoc.Items.Count <= 0) || (cmbPlanMedico.Items.Count <= 0) || ((optMasculino.Checked = false) && (optFemenino.Checked = false)))
            {
                MessageBox.Show("Por favor, Ingrese datos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cargarTodoLimpio();
            }
            else
            {
                nroAfiliado = 0;
                fechaF = dtpFecNac.Value;      
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                tipoDoc = (string)cmbTipoDoc.SelectedItem;
                nroDoc = Convert.ToInt64(txtNroDoc.Text);
                direccion = txtDir.Text;
                telefono = Convert.ToInt32(txtTel.Text);
                estadoCivil = (string)cmbEstadoCivil.SelectedItem;
                mail = txtMail.Text;
                cantFam = Convert.ToInt32(txtCantFam.Text);
                plan = (string)cmbPlanMedico.SelectedItem;
                retorno = 0;

                if (optMasculino.Checked == true)
                {
                    opcionSexo = 'H';
                }
                else
                {
                    opcionSexo = 'M';
                }


                if (plan != null)
                {
                    MessageBox.Show("El afiliado tendra el plan medico del grupo familiar al que se asocie", "Alta Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 
                }
               

                    frmAsociarAfiliado asocio = new frmAsociarAfiliado(rol, usuario, bdd, nombre, apellido, tipoDoc, nroDoc, direccion, telefono, estadoCivil, mail, fechaF, opcionSexo, cantFam);
                    this.Hide();
                    asocio.Show();
                    
                
                /*if ()
                {
                    MessageBox.Show("bien", "Mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("mail", "Mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }*/
            }
        }
        

        /////// valido lo que no puede ingresar en el campo ////////

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsSymbol(e.KeyChar)){
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (char.IsPunctuation(e.KeyChar)){
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras y numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo letras y numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool validarEmail(string email)
        {
            bool validar = false;
            int analizar = email.IndexOf("@");
            if (analizar > 0)
            {
                if (email.IndexOf("@", analizar + 1) > 0)
                {
                    return validar;
                }
                int a = email.IndexOf(".",analizar);
                if (a - 1 > analizar)
                {
                    if (a + 1 < email.Length)
                    {
                        string r = email.Substring(a + 1, 1);
                        if (r != ".")
                        {
                            validar = true;
                        }
                    }
                }
            }
            return validar;
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {

        }

        private void txtCantFam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo cantidad en numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo cantidad en numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo cantidad en numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo cantidad en numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAltaAfiliado_Load(object sender, EventArgs e)
        {

        }
    }
}
