﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class frmModificarAfiliado : Form {
        
        private string comando = "";
        private string rol = "";
        private string usuario = "";
        Clases.BaseDeDatosSQL bdd;

        int idAfiliado;

        private String direccion = "";
        private String telefono = "";
        private String mail = "";

        public frmModificarAfiliado(string rol, string usuario, Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();

            this.rol = rol;
            this.usuario = usuario;
            this.bdd = bdd; 

            this.idAfiliado = 27281; //hardcodeado, despues vemos 

            int idPersona = 1123960; // Hardcode de prueba
            comando = "select * from GD2C2016.NEXTGDD.Persona where id_persona ="+idPersona;
            System.Collections.ArrayList persona = this.bdd.obtenerRow(comando);

            lblNombreAfiliado.Text = persona[1].ToString() +" "+ persona[2].ToString();
            direccion = (string)persona[3];
            telefono = persona[4].ToString();
            mail = (string)persona[5];

            txtDir.Text = direccion;
            txtMail.Text = mail;
            txtTel.Text = telefono;
            
            
        }

        private void frmModificarAfiliado_Load(object sender, EventArgs e)
        {
            
        }

        private void pnlModDatosPersonales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDir.Text != direccion)
            {
                comando = "EXECUTE NEXTGDD.modificar_Afiliado_Domic @id='" + idAfiliado + "',@nuevo_dom='" + txtDir.Text;
                bdd.ExecStoredProcedure2(comando);
                MessageBox.Show("Actualizacion exitosa!", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (txtTel.Text != telefono)
            {
                comando = "EXECUTE NEXTGDD.modificar_Afiliado_Telef @id='" + idAfiliado + "',@nuevo_nuevo_telef='" + txtTel.Text;
                bdd.ExecStoredProcedure2(comando);
                MessageBox.Show("Actualizacion exitosa!", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (txtMail.Text != mail)
            {
                comando = "EXECUTE NEXTGDD.modificar_Afiliado_Mail @id='" + idAfiliado + "',@nuevo_mail='" + txtDir.Text;
                bdd.ExecStoredProcedure2(comando);
                MessageBox.Show("Actualizacion exitosa!", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmBuscarAfiliado buscar = new frmBuscarAfiliado(rol,usuario,bdd);
            this.Hide();
            buscar.Show();
        }

        private void txtDir_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmModificarAfiliado_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
