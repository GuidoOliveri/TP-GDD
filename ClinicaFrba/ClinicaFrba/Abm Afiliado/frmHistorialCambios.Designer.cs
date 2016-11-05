namespace ClinicaFrba.Abm_Afiliado
{
    partial class frmHistorialCambios
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
            this.pnlFiltroParaBuscarHistorial = new System.Windows.Forms.Panel();
            this.txtNroAfiliado = new System.Windows.Forms.TextBox();
            this.txtNroGrupo = new System.Windows.Forms.TextBox();
            this.lblNroAfiliado = new System.Windows.Forms.Label();
            this.lblNroGrupo = new System.Windows.Forms.Label();
            this.lblSeleccionarFiltro = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAceptarYVolver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.historialDeCambios = new ClinicaFrba.HistorialDeCambios();
            this.historialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialTableAdapter = new ClinicaFrba.HistorialDeCambiosTableAdapters.HistorialTableAdapter();
            this.nrohistorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechamodificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivomodificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroafiliadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codplanviejoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codplannuevoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFiltroParaBuscarHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialDeCambios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltroParaBuscarHistorial
            // 
            this.pnlFiltroParaBuscarHistorial.Controls.Add(this.txtNroAfiliado);
            this.pnlFiltroParaBuscarHistorial.Controls.Add(this.txtNroGrupo);
            this.pnlFiltroParaBuscarHistorial.Controls.Add(this.lblNroAfiliado);
            this.pnlFiltroParaBuscarHistorial.Controls.Add(this.lblNroGrupo);
            this.pnlFiltroParaBuscarHistorial.Controls.Add(this.lblSeleccionarFiltro);
            this.pnlFiltroParaBuscarHistorial.Location = new System.Drawing.Point(12, 12);
            this.pnlFiltroParaBuscarHistorial.Name = "pnlFiltroParaBuscarHistorial";
            this.pnlFiltroParaBuscarHistorial.Size = new System.Drawing.Size(424, 120);
            this.pnlFiltroParaBuscarHistorial.TabIndex = 0;
            // 
            // txtNroAfiliado
            // 
            this.txtNroAfiliado.Location = new System.Drawing.Point(149, 69);
            this.txtNroAfiliado.Name = "txtNroAfiliado";
            this.txtNroAfiliado.Size = new System.Drawing.Size(183, 20);
            this.txtNroAfiliado.TabIndex = 4;
            // 
            // txtNroGrupo
            // 
            this.txtNroGrupo.Location = new System.Drawing.Point(149, 29);
            this.txtNroGrupo.Name = "txtNroGrupo";
            this.txtNroGrupo.Size = new System.Drawing.Size(183, 20);
            this.txtNroGrupo.TabIndex = 3;
            // 
            // lblNroAfiliado
            // 
            this.lblNroAfiliado.AutoSize = true;
            this.lblNroAfiliado.Location = new System.Drawing.Point(34, 76);
            this.lblNroAfiliado.Name = "lblNroAfiliado";
            this.lblNroAfiliado.Size = new System.Drawing.Size(64, 13);
            this.lblNroAfiliado.TabIndex = 2;
            this.lblNroAfiliado.Text = "Nro Afiliado:";
            // 
            // lblNroGrupo
            // 
            this.lblNroGrupo.AutoSize = true;
            this.lblNroGrupo.Location = new System.Drawing.Point(34, 29);
            this.lblNroGrupo.Name = "lblNroGrupo";
            this.lblNroGrupo.Size = new System.Drawing.Size(59, 13);
            this.lblNroGrupo.TabIndex = 1;
            this.lblNroGrupo.Text = "Nro Grupo:";
            // 
            // lblSeleccionarFiltro
            // 
            this.lblSeleccionarFiltro.AutoSize = true;
            this.lblSeleccionarFiltro.Location = new System.Drawing.Point(24, 0);
            this.lblSeleccionarFiltro.Name = "lblSeleccionarFiltro";
            this.lblSeleccionarFiltro.Size = new System.Drawing.Size(167, 13);
            this.lblSeleccionarFiltro.TabIndex = 0;
            this.lblSeleccionarFiltro.Text = "Filtro para el historial de busqueda";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(49, 142);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(96, 29);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(309, 142);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 29);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAceptarYVolver
            // 
            this.btnAceptarYVolver.Location = new System.Drawing.Point(142, 319);
            this.btnAceptarYVolver.Name = "btnAceptarYVolver";
            this.btnAceptarYVolver.Size = new System.Drawing.Size(151, 32);
            this.btnAceptarYVolver.TabIndex = 4;
            this.btnAceptarYVolver.Text = "Aceptar y Regresar";
            this.btnAceptarYVolver.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrohistorialDataGridViewTextBoxColumn,
            this.fechamodificacionDataGridViewTextBoxColumn,
            this.motivomodificacionDataGridViewTextBoxColumn,
            this.nroafiliadoDataGridViewTextBoxColumn,
            this.codplanviejoDataGridViewTextBoxColumn,
            this.codplannuevoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.historialBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 136);
            this.dataGridView1.TabIndex = 5;
            // 
            // historialDeCambios
            // 
            this.historialDeCambios.DataSetName = "HistorialDeCambios";
            this.historialDeCambios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historialBindingSource
            // 
            this.historialBindingSource.DataMember = "Historial";
            this.historialBindingSource.DataSource = this.historialDeCambios;
            // 
            // historialTableAdapter
            // 
            this.historialTableAdapter.ClearBeforeFill = true;
            // 
            // nrohistorialDataGridViewTextBoxColumn
            // 
            this.nrohistorialDataGridViewTextBoxColumn.DataPropertyName = "nro_historial";
            this.nrohistorialDataGridViewTextBoxColumn.HeaderText = "nro_historial";
            this.nrohistorialDataGridViewTextBoxColumn.Name = "nrohistorialDataGridViewTextBoxColumn";
            // 
            // fechamodificacionDataGridViewTextBoxColumn
            // 
            this.fechamodificacionDataGridViewTextBoxColumn.DataPropertyName = "fecha_modificacion";
            this.fechamodificacionDataGridViewTextBoxColumn.HeaderText = "fecha_modificacion";
            this.fechamodificacionDataGridViewTextBoxColumn.Name = "fechamodificacionDataGridViewTextBoxColumn";
            // 
            // motivomodificacionDataGridViewTextBoxColumn
            // 
            this.motivomodificacionDataGridViewTextBoxColumn.DataPropertyName = "motivo_modificacion";
            this.motivomodificacionDataGridViewTextBoxColumn.HeaderText = "motivo_modificacion";
            this.motivomodificacionDataGridViewTextBoxColumn.Name = "motivomodificacionDataGridViewTextBoxColumn";
            // 
            // nroafiliadoDataGridViewTextBoxColumn
            // 
            this.nroafiliadoDataGridViewTextBoxColumn.DataPropertyName = "nro_afiliado";
            this.nroafiliadoDataGridViewTextBoxColumn.HeaderText = "nro_afiliado";
            this.nroafiliadoDataGridViewTextBoxColumn.Name = "nroafiliadoDataGridViewTextBoxColumn";
            // 
            // codplanviejoDataGridViewTextBoxColumn
            // 
            this.codplanviejoDataGridViewTextBoxColumn.DataPropertyName = "cod_plan_viejo";
            this.codplanviejoDataGridViewTextBoxColumn.HeaderText = "cod_plan_viejo";
            this.codplanviejoDataGridViewTextBoxColumn.Name = "codplanviejoDataGridViewTextBoxColumn";
            // 
            // codplannuevoDataGridViewTextBoxColumn
            // 
            this.codplannuevoDataGridViewTextBoxColumn.DataPropertyName = "cod_plan_nuevo";
            this.codplannuevoDataGridViewTextBoxColumn.HeaderText = "cod_plan_nuevo";
            this.codplannuevoDataGridViewTextBoxColumn.Name = "codplannuevoDataGridViewTextBoxColumn";
            // 
            // frmHistorialCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 396);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAceptarYVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pnlFiltroParaBuscarHistorial);
            this.Name = "frmHistorialCambios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Cambios ";
            this.Load += new System.EventHandler(this.frmHistorialCambios_Load);
            this.pnlFiltroParaBuscarHistorial.ResumeLayout(false);
            this.pnlFiltroParaBuscarHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialDeCambios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltroParaBuscarHistorial;
        private System.Windows.Forms.TextBox txtNroAfiliado;
        private System.Windows.Forms.TextBox txtNroGrupo;
        private System.Windows.Forms.Label lblNroAfiliado;
        private System.Windows.Forms.Label lblNroGrupo;
        private System.Windows.Forms.Label lblSeleccionarFiltro;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAceptarYVolver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HistorialDeCambios historialDeCambios;
        private System.Windows.Forms.BindingSource historialBindingSource;
        private HistorialDeCambiosTableAdapters.HistorialTableAdapter historialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrohistorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechamodificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivomodificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroafiliadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codplanviejoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codplannuevoDataGridViewTextBoxColumn;
    }
}