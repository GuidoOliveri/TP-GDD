using System;
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
    
        public frmModificarAfiliado(Clases.BaseDeDatosSQL bdd, int idPersona)
        {
            InitializeComponent();
            
            bdd = new Clases.BaseDeDatosSQL(); // Hardcode de prueba
            
            idPersona = 1123960; // Hardcode de prueba
            comando = "select * from GD2C2016.NEXTGDD.Persona where id_persona ="+idPersona;
            System.Collections.ArrayList persona = bdd.obtenerRow(comando);
            
            txtDir.Text = (string) persona[3];
            txtTel.Text = persona[4].ToString();
            txtMail.Text = (string)persona[5];
            
            
        }

        private void frmModificarAfiliado_Load(object sender, EventArgs e)
        {
            
        }

        private void pnlModDatosPersonales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtDir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
