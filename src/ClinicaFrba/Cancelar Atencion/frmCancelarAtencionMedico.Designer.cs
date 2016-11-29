namespace ClinicaFrba.Cancelar_Atencion
{
    partial class frmCancelarAtencionMedico
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
            this.pickerFecha = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.warningNoSePuedeCancelarMismoDia = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.warningSinSeleccionarFechas = new System.Windows.Forms.Label();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.txtBoxDetalleCancelacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMotivoCancelacion = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.faltanDatosWarning = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pickerFecha
            // 
            this.pickerFecha.Location = new System.Drawing.Point(15, 45);
            this.pickerFecha.MaxSelectionCount = 14;
            this.pickerFecha.Name = "pickerFecha";
            this.pickerFecha.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pickerFecha);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 235);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cancelar Atencion Medica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione fecha a cancelar:";
            // 
            // warningNoSePuedeCancelarMismoDia
            // 
            this.warningNoSePuedeCancelarMismoDia.AutoSize = true;
            this.warningNoSePuedeCancelarMismoDia.ForeColor = System.Drawing.Color.Red;
            this.warningNoSePuedeCancelarMismoDia.Location = new System.Drawing.Point(32, 246);
            this.warningNoSePuedeCancelarMismoDia.Name = "warningNoSePuedeCancelarMismoDia";
            this.warningNoSePuedeCancelarMismoDia.Size = new System.Drawing.Size(205, 13);
            this.warningNoSePuedeCancelarMismoDia.TabIndex = 10;
            this.warningNoSePuedeCancelarMismoDia.Text = "No puede cancelar el mismo dia del turno.";
            this.warningNoSePuedeCancelarMismoDia.Visible = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(167, 280);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(98, 23);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Cancelar Turnos";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnCancelarTurnos_Click);
            // 
            // warningSinSeleccionarFechas
            // 
            this.warningSinSeleccionarFechas.AutoSize = true;
            this.warningSinSeleccionarFechas.ForeColor = System.Drawing.Color.Red;
            this.warningSinSeleccionarFechas.Location = new System.Drawing.Point(32, 220);
            this.warningSinSeleccionarFechas.Name = "warningSinSeleccionarFechas";
            this.warningSinSeleccionarFechas.Size = new System.Drawing.Size(116, 13);
            this.warningSinSeleccionarFechas.TabIndex = 10;
            this.warningSinSeleccionarFechas.Text = "Seleccione Una Fecha";
            this.warningSinSeleccionarFechas.Visible = false;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(290, 280);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(98, 23);
            this.cmdVolver.TabIndex = 11;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // txtBoxDetalleCancelacion
            // 
            this.txtBoxDetalleCancelacion.Location = new System.Drawing.Point(10, 87);
            this.txtBoxDetalleCancelacion.Multiline = true;
            this.txtBoxDetalleCancelacion.Name = "txtBoxDetalleCancelacion";
            this.txtBoxDetalleCancelacion.Size = new System.Drawing.Size(272, 56);
            this.txtBoxDetalleCancelacion.TabIndex = 9;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxDetalleCancelacion);
            this.groupBox3.Controls.Add(this.faltanDatosWarning);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbMotivoCancelacion);
            this.groupBox3.Location = new System.Drawing.Point(291, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 153);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motivo";
            // 
            // faltanDatosWarning
            // 
            this.faltanDatosWarning.AutoSize = true;
            this.faltanDatosWarning.ForeColor = System.Drawing.Color.Red;
            this.faltanDatosWarning.Location = new System.Drawing.Point(57, 0);
            this.faltanDatosWarning.Name = "faltanDatosWarning";
            this.faltanDatosWarning.Size = new System.Drawing.Size(67, 13);
            this.faltanDatosWarning.TabIndex = 8;
            this.faltanDatosWarning.Text = "Faltan Datos";
            this.faltanDatosWarning.Visible = false;
            // 
            // frmCancelarAtencionMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 315);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.warningNoSePuedeCancelarMismoDia);
            this.Controls.Add(this.warningSinSeleccionarFechas);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCancelarAtencionMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Atencion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCancelarAtencionMedico_FormClosing);
            this.Load += new System.EventHandler(this.frmCancelarAtencionMedico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar pickerFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label warningNoSePuedeCancelarMismoDia;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label warningSinSeleccionarFechas;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.TextBox txtBoxDetalleCancelacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMotivoCancelacion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label faltanDatosWarning;
    }
}