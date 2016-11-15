using System;
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
        private string idAfiliado = "";


        public frmCompraBonos(string rol, string usuario)
        {
            InitializeComponent();
            this.rol = rol;
            this.usuario = usuario;

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
            return Clases.BaseDeDatosSQL.buscarCampo(queryString);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

     
        private void cmdVolver_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms(rol, usuario);
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
            String plan = Clases.BaseDeDatosSQL.buscarCampo(comando);

            //String fecha = System.Configuration.ConfigurationSettings.AppSettings["date"];

            // Crear Bonos por 
            for (int i = 0; i < cantBonosUpDown.Value; i++)
            {
                comando = "EXECUTE NEXTGDD.comprarBono @fechaImpresion='" + convertirFecha("07/11/2016 00:00:00") + "', @compraFecha='" + convertirFecha("07/11/2016 00:00:00") + "', @codPlan='" + plan + "', @nroAfiliado='" + idAfiliado + "'";
                Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);
            }


            // Registrar la compra
            comando = "EXECUTE NEXTGDD.registrarCompra @cant='" + cantBonosUpDown.Value + "', @idAfiliado='" + idAfiliado + "', @precioTotal='" + lblTotalAPagar.Text + "'";
            Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);

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
                lblTotalAPagar.Text = (cantBonosUpDown.Value * int.Parse(txtPrecioBono.Text)).ToString();
               
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
