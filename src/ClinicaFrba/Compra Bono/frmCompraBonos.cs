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
        private string idAfiliado = "";


        public frmCompraBonos()
        {
            InitializeComponent();

    if(Clases.Usuario.id_rol.Equals("Administrativo")){
                txtNumeroAfiliado.Visible = true;
                lblNumeroAfiliado.Visible = true;
                btnCargarAfiliado.Visible = true;
            }
            else if (Clases.Usuario.id_rol.Equals("Afiliado"))
            {
                
                Clases.Usuario.Nro_Afiliado = 124453901;
                idAfiliado = Clases.Usuario.Nro_Afiliado.ToString(); // Debe ser cargado del afiliado si 
                txtPrecioBono.Text = obtenerPrecioBono(idAfiliado);

            }

        }

        private String obtenerPrecioBono(string afiliado)
        {
            String queryString = "SELECT precio_bono_consulta FROM NEXTGDD.Afiliado RIGHT JOIN NEXTGDD.Plan_Medico ON Afiliado.cod_plan = Plan_Medico.cod_plan WHERE Afiliado.nro_afiliado ='" + afiliado + "'";
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
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms();
            this.Hide();
            menuAbm.Show();
        }

        private void frmCompraBonos_FormClosing(object sender, FormClosingEventArgs e)
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
                txtNumeroAfiliado.Text = "";
                        
            }
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (cantBonosUpDown.Value < 1)
            {
                warningCompraNula.Visible = true;
                return;
            }

            warningCompraNula.Visible = false;

            String comando;
            String fechaDeHoy = Clases.FechaSistema.fechaActualConvertida();


            // Adquiero el codigo del plan
            comando = "select cod_plan from NEXTGDD.Afiliado where nro_afiliado = '" + idAfiliado + "'";
            String plan = Clases.BaseDeDatosSQL.buscarCampo(comando);

            // Registrar la compra
            comando = "EXECUTE NEXTGDD.registrarCompra @cant='" + cantBonosUpDown.Value + "', @idAfiliado='" + idAfiliado + "', @precioTotal='" + lblTotalAPagar.Text + "', @compraFecha='" + fechaDeHoy + "'";
            Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);
            
            // Guardo el ID de la compra
            comando = "SELECT TOP 1 id_compra from NEXTGDD.Compra_Bono where id_afiliado = '" + idAfiliado + "' order by id_compra DESC";
            String compraID = Clases.BaseDeDatosSQL.buscarCampo(comando);

            // Crear Bonos por 
            for (int i = 0; i < cantBonosUpDown.Value; i++)
            {
                comando = "EXECUTE NEXTGDD.comprarBono @fechaImpresion='" + fechaDeHoy + "', @compraFecha='" + fechaDeHoy + "', @codPlan='" + plan + "', @nroAfiliado='" + idAfiliado + "', @idCompra='" + compraID + "'";
                Clases.BaseDeDatosSQL.EjecutarStoredProcedure(comando);
            }

            MessageBox.Show("Compra completada con exito!", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Compra_Bono.frmCompraBonos nuevo = new Compra_Bono.frmCompraBonos();
            this.Hide();
            nuevo.Show();
        }

        private void cantBonos_ValueChanged(object sender, EventArgs e)
        {
            if (cantBonosUpDown.Value == 0)
            {
                lblTotalAPagar.Text = "0.00";
            }
            else
            {
                if (txtNumeroAfiliado.Text != "")
                {
                    lblTotalAPagar.Text = (cantBonosUpDown.Value * int.Parse(txtPrecioBono.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("Debe ingresar un afiliado", "Cantidad de Bonos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cantBonosUpDown.Value = 0;
                    txtPrecioBono.Text = "0.00";
                }
               
            }
        }
    }
}
