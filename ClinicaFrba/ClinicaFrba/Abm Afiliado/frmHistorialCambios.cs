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
    public partial class frmHistorialCambios : Form
    {
        public frmHistorialCambios()
        {
            InitializeComponent();
        }

        private void frmHistorialCambios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'historialDeCambios.Historial' Puede moverla o quitarla según sea necesario.
            this.historialTableAdapter.Fill(this.historialDeCambios.Historial);

        }
    }
}
