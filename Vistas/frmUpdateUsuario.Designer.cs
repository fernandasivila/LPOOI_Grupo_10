namespace Vistas
{
    partial class frmUpdateUsuario
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
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblApellidoNombre = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtApellidoNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDbUsuario = new System.Windows.Forms.Label();
            this.btnBuscarUser = new System.Windows.Forms.Button();
            this.cmbDbUsuario = new System.Windows.Forms.ComboBox();
            this.pnlDatosUsuario = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pnlDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.Location = new System.Drawing.Point(94, 238);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(139, 37);
            this.btnActualizarUsuario.TabIndex = 24;
            this.btnActualizarUsuario.Text = "Actualizar";
            this.btnActualizarUsuario.UseVisualStyleBackColor = true;
            this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizarUsuario_Click);
            // 
            // cmbRoles
            // 
            this.cmbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(172, 53);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(143, 23);
            this.cmbRoles.TabIndex = 23;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtUsuario.Location = new System.Drawing.Point(172, 130);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(143, 21);
            this.txtUsuario.TabIndex = 22;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtContraseña.Location = new System.Drawing.Point(172, 164);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(143, 21);
            this.txtContraseña.TabIndex = 21;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblContraseña.Location = new System.Drawing.Point(26, 168);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(76, 16);
            this.lblContraseña.TabIndex = 20;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblUsuario.Location = new System.Drawing.Point(26, 134);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 19;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblApellidoNombre
            // 
            this.lblApellidoNombre.AutoSize = true;
            this.lblApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblApellidoNombre.Location = new System.Drawing.Point(26, 95);
            this.lblApellidoNombre.Name = "lblApellidoNombre";
            this.lblApellidoNombre.Size = new System.Drawing.Size(119, 16);
            this.lblApellidoNombre.TabIndex = 18;
            this.lblApellidoNombre.Text = "Apellido y Nombre";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblRol.Location = new System.Drawing.Point(26, 62);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(28, 16);
            this.lblRol.TabIndex = 17;
            this.lblRol.Text = "Rol";
            // 
            // txtApellidoNombre
            // 
            this.txtApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtApellidoNombre.Location = new System.Drawing.Point(172, 88);
            this.txtApellidoNombre.Name = "txtApellidoNombre";
            this.txtApellidoNombre.Size = new System.Drawing.Size(143, 21);
            this.txtApellidoNombre.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(104, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Datos de Usuario";
            // 
            // lblDbUsuario
            // 
            this.lblDbUsuario.AutoSize = true;
            this.lblDbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblDbUsuario.Location = new System.Drawing.Point(256, 36);
            this.lblDbUsuario.Name = "lblDbUsuario";
            this.lblDbUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblDbUsuario.TabIndex = 25;
            this.lblDbUsuario.Text = "Usuario";
            // 
            // btnBuscarUser
            // 
            this.btnBuscarUser.Location = new System.Drawing.Point(327, 83);
            this.btnBuscarUser.Name = "btnBuscarUser";
            this.btnBuscarUser.Size = new System.Drawing.Size(139, 37);
            this.btnBuscarUser.TabIndex = 27;
            this.btnBuscarUser.Text = "Buscar";
            this.btnBuscarUser.UseVisualStyleBackColor = true;
            this.btnBuscarUser.Click += new System.EventHandler(this.btnBuscarUser_Click);
            // 
            // cmbDbUsuario
            // 
            this.cmbDbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cmbDbUsuario.FormattingEnabled = true;
            this.cmbDbUsuario.Location = new System.Drawing.Point(405, 29);
            this.cmbDbUsuario.Name = "cmbDbUsuario";
            this.cmbDbUsuario.Size = new System.Drawing.Size(143, 23);
            this.cmbDbUsuario.TabIndex = 28;
            // 
            // pnlDatosUsuario
            // 
            this.pnlDatosUsuario.Controls.Add(this.btnActualizarUsuario);
            this.pnlDatosUsuario.Controls.Add(this.cmbRoles);
            this.pnlDatosUsuario.Controls.Add(this.txtUsuario);
            this.pnlDatosUsuario.Controls.Add(this.txtContraseña);
            this.pnlDatosUsuario.Controls.Add(this.lblContraseña);
            this.pnlDatosUsuario.Controls.Add(this.lblUsuario);
            this.pnlDatosUsuario.Controls.Add(this.lblApellidoNombre);
            this.pnlDatosUsuario.Controls.Add(this.lblRol);
            this.pnlDatosUsuario.Controls.Add(this.txtApellidoNombre);
            this.pnlDatosUsuario.Controls.Add(this.label1);
            this.pnlDatosUsuario.Location = new System.Drawing.Point(233, 148);
            this.pnlDatosUsuario.Name = "pnlDatosUsuario";
            this.pnlDatosUsuario.Size = new System.Drawing.Size(337, 286);
            this.pnlDatosUsuario.TabIndex = 29;
            this.pnlDatosUsuario.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(22, 29);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 30;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmUpdateUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pnlDatosUsuario);
            this.Controls.Add(this.cmbDbUsuario);
            this.Controls.Add(this.btnBuscarUser);
            this.Controls.Add(this.lblDbUsuario);
            this.Name = "frmUpdateUsuario";
            this.Text = "frmUpdateUsuario";
            this.Load += new System.EventHandler(this.frmUpdateUsuario_Load);
            this.pnlDatosUsuario.ResumeLayout(false);
            this.pnlDatosUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarUsuario;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblApellidoNombre;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtApellidoNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDbUsuario;
        private System.Windows.Forms.Button btnBuscarUser;
        private System.Windows.Forms.ComboBox cmbDbUsuario;
        private System.Windows.Forms.Panel pnlDatosUsuario;
        private System.Windows.Forms.Button btnVolver;
    }
}