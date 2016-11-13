﻿namespace ClinicaFrba.Abm_Afiliado
{
    partial class frmBuscarAfiliado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlFiltroBusqueda = new System.Windows.Forms.Panel();
            this.dtpFecNacFilt = new System.Windows.Forms.DateTimePicker();
            this.lblFecNacFiltrado = new System.Windows.Forms.Label();
            this.txtDniFiltrado = new System.Windows.Forms.TextBox();
            this.txtApeFiltrado = new System.Windows.Forms.TextBox();
            this.txtNomFiltrado = new System.Windows.Forms.TextBox();
            this.lblDniFiltrado = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombreFiltrado = new System.Windows.Forms.Label();
            this.lblFiltroBusqueda = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificarAfiliado = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.listaDeAfiliados = new ClinicaFrba.ListaDeAfiliados();
            this.listaDeAfiliadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.afiliadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.afiliadoTableAdapter = new ClinicaFrba.ListaDeAfiliadosTableAdapters.AfiliadoTableAdapter();
            this.pnlFiltroBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeAfiliados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeAfiliadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltroBusqueda
            // 
            this.pnlFiltroBusqueda.Controls.Add(this.dtpFecNacFilt);
            this.pnlFiltroBusqueda.Controls.Add(this.lblFecNacFiltrado);
            this.pnlFiltroBusqueda.Controls.Add(this.txtDniFiltrado);
            this.pnlFiltroBusqueda.Controls.Add(this.txtApeFiltrado);
            this.pnlFiltroBusqueda.Controls.Add(this.txtNomFiltrado);
            this.pnlFiltroBusqueda.Controls.Add(this.lblDniFiltrado);
            this.pnlFiltroBusqueda.Controls.Add(this.lblApellido);
            this.pnlFiltroBusqueda.Controls.Add(this.lblNombreFiltrado);
            this.pnlFiltroBusqueda.Controls.Add(this.lblFiltroBusqueda);
            this.pnlFiltroBusqueda.Location = new System.Drawing.Point(74, 12);
            this.pnlFiltroBusqueda.Name = "pnlFiltroBusqueda";
            this.pnlFiltroBusqueda.Size = new System.Drawing.Size(535, 111);
            this.pnlFiltroBusqueda.TabIndex = 0;
            // 
            // dtpFecNacFilt
            // 
            this.dtpFecNacFilt.Location = new System.Drawing.Point(300, 60);
            this.dtpFecNacFilt.Name = "dtpFecNacFilt";
            this.dtpFecNacFilt.Size = new System.Drawing.Size(201, 20);
            this.dtpFecNacFilt.TabIndex = 8;
            // 
            // lblFecNacFiltrado
            // 
            this.lblFecNacFiltrado.AutoSize = true;
            this.lblFecNacFiltrado.Location = new System.Drawing.Point(198, 63);
            this.lblFecNacFiltrado.Name = "lblFecNacFiltrado";
            this.lblFecNacFiltrado.Size = new System.Drawing.Size(96, 13);
            this.lblFecNacFiltrado.TabIndex = 7;
            this.lblFecNacFiltrado.Text = "Fecha Nacimiento:";
            // 
            // txtDniFiltrado
            // 
            this.txtDniFiltrado.Location = new System.Drawing.Point(300, 24);
            this.txtDniFiltrado.Name = "txtDniFiltrado";
            this.txtDniFiltrado.Size = new System.Drawing.Size(201, 20);
            this.txtDniFiltrado.TabIndex = 6;
            // 
            // txtApeFiltrado
            // 
            this.txtApeFiltrado.Location = new System.Drawing.Point(60, 63);
            this.txtApeFiltrado.Name = "txtApeFiltrado";
            this.txtApeFiltrado.Size = new System.Drawing.Size(114, 20);
            this.txtApeFiltrado.TabIndex = 5;
            // 
            // txtNomFiltrado
            // 
            this.txtNomFiltrado.Location = new System.Drawing.Point(60, 24);
            this.txtNomFiltrado.Name = "txtNomFiltrado";
            this.txtNomFiltrado.Size = new System.Drawing.Size(114, 20);
            this.txtNomFiltrado.TabIndex = 4;
            // 
            // lblDniFiltrado
            // 
            this.lblDniFiltrado.AutoSize = true;
            this.lblDniFiltrado.Location = new System.Drawing.Point(237, 27);
            this.lblDniFiltrado.Name = "lblDniFiltrado";
            this.lblDniFiltrado.Size = new System.Drawing.Size(26, 13);
            this.lblDniFiltrado.TabIndex = 3;
            this.lblDniFiltrado.Text = "Dni:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(7, 63);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombreFiltrado
            // 
            this.lblNombreFiltrado.AutoSize = true;
            this.lblNombreFiltrado.Location = new System.Drawing.Point(7, 27);
            this.lblNombreFiltrado.Name = "lblNombreFiltrado";
            this.lblNombreFiltrado.Size = new System.Drawing.Size(47, 13);
            this.lblNombreFiltrado.TabIndex = 1;
            this.lblNombreFiltrado.Text = "Nombre:";
            // 
            // lblFiltroBusqueda
            // 
            this.lblFiltroBusqueda.AutoSize = true;
            this.lblFiltroBusqueda.Location = new System.Drawing.Point(28, 0);
            this.lblFiltroBusqueda.Name = "lblFiltroBusqueda";
            this.lblFiltroBusqueda.Size = new System.Drawing.Size(95, 13);
            this.lblFiltroBusqueda.TabIndex = 0;
            this.lblFiltroBusqueda.Text = "Filtro de Busqueda";
            this.lblFiltroBusqueda.Click += new System.EventHandler(this.lblFiltroBusqueda_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(159, 137);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(118, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(374, 138);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificarAfiliado
            // 
            this.btnModificarAfiliado.Location = new System.Drawing.Point(108, 372);
            this.btnModificarAfiliado.Name = "btnModificarAfiliado";
            this.btnModificarAfiliado.Size = new System.Drawing.Size(178, 32);
            this.btnModificarAfiliado.TabIndex = 4;
            this.btnModificarAfiliado.Text = "ModificarAfiliado";
            this.btnModificarAfiliado.UseVisualStyleBackColor = true;
            this.btnModificarAfiliado.Click += new System.EventHandler(this.btnModificarAfiliado_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(374, 372);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(178, 32);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // listaDeAfiliados
            // 
            this.listaDeAfiliados.DataSetName = "ListaDeAfiliados";
            this.listaDeAfiliados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaDeAfiliadosBindingSource
            // 
            this.listaDeAfiliadosBindingSource.DataSource = this.listaDeAfiliados;
            this.listaDeAfiliadosBindingSource.Position = 0;
            this.listaDeAfiliadosBindingSource.CurrentChanged += new System.EventHandler(this.listaDeAfiliadosBindingSource_CurrentChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(642, 177);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // afiliadoBindingSource
            // 
            this.afiliadoBindingSource.DataMember = "Afiliado";
            this.afiliadoBindingSource.DataSource = this.listaDeAfiliadosBindingSource;
            this.afiliadoBindingSource.CurrentChanged += new System.EventHandler(this.afiliadoBindingSource_CurrentChanged);
            // 
            // afiliadoTableAdapter
            // 
            this.afiliadoTableAdapter.ClearBeforeFill = true;
            // 
            // frmBuscarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 426);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificarAfiliado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pnlFiltroBusqueda);
            this.Name = "frmBuscarAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Afiliado ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBuscarAfiliado_FormClosing);
            this.Load += new System.EventHandler(this.frmModifcarAfiliadoGrupo_Load);
            this.pnlFiltroBusqueda.ResumeLayout(false);
            this.pnlFiltroBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeAfiliados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeAfiliadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afiliadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltroBusqueda;
        private System.Windows.Forms.Label lblFiltroBusqueda;
        private System.Windows.Forms.DateTimePicker dtpFecNacFilt;
        private System.Windows.Forms.Label lblFecNacFiltrado;
        private System.Windows.Forms.TextBox txtDniFiltrado;
        private System.Windows.Forms.TextBox txtApeFiltrado;
        private System.Windows.Forms.TextBox txtNomFiltrado;
        private System.Windows.Forms.Label lblDniFiltrado;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombreFiltrado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificarAfiliado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.BindingSource listaDeAfiliadosBindingSource;
        private ListaDeAfiliados listaDeAfiliados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource afiliadoBindingSource;
        private ListaDeAfiliadosTableAdapters.AfiliadoTableAdapter afiliadoTableAdapter;
    }
}