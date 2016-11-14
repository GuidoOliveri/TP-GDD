﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaFrba.Clases;


namespace ClinicaFrba.Abm_Afiliado
{
    public partial class frmHistorialCambios : Form
    {
        private string rol = "";
        private string usuario = "";

        public frmHistorialCambios(string rol, string usuario)
        {
            InitializeComponent();
            this.rol = rol;
            this.usuario = usuario;
        }

        private void frmHistorialCambios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'historialDeCambios.Historial' Puede moverla o quitarla según sea necesario.
           // this.historialTableAdapter.Fill(this.historialDeCambios.Historial);
            DataTable tabla = new DataTable();
            tabla = Afiliado.obtenerHistorial() ;
            dataGridView1.DataSource = tabla;
        }

        private void btnAceptarYVolver_Click(object sender, EventArgs e)
        {
            Login.frmMenuDeAbms menuAbm = new Login.frmMenuDeAbms(rol, usuario);
            this.Hide();
            menuAbm.Show();
        }

        private void frmHistorialCambios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Realmente desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
