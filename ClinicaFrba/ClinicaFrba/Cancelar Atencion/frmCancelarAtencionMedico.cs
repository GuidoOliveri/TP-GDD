﻿using System;
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
    public partial class frmCancelarAtencionMedico : Form
    {
        public frmCancelarAtencionMedico()
        {
            InitializeComponent();
        }

        public Clases.Profesional unProfesional { get; set; }
    }
}