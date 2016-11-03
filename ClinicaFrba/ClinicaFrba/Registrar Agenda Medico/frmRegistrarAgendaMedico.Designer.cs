namespace ClinicaFrba.Registrar_Agenda_Medico
{
    partial class frmRegistrarAgendaMedico
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
            this.warning1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbHorarioHasta = new System.Windows.Forms.ComboBox();
            this.cmbHorarioDesde = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDiaHasta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDiaDesde = new System.Windows.Forms.ComboBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.warning2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.warning1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbProfesional);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbEspecialidad);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar agenda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // warning1
            // 
            this.warning1.AutoSize = true;
            this.warning1.ForeColor = System.Drawing.Color.Red;
            this.warning1.Location = new System.Drawing.Point(31, 212);
            this.warning1.Name = "warning1";
            this.warning1.Size = new System.Drawing.Size(209, 13);
            this.warning1.TabIndex = 3;
            this.warning1.Text = "Rango de atencion no válido. Ingrese otro.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Seleccione el profesional:";
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(204, 29);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(218, 21);
            this.cmbProfesional.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Seleccione especialidad:";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(204, 56);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(218, 21);
            this.cmbEspecialidad.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbHorarioHasta);
            this.groupBox3.Controls.Add(this.cmbHorarioDesde);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 60);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rango Horario";
            // 
            // cmbHorarioHasta
            // 
            this.cmbHorarioHasta.FormattingEnabled = true;
            this.cmbHorarioHasta.Location = new System.Drawing.Point(295, 27);
            this.cmbHorarioHasta.Name = "cmbHorarioHasta";
            this.cmbHorarioHasta.Size = new System.Drawing.Size(121, 21);
            this.cmbHorarioHasta.TabIndex = 8;
            // 
            // cmbHorarioDesde
            // 
            this.cmbHorarioDesde.FormattingEnabled = true;
            this.cmbHorarioDesde.Location = new System.Drawing.Point(82, 28);
            this.cmbHorarioDesde.Name = "cmbHorarioDesde";
            this.cmbHorarioDesde.Size = new System.Drawing.Size(121, 21);
            this.cmbHorarioDesde.TabIndex = 7;
            this.cmbHorarioDesde.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Desde:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDiaHasta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbDiaDesde);
            this.groupBox2.Location = new System.Drawing.Point(6, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 58);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Días de Atención";
            // 
            // cmbDiaHasta
            // 
            this.cmbDiaHasta.FormattingEnabled = true;
            this.cmbDiaHasta.Location = new System.Drawing.Point(295, 25);
            this.cmbDiaHasta.Name = "cmbDiaHasta";
            this.cmbDiaHasta.Size = new System.Drawing.Size(121, 21);
            this.cmbDiaHasta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde:";
            // 
            // cmbDiaDesde
            // 
            this.cmbDiaDesde.FormattingEnabled = true;
            this.cmbDiaDesde.Location = new System.Drawing.Point(82, 25);
            this.cmbDiaDesde.Name = "cmbDiaDesde";
            this.cmbDiaDesde.Size = new System.Drawing.Size(121, 21);
            this.cmbDiaDesde.TabIndex = 0;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(204, 246);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // warning2
            // 
            this.warning2.AutoSize = true;
            this.warning2.ForeColor = System.Drawing.Color.Red;
            this.warning2.Location = new System.Drawing.Point(12, 251);
            this.warning2.Name = "warning2";
            this.warning2.Size = new System.Drawing.Size(133, 13);
            this.warning2.TabIndex = 2;
            this.warning2.Text = "Faltan seleccionar campos";
            // 
            // frmRegistrarAgendaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 281);
            this.Controls.Add(this.warning2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistrarAgendaMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de la agenda del médico";
            this.Load += new System.EventHandler(this.frmRegistrarAgendaMedico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbDiaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDiaDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.ComboBox cmbHorarioDesde;
        private System.Windows.Forms.ComboBox cmbHorarioHasta;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.Label warning1;
        private System.Windows.Forms.Label warning2;
    }
}