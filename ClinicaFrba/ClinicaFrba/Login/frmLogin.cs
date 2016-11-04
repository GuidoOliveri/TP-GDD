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
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string cadenaConex = "Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016";
            
            SqlConnection conn = new SqlConnection(cadenaConex);
            
            SqlCommand command = new SqlCommand("NEXTGDD.login", conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter pUsuario = new SqlParameter("@user",SqlDbType.VarChar);
            pUsuario.Direction = ParameterDirection.Input;
            command.Parameters.Add(pUsuario);

            SqlParameter pContrasenia = new SqlParameter("@pass", SqlDbType.VarChar);
            pContrasenia.Direction = ParameterDirection.Input;
            command.Parameters.Add(pContrasenia);

            pUsuario.Value = txtUsuario.Text;
            pContrasenia.Value = txtPassword.Text;

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Usuario correcto", "Aviso", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario incorrecto o inabilitado para acceder al sistema", "Error!", MessageBoxButtons.OK);
            }
        }
            
    }
}
