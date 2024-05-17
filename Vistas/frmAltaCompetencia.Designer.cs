namespace Vistas
{
    partial class frmAltaCompetencia
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtOrganizacion = new System.Windows.Forms.TextBox();
            this.lblOrganizacion = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtSponsors = new System.Windows.Forms.TextBox();
            this.lblSponsors = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(310, 408);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(154, 23);
            this.btnRegistrar.TabIndex = 50;
            this.btnRegistrar.Text = "Registrar Competencia";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(63, 283);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(55, 13);
            this.lblUbicacion.TabIndex = 49;
            this.lblUbicacion.Text = "Ubicación";
            // 
            // txtOrganizacion
            // 
            this.txtOrganizacion.Location = new System.Drawing.Point(124, 254);
            this.txtOrganizacion.Name = "txtOrganizacion";
            this.txtOrganizacion.Size = new System.Drawing.Size(180, 20);
            this.txtOrganizacion.TabIndex = 48;
            // 
            // lblOrganizacion
            // 
            this.lblOrganizacion.AutoSize = true;
            this.lblOrganizacion.Location = new System.Drawing.Point(49, 257);
            this.lblOrganizacion.Name = "lblOrganizacion";
            this.lblOrganizacion.Size = new System.Drawing.Size(69, 13);
            this.lblOrganizacion.TabIndex = 47;
            this.lblOrganizacion.Text = "Organización";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(124, 280);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(180, 20);
            this.txtUbicacion.TabIndex = 46;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(78, 204);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 45;
            this.lblEstado.Text = "Estado";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(124, 149);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaInicio.TabIndex = 43;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(38, 152);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(80, 13);
            this.lblFechaInicio.TabIndex = 42;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(124, 45);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(180, 72);
            this.txtDescripcion.TabIndex = 31;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(54, 48);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 30;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(124, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 29;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(74, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "Nombre";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(124, 175);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaFin.TabIndex = 51;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(49, 178);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(69, 13);
            this.lblFechaFin.TabIndex = 52;
            this.lblFechaFin.Text = "Fecha de Fin";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(124, 201);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 53;
            // 
            // txtSponsors
            // 
            this.txtSponsors.Location = new System.Drawing.Point(124, 306);
            this.txtSponsors.Name = "txtSponsors";
            this.txtSponsors.Size = new System.Drawing.Size(180, 20);
            this.txtSponsors.TabIndex = 54;
            // 
            // lblSponsors
            // 
            this.lblSponsors.AutoSize = true;
            this.lblSponsors.Location = new System.Drawing.Point(67, 309);
            this.lblSponsors.Name = "lblSponsors";
            this.lblSponsors.Size = new System.Drawing.Size(51, 13);
            this.lblSponsors.TabIndex = 55;
            this.lblSponsors.Text = "Sponsors";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(64, 362);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 56;
            this.lblCategoria.Text = "Categoría";
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.FormattingEnabled = true;
            this.cmbDisciplina.Location = new System.Drawing.Point(310, 359);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(121, 21);
            this.cmbDisciplina.TabIndex = 59;
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(252, 362);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(52, 13);
            this.lblDisciplina.TabIndex = 58;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(124, 359);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 60;
            // 
            // frmAltaCompetencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 443);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbDisciplina);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblSponsors);
            this.Controls.Add(this.txtSponsors);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.txtOrganizacion);
            this.Controls.Add(this.lblOrganizacion);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmAltaCompetencia";
            this.Text = "Alta Competencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TextBox txtOrganizacion;
        private System.Windows.Forms.Label lblOrganizacion;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtSponsors;
        private System.Windows.Forms.Label lblSponsors;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.ComboBox cmbCategoria;
    }
}