using ClasesBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class frmUpdateDisciplina : Form
    {
        
        public frmUpdateDisciplina()
        {
            InitializeComponent();
            load_combo_disciplinas();

        }

        private void load_combo_disciplinas()
        {
            cmbDbDisciplina.DisplayMember = "Dis_Nombre";
            cmbDbDisciplina.ValueMember = "Dis_ID";
            cmbDbDisciplina.DataSource = TrabajoDisciplina.ObtenerDisciplinas();
            
        }

        private void frmUpdateDisciplina_Load(object sender, EventArgs e)
        {
            load_combo_disciplinas();
        }

        private void btnBuscarDisciplina_Click(object sender, EventArgs e)
        {
            int idDisciplina = Convert.ToInt32(cmbDbDisciplina.SelectedValue);
            cmbDbDisciplina.Enabled = false;
            btnBuscarDisciplina.Enabled = false;
            Disciplina disciplina = TrabajoDisciplina.ObtenerDisciplinaByID(idDisciplina);

            
            txtNombre.Text = disciplina.Dis_Nombre;
            txtDescripcion.Text = disciplina.Dis_Descripcion;



            pnlDatos.Visible = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string mensajeError;
            if (!validarCampos(out mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Disciplina odisciplina = new Disciplina();
            odisciplina.Dis_ID = Convert.ToInt32(cmbDbDisciplina.SelectedValue);
            odisciplina.Dis_Nombre = txtNombre.Text;
            odisciplina.Dis_Descripcion = txtDescripcion.Text;

            TrabajoDisciplina.ModificarDisciplinaPorID(odisciplina);
            MessageBox.Show($"Disciplina {odisciplina.Dis_Nombre} actualizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Resetear el formulario después de actualizar
            cmbDbDisciplina.Enabled = true;
            btnBuscarDisciplina.Enabled = true;
            pnlDatos.Visible = false;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            load_combo_disciplinas();

        }
        private bool validarCampos(out string mensajeError)
        {
            mensajeError = string.Empty;
            if (txtNombre.Text == "")
            {
                mensajeError = "Debe ingresar un Nombre de Disciplina.";
                return false;
            }
            return true;
        }
    }
}
