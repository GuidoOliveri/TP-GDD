﻿namespace ClinicaFrba.Abm_Afiliado
{
    partial class Form1
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
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.pnlDatosPersonales = new System.Windows.Forms.Panel();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDatosPersonales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.lblDireccionCompleta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblFecNac = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dtpFecNac = new System.Windows.Forms.DateTimePicker();
            this.lblSexo = new System.Windows.Forms.Label();
            this.optMasculino = new System.Windows.Forms.RadioButton();
            this.optFemenino = new System.Windows.Forms.RadioButton();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCantFam = new System.Windows.Forms.Label();
            this.txtCantFam = new System.Windows.Forms.TextBox();
            this.pnlDatosEspecificos = new System.Windows.Forms.Panel();
            this.lblDatosEspecificos = new System.Windows.Forms.Label();
            this.lblPlanMedico = new System.Windows.Forms.Label();
            this.txtPlanMedico = new System.Windows.Forms.TextBox();
            this.lblNroAfiliado = new System.Windows.Forms.Label();
            this.txtNroAfiliado = new System.Windows.Forms.TextBox();
            this.pnlDatosPersonales.SuspendLayout();
            this.pnlDatosEspecificos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(498, 306);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(136, 43);
            this.cmdRegistrar.TabIndex = 0;
            this.cmdRegistrar.Text = "Registrar datos";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(40, 306);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(139, 43);
            this.cmdLimpiar.TabIndex = 1;
            this.cmdLimpiar.Text = "Limpiar Formularios";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlDatosPersonales
            // 
            this.pnlDatosPersonales.Controls.Add(this.txtCantFam);
            this.pnlDatosPersonales.Controls.Add(this.lblCantFam);
            this.pnlDatosPersonales.Controls.Add(this.comboBox1);
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
            this.pnlDatosPersonales.Controls.Add(this.textBox1);
            this.pnlDatosPersonales.Controls.Add(this.lblDireccionCompleta);
            this.pnlDatosPersonales.Controls.Add(this.txtNroDoc);
            this.pnlDatosPersonales.Controls.Add(this.cmbTipoDoc);
            this.pnlDatosPersonales.Controls.Add(this.label1);
            this.pnlDatosPersonales.Controls.Add(this.txtApellido);
            this.pnlDatosPersonales.Controls.Add(this.lblApellido);
            this.pnlDatosPersonales.Controls.Add(this.txtNombre);
            this.pnlDatosPersonales.Controls.Add(this.lblNombre);
            this.pnlDatosPersonales.Location = new System.Drawing.Point(23, 9);
            this.pnlDatosPersonales.Name = "pnlDatosPersonales";
            this.pnlDatosPersonales.Size = new System.Drawing.Size(640, 189);
            this.pnlDatosPersonales.TabIndex = 2;
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
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
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
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Documento:";
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
            this.cmbTipoDoc.Text = "D.N.I.";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(184, 88);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(150, 20);
            this.txtNroDoc.TabIndex = 6;
            this.txtNroDoc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDireccionCompleta
            // 
            this.lblDireccionCompleta.AutoSize = true;
            this.lblDireccionCompleta.Location = new System.Drawing.Point(14, 123);
            this.lblDireccionCompleta.Name = "lblDireccionCompleta";
            this.lblDireccionCompleta.Size = new System.Drawing.Size(102, 13);
            this.lblDireccionCompleta.TabIndex = 7;
            this.lblDireccionCompleta.Text = "Direccion Completa:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 8;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(14, 155);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(133, 13);
            this.lblTel.TabIndex = 9;
            this.lblTel.Text = "Teléfono (Particular o Fijo):";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(153, 152);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(181, 20);
            this.txtTel.TabIndex = 10;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(364, 26);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "Mail:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(417, 25);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(194, 20);
            this.txtMail.TabIndex = 12;
            // 
            // lblFecNac
            // 
            this.lblFecNac.AutoSize = true;
            this.lblFecNac.Location = new System.Drawing.Point(364, 57);
            this.lblFecNac.Name = "lblFecNac";
            this.lblFecNac.Size = new System.Drawing.Size(109, 13);
            this.lblFecNac.TabIndex = 13;
            this.lblFecNac.Text = "Fecha de nacimiento:";
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
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(364, 91);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 15;
            this.lblSexo.Text = "Sexo:";
            // 
            // optMasculino
            // 
            this.optMasculino.AutoSize = true;
            this.optMasculino.Location = new System.Drawing.Point(417, 91);
            this.optMasculino.Name = "optMasculino";
            this.optMasculino.Size = new System.Drawing.Size(73, 17);
            this.optMasculino.TabIndex = 16;
            this.optMasculino.TabStop = true;
            this.optMasculino.Text = "Masculino";
            this.optMasculino.UseVisualStyleBackColor = true;
            // 
            // optFemenino
            // 
            this.optFemenino.AutoSize = true;
            this.optFemenino.Location = new System.Drawing.Point(518, 92);
            this.optFemenino.Name = "optFemenino";
            this.optFemenino.Size = new System.Drawing.Size(71, 17);
            this.optFemenino.TabIndex = 17;
            this.optFemenino.TabStop = true;
            this.optFemenino.Text = "Femenino";
            this.optFemenino.UseVisualStyleBackColor = true;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(364, 127);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoCivil.TabIndex = 18;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Concubinato",
            "Divorciado/a"});
            this.comboBox1.Location = new System.Drawing.Point(432, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Text = "Soltero/a";
            // 
            // lblCantFam
            // 
            this.lblCantFam.AutoSize = true;
            this.lblCantFam.Location = new System.Drawing.Point(364, 155);
            this.lblCantFam.Name = "lblCantFam";
            this.lblCantFam.Size = new System.Drawing.Size(137, 13);
            this.lblCantFam.TabIndex = 20;
            this.lblCantFam.Text = "Cantidad familiares a cargo:";
            // 
            // txtCantFam
            // 
            this.txtCantFam.Location = new System.Drawing.Point(514, 155);
            this.txtCantFam.Name = "txtCantFam";
            this.txtCantFam.Size = new System.Drawing.Size(97, 20);
            this.txtCantFam.TabIndex = 21;
            // 
            // pnlDatosEspecificos
            // 
            this.pnlDatosEspecificos.Controls.Add(this.txtNroAfiliado);
            this.pnlDatosEspecificos.Controls.Add(this.lblNroAfiliado);
            this.pnlDatosEspecificos.Controls.Add(this.txtPlanMedico);
            this.pnlDatosEspecificos.Controls.Add(this.lblPlanMedico);
            this.pnlDatosEspecificos.Controls.Add(this.lblDatosEspecificos);
            this.pnlDatosEspecificos.Location = new System.Drawing.Point(23, 216);
            this.pnlDatosEspecificos.Name = "pnlDatosEspecificos";
            this.pnlDatosEspecificos.Size = new System.Drawing.Size(639, 78);
            this.pnlDatosEspecificos.TabIndex = 3;
            // 
            // lblDatosEspecificos
            // 
            this.lblDatosEspecificos.AutoSize = true;
            this.lblDatosEspecificos.Location = new System.Drawing.Point(18, 0);
            this.lblDatosEspecificos.Name = "lblDatosEspecificos";
            this.lblDatosEspecificos.Size = new System.Drawing.Size(110, 13);
            this.lblDatosEspecificos.TabIndex = 0;
            this.lblDatosEspecificos.Text = "Datos Fundamentales";
            // 
            // lblPlanMedico
            // 
            this.lblPlanMedico.AutoSize = true;
            this.lblPlanMedico.Location = new System.Drawing.Point(18, 26);
            this.lblPlanMedico.Name = "lblPlanMedico";
            this.lblPlanMedico.Size = new System.Drawing.Size(69, 13);
            this.lblPlanMedico.TabIndex = 1;
            this.lblPlanMedico.Text = "Plan Medico:";
            // 
            // txtPlanMedico
            // 
            this.txtPlanMedico.Location = new System.Drawing.Point(117, 26);
            this.txtPlanMedico.Name = "txtPlanMedico";
            this.txtPlanMedico.Size = new System.Drawing.Size(217, 20);
            this.txtPlanMedico.TabIndex = 11;
            // 
            // lblNroAfiliado
            // 
            this.lblNroAfiliado.AutoSize = true;
            this.lblNroAfiliado.Location = new System.Drawing.Point(18, 55);
            this.lblNroAfiliado.Name = "lblNroAfiliado";
            this.lblNroAfiliado.Size = new System.Drawing.Size(63, 13);
            this.lblNroAfiliado.TabIndex = 12;
            this.lblNroAfiliado.Text = "Nro afiliado:";
            // 
            // txtNroAfiliado
            // 
            this.txtNroAfiliado.Location = new System.Drawing.Point(117, 52);
            this.txtNroAfiliado.Name = "txtNroAfiliado";
            this.txtNroAfiliado.Size = new System.Drawing.Size(217, 20);
            this.txtNroAfiliado.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 353);
            this.Controls.Add(this.pnlDatosEspecificos);
            this.Controls.Add(this.pnlDatosPersonales);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdRegistrar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Afiliado";
            this.pnlDatosPersonales.ResumeLayout(false);
            this.pnlDatosPersonales.PerformLayout();
            this.pnlDatosEspecificos.ResumeLayout(false);
            this.pnlDatosEspecificos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Panel pnlDatosPersonales;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDatosPersonales;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDireccionCompleta;
        private System.Windows.Forms.Label lblFecNac;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DateTimePicker dtpFecNac;
        private System.Windows.Forms.RadioButton optFemenino;
        private System.Windows.Forms.RadioButton optMasculino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.TextBox txtCantFam;
        private System.Windows.Forms.Label lblCantFam;
        private System.Windows.Forms.Panel pnlDatosEspecificos;
        private System.Windows.Forms.Label lblDatosEspecificos;
        private System.Windows.Forms.TextBox txtNroAfiliado;
        private System.Windows.Forms.Label lblNroAfiliado;
        private System.Windows.Forms.TextBox txtPlanMedico;
        private System.Windows.Forms.Label lblPlanMedico;
    }
}