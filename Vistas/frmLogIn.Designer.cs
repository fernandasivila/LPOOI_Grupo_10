namespace Vistas
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.pnl_TitleBar = new System.Windows.Forms.Panel();
            this.btn_Restore = new System.Windows.Forms.PictureBox();
            this.btn_Minimize = new System.Windows.Forms.PictureBox();
            this.btn_Maximize = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.lblUsuario.Location = new System.Drawing.Point(264, 229);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 19);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.txtUsuario.Location = new System.Drawing.Point(339, 229);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(235, 25);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.txtContraseña.Location = new System.Drawing.Point(339, 266);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(235, 25);
            this.txtContraseña.TabIndex = 2;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.lblContraseña.Location = new System.Drawing.Point(243, 266);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(79, 19);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña";
            // 
            // pnl_TitleBar
            // 
            this.pnl_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(185)))), ((int)(((byte)(190)))));
            this.pnl_TitleBar.Controls.Add(this.btn_Restore);
            this.pnl_TitleBar.Controls.Add(this.btn_Minimize);
            this.pnl_TitleBar.Controls.Add(this.btn_Maximize);
            this.pnl_TitleBar.Controls.Add(this.btn_Cerrar);
            this.pnl_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_TitleBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_TitleBar.Name = "pnl_TitleBar";
            this.pnl_TitleBar.Size = new System.Drawing.Size(852, 25);
            this.pnl_TitleBar.TabIndex = 10;
            this.pnl_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_TitleBar_MouseDown);
            // 
            // btn_Restore
            // 
            this.btn_Restore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restore.Image = ((System.Drawing.Image)(resources.GetObject("btn_Restore.Image")));
            this.btn_Restore.Location = new System.Drawing.Point(795, 5);
            this.btn_Restore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(17, 16);
            this.btn_Restore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Restore.TabIndex = 2;
            this.btn_Restore.TabStop = false;
            this.btn_Restore.Visible = false;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.Image")));
            this.btn_Minimize.Location = new System.Drawing.Point(763, 5);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(17, 16);
            this.btn_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minimize.TabIndex = 1;
            this.btn_Minimize.TabStop = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Maximize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Maximize.Image")));
            this.btn_Maximize.Location = new System.Drawing.Point(795, 5);
            this.btn_Maximize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(17, 16);
            this.btn_Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Maximize.TabIndex = 3;
            this.btn_Maximize.TabStop = false;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.Image")));
            this.btn_Cerrar.Location = new System.Drawing.Point(826, 5);
            this.btn_Cerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(17, 16);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lbl_Login
            // 
            this.lbl_Login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_Login.Location = new System.Drawing.Point(366, 175);
            this.lbl_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(95, 17);
            this.lbl_Login.TabIndex = 12;
            this.lbl_Login.Text = "Iniciá Sesión";
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(78)))), ((int)(((byte)(32)))));
            this.lbl_Welcome.Location = new System.Drawing.Point(280, 129);
            this.lbl_Welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(278, 38);
            this.lbl_Welcome.TabIndex = 11;
            this.lbl_Welcome.Text = "Bienvenido/as";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(131)))), ((int)(((byte)(129)))));
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(350, 314);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(139, 37);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.Text = "INICIAR SESIÓN";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Vistas.Properties.Resources.silueta;
            this.pictureBox1.Location = new System.Drawing.Point(283, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(852, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.pnl_TitleBar);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogIn";
            this.Text = "Iniciar Sesión";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl_TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Restore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Panel pnl_TitleBar;
        private System.Windows.Forms.PictureBox btn_Restore;
        private System.Windows.Forms.PictureBox btn_Minimize;
        private System.Windows.Forms.PictureBox btn_Maximize;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}