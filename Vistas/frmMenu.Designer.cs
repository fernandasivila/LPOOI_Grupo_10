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
            this.img = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(160)))), ((int)(((byte)(63)))));
            this.menuStrip2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.atletasToolStripMenuItem,
            this.competenciasToolStripMenuItem,
            this.eventosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(975, 33);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinasToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // disciplinasToolStripMenuItem
            // 
            this.disciplinasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevaDisciplinaToolStripMenuItem});
            this.disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            this.disciplinasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.disciplinasToolStripMenuItem.Text = "Disciplinas";
            // 
            // registrarNuevaDisciplinaToolStripMenuItem
            // 
            this.registrarNuevaDisciplinaToolStripMenuItem.Name = "registrarNuevaDisciplinaToolStripMenuItem";
            this.registrarNuevaDisciplinaToolStripMenuItem.Size = new System.Drawing.Size(373, 34);
            this.registrarNuevaDisciplinaToolStripMenuItem.Text = "Registrar nueva Disciplina";
            this.registrarNuevaDisciplinaToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevaDisciplinaToolStripMenuItem_Click);
            // 
            // atletasToolStripMenuItem
            // 
            this.atletasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoAtletaToolStripMenuItem});
            this.atletasToolStripMenuItem.Name = "atletasToolStripMenuItem";
            this.atletasToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.atletasToolStripMenuItem.Text = "Atletas";
            // 
            // registrarNuevoAtletaToolStripMenuItem
            // 
            this.registrarNuevoAtletaToolStripMenuItem.Name = "registrarNuevoAtletaToolStripMenuItem";
            this.registrarNuevoAtletaToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.registrarNuevoAtletaToolStripMenuItem.Text = "Registrar nuevo Atleta";
            this.registrarNuevoAtletaToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoAtletaToolStripMenuItem_Click);
            // 
            // competenciasToolStripMenuItem
            // 
            this.competenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevaCompetenciaToolStripMenuItem});
            this.competenciasToolStripMenuItem.Name = "competenciasToolStripMenuItem";
            this.competenciasToolStripMenuItem.Size = new System.Drawing.Size(167, 29);
            this.competenciasToolStripMenuItem.Text = "Competencias";
            // 
            // registrarNuevaCompetenciaToolStripMenuItem
            // 
            this.registrarNuevaCompetenciaToolStripMenuItem.Name = "registrarNuevaCompetenciaToolStripMenuItem";
            this.registrarNuevaCompetenciaToolStripMenuItem.Size = new System.Drawing.Size(410, 34);
            this.registrarNuevaCompetenciaToolStripMenuItem.Text = "Registrar nueva Competencia";
            this.registrarNuevaCompetenciaToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevaCompetenciaToolStripMenuItem_Click);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // img
            // 
            this.img.Image = ((System.Drawing.Image)(resources.GetObject("img.Image")));
            this.img.Location = new System.Drawing.Point(113, 36);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(729, 410);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 2;
            this.img.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(247)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(975, 449);
            this.Controls.Add(this.img);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenu";
            this.Text = "Menu Principal";
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
    }
}