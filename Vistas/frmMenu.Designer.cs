namespace Vistas
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevaDisciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atletasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoAtletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.competenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevaCompetenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionUsuariosMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.img = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(160)))), ((int)(((byte)(63)))));
            this.menuStrip2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.atletasToolStripMenuItem,
            this.competenciasToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.GestionUsuariosMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip2.Size = new System.Drawing.Size(650, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinasToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(77, 22);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // disciplinasToolStripMenuItem
            // 
            this.disciplinasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevaDisciplinaToolStripMenuItem});
            this.disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            this.disciplinasToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.disciplinasToolStripMenuItem.Text = "Disciplinas";
            // 
            // registrarNuevaDisciplinaToolStripMenuItem
            // 
            this.registrarNuevaDisciplinaToolStripMenuItem.Name = "registrarNuevaDisciplinaToolStripMenuItem";
            this.registrarNuevaDisciplinaToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.registrarNuevaDisciplinaToolStripMenuItem.Text = "Registrar nueva Disciplina";
            this.registrarNuevaDisciplinaToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevaDisciplinaToolStripMenuItem_Click);
            // 
            // atletasToolStripMenuItem
            // 
            this.atletasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoAtletaToolStripMenuItem});
            this.atletasToolStripMenuItem.Name = "atletasToolStripMenuItem";
            this.atletasToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.atletasToolStripMenuItem.Text = "Atletas";
            // 
            // registrarNuevoAtletaToolStripMenuItem
            // 
            this.registrarNuevoAtletaToolStripMenuItem.Name = "registrarNuevoAtletaToolStripMenuItem";
            this.registrarNuevoAtletaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.registrarNuevoAtletaToolStripMenuItem.Text = "Registrar nuevo Atleta";
            this.registrarNuevoAtletaToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoAtletaToolStripMenuItem_Click);
            // 
            // competenciasToolStripMenuItem
            // 
            this.competenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevaCompetenciaToolStripMenuItem});
            this.competenciasToolStripMenuItem.Name = "competenciasToolStripMenuItem";
            this.competenciasToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.competenciasToolStripMenuItem.Text = "Competencias";
            // 
            // registrarNuevaCompetenciaToolStripMenuItem
            // 
            this.registrarNuevaCompetenciaToolStripMenuItem.Name = "registrarNuevaCompetenciaToolStripMenuItem";
            this.registrarNuevaCompetenciaToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.registrarNuevaCompetenciaToolStripMenuItem.Text = "Registrar nueva Competencia";
            this.registrarNuevaCompetenciaToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevaCompetenciaToolStripMenuItem_Click);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // GestionUsuariosMenuItem1
            // 
            this.GestionUsuariosMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarUsuarioToolStripMenuItem,
            this.borrarUsuarioToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem});
            this.GestionUsuariosMenuItem1.Name = "GestionUsuariosMenuItem1";
            this.GestionUsuariosMenuItem1.Size = new System.Drawing.Size(73, 22);
            this.GestionUsuariosMenuItem1.Text = "Usuario";
            // 
            // ingresarUsuarioToolStripMenuItem
            // 
            this.ingresarUsuarioToolStripMenuItem.Name = "ingresarUsuarioToolStripMenuItem";
            this.ingresarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.ingresarUsuarioToolStripMenuItem.Text = "Ingresar Usuario";
            this.ingresarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.ingresarUsuarioToolStripMenuItem_Click);
            // 
            // borrarUsuarioToolStripMenuItem
            // 
            this.borrarUsuarioToolStripMenuItem.Name = "borrarUsuarioToolStripMenuItem";
            this.borrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.borrarUsuarioToolStripMenuItem.Text = "Borrar Usuario";
            this.borrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.borrarUsuarioToolStripMenuItem_Click);
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar Usuario";
            this.modificarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
            // 
            // img
            // 
            this.img.Image = ((System.Drawing.Image)(resources.GetObject("img.Image")));
            this.img.Location = new System.Drawing.Point(75, 23);
            this.img.Margin = new System.Windows.Forms.Padding(2);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(486, 266);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 2;
            this.img.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(247)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(650, 292);
            this.Controls.Add(this.img);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmMenu";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevaDisciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atletasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoAtletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem competenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevaCompetenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.ToolStripMenuItem GestionUsuariosMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingresarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
    }
}