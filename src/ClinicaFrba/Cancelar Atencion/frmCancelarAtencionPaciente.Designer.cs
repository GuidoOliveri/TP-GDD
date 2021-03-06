﻿namespace ClinicaFrba.Cancelar_Atencion
{
    partial class frmCancelarAtencionPaciente
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
            this.faltanCamposWarning = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxDetalleCancelacion = new System.Windows.Forms.TextBox();
            this.cancelarMismoDiaWarning = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMotivoCancelacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSeleccionTurno = new System.Windows.Forms.ComboBox();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.btnCargarAfiliado = new System.Windows.Forms.Button();
            this.txtNumeroAfiliado = new System.Windows.Forms.TextBox();
            this.lblNumeroAfiliado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // faltanCamposWarning
            // 
            this.faltanCamposWarning.AutoSize = true;
            this.faltanCamposWarning.ForeColor = System.Drawing.Color.Red;
            this.faltanCamposWarning.Location = new System.Drawing.Point(67, 106);
            this.faltanCamposWarning.Name = "faltanCamposWarning";
            this.faltanCamposWarning.Size = new System.Drawing.Size(121, 13);
            this.faltanCamposWarning.TabIndex = 5;
            this.faltanCamposWarning.Text = "Falta Completar Campos";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(45, 265);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSeleccionTurno);
            this.groupBox1.Location = new System.Drawing.Point(8, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 222);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cancelar Atencion Medica";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxDetalleCancelacion);
            this.groupBox2.Controls.Add(this.cancelarMismoDiaWarning);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbMotivoCancelacion);
            this.groupBox2.Location = new System.Drawing.Point(0, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 153);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motivo";
            // 
            // txtBoxDetalleCancelacion
            // 
            this.txtBoxDetalleCancelacion.Location = new System.Drawing.Point(10, 87);
            this.txtBoxDetalleCancelacion.Multiline = true;
            this.txtBoxDetalleCancelacion.Name = "txtBoxDetalleCancelacion";
            this.txtBoxDetalleCancelacion.Size = new System.Drawing.Size(272, 56);
            this.txtBoxDetalleCancelacion.TabIndex = 9;
            // 
            // cancelarMismoDiaWarning
            // 
            this.cancelarMismoDiaWarning.AutoSize = true;
            this.cancelarMismoDiaWarning.ForeColor = System.Drawing.Color.Red;
            this.cancelarMismoDiaWarning.Location = new System.Drawing.Point(57, 0);
            this.cancelarMismoDiaWarning.Name = "cancelarMismoDiaWarning";
            this.cancelarMismoDiaWarning.Size = new System.Drawing.Size(205, 13);
            this.cancelarMismoDiaWarning.TabIndex = 8;
            this.cancelarMismoDiaWarning.Text = "No puede cancelar el mismo dia del turno.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Detalle Adicional:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Elija el motivo de la cancelacion:";
            // 
            // cmbMotivoCancelacion
            // 
            this.cmbMotivoCancelacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivoCancelacion.FormattingEnabled = true;
            this.cmbMotivoCancelacion.Location = new System.Drawing.Point(10, 41);
            this.cmbMotivoCancelacion.Name = "cmbMotivoCancelacion";
            this.cmbMotivoCancelacion.Size = new System.Drawing.Size(272, 21);
            this.cmbMotivoCancelacion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione un turno:";
            // 
            // cmbSeleccionTurno
            // 
            this.cmbSeleccionTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeleccionTurno.FormattingEnabled = true;
            this.cmbSeleccionTurno.Location = new System.Drawing.Point(8, 38);
            this.cmbSeleccionTurno.Name = "cmbSeleccionTurno";
            this.cmbSeleccionTurno.Size = new System.Drawing.Size(274, 21);
            this.cmbSeleccionTurno.TabIndex = 0;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(177, 265);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 6;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // btnCargarAfiliado
            // 
            this.btnCargarAfiliado.Location = new System.Drawing.Point(239, 9);
            this.btnCargarAfiliado.Name = "btnCargarAfiliado";
            this.btnCargarAfiliado.Size = new System.Drawing.Size(75, 23);
            this.btnCargarAfiliado.TabIndex = 13;
            this.btnCargarAfiliado.Text = "Cargar";
            this.btnCargarAfiliado.UseVisualStyleBackColor = true;
            this.btnCargarAfiliado.Click += new System.EventHandler(this.btnCargarAfiliado_Click);
            // 
            // txtNumeroAfiliado
            // 
            this.txtNumeroAfiliado.Location = new System.Drawing.Point(109, 11);
            this.txtNumeroAfiliado.Name = "txtNumeroAfiliado";
            this.txtNumeroAfiliado.Size = new System.Drawing.Size(122, 20);
            this.txtNumeroAfiliado.TabIndex = 12;
            // 
            // lblNumeroAfiliado
            // 
            this.lblNumeroAfiliado.AutoSize = true;
            this.lblNumeroAfiliado.Enabled = false;
            this.lblNumeroAfiliado.Location = new System.Drawing.Point(6, 14);
            this.lblNumeroAfiliado.Name = "lblNumeroAfiliado";
            this.lblNumeroAfiliado.Size = new System.Drawing.Size(96, 13);
            this.lblNumeroAfiliado.TabIndex = 11;
            this.lblNumeroAfiliado.Text = "Numero de Afiliado";
            // 
            // frmCancelarAtencionPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 314);
            this.Controls.Add(this.btnCargarAfiliado);
            this.Controls.Add(this.txtNumeroAfiliado);
            this.Controls.Add(this.lblNumeroAfiliado);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.faltanCamposWarning);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCancelarAtencionPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Atención";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCancelarAtencionPaciente_FormClosing);
            this.Load += new System.EventHandler(this.frmCancelarAtencionPaciente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label faltanCamposWarning;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label cancelarMismoDiaWarning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMotivoCancelacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSeleccionTurno;
        private System.Windows.Forms.TextBox txtBoxDetalleCancelacion;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Button btnCargarAfiliado;
        private System.Windows.Forms.TextBox txtNumeroAfiliado;
        private System.Windows.Forms.Label lblNumeroAfiliado;
    }
}