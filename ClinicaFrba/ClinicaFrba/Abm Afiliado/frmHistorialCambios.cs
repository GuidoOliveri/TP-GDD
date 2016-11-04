using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Profesional
{
    public partial class frmHistorialCambios : Form
    {
        public frmHistorialCambios()
        {
            InitializeComponent();
        }

        private void frmHistorialCambios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2016DataSet21.Maestra' Puede moverla o quitarla según sea necesario.
            this.maestraTableAdapter.Fill(this.gD2C2016DataSet21.Maestra);
            // TODO: esta línea de código carga datos en la tabla 'gD2C2016DataSet2.Maestra' Puede moverla o quitarla según sea necesario.
            this.maestraTableAdapter.Fill(this.gD2C2016DataSet2.Maestra);

        }
    }
}
