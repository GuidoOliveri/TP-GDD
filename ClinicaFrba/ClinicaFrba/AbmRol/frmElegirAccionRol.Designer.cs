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
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.btnSeleccionRol = new System.Windows.Forms.Button();
            this.btnVolverALoguearse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDecision
            // 
            this.lblDecision.AutoSize = true;
            this.lblDecision.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecision.Location = new System.Drawing.Point(131, 28);
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.Size = new System.Drawing.Size(232, 25);
            this.lblDecision.TabIndex = 0;
            this.lblDecision.Text = "Qué desea realizar? ";
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Location = new System.Drawing.Point(26, 124);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(117, 48);
            this.btnAgregarRol.TabIndex = 1;
            this.btnAgregarRol.Text = "Agregar Nuevo Rol";
            this.btnAgregarRol.UseVisualStyleBackColor = true;
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // btnSeleccionRol
            // 
            this.btnSeleccionRol.Location = new System.Drawing.Point(174, 126);
            this.btnSeleccionRol.Name = "btnSeleccionRol";
            this.btnSeleccionRol.Size = new System.Drawing.Size(137, 46);
            this.btnSeleccionRol.TabIndex = 2;
            this.btnSeleccionRol.Text = "Seleccionar Rol A Modificar";
            this.btnSeleccionRol.UseVisualStyleBackColor = true;
            this.btnSeleccionRol.Click += new System.EventHandler(this.btnSeleccionRol_Click);
            // 
            // btnVolverALoguearse
            // 
            this.btnVolverALoguearse.Location = new System.Drawing.Point(355, 124);
            this.btnVolverALoguearse.Name = "btnVolverALoguearse";
            this.btnVolverALoguearse.Size = new System.Drawing.Size(125, 48);
            this.btnVolverALoguearse.TabIndex = 3;
            this.btnVolverALoguearse.Text = "Volver a Loguearse";
            this.btnVolverALoguearse.UseVisualStyleBackColor = true;
            this.btnVolverALoguearse.Click += new System.EventHandler(this.btnVolverALoguearse_Click);
            // 
            // frmElegirAccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 245);
            this.Controls.Add(this.btnVolverALoguearse);
            this.Controls.Add(this.btnSeleccionRol);
            this.Controls.Add(this.btnAgregarRol);
            this.Controls.Add(this.lblDecision);
            this.Name = "frmElegirAccionRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegir Acción Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.Button btnAgregarRol;
        private System.Windows.Forms.Button btnSeleccionRol;
        private System.Windows.Forms.Button btnVolverALoguearse;
    }
}