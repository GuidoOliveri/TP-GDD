namespace ClinicaFrba.AbmRol
{
    partial class frmElegirAccionRol
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
            this.lblDecision = new System.Windows.Forms.Label();
            this.cmdAgregarNuevoRol = new System.Windows.Forms.Button();
            this.btnSeleccionRol = new System.Windows.Forms.Button();
            this.btnVolverALoguearse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDecision
            // 
            this.lblDecision.AutoSize = true;
            this.lblDecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecision.Location = new System.Drawing.Point(173, 29);
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.Size = new System.Drawing.Size(232, 25);
            this.lblDecision.TabIndex = 0;
            this.lblDecision.Text = "Qué desea realizar? ";
            // 
            // cmdAgregarNuevoRol
            // 
            this.cmdAgregarNuevoRol.Location = new System.Drawing.Point(53, 99);
            this.cmdAgregarNuevoRol.Name = "cmdAgregarNuevoRol";
            this.cmdAgregarNuevoRol.Size = new System.Drawing.Size(99, 46);
            this.cmdAgregarNuevoRol.TabIndex = 1;
            this.cmdAgregarNuevoRol.Text = "Agregar Nuevo Rol";
            this.cmdAgregarNuevoRol.UseVisualStyleBackColor = true;
            this.cmdAgregarNuevoRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // btnSeleccionRol
            // 
            this.btnSeleccionRol.Location = new System.Drawing.Point(233, 100);
            this.btnSeleccionRol.Name = "btnSeleccionRol";
            this.btnSeleccionRol.Size = new System.Drawing.Size(102, 46);
            this.btnSeleccionRol.TabIndex = 2;
            this.btnSeleccionRol.Text = "Seleccionar Rol A Modificar";
            this.btnSeleccionRol.UseVisualStyleBackColor = true;
            this.btnSeleccionRol.Click += new System.EventHandler(this.btnSeleccionRol_Click);
            // 
            // btnVolverALoguearse
            // 
            this.btnVolverALoguearse.Location = new System.Drawing.Point(404, 98);
            this.btnVolverALoguearse.Name = "btnVolverALoguearse";
            this.btnVolverALoguearse.Size = new System.Drawing.Size(126, 48);
            this.btnVolverALoguearse.TabIndex = 3;
            this.btnVolverALoguearse.Text = "Volver a Funcionalidades";
            this.btnVolverALoguearse.UseVisualStyleBackColor = true;
            this.btnVolverALoguearse.Click += new System.EventHandler(this.btnVolverALoguearse_Click);
            // 
            // frmElegirAccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 214);
            this.Controls.Add(this.btnVolverALoguearse);
            this.Controls.Add(this.btnSeleccionRol);
            this.Controls.Add(this.cmdAgregarNuevoRol);
            this.Controls.Add(this.lblDecision);
            this.Name = "frmElegirAccionRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegir Acción Rol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmElegirAccionRol_FormClosing);
            this.Load += new System.EventHandler(this.frmElegirAccionRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.Button cmdAgregarNuevoRol;
        private System.Windows.Forms.Button btnSeleccionRol;
        private System.Windows.Forms.Button btnVolverALoguearse;
    }
}