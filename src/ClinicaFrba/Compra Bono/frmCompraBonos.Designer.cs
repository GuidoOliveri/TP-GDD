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
            this.lblPrecioBonos = new System.Windows.Forms.Label();
            this.lblSignoPesos = new System.Windows.Forms.Label();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.txtPrecioBono = new System.Windows.Forms.Label();
            this.txtNumeroAfiliado = new System.Windows.Forms.TextBox();
            this.lblNumeroAfiliado = new System.Windows.Forms.Label();
            this.btnCargarAfiliado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cantBonosUpDown = new System.Windows.Forms.NumericUpDown();
            this.warningCompraNula = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cantBonosUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantBonos
            // 
            this.lblCantBonos.AutoSize = true;
            this.lblCantBonos.Location = new System.Drawing.Point(15, 91);
            this.lblCantBonos.Name = "lblCantBonos";
            this.lblCantBonos.Size = new System.Drawing.Size(186, 13);
            this.lblCantBonos.TabIndex = 0;
            this.lblCantBonos.Text = "Ingrese cantidad de bonos a comprar:";
            this.lblCantBonos.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(90, 141);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblPrecioBonos
            // 
            this.lblPrecioBonos.AutoSize = true;
            this.lblPrecioBonos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPrecioBonos.Location = new System.Drawing.Point(17, 63);
            this.lblPrecioBonos.Name = "lblPrecioBonos";
            this.lblPrecioBonos.Size = new System.Drawing.Size(182, 13);
            this.lblPrecioBonos.TabIndex = 3;
            this.lblPrecioBonos.Text = "Precio del bono según el plan actual:";
            // 
            // lblSignoPesos
            // 
            this.lblSignoPesos.AutoSize = true;
            this.lblSignoPesos.Location = new System.Drawing.Point(198, 64);
            this.lblSignoPesos.Name = "lblSignoPesos";
            this.lblSignoPesos.Size = new System.Drawing.Size(13, 13);
            this.lblSignoPesos.TabIndex = 5;
            this.lblSignoPesos.Text = "$";
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(264, 140);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 6;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // txtPrecioBono
            // 
            this.txtPrecioBono.AutoSize = true;
            this.txtPrecioBono.Location = new System.Drawing.Point(217, 64);
            this.txtPrecioBono.Name = "txtPrecioBono";
            this.txtPrecioBono.Size = new System.Drawing.Size(28, 13);
            this.txtPrecioBono.TabIndex = 7;
            this.txtPrecioBono.Text = "0.00";
            // 
            // txtNumeroAfiliado
            // 
            this.txtNumeroAfiliado.Location = new System.Drawing.Point(117, 30);
            this.txtNumeroAfiliado.Name = "txtNumeroAfiliado";
            this.txtNumeroAfiliado.Size = new System.Drawing.Size(197, 20);
            this.txtNumeroAfiliado.TabIndex = 9;
            // 
            // lblNumeroAfiliado
            // 
            this.lblNumeroAfiliado.AutoSize = true;
            this.lblNumeroAfiliado.Location = new System.Drawing.Point(14, 33);
            this.lblNumeroAfiliado.Name = "lblNumeroAfiliado";
            this.lblNumeroAfiliado.Size = new System.Drawing.Size(96, 13);
            this.lblNumeroAfiliado.TabIndex = 8;
            this.lblNumeroAfiliado.Text = "Numero de Afiliado";
            // 
            // btnCargarAfiliado
            // 
            this.btnCargarAfiliado.Location = new System.Drawing.Point(331, 27);
            this.btnCargarAfiliado.Name = "btnCargarAfiliado";
            this.btnCargarAfiliado.Size = new System.Drawing.Size(75, 23);
            this.btnCargarAfiliado.TabIndex = 10;
            this.btnCargarAfiliado.Text = "Cargar";
            this.btnCargarAfiliado.UseVisualStyleBackColor = true;
            this.btnCargarAfiliado.Click += new System.EventHandler(this.btnCargarAfiliado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total:";
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Location = new System.Drawing.Point(335, 92);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(28, 13);
            this.lblTotalAPagar.TabIndex = 13;
            this.lblTotalAPagar.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "$";
            // 
            // cantBonosUpDown
            // 
            this.cantBonosUpDown.Location = new System.Drawing.Point(207, 89);
            this.cantBonosUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.cantBonosUpDown.Name = "cantBonosUpDown";
            this.cantBonosUpDown.Size = new System.Drawing.Size(64, 20);
            this.cantBonosUpDown.TabIndex = 14;
            this.cantBonosUpDown.ValueChanged += new System.EventHandler(this.cantBonos_ValueChanged);
            this.cantBonosUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantBonosUpDown_KeyPress);
            // 
            // warningCompraNula
            // 
            this.warningCompraNula.AutoSize = true;
            this.warningCompraNula.ForeColor = System.Drawing.Color.Red;
            this.warningCompraNula.Location = new System.Drawing.Point(206, 112);
            this.warningCompraNula.Name = "warningCompraNula";
            this.warningCompraNula.Size = new System.Drawing.Size(161, 13);
            this.warningCompraNula.TabIndex = 15;
            this.warningCompraNula.Text = "Ingrese Una Cantidad Mayor A 0";
            this.warningCompraNula.Visible = false;
            // 
            // frmCompraBonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 187);
            this.Controls.Add(this.warningCompraNula);
            this.Controls.Add(this.cantBonosUpDown);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarAfiliado);
            this.Controls.Add(this.txtNumeroAfiliado);
            this.Controls.Add(this.lblNumeroAfiliado);
            this.Controls.Add(this.txtPrecioBono);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.lblSignoPesos);
            this.Controls.Add(this.lblPrecioBonos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblCantBonos);
            this.Name = "frmCompraBonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra de Bonos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCompraBonos_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantBonosUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantBonos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblPrecioBonos;
        private System.Windows.Forms.Label lblSignoPesos;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Label txtPrecioBono;
        private System.Windows.Forms.TextBox txtNumeroAfiliado;
        private System.Windows.Forms.Label lblNumeroAfiliado;
        private System.Windows.Forms.Button btnCargarAfiliado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown cantBonosUpDown;
        private System.Windows.Forms.Label warningCompraNula;
    }
}