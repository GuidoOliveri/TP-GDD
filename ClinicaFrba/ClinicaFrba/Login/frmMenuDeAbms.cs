using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Login
{
    public partial class frmMenuDeAbms : Form
    {
        public frmMenuDeAbms()
        {
            InitializeComponent();
        }

        private void cmdLogueo_Click(object sender, EventArgs e)
        {
            frmLogin logueo = new frmLogin();
            this.Hide();
            logueo.Show();
        }

        private void cmdAbmRol_Click(object sender, EventArgs e)
        {
            AbmRol.frmElegirAccionRol rol = new AbmRol.frmElegirAccionRol();
            this.Hide();
            rol.Show();
        }
    }
}
