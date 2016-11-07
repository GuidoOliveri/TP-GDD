namespace ClinicaFrba.Registro_Resultado
{
    partial class frmRegistroResultado
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
            this.cmbAfiliado = new System.Windows.Forms.ComboBox();
            this.rbFiltrarFecha = new System.Windows.Forms.RadioButton();
            this.warning2 = new System.Windows.Forms.Label();
            this.warning1 = new System.Windows.Forms.Label();
            this.cmbConsulta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.cmbEnfermedad = new System.Windows.Forms.ComboBox();
            this.cmbSintoma = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.warning3 = new System.Windows.Forms.Label();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAfiliado);
            this.groupBox1.Controls.Add(this.rbFiltrarFecha);
            this.groupBox1.Controls.Add(this.warning2);
            this.groupBox1.Controls.Add(this.warning1);
            this.groupBox1.Controls.Add(this.cmbConsulta);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Diagnóstico";
            // 
            // cmbAfiliado
            // 
            this.cmbAfiliado.FormattingEnabled = true;
            this.cmbAfiliado.Location = new System.Drawing.Point(36, 91);
            this.cmbAfiliado.Name = "cmbAfiliado";
            this.cmbAfiliado.Size = new System.Drawing.Size(173, 21);
            this.cmbAfiliado.TabIndex = 10;
            // 
            // rbFiltrarFecha
            // 
            this.rbFiltrarFecha.AutoSize = true;
            this.rbFiltrarFecha.Location = new System.Drawing.Point(36, 68);
            this.rbFiltrarFecha.Name = "rbFiltrarFecha";
            this.rbFiltrarFecha.Size = new System.Drawing.Size(104, 17);
            this.rbFiltrarFecha.TabIndex = 9;
            this.rbFiltrarFecha.TabStop = true;
            this.rbFiltrarFecha.Text = "Filtrar por afiliado";
            this.rbFiltrarFecha.UseVisualStyleBackColor = true;
            // 
            // warning2
            // 
            this.warning2.AutoSize = true;
            this.warning2.ForeColor = System.Drawing.Color.Red;
            this.warning2.Location = new System.Drawing.Point(469, 99);
            this.warning2.Name = "warning2";
            this.warning2.Size = new System.Drawing.Size(98, 13);
            this.warning2.TabIndex = 8;
            this.warning2.Text = "Formato incorrecto.";
            // 
            // warning1
            // 
            this.warning1.AutoSize = true;
            this.warning1.ForeColor = System.Drawing.Color.Red;
            this.warning1.Location = new System.Drawing.Point(469, 60);
            this.warning1.Name = "warning1";
            this.warning1.Size = new System.Drawing.Size(98, 13);
            this.warning1.TabIndex = 7;
            this.warning1.Text = "Formato incorrecto.";
            // 
            // cmbConsulta
            // 
            this.cmbConsulta.FormattingEnabled = true;
            this.cmbConsulta.Location = new System.Drawing.Point(36, 41);
            this.cmbConsulta.Name = "cmbConsulta";
            this.cmbConsulta.Size = new System.Drawing.Size(173, 21);
            this.cmbConsulta.TabIndex = 6;
            this.cmbConsulta.SelectedIndexChanged += new System.EventHandler(this.cmbConsulta_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Seleccione la consulta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.cmbEnfermedad);
            this.groupBox2.Controls.Add(this.cmbSintoma);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 167);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnóstico";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(9, 101);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(558, 57);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.Text = "";
            // 
            // cmbEnfermedad
            // 
            this.cmbEnfermedad.FormattingEnabled = true;
            this.cmbEnfermedad.Location = new System.Drawing.Point(238, 54);
            this.cmbEnfermedad.Name = "cmbEnfermedad";
            this.cmbEnfermedad.Size = new System.Drawing.Size(329, 21);
            this.cmbEnfermedad.TabIndex = 4;
            // 
            // cmbSintoma
            // 
            this.cmbSintoma.FormattingEnabled = true;
            this.cmbSintoma.Location = new System.Drawing.Point(238, 27);
            this.cmbSintoma.Name = "cmbSintoma";
            this.cmbSintoma.Size = new System.Drawing.Size(329, 21);
            this.cmbSintoma.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enfermedad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Síntoma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hora de atención: (hh:mm:ss)";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(405, 76);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(162, 20);
            this.txtHora.TabIndex = 2;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(405, 37);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(162, 20);
            this.txtFecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de atención: (dd/mm/aaaa)";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(261, 303);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // warning3
            // 
            this.warning3.AutoSize = true;
            this.warning3.ForeColor = System.Drawing.Color.Red;
            this.warning3.Location = new System.Drawing.Point(12, 308);
            this.warning3.Name = "warning3";
            this.warning3.Size = new System.Drawing.Size(114, 13);
            this.warning3.TabIndex = 10;
            this.warning3.Text = "Faltan completar datos";
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(395, 303);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(75, 23);
            this.cmdVolver.TabIndex = 11;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmRegistroResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 338);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.warning3);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistroResultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro resultado atención médica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistroResultado_FormClosing);
            this.Load += new System.EventHandler(this.frmRegistroResultado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbEnfermedad;
        private System.Windows.Forms.ComboBox cmbSintoma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label warning2;
        private System.Windows.Forms.Label warning1;
        private System.Windows.Forms.ComboBox cmbConsulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbFiltrarFecha;
        private System.Windows.Forms.Label warning3;
        private System.Windows.Forms.ComboBox cmbAfiliado;
        private System.Windows.Forms.Button cmdVolver;
    }
}