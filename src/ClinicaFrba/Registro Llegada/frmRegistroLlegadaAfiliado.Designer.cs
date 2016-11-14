namespace ClinicaFrba.Registro_Llegada
{
    partial class frmRegistroLlegadaAfiliado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.warning1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBono = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.warning3 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.rbBusqueda = new System.Windows.Forms.RadioButton();
            this.txtHoraLlegada = new System.Windows.Forms.TextBox();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.txtFechaLlegada = new System.Windows.Forms.TextBox();
            this.warning4 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.warning2 = new System.Windows.Forms.Label();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.warning3);
            this.groupBox1.Controls.Add(this.cmbEspecialidad);
            this.groupBox1.Controls.Add(this.rbBusqueda);
            this.groupBox1.Controls.Add(this.txtHoraLlegada);
            this.groupBox1.Controls.Add(this.cmbProfesional);
            this.groupBox1.Controls.Add(this.txtFechaLlegada);
            this.groupBox1.Controls.Add(this.warning4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de llegada";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.warning1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbBono);
            this.groupBox2.Controls.Add(this.cmbTurno);
            this.groupBox2.Location = new System.Drawing.Point(0, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 90);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turno";
            // 
            // warning1
            // 
            this.warning1.AutoSize = true;
            this.warning1.ForeColor = System.Drawing.Color.Red;
            this.warning1.Location = new System.Drawing.Point(153, 43);
            this.warning1.Name = "warning1";
            this.warning1.Size = new System.Drawing.Size(199, 13);
            this.warning1.TabIndex = 8;
            this.warning1.Text = "El turno ya fue utilizado. Seleccione otro.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bonos disponibles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Eliga el turno correspondiente:";
            // 
            // cmbBono
            // 
            this.cmbBono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBono.FormattingEnabled = true;
            this.cmbBono.Location = new System.Drawing.Point(163, 59);
            this.cmbBono.Name = "cmbBono";
            this.cmbBono.Size = new System.Drawing.Size(189, 21);
            this.cmbBono.TabIndex = 5;
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(163, 19);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(189, 21);
            this.cmbTurno.TabIndex = 4;
            this.cmbTurno.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha: (dd/mm/aaaa)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hora: (hh:mm:ss)";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione un profesional:";
            // 
            // warning3
            // 
            this.warning3.AutoSize = true;
            this.warning3.ForeColor = System.Drawing.Color.Red;
            this.warning3.Location = new System.Drawing.Point(209, 265);
            this.warning3.Name = "warning3";
            this.warning3.Size = new System.Drawing.Size(143, 13);
            this.warning3.TabIndex = 9;
            this.warning3.Text = "Formato de fecha incorrecto.";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(163, 75);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(189, 21);
            this.cmbEspecialidad.TabIndex = 2;
            // 
            // rbBusqueda
            // 
            this.rbBusqueda.AutoSize = true;
            this.rbBusqueda.Location = new System.Drawing.Point(163, 52);
            this.rbBusqueda.Name = "rbBusqueda";
            this.rbBusqueda.Size = new System.Drawing.Size(189, 17);
            this.rbBusqueda.TabIndex = 1;
            this.rbBusqueda.TabStop = true;
            this.rbBusqueda.Text = "Refinar busqueda por especialidad";
            this.rbBusqueda.UseVisualStyleBackColor = true;
            // 
            // txtHoraLlegada
            // 
            this.txtHoraLlegada.Location = new System.Drawing.Point(163, 242);
            this.txtHoraLlegada.Name = "txtHoraLlegada";
            this.txtHoraLlegada.Size = new System.Drawing.Size(189, 20);
            this.txtHoraLlegada.TabIndex = 5;
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(163, 25);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(189, 21);
            this.cmbProfesional.TabIndex = 0;
            // 
            // txtFechaLlegada
            // 
            this.txtFechaLlegada.Location = new System.Drawing.Point(163, 203);
            this.txtFechaLlegada.Name = "txtFechaLlegada";
            this.txtFechaLlegada.Size = new System.Drawing.Size(189, 20);
            this.txtFechaLlegada.TabIndex = 10;
            // 
            // warning4
            // 
            this.warning4.AutoSize = true;
            this.warning4.ForeColor = System.Drawing.Color.Red;
            this.warning4.Location = new System.Drawing.Point(209, 226);
            this.warning4.Name = "warning4";
            this.warning4.Size = new System.Drawing.Size(143, 13);
            this.warning4.TabIndex = 12;
            this.warning4.Text = "Formato de fecha incorrecto.";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(168, 301);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // warning2
            // 
            this.warning2.AutoSize = true;
            this.warning2.ForeColor = System.Drawing.Color.Red;
            this.warning2.Location = new System.Drawing.Point(12, 306);
            this.warning2.Name = "warning2";
            this.warning2.Size = new System.Drawing.Size(133, 13);
            this.warning2.TabIndex = 2;
            this.warning2.Text = "Faltan seleccionar campos";
            this.warning2.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(268, 301);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(76, 24);
            this.cmdVolver.TabIndex = 6;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmRegistroLlegadaAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 335);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.warning2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistroLlegadaAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro llegada de afiliado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistroLlegadaAfiliado_FormClosing);
            this.Load += new System.EventHandler(this.frmRegistroLlegadaAfiliado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.RadioButton rbBusqueda;
        private System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBono;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label warning1;
        private System.Windows.Forms.Label warning2;
        private System.Windows.Forms.Label warning3;
        private System.Windows.Forms.TextBox txtHoraLlegada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.TextBox txtFechaLlegada;
        private System.Windows.Forms.Label warning4;
        private System.Windows.Forms.Label label5;
    }
}