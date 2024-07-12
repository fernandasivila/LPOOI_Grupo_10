namespace Vistas
{
    partial class frmResultados
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
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.btnRegistrarInscripcion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAbandonos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescalificados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtParticipantes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.cbxCompetencia = new System.Windows.Forms.ComboBox();
            this.comdepDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comdepDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "VER RESULTADOS";
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetencia.Location = new System.Drawing.Point(102, 45);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(89, 19);
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
            this.btnRegistrarInscripcion.Location = new System.Drawing.Point(502, 42);
            this.btnRegistrarInscripcion.Name = "btnRegistrarInscripcion";
            this.btnRegistrarInscripcion.Size = new System.Drawing.Size(86, 25);
            this.btnRegistrarInscripcion.TabIndex = 14;
            this.btnRegistrarInscripcion.Text = "REGISTRAR";
            this.btnRegistrarInscripcion.UseVisualStyleBackColor = false;
            this.btnRegistrarInscripcion.Click += new System.EventHandler(this.btnRegistrarInscripcion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAbandonos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDescalificados);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtParticipantes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDisciplina);
            this.panel1.Controls.Add(this.txtCategoria);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.dgvResultados);
            this.panel1.Location = new System.Drawing.Point(84, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 268);
            this.panel1.TabIndex = 16;
            this.panel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Historic", 8F);
            this.label6.Location = new System.Drawing.Point(263, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Abandonos";
            // 
            // txtAbandonos
            // 
            this.txtAbandonos.BackColor = System.Drawing.Color.White;
            this.txtAbandonos.Enabled = false;
            this.txtAbandonos.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.txtAbandonos.ForeColor = System.Drawing.Color.Black;
            this.txtAbandonos.Location = new System.Drawing.Point(337, 231);
            this.txtAbandonos.Margin = new System.Windows.Forms.Padding(4);
            this.txtAbandonos.Name = "txtAbandonos";
            this.txtAbandonos.Size = new System.Drawing.Size(40, 25);
            this.txtAbandonos.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 8F);
            this.label5.Location = new System.Drawing.Point(130, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Descalificados";
            // 
            // txtDescalificados
            // 
            this.txtDescalificados.BackColor = System.Drawing.Color.White;
            this.txtDescalificados.Enabled = false;
            this.txtDescalificados.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.txtDescalificados.ForeColor = System.Drawing.Color.Black;
            this.txtDescalificados.Location = new System.Drawing.Point(210, 231);
            this.txtDescalificados.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescalificados.Name = "txtDescalificados";
            this.txtDescalificados.Size = new System.Drawing.Size(40, 25);
            this.txtDescalificados.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 8F);
            this.label4.Location = new System.Drawing.Point(3, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Participantes";
            // 
            // txtParticipantes
            // 
            this.txtParticipantes.BackColor = System.Drawing.Color.White;
            this.txtParticipantes.Enabled = false;
            this.txtParticipantes.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.txtParticipantes.ForeColor = System.Drawing.Color.Black;
            this.txtParticipantes.Location = new System.Drawing.Point(83, 231);
            this.txtParticipantes.Margin = new System.Windows.Forms.Padding(4);
            this.txtParticipantes.Name = "txtParticipantes";
            this.txtParticipantes.Size = new System.Drawing.Size(40, 25);
            this.txtParticipantes.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Disciplina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Categoría";
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.BackColor = System.Drawing.Color.White;
            this.txtDisciplina.Enabled = false;
            this.txtDisciplina.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.txtDisciplina.ForeColor = System.Drawing.Color.Black;
            this.txtDisciplina.Location = new System.Drawing.Point(336, 6);
            this.txtDisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Size = new System.Drawing.Size(179, 25);
            this.txtDisciplina.TabIndex = 19;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.White;
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.txtCategoria.ForeColor = System.Drawing.Color.Black;
            this.txtCategoria.Location = new System.Drawing.Point(78, 6);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(181, 25);
            this.txtCategoria.TabIndex = 17;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(131)))), ((int)(((byte)(129)))));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(403, 228);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(112, 37);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "LIMPIAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.GridColor = System.Drawing.Color.Firebrick;
            this.dgvResultados.Location = new System.Drawing.Point(0, 38);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(515, 184);
            this.dgvResultados.TabIndex = 18;
            // 
            // cbxCompetencia
            // 
            this.cbxCompetencia.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.cbxCompetencia.FormattingEnabled = true;
            this.cbxCompetencia.Location = new System.Drawing.Point(196, 42);
            this.cbxCompetencia.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCompetencia.Name = "cbxCompetencia";
            this.cbxCompetencia.Size = new System.Drawing.Size(301, 25);
            this.cbxCompetencia.TabIndex = 13;
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(705, 352);
            this.Controls.Add(this.cbxCompetencia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegistrarInscripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCompetencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResultados";
            this.Text = "frmResultados";
            this.Load += new System.EventHandler(this.frmCreateEvento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comdepDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.Button btnRegistrarInscripcion;
        private System.Windows.Forms.BindingSource comdepDataSetBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cbxCompetencia;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.TextBox txtDisciplina;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAbandonos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescalificados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtParticipantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}