namespace ClinicaFrba.Compra_Bono
{
    partial class frmCompraBonos
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
            this.lblCantBonos = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCantBonos = new System.Windows.Forms.TextBox();
            this.lblPrecioBonos = new System.Windows.Forms.Label();
            this.txtPrecioBonos = new System.Windows.Forms.TextBox();
            this.lblSignoPesos = new System.Windows.Forms.Label();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCantBonos
            // 
            this.lblCantBonos.AutoSize = true;
            this.lblCantBonos.Location = new System.Drawing.Point(12, 85);
            this.lblCantBonos.Name = "lblCantBonos";
            this.lblCantBonos.Size = new System.Drawing.Size(186, 13);
            this.lblCantBonos.TabIndex = 0;
            this.lblCantBonos.Text = "Ingrese cantidad de bonos a comprar:";
            this.lblCantBonos.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(95, 133);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCantBonos
            // 
            this.txtCantBonos.Location = new System.Drawing.Point(239, 85);
            this.txtCantBonos.Name = "txtCantBonos";
            this.txtCantBonos.Size = new System.Drawing.Size(164, 20);
            this.txtCantBonos.TabIndex = 2;
            // 
            // lblPrecioBonos
            // 
            this.lblPrecioBonos.AutoSize = true;
            this.lblPrecioBonos.Location = new System.Drawing.Point(12, 52);
            this.lblPrecioBonos.Name = "lblPrecioBonos";
            this.lblPrecioBonos.Size = new System.Drawing.Size(182, 13);
            this.lblPrecioBonos.TabIndex = 3;
            this.lblPrecioBonos.Text = "Precio del bono según el plan actual:";
            // 
            // txtPrecioBonos
            // 
            this.txtPrecioBonos.Location = new System.Drawing.Point(346, 52);
            this.txtPrecioBonos.Name = "txtPrecioBonos";
            this.txtPrecioBonos.Size = new System.Drawing.Size(57, 20);
            this.txtPrecioBonos.TabIndex = 4;
            // 
            // lblSignoPesos
            // 
            this.lblSignoPesos.AutoSize = true;
            this.lblSignoPesos.Location = new System.Drawing.Point(327, 55);
            this.lblSignoPesos.Name = "lblSignoPesos";
            this.lblSignoPesos.Size = new System.Drawing.Size(13, 13);
            this.lblSignoPesos.TabIndex = 5;
            this.lblSignoPesos.Text = "$";
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(249, 133);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(69, 22);
            this.cmdVolver.TabIndex = 6;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmCompraBonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 181);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.lblSignoPesos);
            this.Controls.Add(this.txtPrecioBonos);
            this.Controls.Add(this.lblPrecioBonos);
            this.Controls.Add(this.txtCantBonos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblCantBonos);
            this.Name = "frmCompraBonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra de Bonos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCompraBonos_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantBonos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtCantBonos;
        private System.Windows.Forms.Label lblPrecioBonos;
        private System.Windows.Forms.TextBox txtPrecioBonos;
        private System.Windows.Forms.Label lblSignoPesos;
        private System.Windows.Forms.Button cmdVolver;
    }
}