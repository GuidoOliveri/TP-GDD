﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Especialidades_Medicas
{
    public partial class frmEspecialidadesMedicas : Form
    {
        public frmEspecialidadesMedicas()
        {
            InitializeComponent();
        }

        private void frmEspecialidadesMedicas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
