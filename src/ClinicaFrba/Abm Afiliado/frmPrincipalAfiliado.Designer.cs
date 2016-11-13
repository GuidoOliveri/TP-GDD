namespace ClinicaFrba.Abm_Afiliado
{
    partial class frmPrincipalAfiliado
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
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.cmdAltaAfiliado = new System.Windows.Forms.Button();
            this.cmdBajaAfiliado = new System.Windows.Forms.Button();
            this.cmdBuscarAfiliado = new System.Windows.Forms.Button();
            this.cmdHistorialCambios = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.Location = new System.Drawing.Point(88, 34);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(344, 25);
            this.lblSeleccion.TabIndex = 0;
            this.lblSeleccion.Text = "Seleccione la opción a realizar:";
            // 
            // cmdAltaAfiliado
            // 
            this.cmdAltaAfiliado.Location = new System.Drawing.Point(71, 95);
            this.cmdAltaAfiliado.Name = "cmdAltaAfiliado";
            this.cmdAltaAfiliado.Size = new System.Drawing.Size(100, 44);
            this.cmdAltaAfiliado.TabIndex = 1;
            this.cmdAltaAfiliado.Text = "Alta Afiliado";
            this.cmdAltaAfiliado.UseVisualStyleBackColor = true;
            this.cmdAltaAfiliado.Click += new System.EventHandler(this.cmdAltaAfiliado_Click);
            // 
            // cmdBajaAfiliado
            // 
            this.cmdBajaAfiliado.Location = new System.Drawing.Point(218, 95);
            this.cmdBajaAfiliado.Name = "cmdBajaAfiliado";
            this.cmdBajaAfiliado.Size = new System.Drawing.Size(100, 44);
            this.cmdBajaAfiliado.TabIndex = 2;
            this.cmdBajaAfiliado.Text = "Baja Afiliado";
            this.cmdBajaAfiliado.UseVisualStyleBackColor = true;
            this.cmdBajaAfiliado.Click += new System.EventHandler(this.cmdBajaAfiliado_Click);
            // 
            // cmdBuscarAfiliado
            // 
            this.cmdBuscarAfiliado.Location = new System.Drawing.Point(360, 95);
            this.cmdBuscarAfiliado.Name = "cmdBuscarAfiliado";
            this.cmdBuscarAfiliado.Size = new System.Drawing.Size(100, 44);
            this.cmdBuscarAfiliado.TabIndex = 3;
            this.cmdBuscarAfiliado.Text = "Buscar Afiliado";
            this.cmdBuscarAfiliado.UseVisualStyleBackColor = true;
            this.cmdBuscarAfiliado.Click += new System.EventHandler(this.cmdBuscarAfiliado_Click);
            // 
            // cmdHistorialCambios
            // 
            this.cmdHistorialCambios.Location = new System.Drawing.Point(144, 179);
            this.cmdHistorialCambios.Name = "cmdHistorialCambios";
            this.cmdHistorialCambios.Size = new System.Drawing.Size(100, 44);
            this.cmdHistorialCambios.TabIndex = 4;
            this.cmdHistorialCambios.Text = "Ver Historial Cambios";
            this.cmdHistorialCambios.UseVisualStyleBackColor = true;
            this.cmdHistorialCambios.Click += new System.EventHandler(this.cmdHistorialCambios_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(303, 179);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(100, 44);
            this.cmdVolver.TabIndex = 6;
            this.cmdVolver.Text = "Volver a Menu Funcionalidades";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmPrincipalAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 282);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.cmdHistorialCambios);
            this.Controls.Add(this.cmdBuscarAfiliado);
            this.Controls.Add(this.cmdBajaAfiliado);
            this.Controls.Add(this.cmdAltaAfiliado);
            this.Controls.Add(this.lblSeleccion);
            this.Name = "frmPrincipalAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal Afiliado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipalAfiliado_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Button cmdAltaAfiliado;
        private System.Windows.Forms.Button cmdBajaAfiliado;
        private System.Windows.Forms.Button cmdBuscarAfiliado;
        private System.Windows.Forms.Button cmdHistorialCambios;
        private System.Windows.Forms.Button cmdVolver;
    }
}