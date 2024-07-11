namespace Vistas
{
    partial class frmAcreditacion
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
            this.btnRegistrarAcreditacion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxCompetencia = new System.Windows.Forms.ComboBox();
            this.cbxAtleta = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.comdepDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvAcreditacion = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comdepDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcreditacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORMULARIO ACREDITACION";
            // 
            // lblAtleta
            // 
            this.lblAtleta.AutoSize = true;
            this.lblAtleta.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtleta.Location = new System.Drawing.Point(74, 3);
            this.lblAtleta.Name = "lblAtleta";
            this.lblAtleta.Size = new System.Drawing.Size(45, 19);
            this.lblAtleta.TabIndex = 2;
            this.lblAtleta.Text = "Atleta";
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetencia.Location = new System.Drawing.Point(30, 207);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(89, 19);
            this.lblCompetencia.TabIndex = 7;
            this.lblCompetencia.Text = "Competencia";
            // 
            // btnRegistrarAcreditacion
            // 
            this.btnRegistrarAcreditacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(49)))), ((int)(((byte)(38)))));
            this.btnRegistrarAcreditacion.FlatAppearance.BorderSize = 0;
            this.btnRegistrarAcreditacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarAcreditacion.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold);
            this.btnRegistrarAcreditacion.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarAcreditacion.Location = new System.Drawing.Point(183, 298);
            this.btnRegistrarAcreditacion.Name = "btnRegistrarAcreditacion";
            this.btnRegistrarAcreditacion.Size = new System.Drawing.Size(139, 37);
            this.btnRegistrarAcreditacion.TabIndex = 14;
            this.btnRegistrarAcreditacion.Text = "ACREDITAR";
            this.btnRegistrarAcreditacion.UseVisualStyleBackColor = false;
            this.btnRegistrarAcreditacion.Click += new System.EventHandler(this.btnRegistrarAcreditacion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvAcreditacion);
            this.panel1.Controls.Add(this.cbxCompetencia);
            this.panel1.Controls.Add(this.cbxAtleta);
            this.panel1.Controls.Add(this.lblAtleta);
            this.panel1.Controls.Add(this.lblCompetencia);
            this.panel1.Location = new System.Drawing.Point(83, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 249);
            this.panel1.TabIndex = 16;
            // 
            // cbxCompetencia
            // 
            this.cbxCompetencia.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.cbxCompetencia.FormattingEnabled = true;
            this.cbxCompetencia.Location = new System.Drawing.Point(124, 207);
            this.cbxCompetencia.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCompetencia.Name = "cbxCompetencia";
            this.cbxCompetencia.Size = new System.Drawing.Size(301, 25);
            this.cbxCompetencia.TabIndex = 13;
            // 
            // cbxAtleta
            // 
            this.cbxAtleta.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.cbxAtleta.FormattingEnabled = true;
            this.cbxAtleta.Location = new System.Drawing.Point(124, 0);
            this.cbxAtleta.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAtleta.Name = "cbxAtleta";
            this.cbxAtleta.Size = new System.Drawing.Size(301, 25);
            this.cbxAtleta.TabIndex = 12;
            this.cbxAtleta.SelectedIndexChanged += new System.EventHandler(this.cbxAtleta_SelectedIndexChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(131)))), ((int)(((byte)(129)))));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(369, 298);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(139, 37);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "LIMPIAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dgvAcreditacion
            // 
            this.dgvAcreditacion.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAcreditacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcreditacion.GridColor = System.Drawing.Color.Firebrick;
            this.dgvAcreditacion.Location = new System.Drawing.Point(46, 41);
            this.dgvAcreditacion.Name = "dgvAcreditacion";
            this.dgvAcreditacion.Size = new System.Drawing.Size(435, 150);
            this.dgvAcreditacion.TabIndex = 14;
            // 
            // frmAcreditacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(705, 347);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarAcreditacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAcreditacion";
            this.Text = "frmAcreditacion";
            this.Load += new System.EventHandler(this.frmCreateEvento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comdepDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcreditacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAtleta;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.Button btnRegistrarAcreditacion;
        private System.Windows.Forms.BindingSource comdepDataSetBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cbxCompetencia;
        private System.Windows.Forms.ComboBox cbxAtleta;
        private System.Windows.Forms.DataGridView dgvAcreditacion;
    }
}