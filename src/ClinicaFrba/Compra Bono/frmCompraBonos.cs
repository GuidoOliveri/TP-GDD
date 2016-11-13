﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ClinicaFrba.Compra_Bono
{
    public partial class frmCompraBonos : Form
    {
        private string rol = "";
        private string usuario = "";
        private Clases.BaseDeDatosSQL bdd;
        private string idAfiliado = "";


        public frmCompraBonos(string rol, string usuario, Clases.BaseDeDatosSQL bdd)
        {
            InitializeComponent();
            this.rol = rol;
            this.usuario = usuario;
            this.bdd = bdd;

            if(rol.Equals("Administrativo")){
                txtNumeroAfiliado.Visible = true;
                lblNumeroAfiliado.Visible = true;
            }
            else if (rol.Equals("Afiliado"))
            {
                idAfiliado = "124453901"; // Debe ser cargado del afiliado si 
                txtPrecioBono.Text = obtenerPrecioBono(txtNumeroAfiliado.Text);

            }

        }

        private String obtenerPrecioBono(string afiliado)
        {
            String queryString = "SELECT precio_bono_consulta FROM NEXTGDD.Afiliado RIGHT JOIN NEXTGDD.Plan_Medico ON Afiliado.cod_plan = Plan_Medico.cod_plan WHERE Afiliado.nro_afiliado ='" + txtNumeroAfiliado.Text + "'";
            return bdd.buscarCampo(queryString);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

     
        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms(rol, usuario, bdd);
            this.Hide();
            menuAbm.Show();
        }

        private void frmCompraBonos_FormClosing(object sender, FormClosingEventArgs e)
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


        private void txtCantBonos_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void btnCargarAfiliado_Click(object sender, EventArgs e)
        {
            try
            {
                idAfiliado = txtNumeroAfiliado.Text;
                txtPrecioBono.Text = obtenerPrecioBono(idAfiliado);
            }
            catch 
            {
                MessageBox.Show("No Se Encontro al afiliado", "Buscar Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            String comando;

            comando = "select cod_plan from NEXTGDD.Afiliado where nro_afiliado = '" + idAfiliado + "'";
            String plan = bdd.buscarCampo(comando);

            //String fecha = System.Configuration.ConfigurationSettings.AppSettings["date"];

            // Crear Bonos por 
            for (int i = 0; i < cantBonosUpDown.Value; i++)
            {
                comando = "EXECUTE NEXTGDD.comprarBono @fechaImpresion='" + convertirFecha("7/11/2016") + "', @compraFecha='" + convertirFecha("7/11/2016") + "', @codPlan='" + plan + "', @nroAfiliado=" + idAfiliado + "'";
                bdd.ExecStoredProcedure2(comando);
            }


            // Registrar la compra
            comando = "EXECUTE NEXTGDD.registrarCompra @cant='" + cantBonosUpDown.Value + "', @idAfiliado='" + idAfiliado + "', @precioTotal='" + lblTotalAPagar.Text + "'";
            bdd.ExecStoredProcedure2(comando);

            MessageBox.Show("Compra completada con exito!", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }

        private void cantBonos_ValueChanged(object sender, EventArgs e)
        {
            if (cantBonosUpDown.Value == 0)
            {
                lblTotalAPagar.Text = "0.00";
            }
            else
            {
                lblTotalAPagar.Text = (cantBonosUpDown.Value * int.Parse(lblPrecioBonos.Text)).ToString();
               
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
                mes = '0' + mes;
            }
            string año = fechaSinTiempo.Split('/')[2];
            return año + "/" + mes + "/" + dia + " " + fecha.Split(' ')[1];
        }
    }
}
