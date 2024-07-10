namespace Vistas
{
    partial class frmCronometrajes
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
            this.btnRegistrarInscripcion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llblRegistrarAtleta = new System.Windows.Forms.LinkLabel();
            this.cbxCompetencia = new System.Windows.Forms.ComboBox();
            this.cbxAtleta = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.comdepDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comdepDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUEVA INSCRIPCIÓN";
            // 
            // lblAtleta
            // 
            this.lblAtleta.AutoSize = true;
            this.lblAtleta.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtleta.Location = new System.Drawing.Point(45, 111);
            this.lblAtleta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtleta.Name = "lblAtleta";
            this.lblAtleta.Size = new System.Drawing.Size(64, 28);
            this.lblAtleta.TabIndex = 2;
            this.lblAtleta.Text = "Atleta";
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetencia.Location = new System.Drawing.Point(45, 221);
            this.lblCompetencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(127, 28);
            this.lblCompetencia.TabIndex = 7;
            this.lblCompetencia.Text = "Competencia";
            // 
            // btnRegistrarInscripcion
            // 
            this.btnRegistrarInscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(49)))), ((int)(((byte)(38)))));
            this.btnRegistrarInscripcion.FlatAppearance.BorderSize = 0;
            this.btnRegistrarInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarInscripcion.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarInscripcion.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarInscripcion.Location = new System.Drawing.Point(260, 378);
            this.btnRegistrarInscripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarInscripcion.Name = "btnRegistrarInscripcion";
            this.btnRegistrarInscripcion.Size = new System.Drawing.Size(208, 57);
            this.btnRegistrarInscripcion.TabIndex = 14;
            this.btnRegistrarInscripcion.Text = "REGISTRAR";
            this.btnRegistrarInscripcion.UseVisualStyleBackColor = false;
            this.btnRegistrarInscripcion.Click += new System.EventHandler(this.btnRegistrarInscripcion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.llblRegistrarAtleta);
            this.panel1.Controls.Add(this.cbxCompetencia);
            this.panel1.Controls.Add(this.cbxAtleta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAtleta);
            this.panel1.Controls.Add(this.lblCompetencia);
            this.panel1.Location = new System.Drawing.Point(124, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 295);
            this.panel1.TabIndex = 16;
            // 
            // llblRegistrarAtleta
            // 
            this.llblRegistrarAtleta.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(185)))), ((int)(((byte)(190)))));
            this.llblRegistrarAtleta.AutoSize = true;
            this.llblRegistrarAtleta.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.llblRegistrarAtleta.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(131)))), ((int)(((byte)(129)))));
            this.llblRegistrarAtleta.Location = new System.Drawing.Point(45, 156);
            this.llblRegistrarAtleta.Name = "llblRegistrarAtleta";
            this.llblRegistrarAtleta.Size = new System.Drawing.Size(262, 28);
            this.llblRegistrarAtleta.TabIndex = 14;
            this.llblRegistrarAtleta.TabStop = true;
            this.llblRegistrarAtleta.Text = "¿El atleta no esta registrado?";
            this.llblRegistrarAtleta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegistrarAtleta_LinkClicked);
            // 
            // cbxCompetencia
            // 
            this.cbxCompetencia.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.cbxCompetencia.FormattingEnabled = true;
            this.cbxCompetencia.Location = new System.Drawing.Point(237, 218);
            this.cbxCompetencia.Name = "cbxCompetencia";
            this.cbxCompetencia.Size = new System.Drawing.Size(449, 36);
            this.cbxCompetencia.TabIndex = 13;
            // 
            // cbxAtleta
            // 
            this.cbxAtleta.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.cbxAtleta.FormattingEnabled = true;
            this.cbxAtleta.Location = new System.Drawing.Point(237, 108);
            this.cbxAtleta.Name = "cbxAtleta";
            this.cbxAtleta.Size = new System.Drawing.Size(449, 36);
            this.cbxAtleta.TabIndex = 12;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(131)))), ((int)(((byte)(129)))));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(524, 378);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(208, 57);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "LIMPIAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmCreateEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1058, 542);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegistrarInscripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCronometrajes";
            this.Text = "frmCronometrajes";
            this.Load += new System.EventHandler(this.frmCreateEvento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comdepDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAtleta;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.Button btnRegistrarInscripcion;
        private System.Windows.Forms.BindingSource comdepDataSetBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cbxCompetencia;
        private System.Windows.Forms.ComboBox cbxAtleta;
        private System.Windows.Forms.LinkLabel llblRegistrarAtleta;
    }
}