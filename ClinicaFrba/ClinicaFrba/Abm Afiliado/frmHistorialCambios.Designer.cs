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
            this.lblSeleccionarFiltro = new System.Windows.Forms.Label();
            this.lblNroGrupo = new System.Windows.Forms.Label();
            this.lblNroAfiliado = new System.Windows.Forms.Label();
            this.txtNroGrupo = new System.Windows.Forms.TextBox();
            this.txtNroAfiliado = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gD2C2016DataSet2 = new ClinicaFrba.GD2C2016DataSet2();
            this.maestraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maestraTableAdapter = new ClinicaFrba.GD2C2016DataSet2TableAdapters.MaestraTableAdapter();
            this.dgvGrillaDeHistorialDeCambios = new System.Windows.Forms.DataGridView();
            this.pacienteNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteDniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteDireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteFechaNacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planMedCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planMedDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planMedPrecioBonoConsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planMedPrecioBonoFarmaciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoFechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaSintomasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultaEnfermedadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoDniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoDireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicoFechaNacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEspecialidadCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEspecialidadDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraBonoFechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonoConsultaFechaImpresionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonoConsultaNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gD2C2016DataSet21 = new ClinicaFrba.GD2C2016DataSet2();
            this.maestraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAceptarYVolver = new System.Windows.Forms.Button();
            this.pnlFiltroParaBuscarHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaDeHistorialDeCambios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource1)).BeginInit();
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
            // lblSeleccionarFiltro
            // 
            this.lblSeleccionarFiltro.AutoSize = true;
            this.lblSeleccionarFiltro.Location = new System.Drawing.Point(24, 0);
            this.lblSeleccionarFiltro.Name = "lblSeleccionarFiltro";
            this.lblSeleccionarFiltro.Size = new System.Drawing.Size(167, 13);
            this.lblSeleccionarFiltro.TabIndex = 0;
            this.lblSeleccionarFiltro.Text = "Filtro para el historial de busqueda";
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
            // lblNroAfiliado
            // 
            this.lblNroAfiliado.AutoSize = true;
            this.lblNroAfiliado.Location = new System.Drawing.Point(34, 76);
            this.lblNroAfiliado.Name = "lblNroAfiliado";
            this.lblNroAfiliado.Size = new System.Drawing.Size(64, 13);
            this.lblNroAfiliado.TabIndex = 2;
            this.lblNroAfiliado.Text = "Nro Afiliado:";
            // 
            // txtNroGrupo
            // 
            this.txtNroGrupo.Location = new System.Drawing.Point(149, 29);
            this.txtNroGrupo.Name = "txtNroGrupo";
            this.txtNroGrupo.Size = new System.Drawing.Size(183, 20);
            this.txtNroGrupo.TabIndex = 3;
            // 
            // txtNroAfiliado
            // 
            this.txtNroAfiliado.Location = new System.Drawing.Point(149, 69);
            this.txtNroAfiliado.Name = "txtNroAfiliado";
            this.txtNroAfiliado.Size = new System.Drawing.Size(183, 20);
            this.txtNroAfiliado.TabIndex = 4;
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
            // gD2C2016DataSet2
            // 
            this.gD2C2016DataSet2.DataSetName = "GD2C2016DataSet2";
            this.gD2C2016DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maestraBindingSource
            // 
            this.maestraBindingSource.DataMember = "Maestra";
            this.maestraBindingSource.DataSource = this.gD2C2016DataSet2;
            // 
            // maestraTableAdapter
            // 
            this.maestraTableAdapter.ClearBeforeFill = true;
            // 
            // dgvGrillaDeHistorialDeCambios
            // 
            this.dgvGrillaDeHistorialDeCambios.AutoGenerateColumns = false;
            this.dgvGrillaDeHistorialDeCambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaDeHistorialDeCambios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pacienteNombreDataGridViewTextBoxColumn,
            this.pacienteApellidoDataGridViewTextBoxColumn,
            this.pacienteDniDataGridViewTextBoxColumn,
            this.pacienteDireccionDataGridViewTextBoxColumn,
            this.pacienteTelefonoDataGridViewTextBoxColumn,
            this.pacienteMailDataGridViewTextBoxColumn,
            this.pacienteFechaNacDataGridViewTextBoxColumn,
            this.planMedCodigoDataGridViewTextBoxColumn,
            this.planMedDescripcionDataGridViewTextBoxColumn,
            this.planMedPrecioBonoConsultaDataGridViewTextBoxColumn,
            this.planMedPrecioBonoFarmaciaDataGridViewTextBoxColumn,
            this.turnoNumeroDataGridViewTextBoxColumn,
            this.turnoFechaDataGridViewTextBoxColumn,
            this.consultaSintomasDataGridViewTextBoxColumn,
            this.consultaEnfermedadesDataGridViewTextBoxColumn,
            this.medicoNombreDataGridViewTextBoxColumn,
            this.medicoApellidoDataGridViewTextBoxColumn,
            this.medicoDniDataGridViewTextBoxColumn,
            this.medicoDireccionDataGridViewTextBoxColumn,
            this.medicoTelefonoDataGridViewTextBoxColumn,
            this.medicoMailDataGridViewTextBoxColumn,
            this.medicoFechaNacDataGridViewTextBoxColumn,
            this.especialidadCodigoDataGridViewTextBoxColumn,
            this.especialidadDescripcionDataGridViewTextBoxColumn,
            this.tipoEspecialidadCodigoDataGridViewTextBoxColumn,
            this.tipoEspecialidadDescripcionDataGridViewTextBoxColumn,
            this.compraBonoFechaDataGridViewTextBoxColumn,
            this.bonoConsultaFechaImpresionDataGridViewTextBoxColumn,
            this.bonoConsultaNumeroDataGridViewTextBoxColumn});
            this.dgvGrillaDeHistorialDeCambios.DataSource = this.maestraBindingSource1;
            this.dgvGrillaDeHistorialDeCambios.Location = new System.Drawing.Point(12, 187);
            this.dgvGrillaDeHistorialDeCambios.Name = "dgvGrillaDeHistorialDeCambios";
            this.dgvGrillaDeHistorialDeCambios.Size = new System.Drawing.Size(424, 114);
            this.dgvGrillaDeHistorialDeCambios.TabIndex = 3;
            // 
            // pacienteNombreDataGridViewTextBoxColumn
            // 
            this.pacienteNombreDataGridViewTextBoxColumn.DataPropertyName = "Paciente_Nombre";
            this.pacienteNombreDataGridViewTextBoxColumn.HeaderText = "Paciente_Nombre";
            this.pacienteNombreDataGridViewTextBoxColumn.Name = "pacienteNombreDataGridViewTextBoxColumn";
            // 
            // pacienteApellidoDataGridViewTextBoxColumn
            // 
            this.pacienteApellidoDataGridViewTextBoxColumn.DataPropertyName = "Paciente_Apellido";
            this.pacienteApellidoDataGridViewTextBoxColumn.HeaderText = "Paciente_Apellido";
            this.pacienteApellidoDataGridViewTextBoxColumn.Name = "pacienteApellidoDataGridViewTextBoxColumn";
            // 
            // pacienteDniDataGridViewTextBoxColumn
            // 
            this.pacienteDniDataGridViewTextBoxColumn.DataPropertyName = "Paciente_Dni";
            this.pacienteDniDataGridViewTextBoxColumn.HeaderText = "Paciente_Dni";
            this.pacienteDniDataGridViewTextBoxColumn.Name = "pacienteDniDataGridViewTextBoxColumn";
            // 
            // pacienteDireccionDataGridViewTextBoxColumn
            // 
            this.pacienteDireccionDataGridViewTextBoxColumn.DataPropertyName = "Paciente_Direccion";
            this.pacienteDireccionDataGridViewTextBoxColumn.HeaderText = "Paciente_Direccion";
            this.pacienteDireccionDataGridViewTextBoxColumn.Name = "pacienteDireccionDataGridViewTextBoxColumn";
            // 
            // pacienteTelefonoDataGridViewTextBoxColumn
            // 
            this.pacienteTelefonoDataGridViewTextBoxColumn.DataPropertyName = "Paciente_Telefono";
            this.pacienteTelefonoDataGridViewTextBoxColumn.HeaderText = "Paciente_Telefono";
            this.pacienteTelefonoDataGridViewTextBoxColumn.Name = "pacienteTelefonoDataGridViewTextBoxColumn";
            // 
            // pacienteMailDataGridViewTextBoxColumn
            // 
            this.pacienteMailDataGridViewTextBoxColumn.DataPropertyName = "Paciente_Mail";
            this.pacienteMailDataGridViewTextBoxColumn.HeaderText = "Paciente_Mail";
            this.pacienteMailDataGridViewTextBoxColumn.Name = "pacienteMailDataGridViewTextBoxColumn";
            // 
            // pacienteFechaNacDataGridViewTextBoxColumn
            // 
            this.pacienteFechaNacDataGridViewTextBoxColumn.DataPropertyName = "Paciente_Fecha_Nac";
            this.pacienteFechaNacDataGridViewTextBoxColumn.HeaderText = "Paciente_Fecha_Nac";
            this.pacienteFechaNacDataGridViewTextBoxColumn.Name = "pacienteFechaNacDataGridViewTextBoxColumn";
            // 
            // planMedCodigoDataGridViewTextBoxColumn
            // 
            this.planMedCodigoDataGridViewTextBoxColumn.DataPropertyName = "Plan_Med_Codigo";
            this.planMedCodigoDataGridViewTextBoxColumn.HeaderText = "Plan_Med_Codigo";
            this.planMedCodigoDataGridViewTextBoxColumn.Name = "planMedCodigoDataGridViewTextBoxColumn";
            // 
            // planMedDescripcionDataGridViewTextBoxColumn
            // 
            this.planMedDescripcionDataGridViewTextBoxColumn.DataPropertyName = "Plan_Med_Descripcion";
            this.planMedDescripcionDataGridViewTextBoxColumn.HeaderText = "Plan_Med_Descripcion";
            this.planMedDescripcionDataGridViewTextBoxColumn.Name = "planMedDescripcionDataGridViewTextBoxColumn";
            // 
            // planMedPrecioBonoConsultaDataGridViewTextBoxColumn
            // 
            this.planMedPrecioBonoConsultaDataGridViewTextBoxColumn.DataPropertyName = "Plan_Med_Precio_Bono_Consulta";
            this.planMedPrecioBonoConsultaDataGridViewTextBoxColumn.HeaderText = "Plan_Med_Precio_Bono_Consulta";
            this.planMedPrecioBonoConsultaDataGridViewTextBoxColumn.Name = "planMedPrecioBonoConsultaDataGridViewTextBoxColumn";
            // 
            // planMedPrecioBonoFarmaciaDataGridViewTextBoxColumn
            // 
            this.planMedPrecioBonoFarmaciaDataGridViewTextBoxColumn.DataPropertyName = "Plan_Med_Precio_Bono_Farmacia";
            this.planMedPrecioBonoFarmaciaDataGridViewTextBoxColumn.HeaderText = "Plan_Med_Precio_Bono_Farmacia";
            this.planMedPrecioBonoFarmaciaDataGridViewTextBoxColumn.Name = "planMedPrecioBonoFarmaciaDataGridViewTextBoxColumn";
            // 
            // turnoNumeroDataGridViewTextBoxColumn
            // 
            this.turnoNumeroDataGridViewTextBoxColumn.DataPropertyName = "Turno_Numero";
            this.turnoNumeroDataGridViewTextBoxColumn.HeaderText = "Turno_Numero";
            this.turnoNumeroDataGridViewTextBoxColumn.Name = "turnoNumeroDataGridViewTextBoxColumn";
            // 
            // turnoFechaDataGridViewTextBoxColumn
            // 
            this.turnoFechaDataGridViewTextBoxColumn.DataPropertyName = "Turno_Fecha";
            this.turnoFechaDataGridViewTextBoxColumn.HeaderText = "Turno_Fecha";
            this.turnoFechaDataGridViewTextBoxColumn.Name = "turnoFechaDataGridViewTextBoxColumn";
            // 
            // consultaSintomasDataGridViewTextBoxColumn
            // 
            this.consultaSintomasDataGridViewTextBoxColumn.DataPropertyName = "Consulta_Sintomas";
            this.consultaSintomasDataGridViewTextBoxColumn.HeaderText = "Consulta_Sintomas";
            this.consultaSintomasDataGridViewTextBoxColumn.Name = "consultaSintomasDataGridViewTextBoxColumn";
            // 
            // consultaEnfermedadesDataGridViewTextBoxColumn
            // 
            this.consultaEnfermedadesDataGridViewTextBoxColumn.DataPropertyName = "Consulta_Enfermedades";
            this.consultaEnfermedadesDataGridViewTextBoxColumn.HeaderText = "Consulta_Enfermedades";
            this.consultaEnfermedadesDataGridViewTextBoxColumn.Name = "consultaEnfermedadesDataGridViewTextBoxColumn";
            // 
            // medicoNombreDataGridViewTextBoxColumn
            // 
            this.medicoNombreDataGridViewTextBoxColumn.DataPropertyName = "Medico_Nombre";
            this.medicoNombreDataGridViewTextBoxColumn.HeaderText = "Medico_Nombre";
            this.medicoNombreDataGridViewTextBoxColumn.Name = "medicoNombreDataGridViewTextBoxColumn";
            // 
            // medicoApellidoDataGridViewTextBoxColumn
            // 
            this.medicoApellidoDataGridViewTextBoxColumn.DataPropertyName = "Medico_Apellido";
            this.medicoApellidoDataGridViewTextBoxColumn.HeaderText = "Medico_Apellido";
            this.medicoApellidoDataGridViewTextBoxColumn.Name = "medicoApellidoDataGridViewTextBoxColumn";
            // 
            // medicoDniDataGridViewTextBoxColumn
            // 
            this.medicoDniDataGridViewTextBoxColumn.DataPropertyName = "Medico_Dni";
            this.medicoDniDataGridViewTextBoxColumn.HeaderText = "Medico_Dni";
            this.medicoDniDataGridViewTextBoxColumn.Name = "medicoDniDataGridViewTextBoxColumn";
            // 
            // medicoDireccionDataGridViewTextBoxColumn
            // 
            this.medicoDireccionDataGridViewTextBoxColumn.DataPropertyName = "Medico_Direccion";
            this.medicoDireccionDataGridViewTextBoxColumn.HeaderText = "Medico_Direccion";
            this.medicoDireccionDataGridViewTextBoxColumn.Name = "medicoDireccionDataGridViewTextBoxColumn";
            // 
            // medicoTelefonoDataGridViewTextBoxColumn
            // 
            this.medicoTelefonoDataGridViewTextBoxColumn.DataPropertyName = "Medico_Telefono";
            this.medicoTelefonoDataGridViewTextBoxColumn.HeaderText = "Medico_Telefono";
            this.medicoTelefonoDataGridViewTextBoxColumn.Name = "medicoTelefonoDataGridViewTextBoxColumn";
            // 
            // medicoMailDataGridViewTextBoxColumn
            // 
            this.medicoMailDataGridViewTextBoxColumn.DataPropertyName = "Medico_Mail";
            this.medicoMailDataGridViewTextBoxColumn.HeaderText = "Medico_Mail";
            this.medicoMailDataGridViewTextBoxColumn.Name = "medicoMailDataGridViewTextBoxColumn";
            // 
            // medicoFechaNacDataGridViewTextBoxColumn
            // 
            this.medicoFechaNacDataGridViewTextBoxColumn.DataPropertyName = "Medico_Fecha_Nac";
            this.medicoFechaNacDataGridViewTextBoxColumn.HeaderText = "Medico_Fecha_Nac";
            this.medicoFechaNacDataGridViewTextBoxColumn.Name = "medicoFechaNacDataGridViewTextBoxColumn";
            // 
            // especialidadCodigoDataGridViewTextBoxColumn
            // 
            this.especialidadCodigoDataGridViewTextBoxColumn.DataPropertyName = "Especialidad_Codigo";
            this.especialidadCodigoDataGridViewTextBoxColumn.HeaderText = "Especialidad_Codigo";
            this.especialidadCodigoDataGridViewTextBoxColumn.Name = "especialidadCodigoDataGridViewTextBoxColumn";
            // 
            // especialidadDescripcionDataGridViewTextBoxColumn
            // 
            this.especialidadDescripcionDataGridViewTextBoxColumn.DataPropertyName = "Especialidad_Descripcion";
            this.especialidadDescripcionDataGridViewTextBoxColumn.HeaderText = "Especialidad_Descripcion";
            this.especialidadDescripcionDataGridViewTextBoxColumn.Name = "especialidadDescripcionDataGridViewTextBoxColumn";
            // 
            // tipoEspecialidadCodigoDataGridViewTextBoxColumn
            // 
            this.tipoEspecialidadCodigoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Especialidad_Codigo";
            this.tipoEspecialidadCodigoDataGridViewTextBoxColumn.HeaderText = "Tipo_Especialidad_Codigo";
            this.tipoEspecialidadCodigoDataGridViewTextBoxColumn.Name = "tipoEspecialidadCodigoDataGridViewTextBoxColumn";
            // 
            // tipoEspecialidadDescripcionDataGridViewTextBoxColumn
            // 
            this.tipoEspecialidadDescripcionDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Especialidad_Descripcion";
            this.tipoEspecialidadDescripcionDataGridViewTextBoxColumn.HeaderText = "Tipo_Especialidad_Descripcion";
            this.tipoEspecialidadDescripcionDataGridViewTextBoxColumn.Name = "tipoEspecialidadDescripcionDataGridViewTextBoxColumn";
            // 
            // compraBonoFechaDataGridViewTextBoxColumn
            // 
            this.compraBonoFechaDataGridViewTextBoxColumn.DataPropertyName = "Compra_Bono_Fecha";
            this.compraBonoFechaDataGridViewTextBoxColumn.HeaderText = "Compra_Bono_Fecha";
            this.compraBonoFechaDataGridViewTextBoxColumn.Name = "compraBonoFechaDataGridViewTextBoxColumn";
            // 
            // bonoConsultaFechaImpresionDataGridViewTextBoxColumn
            // 
            this.bonoConsultaFechaImpresionDataGridViewTextBoxColumn.DataPropertyName = "Bono_Consulta_Fecha_Impresion";
            this.bonoConsultaFechaImpresionDataGridViewTextBoxColumn.HeaderText = "Bono_Consulta_Fecha_Impresion";
            this.bonoConsultaFechaImpresionDataGridViewTextBoxColumn.Name = "bonoConsultaFechaImpresionDataGridViewTextBoxColumn";
            // 
            // bonoConsultaNumeroDataGridViewTextBoxColumn
            // 
            this.bonoConsultaNumeroDataGridViewTextBoxColumn.DataPropertyName = "Bono_Consulta_Numero";
            this.bonoConsultaNumeroDataGridViewTextBoxColumn.HeaderText = "Bono_Consulta_Numero";
            this.bonoConsultaNumeroDataGridViewTextBoxColumn.Name = "bonoConsultaNumeroDataGridViewTextBoxColumn";
            // 
            // gD2C2016DataSet21
            // 
            this.gD2C2016DataSet21.DataSetName = "GD2C2016DataSet2";
            this.gD2C2016DataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maestraBindingSource1
            // 
            this.maestraBindingSource1.DataMember = "Maestra";
            this.maestraBindingSource1.DataSource = this.gD2C2016DataSet21;
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
            // frmHistorialCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 396);
            this.Controls.Add(this.btnAceptarYVolver);
            this.Controls.Add(this.dgvGrillaDeHistorialDeCambios);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pnlFiltroParaBuscarHistorial);
            this.Name = "frmHistorialCambios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Cambios ";
            this.Load += new System.EventHandler(this.frmHistorialCambios_Load);
            this.pnlFiltroParaBuscarHistorial.ResumeLayout(false);
            this.pnlFiltroParaBuscarHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaDeHistorialDeCambios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource1)).EndInit();
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
        private GD2C2016DataSet2 gD2C2016DataSet2;
        private System.Windows.Forms.BindingSource maestraBindingSource;
        private GD2C2016DataSet2TableAdapters.MaestraTableAdapter maestraTableAdapter;
        private System.Windows.Forms.DataGridView dgvGrillaDeHistorialDeCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteDniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteDireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteFechaNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planMedCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planMedDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planMedPrecioBonoConsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planMedPrecioBonoFarmaciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turnoFechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultaSintomasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultaEnfermedadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoDniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoDireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicoFechaNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEspecialidadCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEspecialidadDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compraBonoFechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonoConsultaFechaImpresionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonoConsultaNumeroDataGridViewTextBoxColumn;
        private GD2C2016DataSet2 gD2C2016DataSet21;
        private System.Windows.Forms.BindingSource maestraBindingSource1;
        private System.Windows.Forms.Button btnAceptarYVolver;
    }
}