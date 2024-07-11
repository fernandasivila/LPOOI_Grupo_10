namespace Vistas
{
    partial class frmDeleteEvento
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAtleta = new System.Windows.Forms.Label();
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.btnAnularInscripcion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCompetencia = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.comdepDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbAtleta = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comdepDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ANULAR INSCRIPCION";
            // 
            // lblAtleta
            // 
            this.lblAtleta.AutoSize = true;
            this.lblAtleta.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtleta.Location = new System.Drawing.Point(30, 72);
            this.lblAtleta.Name = "lblAtleta";
            this.lblAtleta.Size = new System.Drawing.Size(45, 19);
            this.lblAtleta.TabIndex = 2;
            this.lblAtleta.Text = "Atleta";
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetencia.Location = new System.Drawing.Point(30, 129);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(89, 19);
            this.lblCompetencia.TabIndex = 7;
            this.lblCompetencia.Text = "Competencia";
            // 
            // btnAnularInscripcion
            // 
            this.btnAnularInscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(49)))), ((int)(((byte)(38)))));
            this.btnAnularInscripcion.FlatAppearance.BorderSize = 0;
            this.btnAnularInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnularInscripcion.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold);
            this.btnAnularInscripcion.ForeColor = System.Drawing.Color.White;
            this.btnAnularInscripcion.Location = new System.Drawing.Point(173, 246);
            this.btnAnularInscripcion.Name = "btnAnularInscripcion";
            this.btnAnularInscripcion.Size = new System.Drawing.Size(139, 37);
            this.btnAnularInscripcion.TabIndex = 14;
            this.btnAnularInscripcion.Text = "ANULAR";
            this.btnAnularInscripcion.UseVisualStyleBackColor = false;
            this.btnAnularInscripcion.Click += new System.EventHandler(this.btnAnularInscripcion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmbCompetencia);
            this.panel1.Controls.Add(this.cmbAtleta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAtleta);
            this.panel1.Controls.Add(this.lblCompetencia);
            this.panel1.Location = new System.Drawing.Point(83, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 192);
            this.panel1.TabIndex = 16;
            // 
            // cmbCompetencia
            // 
            this.cmbCompetencia.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.cmbCompetencia.FormattingEnabled = true;
            this.cmbCompetencia.Location = new System.Drawing.Point(158, 127);
            this.cmbCompetencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCompetencia.Name = "cmbCompetencia";
            this.cmbCompetencia.Size = new System.Drawing.Size(301, 25);
            this.cmbCompetencia.TabIndex = 13;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(131)))), ((int)(((byte)(129)))));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(349, 246);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(139, 37);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "LIMPIAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // cmbAtleta
            // 
            this.cmbAtleta.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.cmbAtleta.FormattingEnabled = true;
            this.cmbAtleta.Location = new System.Drawing.Point(158, 70);
            this.cmbAtleta.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAtleta.Name = "cmbAtleta";
            this.cmbAtleta.Size = new System.Drawing.Size(301, 25);
            this.cmbAtleta.TabIndex = 12;
            // 
            // frmDeleteEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(705, 352);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAnularInscripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeleteEvento";
            this.Text = "frmDeleteEvento";
            this.Load += new System.EventHandler(this.frmAnularEvento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comdepDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAtleta;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.Button btnAnularInscripcion;
        private System.Windows.Forms.BindingSource comdepDataSetBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cmbCompetencia;
        private System.Windows.Forms.ComboBox cmbAtleta;
    }
}