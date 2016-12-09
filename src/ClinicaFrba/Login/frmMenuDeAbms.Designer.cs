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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuDeAbms));
            this.lblDale = new System.Windows.Forms.Label();
            this.cmdLogueo = new System.Windows.Forms.Button();
            this.cmbFuncionalidades = new System.Windows.Forms.ComboBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDale
            // 
            this.lblDale.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblDale.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDale.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblDale.Location = new System.Drawing.Point(49, 37);
            this.lblDale.Name = "lblDale";
            this.lblDale.Size = new System.Drawing.Size(539, 75);
            this.lblDale.TabIndex = 0;
            this.lblDale.Text = "SELECCIONE LA FUNCIONALIDAD A EJECUTAR:";
            this.lblDale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdLogueo
            // 
            this.cmdLogueo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.cmdLogueo.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmdLogueo.ForeColor = System.Drawing.Color.White;
            this.cmdLogueo.Location = new System.Drawing.Point(147, 194);
            this.cmdLogueo.Name = "cmdLogueo";
            this.cmdLogueo.Size = new System.Drawing.Size(159, 46);
            this.cmdLogueo.TabIndex = 32;
            this.cmdLogueo.Text = "VOLVER A LOGUEARSE";
            this.cmdLogueo.UseVisualStyleBackColor = false;
            this.cmdLogueo.Click += new System.EventHandler(this.cmdLogueo_Click);
            // 
            // cmbFuncionalidades
            // 
            this.cmbFuncionalidades.BackColor = System.Drawing.Color.MintCream;
            this.cmbFuncionalidades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFuncionalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFuncionalidades.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFuncionalidades.FormattingEnabled = true;
            this.cmbFuncionalidades.ItemHeight = 20;
            this.cmbFuncionalidades.Location = new System.Drawing.Point(147, 137);
            this.cmbFuncionalidades.Name = "cmbFuncionalidades";
            this.cmbFuncionalidades.Size = new System.Drawing.Size(347, 28);
            this.cmbFuncionalidades.TabIndex = 33;
            this.cmbFuncionalidades.SelectedIndexChanged += new System.EventHandler(this.cmbFuncionalidades_SelectedIndexChanged);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnEjecutar.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnEjecutar.ForeColor = System.Drawing.Color.White;
            this.btnEjecutar.Location = new System.Drawing.Point(335, 194);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(159, 46);
            this.btnEjecutar.TabIndex = 35;
            this.btnEjecutar.Text = "EJECUTAR";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(517, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // frmMenuDeAbms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(635, 280);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.cmbFuncionalidades);
            this.Controls.Add(this.cmdLogueo);
            this.Controls.Add(this.lblDale);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMenuDeAbms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de ABMs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuDeAbms_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenuDeAbms_FormClosed);
            this.Load += new System.EventHandler(this.frmMenuDeAbms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDale;
        private System.Windows.Forms.Button cmdLogueo;
        private System.Windows.Forms.ComboBox cmbFuncionalidades;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}