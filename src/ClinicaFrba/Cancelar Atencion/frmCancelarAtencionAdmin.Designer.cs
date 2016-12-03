namespace ClinicaFrba.Cancelar_Atencion
{
    partial class frmCancelarAtencionAdmin
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
            this.cancelarPacienteBtn = new System.Windows.Forms.Button();
            this.cancelarMedicoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelarPacienteBtn
            // 
            this.cancelarPacienteBtn.Location = new System.Drawing.Point(51, 30);
            this.cancelarPacienteBtn.Name = "cancelarPacienteBtn";
            this.cancelarPacienteBtn.Size = new System.Drawing.Size(193, 23);
            this.cancelarPacienteBtn.TabIndex = 0;
            this.cancelarPacienteBtn.Text = "Cancelar atencion de pacientes";
            this.cancelarPacienteBtn.UseVisualStyleBackColor = true;
            this.cancelarPacienteBtn.Click += new System.EventHandler(this.cancelarPaciente_Click);
            // 
            // cancelarMedicoBtn
            // 
            this.cancelarMedicoBtn.Location = new System.Drawing.Point(51, 79);
            this.cancelarMedicoBtn.Name = "cancelarMedicoBtn";
            this.cancelarMedicoBtn.Size = new System.Drawing.Size(193, 23);
            this.cancelarMedicoBtn.TabIndex = 1;
            this.cancelarMedicoBtn.Text = "Cancelar atencion medica";
            this.cancelarMedicoBtn.UseVisualStyleBackColor = true;
            this.cancelarMedicoBtn.Click += new System.EventHandler(this.cancelarMedico_Click);
            // 
            // frmCancelarAtencionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.cancelarMedicoBtn);
            this.Controls.Add(this.cancelarPacienteBtn);
            this.Name = "frmCancelarAtencionAdmin";
            this.Text = "CancelarAtencionAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelarPacienteBtn;
        private System.Windows.Forms.Button cancelarMedicoBtn;
    }
}