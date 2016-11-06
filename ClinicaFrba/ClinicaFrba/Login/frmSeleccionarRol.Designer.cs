namespace ClinicaFrba.AbmRol
{
    partial class frmSeleccionarRol
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
            this.lblSelRol = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cboRoles = new System.Windows.Forms.ComboBox();
            this.btnVolverMenuPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelRol
            // 
            this.lblSelRol.AutoSize = true;
            this.lblSelRol.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelRol.Location = new System.Drawing.Point(32, 23);
            this.lblSelRol.Name = "lblSelRol";
            this.lblSelRol.Size = new System.Drawing.Size(502, 43);
            this.lblSelRol.TabIndex = 0;
            this.lblSelRol.Text = "Bienvenido, con qué Rol desea ingresar?";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(335, 191);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(133, 41);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cboRoles
            // 
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Items.AddRange(new object[] {
            "1- Administrativo",
            "2- Afiliado",
            "3- Profesional",
            "",
            ""});
            this.cboRoles.Location = new System.Drawing.Point(114, 106);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(295, 21);
            this.cboRoles.TabIndex = 2;
            // 
            // btnVolverMenuPrincipal
            // 
            this.btnVolverMenuPrincipal.Location = new System.Drawing.Point(70, 191);
            this.btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            this.btnVolverMenuPrincipal.Size = new System.Drawing.Size(149, 41);
            this.btnVolverMenuPrincipal.TabIndex = 3;
            this.btnVolverMenuPrincipal.Text = "Volver al Menu Principal";
            this.btnVolverMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnVolverMenuPrincipal.Click += new System.EventHandler(this.btnVolverMenuPrincipal_Click);
            // 
            // frmSeleccionarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 262);
            this.Controls.Add(this.btnVolverMenuPrincipal);
            this.Controls.Add(this.cboRoles);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblSelRol);
            this.Name = "frmSeleccionarRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelRol;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cboRoles;
        private System.Windows.Forms.Button btnVolverMenuPrincipal;
    }
}