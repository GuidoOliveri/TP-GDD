namespace ClinicaFrba.Pedir_Turno
{
    partial class frmSeleccionDeTurno
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
            this.lblNroAfiliado = new System.Windows.Forms.Label();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.txtNroAfiliado = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnIngresarTurno = new System.Windows.Forms.Button();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.Turno = new System.Windows.Forms.GroupBox();
            this.warning4 = new System.Windows.Forms.Label();
            this.warning2 = new System.Windows.Forms.Label();
            this.warning1 = new System.Windows.Forms.Label();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.warning3 = new System.Windows.Forms.Label();
            this.Turno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNroAfiliado
            // 
            this.lblNroAfiliado.AutoSize = true;
            this.lblNroAfiliado.Location = new System.Drawing.Point(6, 21);
            this.lblNroAfiliado.Name = "lblNroAfiliado";
            this.lblNroAfiliado.Size = new System.Drawing.Size(134, 13);
            this.lblNroAfiliado.TabIndex = 0;
            this.lblNroAfiliado.Text = "Ingrese numero de afiliado:";
            this.lblNroAfiliado.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Location = new System.Drawing.Point(6, 98);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(117, 13);
            this.lblProfesional.TabIndex = 1;
            this.lblProfesional.Text = "Seleccione profesional:";
            this.lblProfesional.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(6, 60);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(125, 13);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Seleccione especialidad:";
            this.lblEspecialidad.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(175, 95);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(228, 21);
            this.cmbProfesional.TabIndex = 3;
            // 
            // txtNroAfiliado
            // 
            this.txtNroAfiliado.Location = new System.Drawing.Point(175, 18);
            this.txtNroAfiliado.Name = "txtNroAfiliado";
            this.txtNroAfiliado.Size = new System.Drawing.Size(228, 20);
            this.txtNroAfiliado.TabIndex = 5;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Location = new System.Drawing.Point(175, 132);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(228, 20);
            this.dtpFecha.TabIndex = 6;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 139);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(104, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Seleccione la fecha:";
            // 
            // btnIngresarTurno
            // 
            this.btnIngresarTurno.Location = new System.Drawing.Point(163, 229);
            this.btnIngresarTurno.Name = "btnIngresarTurno";
            this.btnIngresarTurno.Size = new System.Drawing.Size(148, 23);
            this.btnIngresarTurno.TabIndex = 8;
            this.btnIngresarTurno.Text = "Ingresar Turno";
            this.btnIngresarTurno.UseVisualStyleBackColor = true;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(175, 57);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(228, 21);
            this.cmbEspecialidad.TabIndex = 9;
            // 
            // Turno
            // 
            this.Turno.Controls.Add(this.warning4);
            this.Turno.Controls.Add(this.warning2);
            this.Turno.Controls.Add(this.warning1);
            this.Turno.Controls.Add(this.cmbHorario);
            this.Turno.Controls.Add(this.label1);
            this.Turno.Controls.Add(this.lblNroAfiliado);
            this.Turno.Controls.Add(this.cmbEspecialidad);
            this.Turno.Controls.Add(this.dtpFecha);
            this.Turno.Controls.Add(this.lblFecha);
            this.Turno.Controls.Add(this.txtNroAfiliado);
            this.Turno.Controls.Add(this.cmbProfesional);
            this.Turno.Controls.Add(this.lblProfesional);
            this.Turno.Controls.Add(this.lblEspecialidad);
            this.Turno.Location = new System.Drawing.Point(12, 6);
            this.Turno.Name = "Turno";
            this.Turno.Size = new System.Drawing.Size(416, 217);
            this.Turno.TabIndex = 10;
            this.Turno.TabStop = false;
            this.Turno.Text = "Turno";
            this.Turno.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // warning4
            // 
            this.warning4.AutoSize = true;
            this.warning4.ForeColor = System.Drawing.Color.Red;
            this.warning4.Location = new System.Drawing.Point(254, 41);
            this.warning4.Name = "warning4";
            this.warning4.Size = new System.Drawing.Size(154, 13);
            this.warning4.TabIndex = 14;
            this.warning4.Text = "No existe el numero de afiliado.";
            // 
            // warning2
            // 
            this.warning2.AutoSize = true;
            this.warning2.ForeColor = System.Drawing.Color.Red;
            this.warning2.Location = new System.Drawing.Point(148, 195);
            this.warning2.Name = "warning2";
            this.warning2.Size = new System.Drawing.Size(260, 13);
            this.warning2.TabIndex = 13;
            this.warning2.Text = "No hay disponibilidad en ese horario. Seleccione otro.";
            this.warning2.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // warning1
            // 
            this.warning1.AutoSize = true;
            this.warning1.ForeColor = System.Drawing.Color.Red;
            this.warning1.Location = new System.Drawing.Point(153, 155);
            this.warning1.Name = "warning1";
            this.warning1.Size = new System.Drawing.Size(255, 13);
            this.warning1.TabIndex = 12;
            this.warning1.Text = "No hay disponibilidad en esa fecha. Seleccione otra.";
            // 
            // cmbHorario
            // 
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Items.AddRange(new object[] {
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00"});
            this.cmbHorario.Location = new System.Drawing.Point(175, 170);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(228, 21);
            this.cmbHorario.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seleccione un horario:";
            // 
            // warning3
            // 
            this.warning3.AutoSize = true;
            this.warning3.ForeColor = System.Drawing.Color.Red;
            this.warning3.Location = new System.Drawing.Point(18, 229);
            this.warning3.Name = "warning3";
            this.warning3.Size = new System.Drawing.Size(125, 13);
            this.warning3.TabIndex = 11;
            this.warning3.Text = "Faltan completar campos";
            // 
            // frmSeleccionDeTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 260);
            this.Controls.Add(this.warning3);
            this.Controls.Add(this.Turno);
            this.Controls.Add(this.btnIngresarTurno);
            this.Name = "frmSeleccionDeTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Turno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Turno.ResumeLayout(false);
            this.Turno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroAfiliado;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.TextBox txtNroAfiliado;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnIngresarTurno;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.GroupBox Turno;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label warning2;
        private System.Windows.Forms.Label warning1;
        private System.Windows.Forms.Label warning3;
        private System.Windows.Forms.Label warning4;
    }
}