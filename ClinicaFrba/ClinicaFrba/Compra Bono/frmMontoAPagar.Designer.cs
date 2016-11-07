namespace ClinicaFrba.Compra_Bono
{
    partial class frmMontoAPagar
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
            this.lblMontoAPagar = new System.Windows.Forms.Label();
            this.lblSignoPesos2 = new System.Windows.Forms.Label();
            this.btnAceptarMonto = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMontoAPagar
            // 
            this.lblMontoAPagar.AutoSize = true;
            this.lblMontoAPagar.Location = new System.Drawing.Point(30, 44);
            this.lblMontoAPagar.Name = "lblMontoAPagar";
            this.lblMontoAPagar.Size = new System.Drawing.Size(79, 13);
            this.lblMontoAPagar.TabIndex = 0;
            this.lblMontoAPagar.Text = "Monto a pagar:";
            // 
            // lblSignoPesos2
            // 
            this.lblSignoPesos2.AutoSize = true;
            this.lblSignoPesos2.Location = new System.Drawing.Point(226, 44);
            this.lblSignoPesos2.Name = "lblSignoPesos2";
            this.lblSignoPesos2.Size = new System.Drawing.Size(13, 13);
            this.lblSignoPesos2.TabIndex = 1;
            this.lblSignoPesos2.Text = "$";
            // 
            // btnAceptarMonto
            // 
            this.btnAceptarMonto.Location = new System.Drawing.Point(103, 94);
            this.btnAceptarMonto.Name = "btnAceptarMonto";
            this.btnAceptarMonto.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarMonto.TabIndex = 2;
            this.btnAceptarMonto.Text = "Aceptar";
            this.btnAceptarMonto.UseVisualStyleBackColor = true;
            this.btnAceptarMonto.Click += new System.EventHandler(this.btnAceptarMonto_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(245, 44);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(146, 20);
            this.txtMonto.TabIndex = 3;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(229, 94);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 4;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmMontoAPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 142);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnAceptarMonto);
            this.Controls.Add(this.lblSignoPesos2);
            this.Controls.Add(this.lblMontoAPagar);
            this.Name = "frmMontoAPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monto a pagar";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMontoAPagar;
        private System.Windows.Forms.Label lblSignoPesos2;
        private System.Windows.Forms.Button btnAceptarMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button cmdVolver;
    }
}