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
            try
            {
                if (txtUsuario.Text != "" && txtPassword.Text != "")
                {
                    Usuario user = new Usuario(txtUsuario.Text);
                    if ((user.Codigo_Persona != -1 && user.Codigo_Persona != 0) || (user.Codigo_Persona == -1 && (txtUsuario.Text == "admin" || txtUsuario.Text == "administrador")))
                    {

                        //comienza el hasheo de la pass
                        UTF8Encoding encoderHash = new UTF8Encoding();
                        SHA256Managed hasher = new SHA256Managed();
                        byte[] bytesDeHasheo = hasher.ComputeHash(encoderHash.GetBytes(txtPassword.Text));
                        string pass = bytesDeHasheoToString(bytesDeHasheo);

                        if (!user.Password.Equals(pass))
                        {
                            //ACTUALIZAR CANT FALLIDOS
                            user.ActualizarFallidos(); MessageBox.Show("Usuario y contraseña no validos", "Error!", MessageBoxButtons.OK);
                        }
                        else 
                        {
                            //VALIDAR EL USER
                            if (!user.Activo)
                            {
                                MessageBox.Show("Usuario inactivo para acceder al sistema", "Error!", MessageBoxButtons.OK);
                            }
                            else
                            {
                                //SETEO LOS FALLIDOS EN 0 PORQUE ENTRO
                                user.ReiniciarFallidos();

                                //INGRESO AL FORM PRINCIPAL,LE PASO EL USER ID ASI SABE QUE FUNCIONALIDADES MOSTRAR
                                frmVentanaPrincipal formPrincipal = new frmVentanaPrincipal();
                                formPrincipal.User = user;
                                this.Hide();
                                formPrincipal.Show();
                            }
                        }
                    }
                    else { MessageBox.Show("Usuario y contraseña no validos", "Error!", MessageBoxButtons.OK); }
                }
                else
                {   MessageBox.Show("Complete todos los campos", "Error!", MessageBoxButtons.OK);}
            }
            catch
            { MessageBox.Show("Usuario y contraseña no validos", "Error!", MessageBoxButtons.OK);}
        }

        //funcion para transformar lo hasheado a string
        private string bytesDeHasheoToString(byte[] array)
        {
            StringBuilder salida = new StringBuilder("");
            for (int i = 0; i < array.Length; i++)
            {
                salida.Append(array[i].ToString("X2"));
            }
            return salida.ToString();
        }
    }
}
