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
            this.dgvCronometraje = new System.Windows.Forms.DataGridView();
            this.panelHorarios = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxStateEvent = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtLlegada = new System.Windows.Forms.DateTimePicker();
            this.cbxAtleta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbxCompetencia = new System.Windows.Forms.ComboBox();
            this.comdepDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCronometraje)).BeginInit();
            this.panelHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comdepDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRONOMETRAJE";
            // 
            // lblAtleta
            // 
            this.lblAtleta.AutoSize = true;
            this.lblAtleta.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtleta.Location = new System.Drawing.Point(44, 11);
            this.lblAtleta.Name = "lblAtleta";
            this.lblAtleta.Size = new System.Drawing.Size(45, 19);
            this.lblAtleta.TabIndex = 2;
            this.lblAtleta.Text = "Atleta";
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetencia.Location = new System.Drawing.Point(48, 6);
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
            this.btnRegistrarInscripcion.Location = new System.Drawing.Point(1, 78);
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
            this.panel1.Controls.Add(this.dgvCronometraje);
            this.panel1.Controls.Add(this.panelHorarios);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.cbxCompetencia);
            this.panel1.Controls.Add(this.lblCompetencia);
            this.panel1.Location = new System.Drawing.Point(68, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 301);
            this.panel1.TabIndex = 16;
            // 
            // dgvCronometraje
            // 
            this.dgvCronometraje.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCronometraje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCronometraje.GridColor = System.Drawing.Color.Firebrick;
            this.dgvCronometraje.Location = new System.Drawing.Point(78, 39);
            this.dgvCronometraje.Name = "dgvCronometraje";
            this.dgvCronometraje.Size = new System.Drawing.Size(435, 130);
            this.dgvCronometraje.TabIndex = 17;
            // 
            // panelHorarios
            // 
            this.panelHorarios.BackColor = System.Drawing.Color.White;
            this.panelHorarios.Controls.Add(this.label2);
            this.panelHorarios.Controls.Add(this.cbxStateEvent);
            this.panelHorarios.Controls.Add(this.btnBorrar);
            this.panelHorarios.Controls.Add(this.dtInicio);
            this.panelHorarios.Controls.Add(this.dtLlegada);
            this.panelHorarios.Controls.Add(this.btnRegistrarInscripcion);
            this.panelHorarios.Controls.Add(this.cbxAtleta);
            this.panelHorarios.Controls.Add(this.lblAtleta);
            this.panelHorarios.Controls.Add(this.label6);
            this.panelHorarios.Controls.Add(this.label7);
            this.panelHorarios.Location = new System.Drawing.Point(34, 174);
            this.panelHorarios.Margin = new System.Windows.Forms.Padding(2);
            this.panelHorarios.Name = "panelHorarios";
            this.panelHorarios.Size = new System.Drawing.Size(516, 123);
            this.panelHorarios.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.label2.Location = new System.Drawing.Point(275, 46);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Estado";
            // 
            // cbxStateEvent
            // 
            this.cbxStateEvent.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.cbxStateEvent.FormattingEnabled = true;
            this.cbxStateEvent.Location = new System.Drawing.Point(329, 43);
            this.cbxStateEvent.Margin = new System.Windows.Forms.Padding(2);
            this.cbxStateEvent.Name = "cbxStateEvent";
            this.cbxStateEvent.Size = new System.Drawing.Size(150, 25);
            this.cbxStateEvent.TabIndex = 22;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(131)))), ((int)(((byte)(129)))));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(374, 78);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(139, 37);
            this.btnBorrar.TabIndex = 17;
            this.btnBorrar.Text = "LIMPIAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtInicio.Location = new System.Drawing.Point(52, 45);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(86, 20);
            this.dtInicio.TabIndex = 20;
            this.dtInicio.Value = new System.DateTime(2024, 7, 11, 0, 0, 0, 0);
            // 
            // dtLlegada
            // 
            this.dtLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtLlegada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtLlegada.Location = new System.Drawing.Point(201, 45);
            this.dtLlegada.Name = "dtLlegada";
            this.dtLlegada.ShowUpDown = true;
            this.dtLlegada.Size = new System.Drawing.Size(68, 20);
            this.dtLlegada.TabIndex = 16;
            this.dtLlegada.Value = new System.DateTime(2024, 7, 11, 0, 0, 0, 0);
            // 
            // cbxAtleta
            // 
            this.cbxAtleta.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.cbxAtleta.FormattingEnabled = true;
            this.cbxAtleta.Location = new System.Drawing.Point(94, 8);
            this.cbxAtleta.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAtleta.Name = "cbxAtleta";
            this.cbxAtleta.Size = new System.Drawing.Size(385, 25);
            this.cbxAtleta.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 45);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Llegada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 46);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Inicio";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(131)))), ((int)(((byte)(129)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(467, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 28);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbxCompetencia
            // 
            this.cbxCompetencia.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.cbxCompetencia.FormattingEnabled = true;
            this.cbxCompetencia.Location = new System.Drawing.Point(151, 3);
            this.cbxCompetencia.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCompetencia.Name = "cbxCompetencia";
            this.cbxCompetencia.Size = new System.Drawing.Size(301, 25);
            this.cbxCompetencia.TabIndex = 13;
            // 
            // frmCronometrajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(705, 352);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCronometrajes";
            this.Text = "frmCronometrajes";
            this.Load += new System.EventHandler(this.frmCreateEvento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCronometraje)).EndInit();
            this.panelHorarios.ResumeLayout(false);
            this.panelHorarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comdepDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel panelHorarios;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtLlegada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvCronometraje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxStateEvent;
    }
}