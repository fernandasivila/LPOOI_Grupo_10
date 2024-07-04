

using System;
using ClasesBase;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class frmDeleteDisciplina : Form
    {
        public frmDeleteDisciplina()
        {
            InitializeComponent();
        }
        private void cargarDisciplinas()
        {
            cmbDisciplina.DataSource = TrabajoDisciplina.ObtenerDisciplinas();
            cmbDisciplina.DisplayMember = "Dis_Nombre";
            cmbDisciplina.ValueMember = "Dis_ID";

        }
        private void frmDeleteDisciplina_Load(object sender, EventArgs e)
                {
                        cargarDisciplinas();
                }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cmbDisciplina.Items != null)
            {
                string disNombre = cmbDisciplina.Text;
                
                int disId;
                if (int.TryParse(cmbDisciplina.SelectedValue.ToString(), out disId));


                    var confirmar = MessageBox.Show($"¿Estás seguro de que deseas eliminar la disciplina '{disNombre}'?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (confirmar == DialogResult.Yes)
                {
                    try
                    {
                        TrabajoDisciplina.BorrarDisciplinaPorID(disId);

                        MessageBox.Show("Disciplina eliminada con éxito.", "Éxito", MessageBoxButtons.OK);
                        cargarDisciplinas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar la categoría: {ex.Message}", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una disciplina.", "Advertencia");
            }
         }
    }

}
