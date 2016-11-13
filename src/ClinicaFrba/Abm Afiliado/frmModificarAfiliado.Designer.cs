namespace ClinicaFrba.Abm_Afiliado
{
    partial class frmModificarAfiliado
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
            this.pnlModDatosPersonales = new System.Windows.Forms.Panel();
            this.cmdEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cmbPlanMedico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCantHijos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.lblDireccionCompleta = new System.Windows.Forms.Label();
            this.lblNombreAfiliado = new System.Windows.Forms.Label();
            this.lblDatosAfiliado = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlModDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlModDatosPersonales
            // 
            this.pnlModDatosPersonales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlModDatosPersonales.Controls.Add(this.cmdEstadoCivil);
            this.pnlModDatosPersonales.Controls.Add(this.cmbPlanMedico);
            this.pnlModDatosPersonales.Controls.Add(this.label3);
            this.pnlModDatosPersonales.Controls.Add(this.label2);
            this.pnlModDatosPersonales.Controls.Add(this.txtMotivo);
            this.pnlModDatosPersonales.Controls.Add(this.textBox1);
            this.pnlModDatosPersonales.Controls.Add(this.lblCantHijos);
            this.pnlModDatosPersonales.Controls.Add(this.label1);
            this.pnlModDatosPersonales.Controls.Add(this.txtMail);
            this.pnlModDatosPersonales.Controls.Add(this.lblMail);
            this.pnlModDatosPersonales.Controls.Add(this.txtTel);
            this.pnlModDatosPersonales.Controls.Add(this.lblTel);
            this.pnlModDatosPersonales.Controls.Add(this.txtDir);
            this.pnlModDatosPersonales.Controls.Add(this.lblDireccionCompleta);
            this.pnlModDatosPersonales.Controls.Add(this.lblNombreAfiliado);
            this.pnlModDatosPersonales.Location = new System.Drawing.Point(12, 16);
            this.pnlModDatosPersonales.Name = "pnlModDatosPersonales";
            this.pnlModDatosPersonales.Size = new System.Drawing.Size(460, 283);
            this.pnlModDatosPersonales.TabIndex = 3;
            this.pnlModDatosPersonales.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlModDatosPersonales_Paint);
            // 
            // cmdEstadoCivil
            // 
            this.cmdEstadoCivil.FormattingEnabled = true;
            this.cmdEstadoCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Viudo/a",
            "Concubinato",
            "Divorciado/a"});
            this.cmdEstadoCivil.Location = new System.Drawing.Point(131, 113);
            this.cmdEstadoCivil.Name = "cmdEstadoCivil";
            this.cmdEstadoCivil.Size = new System.Drawing.Size(216, 21);
            this.cmdEstadoCivil.TabIndex = 22;
            // 
            // cmbPlanMedico
            // 
            this.cmbPlanMedico.FormattingEnabled = true;
            this.cmbPlanMedico.Location = new System.Drawing.Point(131, 181);
            this.cmbPlanMedico.Name = "cmbPlanMedico";
            this.cmbPlanMedico.Size = new System.Drawing.Size(216, 21);
            this.cmbPlanMedico.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Motivo cambio plan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Plan Medico:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(131, 216);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(304, 20);
            this.txtMotivo.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 16;
            // 
            // lblCantHijos
            // 
            this.lblCantHijos.AutoSize = true;
            this.lblCantHijos.Location = new System.Drawing.Point(19, 144);
            this.lblCantHijos.Name = "lblCantHijos";
            this.lblCantHijos.Size = new System.Drawing.Size(55, 13);
            this.lblCantHijos.TabIndex = 15;
            this.lblCantHijos.Text = "CantHijos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Estado Civil:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(131, 82);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(217, 20);
            this.txtMail.TabIndex = 12;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(19, 82);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "Mail:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(131, 54);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(217, 20);
            this.txtTel.TabIndex = 10;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(19, 54);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 9;
            this.lblTel.Text = "Teléfono:";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(131, 25);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(217, 20);
            this.txtDir.TabIndex = 8;
            this.txtDir.TextChanged += new System.EventHandler(this.txtDir_TextChanged);
            // 
            // lblDireccionCompleta
            // 
            this.lblDireccionCompleta.AutoSize = true;
            this.lblDireccionCompleta.Location = new System.Drawing.Point(19, 25);
            this.lblDireccionCompleta.Name = "lblDireccionCompleta";
            this.lblDireccionCompleta.Size = new System.Drawing.Size(102, 13);
            this.lblDireccionCompleta.TabIndex = 7;
            this.lblDireccionCompleta.Text = "Direccion Completa:";
            // 
            // lblNombreAfiliado
            // 
            this.lblNombreAfiliado.AutoSize = true;
            this.lblNombreAfiliado.Location = new System.Drawing.Point(69, 25);
            this.lblNombreAfiliado.Name = "lblNombreAfiliado";
            this.lblNombreAfiliado.Size = new System.Drawing.Size(10, 13);
            this.lblNombreAfiliado.TabIndex = 2;
            this.lblNombreAfiliado.Text = "-";
            // 
            // lblDatosAfiliado
            // 
            this.lblDatosAfiliado.AutoSize = true;
            this.lblDatosAfiliado.Location = new System.Drawing.Point(45, 9);
            this.lblDatosAfiliado.Name = "lblDatosAfiliado";
            this.lblDatosAfiliado.Size = new System.Drawing.Size(144, 13);
            this.lblDatosAfiliado.TabIndex = 0;
            this.lblDatosAfiliado.Text = "Datos Personales del Afiliado";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(35, 318);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(360, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar Y Volver";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmModificarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 365);
            this.Controls.Add(this.lblDatosAfiliado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlModDatosPersonales);
            this.Name = "frmModificarAfiliado";
            this.Text = "Modificar Afiliado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmModificarAfiliado_FormClosing);
            this.Load += new System.EventHandler(this.frmModificarAfiliado_Load);
            this.pnlModDatosPersonales.ResumeLayout(false);
            this.pnlModDatosPersonales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlModDatosPersonales;
        private System.Windows.Forms.Label lblDatosAfiliado;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label lblDireccionCompleta;
        private System.Windows.Forms.Label lblNombreAfiliado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbPlanMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCantHijos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdEstadoCivil;
    }
}