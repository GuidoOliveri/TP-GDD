﻿using System;
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
    public partial class frmModifcarAfiliado : Form
    {
        public frmModifcarAfiliado()
        {
            InitializeComponent();
        }

        private void lblFiltroBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void frmModifcarAfiliadoGrupo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'listaDeAfiliados.Afiliado' Puede moverla o quitarla según sea necesario.
            this.afiliadoTableAdapter.Fill(this.listaDeAfiliados.Afiliado);
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public string Operacion { get; set; }

        public Clases.Profesional profesional { get; set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaDeAfiliadosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void afiliadoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarAfiliado_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

    }
}