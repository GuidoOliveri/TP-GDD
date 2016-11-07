namespace ClinicaFrba.Abm_Afiliado
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
            this.cmdVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dtpFechaBaja = new System.Windows.Forms.DateTimePicker();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNroAfiliado = new System.Windows.Forms.Label();
            this.lblIngresaFechas = new System.Windows.Forms.Label();
            this.pnlIngreseFechaBaja.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIngreseFechaBaja
            // 
            this.pnlIngreseFechaBaja.Controls.Add(this.cmdVolver);
            this.pnlIngreseFechaBaja.Controls.Add(this.btnAceptar);
            this.pnlIngreseFechaBaja.Controls.Add(this.dtpFechaBaja);
            this.pnlIngreseFechaBaja.Controls.Add(this.txtMatricula);
            this.pnlIngreseFechaBaja.Controls.Add(this.lblFecha);
            this.pnlIngreseFechaBaja.Controls.Add(this.lblNroAfiliado);
            this.pnlIngreseFechaBaja.Controls.Add(this.lblIngresaFechas);
            this.pnlIngreseFechaBaja.Location = new System.Drawing.Point(28, 21);
            this.pnlIngreseFechaBaja.Name = "pnlIngreseFechaBaja";
            this.pnlIngreseFechaBaja.Size = new System.Drawing.Size(372, 205);
            this.pnlIngreseFechaBaja.TabIndex = 0;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(225, 149);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(110, 38);
            this.cmdVolver.TabIndex = 6;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(29, 149);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 38);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dtpFechaBaja
            // 
            this.dtpFechaBaja.Location = new System.Drawing.Point(126, 96);
            this.dtpFechaBaja.Name = "dtpFechaBaja";
            this.dtpFechaBaja.Size = new System.Drawing.Size(146, 20);
            this.dtpFechaBaja.TabIndex = 4;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(124, 50);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(149, 20);
            this.txtMatricula.TabIndex = 3;
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
            // lblNroAfiliado
            // 
            this.lblNroAfiliado.AutoSize = true;
            this.lblNroAfiliado.Location = new System.Drawing.Point(37, 50);
            this.lblNroAfiliado.Name = "lblNroAfiliado";
            this.lblNroAfiliado.Size = new System.Drawing.Size(64, 13);
            this.lblNroAfiliado.TabIndex = 1;
            this.lblNroAfiliado.Text = "Nro Afiliado:";
            // 
            // lblIngresaFechas
            // 
            this.lblIngresaFechas.AutoSize = true;
            this.lblIngresaFechas.Location = new System.Drawing.Point(20, 0);
            this.lblIngresaFechas.Name = "lblIngresaFechas";
            this.lblIngresaFechas.Size = new System.Drawing.Size(140, 13);
            this.lblIngresaFechas.TabIndex = 0;
            this.lblIngresaFechas.Text = "Ingrese Nro Afiliado y Fecha";
            this.lblIngresaFechas.Click += new System.EventHandler(this.lblIngresaFechas_Click);
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
            this.Load += new System.EventHandler(this.frmBajaAfiliado_Load);
            this.pnlIngreseFechaBaja.ResumeLayout(false);
            this.pnlIngreseFechaBaja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIngreseFechaBaja;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNroAfiliado;
        private System.Windows.Forms.Label lblIngresaFechas;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker dtpFechaBaja;
        private System.Windows.Forms.TextBox txtMatricula;
    }
}