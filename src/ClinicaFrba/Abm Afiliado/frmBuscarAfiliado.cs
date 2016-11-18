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
    public partial class frmBuscarAfiliado : Form
    {
        private string comando = "";
        private string plan = "";
        private UInt64 nroAfil ;
        DataTable tabla;
        //DataTable tablaAfil;
        //DataTable tablagrupo;
        //DataTable tablaAfilgrupo;
        private string mioperacion= "";

       //private List<Afiliado> listaDeAfiliados;

        public frmBuscarAfiliado(string operacion)
        {
            InitializeComponent();
            mioperacion = operacion;


        }

        private void lblFiltroBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void frmModifcarAfiliadoGrupo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'listaDeAfiliados.Afiliado' Puede moverla o quitarla según sea necesario.
            //this.afiliadoTableAdapter.Fill(this.listaDeAfiliados.Afiliado);
            
            plan = (string)cmbPlanes.SelectedItem;

            comando = "select distinct descripcion from NEXTGDD.Plan_Medico";
            cargar(Clases.BaseDeDatosSQL.ObtenerLista(comando, "descripcion"), cmbPlanes);

            cmbPlanes.DropDownStyle = ComboBoxStyle.DropDownList;

            cargarGrilla();
            //tabla = new DataTable();
            //tabla = Afiliado.obtenerAfilidos();
            //dataGridView1.DataSource = tabla;

            List<Afiliado> listaDeAfiliados = Afiliado.ObtenerTodos();

            dataGridView1.DataSource = listaDeAfiliados;


        }

        private void cargar(List<string> lista, ComboBox cmb)
        {
            foreach (string elemento in lista)
            {
                cmb.Items.Add(elemento);
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipalAfiliado principalAfil = new frmPrincipalAfiliado();
            this.Hide();
            principalAfil.Show();
        }

        //public string Operacion { get; set; }

        //public Clases.Profesional profesional { get; set; }

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
            try
            {
                nroAfil = UInt64.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());


                if (mioperacion == "Eliminar")
                {
                    frmBajaAfiliado baja = new frmBajaAfiliado(nroAfil);
                    this.Hide();
                    baja.Show();
                }
                else if (mioperacion == "Modificar")
                {
                    frmModificarAfiliado este = new frmModificarAfiliado(nroAfil);
                    this.Hide();
                    este.Show();

                }
            }
            catch
            {
                MessageBox.Show("No se selecciono ningun afiliado", "Error!", MessageBoxButtons.OK);
            }

          

        }

        public void ActualizarGrilla()
        {
            plan = (string)cmbPlanes.SelectedItem;

            if (txtNomFiltrado.Text != "" || txtApeFiltrado.Text != "" || txtDniFiltrado.Text != "" || textNroAfiliado.Text != "" || plan != "")
            {
                List<Afiliado> listaDeAfiliados = Afiliado.ObtenerAfiliados2(txtNomFiltrado.Text, txtApeFiltrado.Text, txtDniFiltrado.Text, textNroAfiliado.Text, plan);
                
                dataGridView1.DataSource = listaDeAfiliados;
            }
            else
            {

                MessageBox.Show("Por Favor ingrese campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //listaDeAfiliados = Afiliado.ObtenerTodos();
            }

            //meto el resultado en la grilla
            //dataGridView1.DataSource = listaDeAfiliados;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            try
            {
                ActualizarGrilla();
            }
            catch { MessageBox.Show("no actualiza grilla", "Error!", MessageBoxButtons.OK); }

           //if ((String.IsNullOrEmpty(txtApeFiltrado.Text)) && (String.IsNullOrEmpty(textNroAfiliado.Text) )&&(String.IsNullOrEmpty(txtDniFiltrado.Text)) &&( String.IsNullOrEmpty(txtNomFiltrado.Text) )&&  (cmbPlanes.SelectedIndex == -1)) 
           // {
           //     MessageBox.Show("Por Favor ingrese campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           // }
           //else if ((textNroAfiliado.Text != string.Empty) && (txtDniFiltrado.Text != string.Empty) && (txtNomFiltrado.Text != string.Empty))
           // {
           //     MessageBox.Show("Gracias por no  ingresar plan.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           //     //tablagrupo = new DataTable();
           //     //tablagrupo = Afiliado.obtenerHistorialGrupo(UInt64.Parse(txtNroGrupo.Text));
           //     //dataGridView1.DataSource = tablagrupo;
           // }
           //else if ((cmbPlanes.SelectedIndex >0) && (txtDniFiltrado.Text != string.Empty) && (txtNomFiltrado.Text != string.Empty))
           //{
           //    MessageBox.Show("Gracias por no  ingresar nroafil.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           //    //tablagrupo = new DataTable();
           //    //tablagrupo = Afiliado.obtenerHistorialGrupo(UInt64.Parse(txtNroGrupo.Text));
           //    //dataGridView1.DataSource = tablagrupo;
           //}
           //else if ((textNroAfiliado.Text != string.Empty) && (cmbPlanes.SelectedIndex > 0) && (txtNomFiltrado.Text != string.Empty))
           //{
           //    MessageBox.Show("Gracias por no  ingresar nron doc.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           //    //tablagrupo = new DataTable();
           //    //tablagrupo = Afiliado.obtenerHistorialGrupo(UInt64.Parse(txtNroGrupo.Text));
           //    //dataGridView1.DataSource = tablagrupo;
           //}

           //else if ((textNroAfiliado.Text != string.Empty) && (cmbPlanes.SelectedIndex > 0) )
           //{
           //    MessageBox.Show("Gracias por no  ingresar nron doc y nombre .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           //    //tablagrupo = new DataTable();
           //    //tablagrupo = Afiliado.obtenerHistorialGrupo(UInt64.Parse(txtNroGrupo.Text));
           //    //dataGridView1.DataSource = tablagrupo;
           //}

           //else if ((textNroAfiliado.Text != string.Empty) && (txtNomFiltrado.Text != string.Empty))
           //{
           //    MessageBox.Show("Gracias por no  ingresar nron doc y plan .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           //    //tablagrupo = new DataTable();
           //    //tablagrupo = Afiliado.obtenerHistorialGrupo(UInt64.Parse(txtNroGrupo.Text));
           //    //dataGridView1.DataSource = tablagrupo;
           //}

           // else if ( (txtApeFiltrado.Text != string.Empty) && (textNroAfiliado.Text != string.Empty) && (txtDniFiltrado.Text != string.Empty) )
           // {

           //      MessageBox.Show("Gracias por no ingresar nombre y plan.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
           //     //tablaAfil = new DataTable();
           //     //tablaAfil = Afiliado.obtenerHistorial_Afil(UInt64.Parse(txtNroAfiliado.Text));
           //     //dataGridView1.DataSource = tablaAfil;


           // }
           //else if ((txtApeFiltrado.Text != string.Empty) && (textNroAfiliado.Text != string.Empty))
           
           // {

           //     MessageBox.Show("Gracias por no ingresar nombre, plan y doc.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
           //     //tablaAfilgrupo = new DataTable();
           //     //tablaAfilgrupo = Afiliado.mostrarHistorialAfil_grupo(UInt64.Parse(txtNroGrupo.Text), UInt64.Parse(txtNroAfiliado.Text));
           //     //dataGridView1.DataSource = tablaAfilgrupo;
           //     //// MessageBox.Show("Por favor, filtre por un campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           // }

           //else if ((txtApeFiltrado.Text != string.Empty))
           //{

           //    MessageBox.Show("Gracias por no ingresar nombre, plan , doc y nro afiliado.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           //}
           //else
           //{

           //    MessageBox.Show("Gracias por no ingresar todos los campos.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           //}


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();

            //tabla = Afiliado.obtenerAfiliados();
            
            //dataGridView1.DataSource = tabla;

            List<Afiliado> listaDeAfiliados = Afiliado.ObtenerTodos();

            dataGridView1.DataSource = listaDeAfiliados;
        }

        private void frmBuscarAfiliado_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Realmente desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void limpiar()
        {
            // limpio txt
            txtDniFiltrado.Clear();
            txtNomFiltrado.Clear();
            txtApeFiltrado.Clear();
            textNroAfiliado.Clear();
            cmbPlanes.SelectedIndex = -1;

        }

        private void pnlFiltroBusqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDniFiltrado_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void cargarGrilla()
        {

            DataGridViewTextBoxColumn ColPersona = new DataGridViewTextBoxColumn();
            ColPersona.DataPropertyName = "nro_afiliado";
            ColPersona.HeaderText = "Nro Afiliado";
            ColPersona.Width = 100;
            dataGridView1.Columns.Add(ColPersona);

            DataGridViewTextBoxColumn ColNombre = new DataGridViewTextBoxColumn();
            ColNombre.DataPropertyName = "Nombre";
            ColNombre.HeaderText = "Nombre";
            ColNombre.Width =  100;
            dataGridView1.Columns.Add(ColNombre);

            DataGridViewTextBoxColumn ColApellido = new DataGridViewTextBoxColumn();
            ColApellido.DataPropertyName = "Apellido";
            ColApellido.HeaderText = "Apellido";
            ColApellido.Width = 100;
            dataGridView1.Columns.Add(ColApellido);

            DataGridViewTextBoxColumn ColTipDoc = new DataGridViewTextBoxColumn();
            ColTipDoc.DataPropertyName = "Tipo_Doc";
            ColTipDoc.HeaderText = "Tipo Doc";
            ColTipDoc.Width = 45;
            dataGridView1.Columns.Add(ColTipDoc);

            DataGridViewTextBoxColumn ColDoc = new DataGridViewTextBoxColumn();
            ColDoc.DataPropertyName = "Nro_Doc";
            ColDoc.HeaderText = "Nro Doc";
            ColDoc.Width = 100;
            dataGridView1.Columns.Add(ColDoc);

            DataGridViewTextBoxColumn ColDir = new DataGridViewTextBoxColumn();
            ColDir.DataPropertyName = "Direccion";
            ColDir.HeaderText = "Direccion";
            ColDir.Width = 160;
            dataGridView1.Columns.Add(ColDir);

            DataGridViewTextBoxColumn ColTel = new DataGridViewTextBoxColumn();
            ColTel.DataPropertyName = "Telefono";
            ColTel.HeaderText = "Telefono";
            ColTel.Width = 80;
            dataGridView1.Columns.Add(ColTel);

            DataGridViewTextBoxColumn ColMail = new DataGridViewTextBoxColumn();
            ColMail.DataPropertyName = "Mail";
            ColMail.HeaderText = "Mail";
            ColMail.Width = 160;
            dataGridView1.Columns.Add(ColMail);

            DataGridViewTextBoxColumn ColPlan = new DataGridViewTextBoxColumn();
            ColPlan.DataPropertyName = "Plan_Medico";
            ColPlan.HeaderText = "Plan Medico";
            ColPlan.Width = 100;
            dataGridView1.Columns.Add(ColPlan);

            DataGridViewTextBoxColumn ColFN = new DataGridViewTextBoxColumn();
            ColFN.DataPropertyName = "Fecha_Nac";
            ColFN.HeaderText = "Fecha Nac";
            ColFN.Width = 80;
            dataGridView1.Columns.Add(ColFN);

            DataGridViewTextBoxColumn ColEC = new DataGridViewTextBoxColumn();
            ColEC.DataPropertyName = "Estado_Civil";
            ColEC.HeaderText = "Estado Civil";
            ColEC.Width = 80;
            dataGridView1.Columns.Add(ColEC);

            DataGridViewTextBoxColumn ColCH = new DataGridViewTextBoxColumn();
            ColCH.DataPropertyName = "Cant_Hijos";
            ColCH.HeaderText = "Cantidad Familiares";
            ColCH.Width = 60;
            dataGridView1.Columns.Add(ColCH);


            btnModificarAfiliado.Text = mioperacion;//"Eliminar";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex == -1) 
                return;
            
            else
            {
                textNroAfiliado.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); 
                txtNomFiltrado.Text=   dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtApeFiltrado.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtDniFiltrado.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cmbPlanes.SelectedItem = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            }
        }




    }
}
