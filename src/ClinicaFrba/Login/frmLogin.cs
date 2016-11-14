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
   
        private SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016");

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

            conn.Open();

            SqlCommand command = new SqlCommand("NEXTGDD.login", conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parUser = new SqlParameter("@user", uname);
            SqlParameter parContra = new SqlParameter("@pass", upass);

            // numero para saber si esta habilitado o no 
            SqlParameter parNumero = new SqlParameter("@ret",retorno);
            parNumero.Direction = ParameterDirection.Output;

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
                    frmSeleccionarRol seleccion = new frmSeleccionarRol(nombreRoles,uname);
                    this.Hide();
                    seleccion.Show();
                }
                else
                {
                    frmMenuDeAbms elegiaccion = new frmMenuDeAbms(nombreRoles.ElementAt(0),uname);
                    this.Hide();
                    elegiaccion.Show();
                    Usuario.id_rol = nombreRoles.ElementAt(0);
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

           /*   
            {
                foreach (String nombre in nombreRoles)
                {
                    combo.Items.Add(nombre);
                }
            }
            else
            {
                // mostrar la pantalla del menu directo
            } */
        }

        private void cmdVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal principal = new frmVentanaPrincipal();
            this.Hide();
            principal.Show();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Realmente desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
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



