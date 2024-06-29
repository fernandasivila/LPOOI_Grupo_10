namespace Vistas
{
    partial class frmUpdateDisciplina
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
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellidoNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscarDisciplina = new System.Windows.Forms.Button();
            this.cmbDbDisciplina = new System.Windows.Forms.ComboBox();
            this.lblDbUsuario = new System.Windows.Forms.Label();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.White;
            this.pnlDatos.Controls.Add(this.txtDescripcion);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Controls.Add(this.txtNombre);
            this.pnlDatos.Controls.Add(this.lblApellidoNombre);
            this.pnlDatos.Controls.Add(this.lblDescripcion);
            this.pnlDatos.Location = new System.Drawing.Point(112, 80);
            this.pnlDatos.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(467, 157);
            this.pnlDatos.TabIndex = 30;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.txtDescripcion.Location = new System.Drawing.Point(191, 101);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(233, 42);
            this.txtDescripcion.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODIFICAR DISCIPLINA";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.txtNombre.Location = new System.Drawing.Point(191, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblApellidoNombre
            // 
            this.lblApellidoNombre.AutoSize = true;
            this.lblApellidoNombre.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoNombre.Location = new System.Drawing.Point(71, 67);
            this.lblApellidoNombre.Name = "lblApellidoNombre";
            this.lblApellidoNombre.Size = new System.Drawing.Size(59, 19);
            this.lblApellidoNombre.TabIndex = 4;
            this.lblApellidoNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(45, 103);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(85, 19);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Desccripcion";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(49)))), ((int)(((byte)(38)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI Historic", 8F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(276, 270);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(139, 37);
            this.btnActualizar.TabIndex = 31;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscarDisciplina
            // 
            this.btnBuscarDisciplina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(185)))), ((int)(((byte)(190)))));
            this.btnBuscarDisciplina.FlatAppearance.BorderSize = 0;
            this.btnBuscarDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDisciplina.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDisciplina.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarDisciplina.Location = new System.Drawing.Point(460, 29);
            this.btnBuscarDisciplina.Margin = new System.Windows.Forms.Padding(1);
            this.btnBuscarDisciplina.Name = "btnBuscarDisciplina";
            this.btnBuscarDisciplina.Size = new System.Drawing.Size(35, 27);
            this.btnBuscarDisciplina.TabIndex = 34;
            this.btnBuscarDisciplina.Text = "🔍";
            this.btnBuscarDisciplina.UseVisualStyleBackColor = false;
            this.btnBuscarDisciplina.Click += new System.EventHandler(this.btnBuscarDisciplina_Click);
            // 
            // cmbDbDisciplina
            // 
            this.cmbDbDisciplina.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.cmbDbDisciplina.FormattingEnabled = true;
            this.cmbDbDisciplina.Location = new System.Drawing.Point(276, 32);
            this.cmbDbDisciplina.Name = "cmbDbDisciplina";
            this.cmbDbDisciplina.Size = new System.Drawing.Size(188, 25);
            this.cmbDbDisciplina.TabIndex = 33;
            // 
            // lblDbUsuario
            // 
            this.lblDbUsuario.AutoSize = true;
            this.lblDbUsuario.Font = new System.Drawing.Font("Segoe UI Historic", 10F);
            this.lblDbUsuario.Location = new System.Drawing.Point(199, 32);
            this.lblDbUsuario.Name = "lblDbUsuario";
            this.lblDbUsuario.Size = new System.Drawing.Size(66, 19);
            this.lblDbUsuario.TabIndex = 32;
            this.lblDbUsuario.Text = "Disciplina";
            // 
            // frmUpdateDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 352);
            this.Controls.Add(this.btnBuscarDisciplina);
            this.Controls.Add(this.cmbDbDisciplina);
            this.Controls.Add(this.lblDbUsuario);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.pnlDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUpdateDisciplina";
            this.Text = "frmUpdate";
            this.Load += new System.EventHandler(this.frmUpdateDisciplina_Load);
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellidoNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscarDisciplina;
        private System.Windows.Forms.ComboBox cmbDbDisciplina;
        private System.Windows.Forms.Label lblDbUsuario;
    }
}