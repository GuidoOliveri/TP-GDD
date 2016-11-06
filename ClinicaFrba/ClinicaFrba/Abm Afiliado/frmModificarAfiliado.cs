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
        private string profesional = "";
    
        public frmModificarAfiliado(int idPersona)
        {
            InitializeComponent();

            Clases.BaseDeDatosSQL basedeDatos = new Clases.BaseDeDatosSQL();

            idPersona = 1123960; // Hardcode de prueba
            comando = "select * from GD2C2016.NEXTGDD.Persona where id_persona ="+idPersona;
         //   basedeDatos.ObtenerPersona(comando);
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
    }
}
