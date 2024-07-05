namespace Vistas
{
    partial class frmDeleteAtleta
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
            this.lblAtleta = new System.Windows.Forms.Label();
            this.btnBorrarAtleta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbAtleta = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAtleta
            // 
            this.lblAtleta.AutoSize = true;
            this.lblAtleta.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.lblAtleta.Location = new System.Drawing.Point(31, 68);
            this.lblAtleta.Name = "lblAtleta";
            this.lblAtleta.Size = new System.Drawing.Size(116, 19);
            this.lblAtleta.TabIndex = 2;
            this.lblAtleta.Text = "Seleccionar Atleta";
            // 
            // btnBorrarAtleta
            // 
            this.btnBorrarAtleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(49)))), ((int)(((byte)(38)))));
            this.btnBorrarAtleta.FlatAppearance.BorderSize = 0;
            this.btnBorrarAtleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarAtleta.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold);
            this.btnBorrarAtleta.ForeColor = System.Drawing.Color.White;
            this.btnBorrarAtleta.Location = new System.Drawing.Point(263, 195);
            this.btnBorrarAtleta.Name = "btnBorrarAtleta";
            this.btnBorrarAtleta.Size = new System.Drawing.Size(139, 37);
            this.btnBorrarAtleta.TabIndex = 15;
            this.btnBorrarAtleta.Text = "BORRAR";
            this.btnBorrarAtleta.UseVisualStyleBackColor = false;
            this.btnBorrarAtleta.Click += new System.EventHandler(this.btnBorrarUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmbAtleta);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblAtleta);
            this.panel1.Location = new System.Drawing.Point(111, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 122);
            this.panel1.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(149, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(140, 21);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "BORRAR ATLETA";
            // 
            // cmbAtleta
            // 
            this.cmbAtleta.FormattingEnabled = true;
            this.cmbAtleta.Location = new System.Drawing.Point(152, 68);
            this.cmbAtleta.Name = "cmbAtleta";
            this.cmbAtleta.Size = new System.Drawing.Size(234, 21);
            this.cmbAtleta.TabIndex = 12;
            // 
            // frmDeleteAtleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(705, 352);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBorrarAtleta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeleteAtleta";
            this.Text = "Borrar Usuario";
            this.Load += new System.EventHandler(this.frmDeleteAtleta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAtleta;
        private System.Windows.Forms.Button btnBorrarAtleta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbAtleta;
    }
}