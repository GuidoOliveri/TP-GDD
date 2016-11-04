namespace ClinicaFrba.Abm_Profesional
{
    partial class frmBajaAfiliado
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
            this.pnlIngreseFechaBaja = new System.Windows.Forms.Panel();
            this.lblIngresaFechas = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.dtpFechaBaja = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlIngreseFechaBaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIngreseFechaBaja
            // 
            this.pnlIngreseFechaBaja.Controls.Add(this.btnCancelar);
            this.pnlIngreseFechaBaja.Controls.Add(this.btnAceptar);
            this.pnlIngreseFechaBaja.Controls.Add(this.dtpFechaBaja);
            this.pnlIngreseFechaBaja.Controls.Add(this.txtMatricula);
            this.pnlIngreseFechaBaja.Controls.Add(this.lblFecha);
            this.pnlIngreseFechaBaja.Controls.Add(this.lblMatricula);
            this.pnlIngreseFechaBaja.Controls.Add(this.lblIngresaFechas);
            this.pnlIngreseFechaBaja.Location = new System.Drawing.Point(28, 21);
            this.pnlIngreseFechaBaja.Name = "pnlIngreseFechaBaja";
            this.pnlIngreseFechaBaja.Size = new System.Drawing.Size(372, 205);
            this.pnlIngreseFechaBaja.TabIndex = 0;
            // 
            // lblIngresaFechas
            // 
            this.lblIngresaFechas.AutoSize = true;
            this.lblIngresaFechas.Location = new System.Drawing.Point(20, 0);
            this.lblIngresaFechas.Name = "lblIngresaFechas";
            this.lblIngresaFechas.Size = new System.Drawing.Size(129, 13);
            this.lblIngresaFechas.TabIndex = 0;
            this.lblIngresaFechas.Text = "Ingrese Matricula y Fecha";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(37, 50);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(53, 13);
            this.lblMatricula.TabIndex = 1;
            this.lblMatricula.Text = "Matricula:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(37, 103);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(124, 50);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(149, 20);
            this.txtMatricula.TabIndex = 3;
            // 
            // dtpFechaBaja
            // 
            this.dtpFechaBaja.Location = new System.Drawing.Point(126, 96);
            this.dtpFechaBaja.Name = "dtpFechaBaja";
            this.dtpFechaBaja.Size = new System.Drawing.Size(146, 20);
            this.dtpFechaBaja.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(29, 149);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 38);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(225, 149);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 38);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmBajaAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 262);
            this.Controls.Add(this.pnlIngreseFechaBaja);
            this.Name = "frmBajaAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja de Afiliado";
            this.pnlIngreseFechaBaja.ResumeLayout(false);
            this.pnlIngreseFechaBaja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIngreseFechaBaja;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblIngresaFechas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker dtpFechaBaja;
        private System.Windows.Forms.TextBox txtMatricula;
    }
}