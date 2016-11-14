namespace ClinicaFrba.Abm_Afiliado
{
    partial class frmAsociarAfiliado
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
            this.pnlAsociar = new System.Windows.Forms.Panel();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblFamAsoc = new System.Windows.Forms.Label();
            this.optConyuge = new System.Windows.Forms.RadioButton();
            this.optHijo = new System.Windows.Forms.RadioButton();
            this.txtNroAfiliadoPrincipal = new System.Windows.Forms.TextBox();
            this.lblNroAfiliadoPrincipal = new System.Windows.Forms.Label();
            this.btnAsociar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlAsociar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAsociar
            // 
            this.pnlAsociar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAsociar.Controls.Add(this.lblDatos);
            this.pnlAsociar.Controls.Add(this.lblFamAsoc);
            this.pnlAsociar.Controls.Add(this.optConyuge);
            this.pnlAsociar.Controls.Add(this.optHijo);
            this.pnlAsociar.Controls.Add(this.txtNroAfiliadoPrincipal);
            this.pnlAsociar.Controls.Add(this.lblNroAfiliadoPrincipal);
            this.pnlAsociar.Location = new System.Drawing.Point(29, 34);
            this.pnlAsociar.Name = "pnlAsociar";
            this.pnlAsociar.Size = new System.Drawing.Size(418, 105);
            this.pnlAsociar.TabIndex = 0;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(13, -1);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(92, 13);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Datos importantes";
            // 
            // lblFamAsoc
            // 
            this.lblFamAsoc.AutoSize = true;
            this.lblFamAsoc.Location = new System.Drawing.Point(22, 66);
            this.lblFamAsoc.Name = "lblFamAsoc";
            this.lblFamAsoc.Size = new System.Drawing.Size(89, 13);
            this.lblFamAsoc.TabIndex = 4;
            this.lblFamAsoc.Text = "Familiar a Asociar";
            // 
            // optConyuge
            // 
            this.optConyuge.AutoSize = true;
            this.optConyuge.Location = new System.Drawing.Point(295, 64);
            this.optConyuge.Name = "optConyuge";
            this.optConyuge.Size = new System.Drawing.Size(67, 17);
            this.optConyuge.TabIndex = 3;
            this.optConyuge.TabStop = true;
            this.optConyuge.Text = "Conyuge";
            this.optConyuge.UseVisualStyleBackColor = true;
            // 
            // optHijo
            // 
            this.optHijo.AutoSize = true;
            this.optHijo.Location = new System.Drawing.Point(153, 64);
            this.optHijo.Name = "optHijo";
            this.optHijo.Size = new System.Drawing.Size(124, 17);
            this.optHijo.TabIndex = 2;
            this.optHijo.TabStop = true;
            this.optHijo.Text = "Hijo/a u Otro Familiar";
            this.optHijo.UseVisualStyleBackColor = true;
            // 
            // txtNroAfiliadoPrincipal
            // 
            this.txtNroAfiliadoPrincipal.Location = new System.Drawing.Point(215, 29);
            this.txtNroAfiliadoPrincipal.Name = "txtNroAfiliadoPrincipal";
            this.txtNroAfiliadoPrincipal.Size = new System.Drawing.Size(111, 20);
            this.txtNroAfiliadoPrincipal.TabIndex = 1;
            this.txtNroAfiliadoPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroAfiliadoPrincipal_KeyPress);
            // 
            // lblNroAfiliadoPrincipal
            // 
            this.lblNroAfiliadoPrincipal.AutoSize = true;
            this.lblNroAfiliadoPrincipal.Location = new System.Drawing.Point(22, 29);
            this.lblNroAfiliadoPrincipal.Name = "lblNroAfiliadoPrincipal";
            this.lblNroAfiliadoPrincipal.Size = new System.Drawing.Size(104, 13);
            this.lblNroAfiliadoPrincipal.TabIndex = 0;
            this.lblNroAfiliadoPrincipal.Text = "Nro Afiliado Principal";
            // 
            // btnAsociar
            // 
            this.btnAsociar.Location = new System.Drawing.Point(357, 164);
            this.btnAsociar.Name = "btnAsociar";
            this.btnAsociar.Size = new System.Drawing.Size(90, 32);
            this.btnAsociar.TabIndex = 1;
            this.btnAsociar.Text = "Asociar";
            this.btnAsociar.UseVisualStyleBackColor = true;
            this.btnAsociar.Click += new System.EventHandler(this.btnAsociar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(29, 164);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 32);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmAsociarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 208);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAsociar);
            this.Controls.Add(this.pnlAsociar);
            this.Name = "frmAsociarAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asociar Afiliado";
            this.Load += new System.EventHandler(this.frmAsociarAfiliado_Load);
            this.pnlAsociar.ResumeLayout(false);
            this.pnlAsociar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAsociar;
        private System.Windows.Forms.TextBox txtNroAfiliadoPrincipal;
        private System.Windows.Forms.Label lblNroAfiliadoPrincipal;
        private System.Windows.Forms.Button btnAsociar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblFamAsoc;
        private System.Windows.Forms.RadioButton optConyuge;
        private System.Windows.Forms.RadioButton optHijo;
    }
}