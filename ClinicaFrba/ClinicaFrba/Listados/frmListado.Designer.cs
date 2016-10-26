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
            this.dataGridTablaFiltro = new System.Windows.Forms.DataGridView();
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
            this.gD2C2016DataSet = new ClinicaFrba.GD2C2016DataSet();
            this.maestraTableAdapter = new ClinicaFrba.GD2C2016DataSetTableAdapters.MaestraTableAdapter();
            this.pnlFiltroBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTablaFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(52, 143);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(151, 25);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar\r\n";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorrar.Location = new System.Drawing.Point(307, 143);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(151, 26);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
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
            // dataGridTablaFiltro
            // 
            this.dataGridTablaFiltro.AutoGenerateColumns = false;
            this.dataGridTablaFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTablaFiltro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridTablaFiltro.DataSource = this.maestraBindingSource;
            this.dataGridTablaFiltro.Location = new System.Drawing.Point(12, 188);
            this.dataGridTablaFiltro.Name = "dataGridTablaFiltro";
            this.dataGridTablaFiltro.Size = new System.Drawing.Size(645, 143);
            this.dataGridTablaFiltro.TabIndex = 4;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 415);
            this.Controls.Add(this.dataGridTablaFiltro);
            this.Controls.Add(this.lblFiltroBusqueda);
            this.Controls.Add(this.pnlFiltroBusqueda);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlFiltroBusqueda.ResumeLayout(false);
            this.pnlFiltroBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTablaFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maestraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD2C2016DataSet)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridTablaFiltro;
        private GD2C2016DataSet gD2C2016DataSet;
        private System.Windows.Forms.BindingSource maestraBindingSource;
        private GD2C2016DataSetTableAdapters.MaestraTableAdapter maestraTableAdapter;
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
    }
}