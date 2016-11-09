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
            this.warning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.cmbListado = new System.Windows.Forms.ComboBox();
            this.lblSeleccioneUnaOpcion = new System.Windows.Forms.Label();
            this.lblFiltroBusqueda = new System.Windows.Forms.Label();
            this.maestraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2016DataSet = new ClinicaFrba.GD2C2016DataSet();
            this.maestraTableAdapter = new ClinicaFrba.GD2C2016DataSetTableAdapters.MaestraTableAdapter();
            this.dgListado = new System.Windows.Forms.DataGridView();
            this.listaDeAfiliadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaDeAfiliados = new ClinicaFrba.ListaDeAfiliados();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.pnlFiltroBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).BeginInit();
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
            this.pnlFiltroBusqueda.Controls.Add(this.warning);
            this.pnlFiltroBusqueda.Controls.Add(this.label1);
            this.pnlFiltroBusqueda.Controls.Add(this.cmbSemestre);
            this.pnlFiltroBusqueda.Controls.Add(this.btnSeleccionar);
            this.pnlFiltroBusqueda.Controls.Add(this.cmbListado);
            this.pnlFiltroBusqueda.Controls.Add(this.lblSeleccioneUnaOpcion);
            this.pnlFiltroBusqueda.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlFiltroBusqueda.Location = new System.Drawing.Point(12, 10);
            this.pnlFiltroBusqueda.Name = "pnlFiltroBusqueda";
            this.pnlFiltroBusqueda.Size = new System.Drawing.Size(553, 108);
            this.pnlFiltroBusqueda.TabIndex = 2;
            this.pnlFiltroBusqueda.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(25, 84);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(133, 13);
            this.warning.TabIndex = 6;
            this.warning.Text = "Faltan seleccionar campos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Semestre:";
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Location = new System.Drawing.Point(359, 48);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(168, 21);
            this.cmbSemestre.TabIndex = 9;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(439, 78);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(88, 25);
            this.btnSeleccionar.TabIndex = 8;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // cmbListado
            // 
            this.cmbListado.FormattingEnabled = true;
            this.cmbListado.Items.AddRange(new object[] {
            "Top 5 especialidades con más cancelaciones",
            "Top 5 profesionales más consultados por plan",
            "Top 5 profesionales con menos horas trabajadas",
            "Top 5 afiliados con mayor cantidad de bonos comprados",
            "Top 5 especialidades médicas con más bonos utilizados"});
            this.cmbListado.Location = new System.Drawing.Point(181, 21);
            this.cmbListado.Name = "cmbListado";
            this.cmbListado.Size = new System.Drawing.Size(346, 21);
            this.cmbListado.TabIndex = 6;
            // 
            // lblSeleccioneUnaOpcion
            // 
            this.lblSeleccioneUnaOpcion.AutoSize = true;
            this.lblSeleccioneUnaOpcion.Location = new System.Drawing.Point(25, 24);
            this.lblSeleccioneUnaOpcion.Name = "lblSeleccioneUnaOpcion";
            this.lblSeleccioneUnaOpcion.Size = new System.Drawing.Size(119, 13);
            this.lblSeleccioneUnaOpcion.TabIndex = 4;
            this.lblSeleccioneUnaOpcion.Text = "Seleccione una opción:";
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
            // dgListado
            // 
            this.dgListado.AllowUserToAddRows = false;
            this.dgListado.AllowUserToDeleteRows = false;
            this.dgListado.AllowUserToResizeColumns = false;
            this.dgListado.AllowUserToResizeRows = false;
            this.dgListado.AutoGenerateColumns = false;
            this.dgListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListado.DataSource = this.listaDeAfiliadosBindingSource;
            this.dgListado.Location = new System.Drawing.Point(12, 185);
            this.dgListado.Name = "dgListado";
            this.dgListado.Size = new System.Drawing.Size(553, 167);
            this.dgListado.TabIndex = 4;
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
            this.cmdVolver.Location = new System.Drawing.Point(223, 367);
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
            this.ClientSize = new System.Drawing.Size(578, 415);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.dgListado);
            this.Controls.Add(this.lblFiltroBusqueda);
            this.Controls.Add(this.pnlFiltroBusqueda);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListado_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlFiltroBusqueda.ResumeLayout(false);
            this.pnlFiltroBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeAfiliadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeAfiliados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Panel pnlFiltroBusqueda;
        private System.Windows.Forms.Label lblFiltroBusqueda;
        private System.Windows.Forms.ComboBox cmbListado;
        private System.Windows.Forms.Label lblSeleccioneUnaOpcion;
        private System.Windows.Forms.Button btnSeleccionar;
        private GD2C2016DataSet gD2C2016DataSet;
        private System.Windows.Forms.BindingSource maestraBindingSource;
        private GD2C2016DataSetTableAdapters.MaestraTableAdapter maestraTableAdapter;
        private System.Windows.Forms.DataGridView dgListado;
        private System.Windows.Forms.BindingSource listaDeAfiliadosBindingSource;
        private ListaDeAfiliados listaDeAfiliados;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.Label warning;
    }
}