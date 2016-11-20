using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.Clases;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class frmBajaAfiliado : Form
    {
        private UInt64 nroAfil;
        private DateTime fechaBaja;
        int resultado;
        private string operacionBaja = "Eliminar";

        public frmBajaAfiliado( UInt64 nroAfil )
        {
            InitializeComponent();
            txtMatricula.Text= nroAfil.ToString() ;

        }

        private void frmBajaAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void lblIngresaFechas_Click(object sender, EventArgs e)
        {

        }

        private void limpiar(){
        
             txtMatricula.Clear();
             dtpFechaBaja.ResetText();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txtMatricula.Text) )  
            {
                MessageBox.Show("Por favor, ingrese algun nro de afiliado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {
                  
              nroAfil = Convert.ToUInt64(txtMatricula.Text); 
              fechaBaja= Convert.ToDateTime(dtpFechaBaja.Value).Date ;

              resultado= Afiliado.darDeBajaAfiliado(nroAfil, fechaBaja);
                
                if (resultado.Equals(-1))
                {
                    
                    MessageBox.Show("Lo sentimos, no podemos procesar tu solicitud. Inténtalo de nuevo más tarde.", "Baja Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();
                    frmBuscarAfiliado buscar = new frmBuscarAfiliado(operacionBaja);
                    this.Hide();
                    buscar.Show();
                }
                else if (resultado.Equals(-2))
                {
                    
                    MessageBox.Show("El Nro de Afiliado: " + nroAfil+ " No existe!", "Baja Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();
                    frmBuscarAfiliado buscar = new frmBuscarAfiliado(operacionBaja);
                    this.Hide();
                    buscar.Show();
                }
                else if (resultado.Equals(-3))
                {

                    MessageBox.Show("El Nro de Afiliado: " + nroAfil + " Ya fue dado de baja anteriormente!", "Baja Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();
                    frmBuscarAfiliado buscar = new frmBuscarAfiliado(operacionBaja);
                    this.Hide();
                    buscar.Show();
                }
                else
                {
                    
                    MessageBox.Show("El Nro de Afiliado: " + nroAfil+ "\nFue dado de baja exitosamente!", "Baja Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    frmBuscarAfiliado buscar = new frmBuscarAfiliado(operacionBaja);
                    this.Hide();
                    buscar.Show();
                }

            }


        }


        private void cmdVolver_Click(object sender, EventArgs e)
        {
            frmBuscarAfiliado buscar = new frmBuscarAfiliado(operacionBaja);
            this.Hide();
            buscar.Show();
        }

        private void frmBajaAfiliado_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Realmente desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlIngreseFechaBaja_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpFechaBaja_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
