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
            this.lblIdUser = new System.Windows.Forms.Label();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.btnBuscarUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.Location = new System.Drawing.Point(327, 386);
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
            this.cmbRoles.Location = new System.Drawing.Point(405, 201);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(143, 23);
            this.cmbRoles.TabIndex = 23;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtUsuario.Location = new System.Drawing.Point(405, 278);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(143, 21);
            this.txtUsuario.TabIndex = 22;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtContraseña.Location = new System.Drawing.Point(405, 312);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(143, 21);
            this.txtContraseña.TabIndex = 21;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblContraseña.Location = new System.Drawing.Point(259, 316);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(76, 16);
            this.lblContraseña.TabIndex = 20;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblUsuario.Location = new System.Drawing.Point(259, 282);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 19;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblApellidoNombre
            // 
            this.lblApellidoNombre.AutoSize = true;
            this.lblApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblApellidoNombre.Location = new System.Drawing.Point(259, 243);
            this.lblApellidoNombre.Name = "lblApellidoNombre";
            this.lblApellidoNombre.Size = new System.Drawing.Size(119, 16);
            this.lblApellidoNombre.TabIndex = 18;
            this.lblApellidoNombre.Text = "Apellido y Nombre";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblRol.Location = new System.Drawing.Point(259, 210);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(28, 16);
            this.lblRol.TabIndex = 17;
            this.lblRol.Text = "Rol";
            // 
            // txtApellidoNombre
            // 
            this.txtApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtApellidoNombre.Location = new System.Drawing.Point(405, 236);
            this.txtApellidoNombre.Name = "txtApellidoNombre";
            this.txtApellidoNombre.Size = new System.Drawing.Size(143, 21);
            this.txtApellidoNombre.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(337, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Datos de Usuario";
            // 
            // lblIdUser
            // 
            this.lblIdUser.AutoSize = true;
            this.lblIdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblIdUser.Location = new System.Drawing.Point(256, 36);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(68, 16);
            this.lblIdUser.TabIndex = 25;
            this.lblIdUser.Text = "Id Usuario";
            // 
            // txtIdUser
            // 
            this.txtIdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtIdUser.Location = new System.Drawing.Point(402, 31);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.Size = new System.Drawing.Size(143, 21);
            this.txtIdUser.TabIndex = 26;
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
            // frmUpdateUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarUser);
            this.Controls.Add(this.txtIdUser);
            this.Controls.Add(this.lblIdUser);
            this.Controls.Add(this.btnActualizarUsuario);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblApellidoNombre);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.txtApellidoNombre);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateUsuario";
            this.Text = "frmUpdateUsuario";
            this.Load += new System.EventHandler(this.frmUpdateUsuario_Load);
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
        private System.Windows.Forms.Label lblIdUser;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.Button btnBuscarUser;
    }
}