namespace ClinicaFrba.Abm_Afiliado
{
    partial class frmAltaAfiliado
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlDatosPersonales = new System.Windows.Forms.Panel();
            this.pnlDireccion = new System.Windows.Forms.Panel();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblDepto = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.txtCantFam = new System.Windows.Forms.TextBox();
            this.lblCantFam = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblDatosPersonales = new System.Windows.Forms.Label();
            this.optFemenino = new System.Windows.Forms.RadioButton();
            this.optMasculino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.dtpFecNac = new System.Windows.Forms.DateTimePicker();
            this.lblFecNac = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlDatosEspecificos = new System.Windows.Forms.Panel();
            this.cmbPlanMedico = new System.Windows.Forms.ComboBox();
            this.lblAltaFamiliar = new System.Windows.Forms.Label();
            this.lblPlanMedico = new System.Windows.Forms.Label();
            this.lblDatosEspecificos = new System.Windows.Forms.Label();
            this.lblAclaracion = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmdAsociarAfiliado = new System.Windows.Forms.Button();
            this.pnlDatosPersonales.SuspendLayout();
            this.pnlDireccion.SuspendLayout();
            this.pnlDatosEspecificos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(141, 309);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(91, 41);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar datos";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(23, 308);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 42);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar Formularios";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pnlDatosPersonales
            // 
            this.pnlDatosPersonales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosPersonales.Controls.Add(this.pnlDireccion);
            this.pnlDatosPersonales.Controls.Add(this.txtCantFam);
            this.pnlDatosPersonales.Controls.Add(this.lblCantFam);
            this.pnlDatosPersonales.Controls.Add(this.cmbEstadoCivil);
            this.pnlDatosPersonales.Controls.Add(this.lblEstadoCivil);
            this.pnlDatosPersonales.Controls.Add(this.lblDatosPersonales);
            this.pnlDatosPersonales.Controls.Add(this.optFemenino);
            this.pnlDatosPersonales.Controls.Add(this.optMasculino);
            this.pnlDatosPersonales.Controls.Add(this.lblSexo);
            this.pnlDatosPersonales.Controls.Add(this.dtpFecNac);
            this.pnlDatosPersonales.Controls.Add(this.lblFecNac);
            this.pnlDatosPersonales.Controls.Add(this.txtMail);
            this.pnlDatosPersonales.Controls.Add(this.lblMail);
            this.pnlDatosPersonales.Controls.Add(this.txtTel);
            this.pnlDatosPersonales.Controls.Add(this.lblTel);
            this.pnlDatosPersonales.Controls.Add(this.txtNroDoc);
            this.pnlDatosPersonales.Controls.Add(this.cmbTipoDoc);
            this.pnlDatosPersonales.Controls.Add(this.lblDni);
            this.pnlDatosPersonales.Controls.Add(this.txtApellido);
            this.pnlDatosPersonales.Controls.Add(this.lblApellido);
            this.pnlDatosPersonales.Controls.Add(this.txtNombre);
            this.pnlDatosPersonales.Controls.Add(this.lblNombre);
            this.pnlDatosPersonales.Location = new System.Drawing.Point(23, 9);
            this.pnlDatosPersonales.Name = "pnlDatosPersonales";
            this.pnlDatosPersonales.Size = new System.Drawing.Size(640, 220);
            this.pnlDatosPersonales.TabIndex = 2;
            this.pnlDatosPersonales.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDatosPersonales_Paint);
            // 
            // pnlDireccion
            // 
            this.pnlDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDireccion.Controls.Add(this.txtDepto);
            this.pnlDireccion.Controls.Add(this.txtPiso);
            this.pnlDireccion.Controls.Add(this.txtAltura);
            this.pnlDireccion.Controls.Add(this.txtCalle);
            this.pnlDireccion.Controls.Add(this.lblDepto);
            this.pnlDireccion.Controls.Add(this.lblPiso);
            this.pnlDireccion.Controls.Add(this.lblAlt);
            this.pnlDireccion.Controls.Add(this.lblCalle);
            this.pnlDireccion.Controls.Add(this.lblDir);
            this.pnlDireccion.Location = new System.Drawing.Point(17, 115);
            this.pnlDireccion.Name = "pnlDireccion";
            this.pnlDireccion.Size = new System.Drawing.Size(317, 68);
            this.pnlDireccion.TabIndex = 22;
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(185, 38);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(72, 20);
            this.txtDepto.TabIndex = 8;
            this.txtDepto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepto_KeyPress);
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(61, 38);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(72, 20);
            this.txtPiso.TabIndex = 7;
            this.txtPiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPiso_KeyPress);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(185, 11);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(72, 20);
            this.txtAltura.TabIndex = 6;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(61, 12);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(72, 20);
            this.txtCalle.TabIndex = 5;
            this.txtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalle_KeyPress);
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Location = new System.Drawing.Point(145, 41);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(39, 13);
            this.lblDepto.TabIndex = 4;
            this.lblDepto.Text = "Depto:";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(13, 38);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(30, 13);
            this.lblPiso.TabIndex = 3;
            this.lblPiso.Text = "Piso:";
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.Location = new System.Drawing.Point(145, 15);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(41, 13);
            this.lblAlt.TabIndex = 2;
            this.lblAlt.Text = "*Altura:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(13, 15);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(37, 13);
            this.lblCalle.TabIndex = 1;
            this.lblCalle.Text = "*Calle:";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(7, -1);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(52, 13);
            this.lblDir.TabIndex = 0;
            this.lblDir.Text = "Direccion";
            // 
            // txtCantFam
            // 
            this.txtCantFam.Location = new System.Drawing.Point(469, 154);
            this.txtCantFam.Name = "txtCantFam";
            this.txtCantFam.Size = new System.Drawing.Size(149, 20);
            this.txtCantFam.TabIndex = 21;
            this.txtCantFam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantFam_KeyPress);
            // 
            // lblCantFam
            // 
            this.lblCantFam.AutoSize = true;
            this.lblCantFam.Location = new System.Drawing.Point(364, 157);
            this.lblCantFam.Name = "lblCantFam";
            this.lblCantFam.Size = new System.Drawing.Size(80, 13);
            this.lblCantFam.TabIndex = 20;
            this.lblCantFam.Text = "*Cantidad hijos:";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Concubinato",
            "Divorciado/a"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(439, 123);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(179, 21);
            this.cmbEstadoCivil.TabIndex = 19;
            this.cmbEstadoCivil.SelectedIndexChanged += new System.EventHandler(this.cboEstadoCivil_SelectedIndexChanged);
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(364, 127);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(69, 13);
            this.lblEstadoCivil.TabIndex = 18;
            this.lblEstadoCivil.Text = "*Estado Civil:";
            // 
            // lblDatosPersonales
            // 
            this.lblDatosPersonales.AutoSize = true;
            this.lblDatosPersonales.Location = new System.Drawing.Point(18, 0);
            this.lblDatosPersonales.Name = "lblDatosPersonales";
            this.lblDatosPersonales.Size = new System.Drawing.Size(144, 13);
            this.lblDatosPersonales.TabIndex = 0;
            this.lblDatosPersonales.Text = "Datos Personales del Afiliado";
            // 
            // optFemenino
            // 
            this.optFemenino.AutoSize = true;
            this.optFemenino.Location = new System.Drawing.Point(540, 96);
            this.optFemenino.Name = "optFemenino";
            this.optFemenino.Size = new System.Drawing.Size(71, 17);
            this.optFemenino.TabIndex = 17;
            this.optFemenino.Text = "Femenino";
            this.optFemenino.UseVisualStyleBackColor = true;
            // 
            // optMasculino
            // 
            this.optMasculino.AutoSize = true;
            this.optMasculino.Location = new System.Drawing.Point(439, 96);
            this.optMasculino.Name = "optMasculino";
            this.optMasculino.Size = new System.Drawing.Size(73, 17);
            this.optMasculino.TabIndex = 16;
            this.optMasculino.Text = "Masculino";
            this.optMasculino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(364, 96);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 13);
            this.lblSexo.TabIndex = 15;
            this.lblSexo.Text = "*Sexo:";
            // 
            // dtpFecNac
            // 
            this.dtpFecNac.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpFecNac.CustomFormat = "dd-MM-yyyy 0:00:00";
            this.dtpFecNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecNac.Location = new System.Drawing.Point(485, 61);
            this.dtpFecNac.Name = "dtpFecNac";
            this.dtpFecNac.Size = new System.Drawing.Size(133, 20);
            this.dtpFecNac.TabIndex = 14;
            // 
            // lblFecNac
            // 
            this.lblFecNac.AutoSize = true;
            this.lblFecNac.Location = new System.Drawing.Point(364, 61);
            this.lblFecNac.Name = "lblFecNac";
            this.lblFecNac.Size = new System.Drawing.Size(113, 13);
            this.lblFecNac.TabIndex = 13;
            this.lblFecNac.Text = "*Fecha de nacimiento:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(417, 25);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(201, 20);
            this.txtMail.TabIndex = 12;
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(364, 26);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 13);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "*Mail:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(157, 189);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(181, 20);
            this.txtTel.TabIndex = 10;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(14, 192);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(137, 13);
            this.lblTel.TabIndex = 9;
            this.lblTel.Text = "*Teléfono (Particular o Fijo):";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(184, 88);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(150, 20);
            this.txtNroDoc.TabIndex = 6;
            this.txtNroDoc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtNroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroDoc_KeyPress);
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Items.AddRange(new object[] {
            "D.N.I.",
            "L.E.",
            "L.C.",
            "C.I.",
            "Pasaporte"});
            this.cmbTipoDoc.Location = new System.Drawing.Point(93, 88);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(85, 21);
            this.cmbTipoDoc.TabIndex = 5;
            this.cmbTipoDoc.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDoc_SelectedIndexChanged);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(14, 91);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(69, 13);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "*Documento:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(93, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(241, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(18, 57);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "*Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 23);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "*Nombre:";
            // 
            // pnlDatosEspecificos
            // 
            this.pnlDatosEspecificos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosEspecificos.Controls.Add(this.cmbPlanMedico);
            this.pnlDatosEspecificos.Controls.Add(this.lblAltaFamiliar);
            this.pnlDatosEspecificos.Controls.Add(this.lblPlanMedico);
            this.pnlDatosEspecificos.Controls.Add(this.lblDatosEspecificos);
            this.pnlDatosEspecificos.Location = new System.Drawing.Point(23, 235);
            this.pnlDatosEspecificos.Name = "pnlDatosEspecificos";
            this.pnlDatosEspecificos.Size = new System.Drawing.Size(639, 67);
            this.pnlDatosEspecificos.TabIndex = 3;
            // 
            // cmbPlanMedico
            // 
            this.cmbPlanMedico.FormattingEnabled = true;
            this.cmbPlanMedico.Items.AddRange(new object[] {
            "(ninguno)"});
            this.cmbPlanMedico.Location = new System.Drawing.Point(260, 22);
            this.cmbPlanMedico.Name = "cmbPlanMedico";
            this.cmbPlanMedico.Size = new System.Drawing.Size(167, 21);
            this.cmbPlanMedico.TabIndex = 15;
            // 
            // lblAltaFamiliar
            // 
            this.lblAltaFamiliar.AutoSize = true;
            this.lblAltaFamiliar.Location = new System.Drawing.Point(466, 19);
            this.lblAltaFamiliar.Name = "lblAltaFamiliar";
            this.lblAltaFamiliar.Size = new System.Drawing.Size(0, 13);
            this.lblAltaFamiliar.TabIndex = 14;
            // 
            // lblPlanMedico
            // 
            this.lblPlanMedico.AutoSize = true;
            this.lblPlanMedico.Location = new System.Drawing.Point(181, 30);
            this.lblPlanMedico.Name = "lblPlanMedico";
            this.lblPlanMedico.Size = new System.Drawing.Size(73, 13);
            this.lblPlanMedico.TabIndex = 1;
            this.lblPlanMedico.Text = "*Plan Medico:";
            // 
            // lblDatosEspecificos
            // 
            this.lblDatosEspecificos.AutoSize = true;
            this.lblDatosEspecificos.Location = new System.Drawing.Point(25, -1);
            this.lblDatosEspecificos.Name = "lblDatosEspecificos";
            this.lblDatosEspecificos.Size = new System.Drawing.Size(126, 13);
            this.lblDatosEspecificos.TabIndex = 0;
            this.lblDatosEspecificos.Text = "Datos Especificos Clinica";
            // 
            // lblAclaracion
            // 
            this.lblAclaracion.AutoSize = true;
            this.lblAclaracion.Location = new System.Drawing.Point(491, 324);
            this.lblAclaracion.Name = "lblAclaracion";
            this.lblAclaracion.Size = new System.Drawing.Size(209, 13);
            this.lblAclaracion.TabIndex = 4;
            this.lblAclaracion.Text = "Aclaración: Los campos (*) son obligatorios";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(384, 308);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 42);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmdAsociarAfiliado
            // 
            this.cmdAsociarAfiliado.Location = new System.Drawing.Point(258, 309);
            this.cmdAsociarAfiliado.Name = "cmdAsociarAfiliado";
            this.cmdAsociarAfiliado.Size = new System.Drawing.Size(100, 42);
            this.cmdAsociarAfiliado.TabIndex = 6;
            this.cmdAsociarAfiliado.Text = "Asociar Afiliado a un Grupo";
            this.cmdAsociarAfiliado.UseVisualStyleBackColor = true;
            this.cmdAsociarAfiliado.Click += new System.EventHandler(this.cmdAsociarAfiliado_Click);
            // 
            // frmAltaAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 380);
            this.Controls.Add(this.cmdAsociarAfiliado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblAclaracion);
            this.Controls.Add(this.pnlDatosEspecificos);
            this.Controls.Add(this.pnlDatosPersonales);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "frmAltaAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Afiliado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAltaAfiliado_FormClosing);
            this.Load += new System.EventHandler(this.frmAltaAfiliado_Load);
            this.pnlDatosPersonales.ResumeLayout(false);
            this.pnlDatosPersonales.PerformLayout();
            this.pnlDireccion.ResumeLayout(false);
            this.pnlDireccion.PerformLayout();
            this.pnlDatosEspecificos.ResumeLayout(false);
            this.pnlDatosEspecificos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel pnlDatosPersonales;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDatosPersonales;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblFecNac;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DateTimePicker dtpFecNac;
        private System.Windows.Forms.RadioButton optFemenino;
        private System.Windows.Forms.RadioButton optMasculino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.TextBox txtCantFam;
        private System.Windows.Forms.Label lblCantFam;
        private System.Windows.Forms.Panel pnlDatosEspecificos;
        private System.Windows.Forms.Label lblDatosEspecificos;
        private System.Windows.Forms.Label lblPlanMedico;
        private System.Windows.Forms.Label lblAclaracion;
        private System.Windows.Forms.Label lblAltaFamiliar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmbPlanMedico;
        private System.Windows.Forms.Button cmdAsociarAfiliado;
        private System.Windows.Forms.Panel pnlDireccion;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblDir;
    }
}