namespace ClinicaFrba.Abm_Profesional
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
            this.lblGrupoFamiliar = new System.Windows.Forms.Label();
            this.lblGrupoFam = new System.Windows.Forms.Label();
            this.txtCantFam = new System.Windows.Forms.TextBox();
            this.lblCantFam = new System.Windows.Forms.Label();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
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
            this.txtDir = new System.Windows.Forms.TextBox();
            this.lblDireccionCompleta = new System.Windows.Forms.Label();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlDatosEspecificos = new System.Windows.Forms.Panel();
            this.dtpFechaCambioPlan = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCambioPlan = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivoCambio = new System.Windows.Forms.Label();
            this.btnConyuge = new System.Windows.Forms.Button();
            this.btnHijo = new System.Windows.Forms.Button();
            this.lblAltaFamiliar = new System.Windows.Forms.Label();
            this.txtNroAfiliado = new System.Windows.Forms.TextBox();
            this.lblNroAfiliado = new System.Windows.Forms.Label();
            this.txtPlanMedico = new System.Windows.Forms.TextBox();
            this.lblPlanMedico = new System.Windows.Forms.Label();
            this.lblDatosEspecificos = new System.Windows.Forms.Label();
            this.lblAclaracion = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlDatosPersonales.SuspendLayout();
            this.pnlDatosEspecificos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(176, 308);
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
            this.pnlDatosPersonales.Controls.Add(this.lblGrupoFamiliar);
            this.pnlDatosPersonales.Controls.Add(this.lblGrupoFam);
            this.pnlDatosPersonales.Controls.Add(this.txtCantFam);
            this.pnlDatosPersonales.Controls.Add(this.lblCantFam);
            this.pnlDatosPersonales.Controls.Add(this.cboEstadoCivil);
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
            this.pnlDatosPersonales.Controls.Add(this.txtDir);
            this.pnlDatosPersonales.Controls.Add(this.lblDireccionCompleta);
            this.pnlDatosPersonales.Controls.Add(this.txtNroDoc);
            this.pnlDatosPersonales.Controls.Add(this.cboTipoDoc);
            this.pnlDatosPersonales.Controls.Add(this.lblDni);
            this.pnlDatosPersonales.Controls.Add(this.txtApellido);
            this.pnlDatosPersonales.Controls.Add(this.lblApellido);
            this.pnlDatosPersonales.Controls.Add(this.txtNombre);
            this.pnlDatosPersonales.Controls.Add(this.lblNombre);
            this.pnlDatosPersonales.Location = new System.Drawing.Point(23, 9);
            this.pnlDatosPersonales.Name = "pnlDatosPersonales";
            this.pnlDatosPersonales.Size = new System.Drawing.Size(640, 201);
            this.pnlDatosPersonales.TabIndex = 2;
            this.pnlDatosPersonales.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDatosPersonales_Paint);
            // 
            // lblGrupoFamiliar
            // 
            this.lblGrupoFamiliar.AutoSize = true;
            this.lblGrupoFamiliar.Location = new System.Drawing.Point(455, 178);
            this.lblGrupoFamiliar.Name = "lblGrupoFamiliar";
            this.lblGrupoFamiliar.Size = new System.Drawing.Size(35, 13);
            this.lblGrupoFamiliar.TabIndex = 23;
            this.lblGrupoFamiliar.Text = "XXXX";
            // 
            // lblGrupoFam
            // 
            this.lblGrupoFam.AutoSize = true;
            this.lblGrupoFam.Location = new System.Drawing.Point(364, 178);
            this.lblGrupoFam.Name = "lblGrupoFam";
            this.lblGrupoFam.Size = new System.Drawing.Size(77, 13);
            this.lblGrupoFam.TabIndex = 22;
            this.lblGrupoFam.Text = "Grupo Familiar:";
            // 
            // txtCantFam
            // 
            this.txtCantFam.Location = new System.Drawing.Point(514, 148);
            this.txtCantFam.Name = "txtCantFam";
            this.txtCantFam.Size = new System.Drawing.Size(97, 20);
            this.txtCantFam.TabIndex = 21;
            // 
            // lblCantFam
            // 
            this.lblCantFam.AutoSize = true;
            this.lblCantFam.Location = new System.Drawing.Point(364, 148);
            this.lblCantFam.Name = "lblCantFam";
            this.lblCantFam.Size = new System.Drawing.Size(80, 13);
            this.lblCantFam.TabIndex = 20;
            this.lblCantFam.Text = "*Cantidad hijos:";
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Concubinato",
            "Divorciado/a"});
            this.cboEstadoCivil.Location = new System.Drawing.Point(439, 117);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(179, 21);
            this.cboEstadoCivil.TabIndex = 19;
            this.cboEstadoCivil.SelectedIndexChanged += new System.EventHandler(this.cboEstadoCivil_SelectedIndexChanged);
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(364, 120);
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
            this.optFemenino.Location = new System.Drawing.Point(518, 88);
            this.optFemenino.Name = "optFemenino";
            this.optFemenino.Size = new System.Drawing.Size(71, 17);
            this.optFemenino.TabIndex = 17;
            this.optFemenino.TabStop = true;
            this.optFemenino.Text = "Femenino";
            this.optFemenino.UseVisualStyleBackColor = true;
            // 
            // optMasculino
            // 
            this.optMasculino.AutoSize = true;
            this.optMasculino.Location = new System.Drawing.Point(417, 86);
            this.optMasculino.Name = "optMasculino";
            this.optMasculino.Size = new System.Drawing.Size(73, 17);
            this.optMasculino.TabIndex = 16;
            this.optMasculino.TabStop = true;
            this.optMasculino.Text = "Masculino";
            this.optMasculino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(364, 88);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(38, 13);
            this.lblSexo.TabIndex = 15;
            this.lblSexo.Text = "*Sexo:";
            // 
            // dtpFecNac
            // 
            this.dtpFecNac.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpFecNac.CustomFormat = "dd-MM-yyyy";
            this.dtpFecNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecNac.Location = new System.Drawing.Point(485, 54);
            this.dtpFecNac.Name = "dtpFecNac";
            this.dtpFecNac.Size = new System.Drawing.Size(126, 20);
            this.dtpFecNac.TabIndex = 14;
            // 
            // lblFecNac
            // 
            this.lblFecNac.AutoSize = true;
            this.lblFecNac.Location = new System.Drawing.Point(364, 57);
            this.lblFecNac.Name = "lblFecNac";
            this.lblFecNac.Size = new System.Drawing.Size(113, 13);
            this.lblFecNac.TabIndex = 13;
            this.lblFecNac.Text = "*Fecha de nacimiento:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(417, 25);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(194, 20);
            this.txtMail.TabIndex = 12;
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
            this.txtTel.Location = new System.Drawing.Point(153, 152);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(181, 20);
            this.txtTel.TabIndex = 10;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(14, 155);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(137, 13);
            this.lblTel.TabIndex = 9;
            this.lblTel.Text = "*Teléfono (Particular o Fijo):";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(117, 120);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(217, 20);
            this.txtDir.TabIndex = 8;
            // 
            // lblDireccionCompleta
            // 
            this.lblDireccionCompleta.AutoSize = true;
            this.lblDireccionCompleta.Location = new System.Drawing.Point(14, 123);
            this.lblDireccionCompleta.Name = "lblDireccionCompleta";
            this.lblDireccionCompleta.Size = new System.Drawing.Size(106, 13);
            this.lblDireccionCompleta.TabIndex = 7;
            this.lblDireccionCompleta.Text = "*Direccion Completa:";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(184, 88);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(150, 20);
            this.txtNroDoc.TabIndex = 6;
            this.txtNroDoc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Items.AddRange(new object[] {
            "D.N.I.",
            "L.E.",
            "L.C.",
            "C.I.",
            "Pasaporte"});
            this.cboTipoDoc.Location = new System.Drawing.Point(93, 88);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(85, 21);
            this.cboTipoDoc.TabIndex = 5;
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
            this.pnlDatosEspecificos.Controls.Add(this.dtpFechaCambioPlan);
            this.pnlDatosEspecificos.Controls.Add(this.lblFechaCambioPlan);
            this.pnlDatosEspecificos.Controls.Add(this.txtMotivo);
            this.pnlDatosEspecificos.Controls.Add(this.lblMotivoCambio);
            this.pnlDatosEspecificos.Controls.Add(this.btnConyuge);
            this.pnlDatosEspecificos.Controls.Add(this.btnHijo);
            this.pnlDatosEspecificos.Controls.Add(this.lblAltaFamiliar);
            this.pnlDatosEspecificos.Controls.Add(this.txtNroAfiliado);
            this.pnlDatosEspecificos.Controls.Add(this.lblNroAfiliado);
            this.pnlDatosEspecificos.Controls.Add(this.txtPlanMedico);
            this.pnlDatosEspecificos.Controls.Add(this.lblPlanMedico);
            this.pnlDatosEspecificos.Controls.Add(this.lblDatosEspecificos);
            this.pnlDatosEspecificos.Location = new System.Drawing.Point(23, 216);
            this.pnlDatosEspecificos.Name = "pnlDatosEspecificos";
            this.pnlDatosEspecificos.Size = new System.Drawing.Size(639, 86);
            this.pnlDatosEspecificos.TabIndex = 3;
            // 
            // dtpFechaCambioPlan
            // 
            this.dtpFechaCambioPlan.Location = new System.Drawing.Point(311, 47);
            this.dtpFechaCambioPlan.Name = "dtpFechaCambioPlan";
            this.dtpFechaCambioPlan.Size = new System.Drawing.Size(121, 20);
            this.dtpFechaCambioPlan.TabIndex = 20;
            // 
            // lblFechaCambioPlan
            // 
            this.lblFechaCambioPlan.AutoSize = true;
            this.lblFechaCambioPlan.Location = new System.Drawing.Point(204, 47);
            this.lblFechaCambioPlan.Name = "lblFechaCambioPlan";
            this.lblFechaCambioPlan.Size = new System.Drawing.Size(100, 13);
            this.lblFechaCambioPlan.TabIndex = 19;
            this.lblFechaCambioPlan.Text = "Fecha cambio plan:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(324, 22);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(109, 20);
            this.txtMotivo.TabIndex = 18;
            this.txtMotivo.TextChanged += new System.EventHandler(this.txtMotivo_TextChanged);
            // 
            // lblMotivoCambio
            // 
            this.lblMotivoCambio.AutoSize = true;
            this.lblMotivoCambio.Location = new System.Drawing.Point(204, 22);
            this.lblMotivoCambio.Name = "lblMotivoCambio";
            this.lblMotivoCambio.Size = new System.Drawing.Size(117, 13);
            this.lblMotivoCambio.TabIndex = 17;
            this.lblMotivoCambio.Text = "Motivo cambio de plan:";
            // 
            // btnConyuge
            // 
            this.btnConyuge.Location = new System.Drawing.Point(555, 42);
            this.btnConyuge.Name = "btnConyuge";
            this.btnConyuge.Size = new System.Drawing.Size(81, 23);
            this.btnConyuge.TabIndex = 16;
            this.btnConyuge.Text = "Conyuge";
            this.btnConyuge.UseVisualStyleBackColor = true;
            // 
            // btnHijo
            // 
            this.btnHijo.Location = new System.Drawing.Point(466, 42);
            this.btnHijo.Name = "btnHijo";
            this.btnHijo.Size = new System.Drawing.Size(83, 23);
            this.btnHijo.TabIndex = 15;
            this.btnHijo.Text = "Hijo";
            this.btnHijo.UseVisualStyleBackColor = true;
            // 
            // lblAltaFamiliar
            // 
            this.lblAltaFamiliar.AutoSize = true;
            this.lblAltaFamiliar.Location = new System.Drawing.Point(466, 19);
            this.lblAltaFamiliar.Name = "lblAltaFamiliar";
            this.lblAltaFamiliar.Size = new System.Drawing.Size(170, 13);
            this.lblAltaFamiliar.TabIndex = 14;
            this.lblAltaFamiliar.Text = "Desea dar de alta a algun familiar?";
            // 
            // txtNroAfiliado
            // 
            this.txtNroAfiliado.Enabled = false;
            this.txtNroAfiliado.Location = new System.Drawing.Point(89, 44);
            this.txtNroAfiliado.Name = "txtNroAfiliado";
            this.txtNroAfiliado.Size = new System.Drawing.Size(109, 20);
            this.txtNroAfiliado.TabIndex = 13;
            // 
            // lblNroAfiliado
            // 
            this.lblNroAfiliado.AutoSize = true;
            this.lblNroAfiliado.Location = new System.Drawing.Point(10, 45);
            this.lblNroAfiliado.Name = "lblNroAfiliado";
            this.lblNroAfiliado.Size = new System.Drawing.Size(67, 13);
            this.lblNroAfiliado.TabIndex = 12;
            this.lblNroAfiliado.Text = "*Nro afiliado:";
            // 
            // txtPlanMedico
            // 
            this.txtPlanMedico.Location = new System.Drawing.Point(89, 19);
            this.txtPlanMedico.Name = "txtPlanMedico";
            this.txtPlanMedico.Size = new System.Drawing.Size(109, 20);
            this.txtPlanMedico.TabIndex = 11;
            // 
            // lblPlanMedico
            // 
            this.lblPlanMedico.AutoSize = true;
            this.lblPlanMedico.Location = new System.Drawing.Point(10, 19);
            this.lblPlanMedico.Name = "lblPlanMedico";
            this.lblPlanMedico.Size = new System.Drawing.Size(73, 13);
            this.lblPlanMedico.TabIndex = 1;
            this.lblPlanMedico.Text = "*Plan Medico:";
            // 
            // lblDatosEspecificos
            // 
            this.lblDatosEspecificos.AutoSize = true;
            this.lblDatosEspecificos.Location = new System.Drawing.Point(18, 0);
            this.lblDatosEspecificos.Name = "lblDatosEspecificos";
            this.lblDatosEspecificos.Size = new System.Drawing.Size(126, 13);
            this.lblDatosEspecificos.TabIndex = 0;
            this.lblDatosEspecificos.Text = "Datos Especificos Clinica";
            // 
            // lblAclaracion
            // 
            this.lblAclaracion.AutoSize = true;
            this.lblAclaracion.Location = new System.Drawing.Point(453, 331);
            this.lblAclaracion.Name = "lblAclaracion";
            this.lblAclaracion.Size = new System.Drawing.Size(209, 13);
            this.lblAclaracion.TabIndex = 4;
            this.lblAclaracion.Text = "Aclaración: Los campos (*) son obligatorios";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(318, 308);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 42);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmAltaAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 353);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblAclaracion);
            this.Controls.Add(this.pnlDatosEspecificos);
            this.Controls.Add(this.pnlDatosPersonales);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "frmAltaAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Afiliado";
            this.pnlDatosPersonales.ResumeLayout(false);
            this.pnlDatosPersonales.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label lblDireccionCompleta;
        private System.Windows.Forms.Label lblFecNac;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DateTimePicker dtpFecNac;
        private System.Windows.Forms.RadioButton optFemenino;
        private System.Windows.Forms.RadioButton optMasculino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.TextBox txtCantFam;
        private System.Windows.Forms.Label lblCantFam;
        private System.Windows.Forms.Panel pnlDatosEspecificos;
        private System.Windows.Forms.Label lblDatosEspecificos;
        private System.Windows.Forms.TextBox txtNroAfiliado;
        private System.Windows.Forms.Label lblNroAfiliado;
        private System.Windows.Forms.TextBox txtPlanMedico;
        private System.Windows.Forms.Label lblPlanMedico;
        private System.Windows.Forms.Label lblAclaracion;
        private System.Windows.Forms.Button btnConyuge;
        private System.Windows.Forms.Button btnHijo;
        private System.Windows.Forms.Label lblAltaFamiliar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblGrupoFamiliar;
        private System.Windows.Forms.Label lblGrupoFam;
        private System.Windows.Forms.Label lblFechaCambioPlan;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivoCambio;
        private System.Windows.Forms.DateTimePicker dtpFechaCambioPlan;
    }
}