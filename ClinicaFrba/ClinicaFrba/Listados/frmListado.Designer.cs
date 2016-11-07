namespace ClinicaFrba.Listados
{
    partial class frmListado
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.pnlFiltroBusqueda = new System.Windows.Forms.Panel();
            this.cmdSeleccionar = new System.Windows.Forms.Button();
            this.txtBusquedaEspecifica = new System.Windows.Forms.TextBox();
            this.cmbSeleccioneUnaOpcion = new System.Windows.Forms.ComboBox();
            this.lblBusquedaEspecifica = new System.Windows.Forms.Label();
            this.lblSeleccioneUnaOpcion = new System.Windows.Forms.Label();
            this.txtFiltroTextoLibreExacto = new System.Windows.Forms.TextBox();
            this.txtFiltroTextoLibre = new System.Windows.Forms.TextBox();
            this.lblFiltroTextoLibreExacto = new System.Windows.Forms.Label();
            this.lblFiltroTextoLibre = new System.Windows.Forms.Label();
            this.lblFiltroBusqueda = new System.Windows.Forms.Label();
            this.maestraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2016DataSet = new ClinicaFrba.GD2C2016DataSet();
            this.maestraTableAdapter = new ClinicaFrba.GD2C2016DataSetTableAdapters.MaestraTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listaDeAfiliadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaDeAfiliados = new ClinicaFrba.ListaDeAfiliados();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.pnlFiltroBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeAfiliadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeAfiliados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(100, 143);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(151, 25);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar\r\n";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorrar.Location = new System.Drawing.Point(347, 143);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(151, 26);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // pnlFiltroBusqueda
            // 
            this.pnlFiltroBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFiltroBusqueda.Controls.Add(this.cmdSeleccionar);
            this.pnlFiltroBusqueda.Controls.Add(this.txtBusquedaEspecifica);
            this.pnlFiltroBusqueda.Controls.Add(this.cmbSeleccioneUnaOpcion);
            this.pnlFiltroBusqueda.Controls.Add(this.lblBusquedaEspecifica);
            this.pnlFiltroBusqueda.Controls.Add(this.lblSeleccioneUnaOpcion);
            this.pnlFiltroBusqueda.Controls.Add(this.txtFiltroTextoLibreExacto);
            this.pnlFiltroBusqueda.Controls.Add(this.txtFiltroTextoLibre);
            this.pnlFiltroBusqueda.Controls.Add(this.lblFiltroTextoLibreExacto);
            this.pnlFiltroBusqueda.Controls.Add(this.lblFiltroTextoLibre);
            this.pnlFiltroBusqueda.Cursor = System.Windows.Forms.Cursors.No;
            this.pnlFiltroBusqueda.Location = new System.Drawing.Point(12, 10);
            this.pnlFiltroBusqueda.Name = "pnlFiltroBusqueda";
            this.pnlFiltroBusqueda.Size = new System.Drawing.Size(563, 108);
            this.pnlFiltroBusqueda.TabIndex = 2;
            this.pnlFiltroBusqueda.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.Location = new System.Drawing.Point(452, 50);
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.Size = new System.Drawing.Size(88, 25);
            this.cmdSeleccionar.TabIndex = 8;
            this.cmdSeleccionar.Text = "Seleccionar";
            this.cmdSeleccionar.UseVisualStyleBackColor = true;
            this.cmdSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // txtBusquedaEspecifica
            // 
            this.txtBusquedaEspecifica.Enabled = false;
            this.txtBusquedaEspecifica.Location = new System.Drawing.Point(363, 50);
            this.txtBusquedaEspecifica.Name = "txtBusquedaEspecifica";
            this.txtBusquedaEspecifica.Size = new System.Drawing.Size(82, 20);
            this.txtBusquedaEspecifica.TabIndex = 7;
            // 
            // cmbSeleccioneUnaOpcion
            // 
            this.cmbSeleccioneUnaOpcion.FormattingEnabled = true;
            this.cmbSeleccioneUnaOpcion.Location = new System.Drawing.Point(363, 21);
            this.cmbSeleccioneUnaOpcion.Name = "cmbSeleccioneUnaOpcion";
            this.cmbSeleccioneUnaOpcion.Size = new System.Drawing.Size(177, 21);
            this.cmbSeleccioneUnaOpcion.TabIndex = 6;
            // 
            // lblBusquedaEspecifica
            // 
            this.lblBusquedaEspecifica.AutoSize = true;
            this.lblBusquedaEspecifica.Location = new System.Drawing.Point(246, 50);
            this.lblBusquedaEspecifica.Name = "lblBusquedaEspecifica";
            this.lblBusquedaEspecifica.Size = new System.Drawing.Size(111, 13);
            this.lblBusquedaEspecifica.TabIndex = 5;
            this.lblBusquedaEspecifica.Text = "Búsqueda específica:";
            // 
            // lblSeleccioneUnaOpcion
            // 
            this.lblSeleccioneUnaOpcion.AutoSize = true;
            this.lblSeleccioneUnaOpcion.Location = new System.Drawing.Point(246, 22);
            this.lblSeleccioneUnaOpcion.Name = "lblSeleccioneUnaOpcion";
            this.lblSeleccioneUnaOpcion.Size = new System.Drawing.Size(119, 13);
            this.lblSeleccioneUnaOpcion.TabIndex = 4;
            this.lblSeleccioneUnaOpcion.Text = "Seleccione una opción:";
            // 
            // txtFiltroTextoLibreExacto
            // 
            this.txtFiltroTextoLibreExacto.Location = new System.Drawing.Point(114, 48);
            this.txtFiltroTextoLibreExacto.Name = "txtFiltroTextoLibreExacto";
            this.txtFiltroTextoLibreExacto.Size = new System.Drawing.Size(110, 20);
            this.txtFiltroTextoLibreExacto.TabIndex = 3;
            // 
            // txtFiltroTextoLibre
            // 
            this.txtFiltroTextoLibre.Location = new System.Drawing.Point(114, 22);
            this.txtFiltroTextoLibre.Name = "txtFiltroTextoLibre";
            this.txtFiltroTextoLibre.Size = new System.Drawing.Size(110, 20);
            this.txtFiltroTextoLibre.TabIndex = 2;
            // 
            // lblFiltroTextoLibreExacto
            // 
            this.lblFiltroTextoLibreExacto.AutoSize = true;
            this.lblFiltroTextoLibreExacto.Location = new System.Drawing.Point(10, 50);
            this.lblFiltroTextoLibreExacto.Name = "lblFiltroTextoLibreExacto";
            this.lblFiltroTextoLibreExacto.Size = new System.Drawing.Size(91, 13);
            this.lblFiltroTextoLibreExacto.TabIndex = 1;
            this.lblFiltroTextoLibreExacto.Text = "Texto libre exacto";
            // 
            // lblFiltroTextoLibre
            // 
            this.lblFiltroTextoLibre.AutoSize = true;
            this.lblFiltroTextoLibre.Location = new System.Drawing.Point(10, 21);
            this.lblFiltroTextoLibre.Name = "lblFiltroTextoLibre";
            this.lblFiltroTextoLibre.Size = new System.Drawing.Size(56, 13);
            this.lblFiltroTextoLibre.TabIndex = 0;
            this.lblFiltroTextoLibre.Text = "Texto libre";
            this.lblFiltroTextoLibre.Click += new System.EventHandler(this.lblFiltro1_Click);
            // 
            // lblFiltroBusqueda
            // 
            this.lblFiltroBusqueda.AutoSize = true;
            this.lblFiltroBusqueda.Location = new System.Drawing.Point(38, 9);
            this.lblFiltroBusqueda.Name = "lblFiltroBusqueda";
            this.lblFiltroBusqueda.Size = new System.Drawing.Size(99, 13);
            this.lblFiltroBusqueda.TabIndex = 3;
            this.lblFiltroBusqueda.Text = "Filtros de busqueda";
            // 
            // maestraBindingSource
            // 
            this.maestraBindingSource.DataMember = "Maestra";
            this.maestraBindingSource.DataSource = this.gD2C2016DataSet;
            // 
            // gD2C2016DataSet
            // 
            this.gD2C2016DataSet.DataSetName = "GD2C2016DataSet";
            this.gD2C2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maestraTableAdapter
            // 
            this.maestraTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.listaDeAfiliadosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(563, 167);
            this.dataGridView1.TabIndex = 4;
            // 
            // listaDeAfiliadosBindingSource
            // 
            this.listaDeAfiliadosBindingSource.DataSource = this.listaDeAfiliados;
            this.listaDeAfiliadosBindingSource.Position = 0;
            // 
            // listaDeAfiliados
            // 
            this.listaDeAfiliados.DataSetName = "ListaDeAfiliados";
            this.listaDeAfiliados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(233, 367);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(136, 36);
            this.cmdVolver.TabIndex = 5;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 415);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblFiltroBusqueda);
            this.Controls.Add(this.pnlFiltroBusqueda);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlFiltroBusqueda.ResumeLayout(false);
            this.pnlFiltroBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeAfiliadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeAfiliados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Panel pnlFiltroBusqueda;
        private System.Windows.Forms.Label lblFiltroTextoLibreExacto;
        private System.Windows.Forms.Label lblFiltroTextoLibre;
        private System.Windows.Forms.Label lblFiltroBusqueda;
        private System.Windows.Forms.TextBox txtFiltroTextoLibreExacto;
        private System.Windows.Forms.TextBox txtFiltroTextoLibre;
        private System.Windows.Forms.ComboBox cmbSeleccioneUnaOpcion;
        private System.Windows.Forms.Label lblBusquedaEspecifica;
        private System.Windows.Forms.Label lblSeleccioneUnaOpcion;
        private System.Windows.Forms.TextBox txtBusquedaEspecifica;
        private System.Windows.Forms.Button cmdSeleccionar;
        private GD2C2016DataSet gD2C2016DataSet;
        private System.Windows.Forms.BindingSource maestraBindingSource;
        private GD2C2016DataSetTableAdapters.MaestraTableAdapter maestraTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource listaDeAfiliadosBindingSource;
        private ListaDeAfiliados listaDeAfiliados;
        private System.Windows.Forms.Button cmdVolver;
    }
}