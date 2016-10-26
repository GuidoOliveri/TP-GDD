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
            this.SuspendLayout();
            // 
            // lblNroAfiliado
            // 
            this.lblNroAfiliado.AutoSize = true;
            this.lblNroAfiliado.Location = new System.Drawing.Point(5, 15);
            this.lblNroAfiliado.Name = "lblNroAfiliado";
            this.lblNroAfiliado.Size = new System.Drawing.Size(134, 13);
            this.lblNroAfiliado.TabIndex = 0;
            this.lblNroAfiliado.Text = "Ingrese numero de afiliado:";
            this.lblNroAfiliado.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Location = new System.Drawing.Point(5, 67);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(117, 13);
            this.lblProfesional.TabIndex = 1;
            this.lblProfesional.Text = "Seleccione profesional:";
            this.lblProfesional.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(5, 41);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(125, 13);
            this.lblEspecialidad.TabIndex = 2;
            this.lblEspecialidad.Text = "Seleccione especialidad:";
            this.lblEspecialidad.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(161, 64);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(228, 21);
            this.cmbProfesional.TabIndex = 3;
            // 
            // txtNroAfiliado
            // 
            this.txtNroAfiliado.Location = new System.Drawing.Point(161, 12);
            this.txtNroAfiliado.Name = "txtNroAfiliado";
            this.txtNroAfiliado.Size = new System.Drawing.Size(228, 20);
            this.txtNroAfiliado.TabIndex = 5;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(161, 92);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(228, 20);
            this.dtpFecha.TabIndex = 6;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(5, 92);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(104, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Seleccione la fecha:";
            // 
            // btnIngresarTurno
            // 
            this.btnIngresarTurno.Location = new System.Drawing.Point(128, 126);
            this.btnIngresarTurno.Name = "btnIngresarTurno";
            this.btnIngresarTurno.Size = new System.Drawing.Size(148, 23);
            this.btnIngresarTurno.TabIndex = 8;
            this.btnIngresarTurno.Text = "Ingresar Turno";
            this.btnIngresarTurno.UseVisualStyleBackColor = true;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Especialidad 1",
            "Especialidad 2"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(161, 38);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(228, 21);
            this.cmbEspecialidad.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 162);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.btnIngresarTurno);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtNroAfiliado);
            this.Controls.Add(this.cmbProfesional);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.lblNroAfiliado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Turno";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}