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

        private SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2016;Persist Security Info=True;User ID=gd;Password=gd2016");

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            conn.Open();
            string uname = txtUsuario.Text;
            string upass = txtPassword.Text;

            SqlCommand command = new SqlCommand("NEXTGDD.login", conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parUser = new SqlParameter("@user",uname);
            SqlParameter parContra = new SqlParameter("@pass", upass);

            command.Parameters.Add(parUser);
            command.Parameters.Add(parContra);

            SqlDataReader dr = command.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                MessageBox.Show("Logueo exitoso! Entrando al sistema...", "Logueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AbmRol.frmElegirAccionRol elegiaccion = new AbmRol.frmElegirAccionRol();
                this.Hide();
                elegiaccion.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contrasenia incorrecta", "Logueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
            
    }
}
