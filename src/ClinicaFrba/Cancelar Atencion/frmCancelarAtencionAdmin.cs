using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class frmCancelarAtencionAdmin : Form
    {
        public frmCancelarAtencionAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cancelarPaciente_Click(object sender, EventArgs e)
        {
            Cancelar_Atencion.frmCancelarAtencionPaciente func = new Cancelar_Atencion.frmCancelarAtencionPaciente();
            func.Show();
            this.Hide();
        }

        private void cancelarMedico_Click(object sender, EventArgs e)
        {
            Cancelar_Atencion.frmCancelarAtencionMedico func = new Cancelar_Atencion.frmCancelarAtencionMedico();
            func.Show();
            this.Hide();
        }
    }
}
