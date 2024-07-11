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
            this.timeInicio = new System.Windows.Forms.DateTimePicker();
            this.cbxStateEvent = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timeFin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(183, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRONOMETRAJE";
            // 
            // lblAtleta
            // 
            this.lblAtleta.AutoSize = true;
            this.lblAtleta.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtleta.Location = new System.Drawing.Point(30, 57);
            this.lblAtleta.Name = "lblAtleta";
            this.lblAtleta.Size = new System.Drawing.Size(45, 19);
            this.lblAtleta.TabIndex = 2;
            this.lblAtleta.Text = "Atleta";
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetencia.Location = new System.Drawing.Point(30, 98);
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
            this.btnRegistrarInscripcion.Location = new System.Drawing.Point(190, 303);
            this.btnRegistrarInscripcion.Name = "btnRegistrarInscripcion";
            this.btnRegistrarInscripcion.Size = new System.Drawing.Size(139, 37);
            this.btnRegistrarInscripcion.TabIndex = 14;
            this.btnRegistrarInscripcion.Text = "REGISTRAR";
            this.btnRegistrarInscripcion.UseVisualStyleBackColor = false;
            this.btnRegistrarInscripcion.Click += new System.EventHandler(this.btnRegistrarInscripcion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.timeInicio);
            this.panel1.Controls.Add(this.cbxStateEvent);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.timeFin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxCompetencia);
            this.panel1.Controls.Add(this.cbxAtleta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAtleta);
            this.panel1.Controls.Add(this.lblCompetencia);
            this.panel1.Location = new System.Drawing.Point(83, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 246);
            this.panel1.TabIndex = 16;
            // 
            // timeInicio
            // 
            this.timeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeInicio.Location = new System.Drawing.Point(100, 153);
            this.timeInicio.Name = "timeInicio";
            this.timeInicio.Size = new System.Drawing.Size(106, 20);
            this.timeInicio.TabIndex = 20;
            // 
            // cbxStateEvent
            // 
            this.cbxStateEvent.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.cbxStateEvent.FormattingEnabled = true;
            this.cbxStateEvent.Location = new System.Drawing.Point(295, 187);
            this.cbxStateEvent.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStateEvent.Name = "cbxStateEvent";
            this.cbxStateEvent.Size = new System.Drawing.Size(154, 25);
            this.cbxStateEvent.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Otro motivo?";
            // 
            // timeFin
            // 
            this.timeFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeFin.Location = new System.Drawing.Point(100, 190);
            this.timeFin.Name = "timeFin";
            this.timeFin.Size = new System.Drawing.Size(65, 20);
            this.timeFin.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 190);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Llegada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 154);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Inicio";
            // 
            // cbxCompetencia
            // 
            this.cbxCompetencia.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.cbxCompetencia.FormattingEnabled = true;
            this.cbxCompetencia.Location = new System.Drawing.Point(177, 98);
            this.cbxCompetencia.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCompetencia.Name = "cbxCompetencia";
            this.cbxCompetencia.Size = new System.Drawing.Size(301, 25);
            this.cbxCompetencia.TabIndex = 13;
            // 
            // cbxAtleta
            // 
            this.cbxAtleta.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.cbxAtleta.FormattingEnabled = true;
            this.cbxAtleta.Location = new System.Drawing.Point(177, 57);
            this.cbxAtleta.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAtleta.Name = "cbxAtleta";
            this.cbxAtleta.Size = new System.Drawing.Size(301, 25);
            this.cbxAtleta.TabIndex = 12;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(131)))), ((int)(((byte)(129)))));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(378, 303);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(139, 37);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "LIMPIAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmCronometrajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(705, 352);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegistrarInscripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker timeFin;
        private System.Windows.Forms.ComboBox cbxStateEvent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker timeInicio;
    }
}