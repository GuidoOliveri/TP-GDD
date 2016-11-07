namespace ClinicaFrba.Login
{
    partial class frmMenuDeAbms
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
            this.lblDale = new System.Windows.Forms.Label();
            this.cmdLogueo = new System.Windows.Forms.Button();
            this.cmbFuncionalidades = new System.Windows.Forms.ComboBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDale
            // 
            this.lblDale.AutoSize = true;
            this.lblDale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDale.Location = new System.Drawing.Point(77, 18);
            this.lblDale.Name = "lblDale";
            this.lblDale.Size = new System.Drawing.Size(464, 29);
            this.lblDale.TabIndex = 0;
            this.lblDale.Text = "Seleccione la funcionalidad a ejecutar:";
            // 
            // cmdLogueo
            // 
            this.cmdLogueo.Location = new System.Drawing.Point(136, 247);
            this.cmdLogueo.Name = "cmdLogueo";
            this.cmdLogueo.Size = new System.Drawing.Size(142, 27);
            this.cmdLogueo.TabIndex = 32;
            this.cmdLogueo.Text = "Volver a Loguearse";
            this.cmdLogueo.UseVisualStyleBackColor = true;
            this.cmdLogueo.Click += new System.EventHandler(this.cmdLogueo_Click);
            // 
            // cmbFuncionalidades
            // 
            this.cmbFuncionalidades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFuncionalidades.FormattingEnabled = true;
            this.cmbFuncionalidades.Location = new System.Drawing.Point(136, 139);
            this.cmbFuncionalidades.Name = "cmbFuncionalidades";
            this.cmbFuncionalidades.Size = new System.Drawing.Size(338, 21);
            this.cmbFuncionalidades.TabIndex = 33;
            this.cmbFuncionalidades.SelectedIndexChanged += new System.EventHandler(this.cmbFuncionalidades_SelectedIndexChanged);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(361, 247);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(137, 27);
            this.btnEjecutar.TabIndex = 35;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // frmMenuDeAbms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 361);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.cmbFuncionalidades);
            this.Controls.Add(this.cmdLogueo);
            this.Controls.Add(this.lblDale);
            this.Name = "frmMenuDeAbms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de ABMs";
            this.Load += new System.EventHandler(this.frmMenuDeAbms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDale;
        private System.Windows.Forms.Button cmdLogueo;
        private System.Windows.Forms.ComboBox cmbFuncionalidades;
        private System.Windows.Forms.Button btnEjecutar;
    }
}