namespace ClinicaFrba.AbmRol
{
    partial class frmAgregarNuevoRol
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
            this.lblNombreNuevoRol = new System.Windows.Forms.Label();
            this.lblNuevasFuncionalidades = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdSeleccionarTodo = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreNuevoRol
            // 
            this.lblNombreNuevoRol.AutoSize = true;
            this.lblNombreNuevoRol.Location = new System.Drawing.Point(12, 20);
            this.lblNombreNuevoRol.Name = "lblNombreNuevoRol";
            this.lblNombreNuevoRol.Size = new System.Drawing.Size(78, 13);
            this.lblNombreNuevoRol.TabIndex = 9;
            this.lblNombreNuevoRol.Text = "Nombre del rol:";
            // 
            // lblNuevasFuncionalidades
            // 
            this.lblNuevasFuncionalidades.AutoSize = true;
            this.lblNuevasFuncionalidades.Location = new System.Drawing.Point(12, 75);
            this.lblNuevasFuncionalidades.Name = "lblNuevasFuncionalidades";
            this.lblNuevasFuncionalidades.Size = new System.Drawing.Size(87, 13);
            this.lblNuevasFuncionalidades.TabIndex = 10;
            this.lblNuevasFuncionalidades.Text = "Funcionalidades:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // cmbFuncionalidades
            // 
            this.cmbFuncionalidades.FormattingEnabled = true;
            this.cmbFuncionalidades.Location = new System.Drawing.Point(133, 75);
            this.cmbFuncionalidades.Name = "cmbFuncionalidades";
            this.cmbFuncionalidades.Size = new System.Drawing.Size(215, 199);
            this.cmbFuncionalidades.TabIndex = 13;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(230, 313);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(103, 23);
            this.cmdAgregar.TabIndex = 14;
            this.cmdAgregar.Text = "Guardar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(78, 359);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(98, 23);
            this.cmdLimpiar.TabIndex = 15;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdSeleccionarTodo
            // 
            this.cmdSeleccionarTodo.Location = new System.Drawing.Point(78, 313);
            this.cmdSeleccionarTodo.Name = "cmdSeleccionarTodo";
            this.cmdSeleccionarTodo.Size = new System.Drawing.Size(98, 23);
            this.cmdSeleccionarTodo.TabIndex = 16;
            this.cmdSeleccionarTodo.Text = "Seleccionar todo";
            this.cmdSeleccionarTodo.UseVisualStyleBackColor = true;
            this.cmdSeleccionarTodo.Click += new System.EventHandler(this.cmdSeleccionarTodo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(234, 359);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(98, 23);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmAgregarNuevoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 407);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cmdSeleccionarTodo);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.cmbFuncionalidades);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNuevasFuncionalidades);
            this.Controls.Add(this.lblNombreNuevoRol);
            this.Name = "frmAgregarNuevoRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de Rol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgregarNuevoRol_FormClosing);
            this.Load += new System.EventHandler(this.frmRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreNuevoRol;
        private System.Windows.Forms.Label lblNuevasFuncionalidades;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckedListBox cmbFuncionalidades;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdSeleccionarTodo;
        private System.Windows.Forms.Button btnVolver;
    }
}