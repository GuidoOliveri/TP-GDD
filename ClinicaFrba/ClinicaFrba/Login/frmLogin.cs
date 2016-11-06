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

namespace ClinicaFrba.Login
{
    public partial class frmLogin : Form
    {
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

            int resu = Int32.Parse(parNumero.Value.ToString());
           
            if (resu.Equals(0))
            {
                MessageBox.Show("Logueo exitoso! Entrando al sistema...", "Logueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMenuDeAbms elegiaccion = new frmMenuDeAbms();
                this.Hide();
                elegiaccion.Show();
            }
            else if (resu.Equals(-1))
            {
                MessageBox.Show("Quedaste inhabilitado por fallar 3 veces la contraseña o no existe el usuario", "Logueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(resu.Equals(-2))
            {
                MessageBox.Show("Usuario o contrasenia incorrecta", "Logueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dr.Close();
            conn.Close();

           /* String query = "SELECT  R_U.nombre as nom FROM NEXTGDD.Usuario_X_Rol R_U, NEXTGDD.Rol R, NEXTGDD.Usuario U WHERE R_U.id_rol = R.id_rol AND U.username = @user AND U.username = R_U.username ";

            SqlCommand command = new SqlCommand(query , conn);

            SqlDataReader dr = command.ExecuteReader();
            List<String> nombreRoles = new List<string>();
            while (dr.Read()) nombreRoles.Add(dr.GetString(0));
            if (nombreRoles.Count > 1)
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
    }
}



