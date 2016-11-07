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
            this.lblDatosAfiliado = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.lblDireccionCompleta = new System.Windows.Forms.Label();
            this.lblNombreAfiliado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlModDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlModDatosPersonales
            // 
            this.pnlModDatosPersonales.Controls.Add(this.lblDatosAfiliado);
            this.pnlModDatosPersonales.Controls.Add(this.txtMail);
            this.pnlModDatosPersonales.Controls.Add(this.lblMail);
            this.pnlModDatosPersonales.Controls.Add(this.txtTel);
            this.pnlModDatosPersonales.Controls.Add(this.lblTel);
            this.pnlModDatosPersonales.Controls.Add(this.txtDir);
            this.pnlModDatosPersonales.Controls.Add(this.lblDireccionCompleta);
            this.pnlModDatosPersonales.Controls.Add(this.lblNombreAfiliado);
            this.pnlModDatosPersonales.Controls.Add(this.lblNombre);
            this.pnlModDatosPersonales.Location = new System.Drawing.Point(12, 16);
            this.pnlModDatosPersonales.Name = "pnlModDatosPersonales";
            this.pnlModDatosPersonales.Size = new System.Drawing.Size(351, 145);
            this.pnlModDatosPersonales.TabIndex = 3;
            this.pnlModDatosPersonales.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlModDatosPersonales_Paint);
            // 
            // lblDatosAfiliado
            // 
            this.lblDatosAfiliado.AutoSize = true;
            this.lblDatosAfiliado.Location = new System.Drawing.Point(18, -2);
            this.lblDatosAfiliado.Name = "lblDatosAfiliado";
            this.lblDatosAfiliado.Size = new System.Drawing.Size(144, 13);
            this.lblDatosAfiliado.TabIndex = 0;
            this.lblDatosAfiliado.Text = "Datos Personales del Afiliado";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(58, 110);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(280, 20);
            this.txtMail.TabIndex = 12;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(19, 113);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 13);
            this.lblMail.TabIndex = 11;
            this.lblMail.Text = "*Mail:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(80, 80);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(258, 20);
            this.txtTel.TabIndex = 10;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(18, 83);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(56, 13);
            this.lblTel.TabIndex = 9;
            this.lblTel.Text = "*Teléfono:";
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(121, 48);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(217, 20);
            this.txtDir.TabIndex = 8;
            this.txtDir.TextChanged += new System.EventHandler(this.txtDir_TextChanged);
            // 
            // lblDireccionCompleta
            // 
            this.lblDireccionCompleta.AutoSize = true;
            this.lblDireccionCompleta.Location = new System.Drawing.Point(18, 51);
            this.lblDireccionCompleta.Name = "lblDireccionCompleta";
            this.lblDireccionCompleta.Size = new System.Drawing.Size(106, 13);
            this.lblDireccionCompleta.TabIndex = 7;
            this.lblDireccionCompleta.Text = "*Direccion Completa:";
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
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Afiliado:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(61, 187);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(223, 187);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmModificarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 235);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlModDatosPersonales);
            this.Name = "frmModificarAfiliado";
            this.Text = "frmModificarAfiliado";
            this.Load += new System.EventHandler(this.frmModificarAfiliado_Load);
            this.pnlModDatosPersonales.ResumeLayout(false);
            this.pnlModDatosPersonales.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}