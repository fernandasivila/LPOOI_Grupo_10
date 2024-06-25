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
            this.lblDbUsuario = new System.Windows.Forms.Label();
            this.cmbDbUsuario = new System.Windows.Forms.ComboBox();
            this.pnlDatosUsuario = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidoNombre = new System.Windows.Forms.TextBox();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblApellidoNombre = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnBuscarUser = new System.Windows.Forms.Button();
            this.pnlDatosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(49)))), ((int)(((byte)(38)))));
            this.btnActualizarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarUsuario.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold);
            this.btnActualizarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnActualizarUsuario.Location = new System.Drawing.Point(423, 469);
            this.btnActualizarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(208, 57);
            this.btnActualizarUsuario.TabIndex = 24;
            this.btnActualizarUsuario.Text = "ACTUALIZAR";
            this.btnActualizarUsuario.UseVisualStyleBackColor = false;
            this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizarUsuario_Click);
            // 
            // lblDbUsuario
            // 
            this.lblDbUsuario.AutoSize = true;
            this.lblDbUsuario.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.lblDbUsuario.Location = new System.Drawing.Point(325, 14);
            this.lblDbUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDbUsuario.Name = "lblDbUsuario";
            this.lblDbUsuario.Size = new System.Drawing.Size(79, 28);
            this.lblDbUsuario.TabIndex = 25;
            this.lblDbUsuario.Text = "Usuario";
            // 
            // cmbDbUsuario
            // 
            this.cmbDbUsuario.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.cmbDbUsuario.FormattingEnabled = true;
            this.cmbDbUsuario.Location = new System.Drawing.Point(423, 14);
            this.cmbDbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDbUsuario.Name = "cmbDbUsuario";
            this.cmbDbUsuario.Size = new System.Drawing.Size(212, 36);
            this.cmbDbUsuario.TabIndex = 28;
            // 
            // pnlDatosUsuario
            // 
            this.pnlDatosUsuario.BackColor = System.Drawing.Color.White;
            this.pnlDatosUsuario.Controls.Add(this.label1);
            this.pnlDatosUsuario.Controls.Add(this.txtApellidoNombre);
            this.pnlDatosUsuario.Controls.Add(this.cmbRoles);
            this.pnlDatosUsuario.Controls.Add(this.lblRol);
            this.pnlDatosUsuario.Controls.Add(this.txtUsuario);
            this.pnlDatosUsuario.Controls.Add(this.lblApellidoNombre);
            this.pnlDatosUsuario.Controls.Add(this.txtContraseña);
            this.pnlDatosUsuario.Controls.Add(this.lblUsuario);
            this.pnlDatosUsuario.Controls.Add(this.lblContraseña);
            this.pnlDatosUsuario.Location = new System.Drawing.Point(185, 80);
            this.pnlDatosUsuario.Name = "pnlDatosUsuario";
            this.pnlDatosUsuario.Size = new System.Drawing.Size(700, 364);
            this.pnlDatosUsuario.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS DE USUARIO";
            // 
            // txtApellidoNombre
            // 
            this.txtApellidoNombre.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.txtApellidoNombre.Location = new System.Drawing.Point(284, 159);
            this.txtApellidoNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellidoNombre.Name = "txtApellidoNombre";
            this.txtApellidoNombre.Size = new System.Drawing.Size(347, 31);
            this.txtApellidoNombre.TabIndex = 1;
            // 
            // cmbRoles
            // 
            this.cmbRoles.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbRoles.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(284, 100);
            this.cmbRoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(347, 33);
            this.cmbRoles.TabIndex = 13;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(65, 104);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(41, 28);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.txtUsuario.Location = new System.Drawing.Point(284, 214);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(347, 31);
            this.txtUsuario.TabIndex = 11;
            // 
            // lblApellidoNombre
            // 
            this.lblApellidoNombre.AutoSize = true;
            this.lblApellidoNombre.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoNombre.Location = new System.Drawing.Point(65, 159);
            this.lblApellidoNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoNombre.Name = "lblApellidoNombre";
            this.lblApellidoNombre.Size = new System.Drawing.Size(179, 28);
            this.lblApellidoNombre.TabIndex = 4;
            this.lblApellidoNombre.Text = "Apellido y Nombre";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.txtContraseña.Location = new System.Drawing.Point(284, 269);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(347, 31);
            this.txtContraseña.TabIndex = 10;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(65, 214);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 28);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(65, 269);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(110, 28);
            this.lblContraseña.TabIndex = 8;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnBuscarUser
            // 
            this.btnBuscarUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(185)))), ((int)(((byte)(190)))));
            this.btnBuscarUser.FlatAppearance.BorderSize = 0;
            this.btnBuscarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarUser.Location = new System.Drawing.Point(631, 9);
            this.btnBuscarUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarUser.Name = "btnBuscarUser";
            this.btnBuscarUser.Size = new System.Drawing.Size(52, 42);
            this.btnBuscarUser.TabIndex = 30;
            this.btnBuscarUser.Text = "🔍";
            this.btnBuscarUser.UseVisualStyleBackColor = false;
            this.btnBuscarUser.Click += new System.EventHandler(this.btnBuscarUser_Click);
            // 
            // frmUpdateUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 542);
            this.Controls.Add(this.btnBuscarUser);
            this.Controls.Add(this.pnlDatosUsuario);
            this.Controls.Add(this.btnActualizarUsuario);
            this.Controls.Add(this.cmbDbUsuario);
            this.Controls.Add(this.lblDbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label lblDbUsuario;
        private System.Windows.Forms.ComboBox cmbDbUsuario;
        private System.Windows.Forms.Panel pnlDatosUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidoNombre;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblApellidoNombre;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnBuscarUser;
    }
}