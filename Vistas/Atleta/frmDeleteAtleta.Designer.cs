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
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBorrarAtleta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.lblNombre.Location = new System.Drawing.Point(70, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Ingresar ID";
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
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(111, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtID.Location = new System.Drawing.Point(153, 65);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(233, 23);
            this.txtID.TabIndex = 11;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnBorrarAtleta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtID;
    }
}