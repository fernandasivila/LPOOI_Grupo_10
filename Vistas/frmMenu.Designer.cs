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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atletasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.competenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevaDisciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoAtletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevaCompetenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.atletasToolStripMenuItem,
            this.competenciasToolStripMenuItem,
            this.eventosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disciplinasToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // atletasToolStripMenuItem
            // 
            this.atletasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoAtletaToolStripMenuItem});
            this.atletasToolStripMenuItem.Name = "atletasToolStripMenuItem";
            this.atletasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.atletasToolStripMenuItem.Text = "Atletas";
            // 
            // competenciasToolStripMenuItem
            // 
            this.competenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevaCompetenciaToolStripMenuItem});
            this.competenciasToolStripMenuItem.Name = "competenciasToolStripMenuItem";
            this.competenciasToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.competenciasToolStripMenuItem.Text = "Competencias";
            // 
            // disciplinasToolStripMenuItem
            // 
            this.disciplinasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevaDisciplinaToolStripMenuItem});
            this.disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            this.disciplinasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disciplinasToolStripMenuItem.Text = "Disciplinas";
            // 
            // registrarNuevaDisciplinaToolStripMenuItem
            // 
            this.registrarNuevaDisciplinaToolStripMenuItem.Name = "registrarNuevaDisciplinaToolStripMenuItem";
            this.registrarNuevaDisciplinaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.registrarNuevaDisciplinaToolStripMenuItem.Text = "Registrar nueva Disciplina";
            // 
            // registrarNuevoAtletaToolStripMenuItem
            // 
            this.registrarNuevoAtletaToolStripMenuItem.Name = "registrarNuevoAtletaToolStripMenuItem";
            this.registrarNuevoAtletaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.registrarNuevoAtletaToolStripMenuItem.Text = "Registrar nuevo Atleta";
            // 
            // registrarNuevaCompetenciaToolStripMenuItem
            // 
            this.registrarNuevaCompetenciaToolStripMenuItem.Name = "registrarNuevaCompetenciaToolStripMenuItem";
            this.registrarNuevaCompetenciaToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.registrarNuevaCompetenciaToolStripMenuItem.Text = "Registrar nueva Competencia";
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu Principal";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevaDisciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atletasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoAtletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem competenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevaCompetenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
    }
}