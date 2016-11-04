using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.AbmRol;
using ClinicaFrba.Clases;
using ClinicaFrba.Abm_Profesional;
using ClinicaFrba.Registrar_Agenda_Medico;
using ClinicaFrba.Cancelar_Atencion;
using ClinicaFrba.Registro_Llegada;

namespace ClinicaFrba
{
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        public Usuario User { get; set; }
    }
}
