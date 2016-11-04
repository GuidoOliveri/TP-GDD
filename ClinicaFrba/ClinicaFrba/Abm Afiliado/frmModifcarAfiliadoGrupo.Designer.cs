namespace ClinicaFrba.Abm_Afiliado
{
    partial class frmModifcarAfiliado
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
            this.dgvModificacionPacientes = new System.Windows.Forms.DataGridView();
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
            this.maestraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD2C2016DataSet1 = new ClinicaFrba.GD2C2016DataSet1();
            this.maestraTableAdapter = new ClinicaFrba.GD2C2016DataSet1TableAdapters.MaestraTableAdapter();
            this.btnModificarAfiliado = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlFiltroBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificacionPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSet1)).BeginInit();
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
            this.pnlFiltroBusqueda.Location = new System.Drawing.Point(26, 12);
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
            this.btnLimpiar.Location = new System.Drawing.Point(111, 138);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(118, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(326, 138);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvModificacionPacientes
            // 
            this.dgvModificacionPacientes.AutoGenerateColumns = false;
            this.dgvModificacionPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificacionPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvModificacionPacientes.DataSource = this.maestraBindingSource;
            this.dgvModificacionPacientes.Location = new System.Drawing.Point(36, 187);
            this.dgvModificacionPacientes.Name = "dgvModificacionPacientes";
            this.dgvModificacionPacientes.Size = new System.Drawing.Size(525, 157);
            this.dgvModificacionPacientes.TabIndex = 3;
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
            // maestraBindingSource
            // 
            this.maestraBindingSource.DataMember = "Maestra";
            this.maestraBindingSource.DataSource = this.gD2C2016DataSet1;
            // 
            // gD2C2016DataSet1
            // 
            this.gD2C2016DataSet1.DataSetName = "GD2C2016DataSet1";
            this.gD2C2016DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maestraTableAdapter
            // 
            this.maestraTableAdapter.ClearBeforeFill = true;
            // 
            // btnModificarAfiliado
            // 
            this.btnModificarAfiliado.Location = new System.Drawing.Point(60, 361);
            this.btnModificarAfiliado.Name = "btnModificarAfiliado";
            this.btnModificarAfiliado.Size = new System.Drawing.Size(178, 32);
            this.btnModificarAfiliado.TabIndex = 4;
            this.btnModificarAfiliado.Text = "ModificarAfiliado";
            this.btnModificarAfiliado.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(349, 361);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(178, 32);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmModifcarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 402);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificarAfiliado);
            this.Controls.Add(this.dgvModificacionPacientes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pnlFiltroBusqueda);
            this.Name = "frmModifcarAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion Afiliado ";
            this.Load += new System.EventHandler(this.frmModifcarAfiliadoGrupo_Load);
            this.pnlFiltroBusqueda.ResumeLayout(false);
            this.pnlFiltroBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificacionPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSet1)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvModificacionPacientes;
        private GD2C2016DataSet1 gD2C2016DataSet1;
        private System.Windows.Forms.BindingSource maestraBindingSource;
        private GD2C2016DataSet1TableAdapters.MaestraTableAdapter maestraTableAdapter;
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
        private System.Windows.Forms.Button btnModificarAfiliado;
        private System.Windows.Forms.Button btnVolver;
    }
}