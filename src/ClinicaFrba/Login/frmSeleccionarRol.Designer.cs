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
            this.warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelRol
            // 
            this.lblSelRol.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblSelRol.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelRol.ForeColor = System.Drawing.Color.Snow;
            this.lblSelRol.Location = new System.Drawing.Point(33, 30);
            this.lblSelRol.Name = "lblSelRol";
            this.lblSelRol.Size = new System.Drawing.Size(507, 72);
            this.lblSelRol.TabIndex = 0;
            this.lblSelRol.Text = "SELECCIONE EL ROL CON EL QUE DESEA INGRESAR";
            this.lblSelRol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(304, 180);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(144, 41);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cboRoles
            // 
            this.cboRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoles.FormattingEnabled = true;
            this.cboRoles.Location = new System.Drawing.Point(120, 126);
            this.cboRoles.Name = "cboRoles";
            this.cboRoles.Size = new System.Drawing.Size(328, 24);
            this.cboRoles.TabIndex = 2;
            this.cboRoles.SelectedIndexChanged += new System.EventHandler(this.cboRoles_SelectedIndexChanged);
            // 
            // btnVolverMenuPrincipal
            // 
            this.btnVolverMenuPrincipal.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnVolverMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverMenuPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnVolverMenuPrincipal.Location = new System.Drawing.Point(120, 180);
            this.btnVolverMenuPrincipal.Name = "btnVolverMenuPrincipal";
            this.btnVolverMenuPrincipal.Size = new System.Drawing.Size(144, 41);
            this.btnVolverMenuPrincipal.TabIndex = 3;
            this.btnVolverMenuPrincipal.Text = "VOLVER AL MENU PRINCIPAL";
            this.btnVolverMenuPrincipal.UseVisualStyleBackColor = false;
            this.btnVolverMenuPrincipal.Click += new System.EventHandler(this.btnVolverMenuPrincipal_Click);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.White;
            this.warning.Location = new System.Drawing.Point(35, 240);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(160, 13);
            this.warning.TabIndex = 4;
            this.warning.Text = "Debe seleccionar alguna opcion";
            // 
            // frmSeleccionarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(563, 262);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.btnVolverMenuPrincipal);
            this.Controls.Add(this.cboRoles);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblSelRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSeleccionarRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Rol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSeleccionarRol_FormClosing);
            this.Load += new System.EventHandler(this.frmSeleccionarRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelRol;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cboRoles;
        private System.Windows.Forms.Button btnVolverMenuPrincipal;
        private System.Windows.Forms.Label warning;
    }
}