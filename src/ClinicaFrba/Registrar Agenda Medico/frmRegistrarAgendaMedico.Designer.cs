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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.warning1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDiaHasta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDiaDesde = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbHorarioHasta = new System.Windows.Forms.ComboBox();
            this.cmbHorarioDesde = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgRangoAtencion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.warning3 = new System.Windows.Forms.Label();
            this.gbRangoFechas = new System.Windows.Forms.GroupBox();
            this.dpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.warning2 = new System.Windows.Forms.Label();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRangoAtencion)).BeginInit();
            this.gbRangoFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.warning1);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dgRangoAtencion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbProfesional);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbEspecialidad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar agenda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(332, 265);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // warning1
            // 
            this.warning1.AutoSize = true;
            this.warning1.ForeColor = System.Drawing.Color.Red;
            this.warning1.Location = new System.Drawing.Point(9, 265);
            this.warning1.Name = "warning1";
            this.warning1.Size = new System.Drawing.Size(224, 13);
            this.warning1.TabIndex = 11;
            this.warning1.Text = "El rango horario no es válido. Seleccione otro.";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(414, 265);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDiaHasta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbDiaDesde);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 43);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Días de Atención";
            // 
            // cmbDiaHasta
            // 
            this.cmbDiaHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiaHasta.FormattingEnabled = true;
            this.cmbDiaHasta.Location = new System.Drawing.Point(344, 16);
            this.cmbDiaHasta.Name = "cmbDiaHasta";
            this.cmbDiaHasta.Size = new System.Drawing.Size(121, 21);
            this.cmbDiaHasta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde:";
            // 
            // cmbDiaDesde
            // 
            this.cmbDiaDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiaDesde.FormattingEnabled = true;
            this.cmbDiaDesde.Location = new System.Drawing.Point(82, 16);
            this.cmbDiaDesde.Name = "cmbDiaDesde";
            this.cmbDiaDesde.Size = new System.Drawing.Size(121, 21);
            this.cmbDiaDesde.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ingrese Rangos de Atención:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbHorarioHasta);
            this.groupBox3.Controls.Add(this.cmbHorarioDesde);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 43);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rango Horario";
            // 
            // cmbHorarioHasta
            // 
            this.cmbHorarioHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarioHasta.FormattingEnabled = true;
            this.cmbHorarioHasta.Location = new System.Drawing.Point(344, 17);
            this.cmbHorarioHasta.Name = "cmbHorarioHasta";
            this.cmbHorarioHasta.Size = new System.Drawing.Size(121, 21);
            this.cmbHorarioHasta.TabIndex = 8;
            // 
            // cmbHorarioDesde
            // 
            this.cmbHorarioDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarioDesde.FormattingEnabled = true;
            this.cmbHorarioDesde.Location = new System.Drawing.Point(82, 17);
            this.cmbHorarioDesde.Name = "cmbHorarioDesde";
            this.cmbHorarioDesde.Size = new System.Drawing.Size(121, 21);
            this.cmbHorarioDesde.TabIndex = 7;
            this.cmbHorarioDesde.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Desde:";
            // 
            // dgRangoAtencion
            // 
            this.dgRangoAtencion.AllowDrop = true;
            this.dgRangoAtencion.AllowUserToAddRows = false;
            this.dgRangoAtencion.AllowUserToDeleteRows = false;
            this.dgRangoAtencion.AllowUserToResizeColumns = false;
            this.dgRangoAtencion.AllowUserToResizeRows = false;
            this.dgRangoAtencion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRangoAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgRangoAtencion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgRangoAtencion.Location = new System.Drawing.Point(9, 290);
            this.dgRangoAtencion.Name = "dgRangoAtencion";
            this.dgRangoAtencion.Size = new System.Drawing.Size(483, 73);
            this.dgRangoAtencion.TabIndex = 3;
            this.dgRangoAtencion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRangoAtencion_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Dia (Desde)";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dia (Hasta)";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hora (Desde)";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hora (Hasta)";
            this.Column4.Name = "Column4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Seleccione el profesional:";
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(222, 21);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(267, 21);
            this.cmbProfesional.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Seleccione especialidad:";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(222, 46);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(267, 21);
            this.cmbEspecialidad.TabIndex = 5;
            // 
            // warning3
            // 
            this.warning3.AutoSize = true;
            this.warning3.ForeColor = System.Drawing.Color.Red;
            this.warning3.Location = new System.Drawing.Point(9, 62);
            this.warning3.Name = "warning3";
            this.warning3.Size = new System.Drawing.Size(430, 13);
            this.warning3.TabIndex = 12;
            this.warning3.Text = "Ya existe una agenda para ese rango de fechas. Solo puede agregar rangos de atenc" +
    "ión.";
            this.warning3.Click += new System.EventHandler(this.warning3_Click);
            // 
            // gbRangoFechas
            // 
            this.gbRangoFechas.Controls.Add(this.dpFechaDesde);
            this.gbRangoFechas.Controls.Add(this.warning3);
            this.gbRangoFechas.Controls.Add(this.label9);
            this.gbRangoFechas.Controls.Add(this.dpFechaHasta);
            this.gbRangoFechas.Controls.Add(this.label8);
            this.gbRangoFechas.Location = new System.Drawing.Point(12, 85);
            this.gbRangoFechas.Name = "gbRangoFechas";
            this.gbRangoFechas.Size = new System.Drawing.Size(501, 77);
            this.gbRangoFechas.TabIndex = 3;
            this.gbRangoFechas.TabStop = false;
            this.gbRangoFechas.Text = "Rango de fechas";
            // 
            // dpFechaDesde
            // 
            this.dpFechaDesde.Location = new System.Drawing.Point(222, 16);
            this.dpFechaDesde.Name = "dpFechaDesde";
            this.dpFechaDesde.Size = new System.Drawing.Size(267, 20);
            this.dpFechaDesde.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Hasta:";
            // 
            // dpFechaHasta
            // 
            this.dpFechaHasta.Location = new System.Drawing.Point(222, 40);
            this.dpFechaHasta.Name = "dpFechaHasta";
            this.dpFechaHasta.Size = new System.Drawing.Size(267, 20);
            this.dpFechaHasta.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Desde:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(344, 383);
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
            this.warning2.Location = new System.Drawing.Point(12, 388);
            this.warning2.Name = "warning2";
            this.warning2.Size = new System.Drawing.Size(133, 13);
            this.warning2.TabIndex = 2;
            this.warning2.Text = "Faltan seleccionar campos";
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(426, 383);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 4;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmRegistrarAgendaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 413);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.warning2);
            this.Controls.Add(this.gbRangoFechas);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistrarAgendaMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de la agenda del médico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistrarAgendaMedico_FormClosing);
            this.Load += new System.EventHandler(this.frmRegistrarAgendaMedico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRangoAtencion)).EndInit();
            this.gbRangoFechas.ResumeLayout(false);
            this.gbRangoFechas.PerformLayout();
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
        private System.Windows.Forms.Label warning2;
        private System.Windows.Forms.DataGridView dgRangoAtencion;
        private System.Windows.Forms.GroupBox gbRangoFechas;
        private System.Windows.Forms.DateTimePicker dpFechaDesde;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dpFechaHasta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label warning1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label warning3;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Button btnBorrar;
    }
}