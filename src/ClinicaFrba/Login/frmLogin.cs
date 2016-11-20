using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaFrba.Clases;
using System.Security.Cryptography;
using System.Data.SqlClient;
using ClinicaFrba.AbmRol;

namespace ClinicaFrba.Login
{
    public partial class frmLogin : Form
    {
        private string query = "";
        
        public frmLogin()
        {
            InitializeComponent();
            warning.Visible = false;
        }

        private SqlConnection conn; 

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            string uname = txtUsuario.Text;
            string upass = txtPassword.Text;
            int retorno=0;

            if (uname == "" || uname == null || upass == "" || upass == "")
            {
                warning.Visible = true;
                return;
            }
            conn = BaseDeDatosSQL.ObtenerConexion();
            //conn.Open();
            //List<String> campos = new List<string>();
            //campos.Add("@user", uname);
            //campos.Add(@pass", upass); 
            //List<SqlParameter> misParametros = new List<SqlParameter>();

            //misParametros.Add(new SqlParameter("@user", uname));
            //misParametros.Add(new SqlParameter("@Password", upass));

     

            //misParametros.Add(new SqlParameter("@ret", retorno));


            //decimal resul= BaseDeDatosSQL.ExecStoredProcedure("NEXTGDD.login", misParametros);
            
            SqlCommand command = new SqlCommand("NEXTGDD.login", conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parUser = new SqlParameter("@user", uname);
            SqlParameter parContra = new SqlParameter("@pass", upass);
            SqlParameter parNumero = new SqlParameter("@ret", retorno);
            parNumero.Direction = ParameterDirection.Output;
             //numero para saber si esta habilitado o no 
          
            command.Parameters.Add(parNumero);
            command.Parameters.Add(parUser);
            command.Parameters.Add(parContra);

            
            SqlDataReader dr = command.ExecuteReader();
            dr.Read();
            dr.Close();

            int resu = Int32.Parse(parNumero.Value.ToString());
           
            if (resu.Equals(0))
            {
                MessageBox.Show("Logueo exitoso! Entrando al sistema...", "Logueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Usuario.Name = txtUsuario.Text;
                // para que me de el nombre del rol, lo busco yo, no me lo devuelve en el stored procedure 
                query = "SELECT  R.nombre as nom FROM NEXTGDD.Usuario_X_Rol R_U, NEXTGDD.Rol R, NEXTGDD.Usuario U WHERE R_U.id_rol = R.id_rol AND U.username = @user AND U.username = R_U.username ";
               
                SqlCommand comandito = new SqlCommand(query, conn);
               
                SqlParameter parametroUsuario = new SqlParameter("@user", uname);
                
                comandito.Parameters.Add(parametroUsuario);
               
                SqlDataReader dataReader = comandito.ExecuteReader();

                List<String> nombreRoles = new List<string>();
                while (dataReader.Read()) nombreRoles.Add(dataReader.GetString(0));
                if (nombreRoles.Count > 1)
                {
                    frmSeleccionarRol seleccion = new frmSeleccionarRol(nombreRoles);
                    this.Hide();
                    seleccion.Show();
                }
                else if (nombreRoles.Count == 1)
                {
                    Clases.Usuario.id_rol = nombreRoles.ElementAt(0);
                    frmMenuDeAbms elegiaccion = new frmMenuDeAbms();
                    this.Hide();
                    elegiaccion.Show();
                }
                else
                {
                    MessageBox.Show("No tienes ningun Rol asignado", "Logueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               


                dataReader.Close();
            }
            else if (resu.Equals(-1))
            {
                MessageBox.Show("Quedaste inhabilitado por fallar 3 veces la contraseña o no existe el usuario", "Logueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(resu.Equals(-2))
            {
                MessageBox.Show("Usuario o contrasenia incorrecta", "Logueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            conn.Close();
         
        }

        private void cmdVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal principal = new frmVentanaPrincipal();
            this.Hide();
            principal.Show();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}



