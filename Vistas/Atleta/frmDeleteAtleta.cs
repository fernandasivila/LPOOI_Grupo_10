using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class frmDeleteAtleta : Form
    {
        public frmDeleteAtleta()
        {
            InitializeComponent();
        }

        private void cargarAtletas()
        {
            List<Atleta> atletas = TrabajoAtleta.obtenerAtletas();

            cmbAtleta.DataSource = atletas;
            cmbAtleta.DisplayMember = "NombreCompleto";
            cmbAtleta.ValueMember = "Atl_ID";
        }

        private void btnBorrarUsuario_Click(object sender, EventArgs e)
        {
            if (cmbAtleta.SelectedItem != null)
            {
                int atlId = (int)cmbAtleta.SelectedValue;
                string atlNombre = cmbAtleta.Text;

                var confirmar = MessageBox.Show($"¿Estás seguro de que deseas eliminar al atleta '{atlNombre}'?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);

                if (confirmar == DialogResult.Yes)
                {
                    try
                    {
                        TrabajoAtleta.borrarAtleta(atlId);
                        MessageBox.Show("Atleta eliminado con éxito.", "Éxito");
                        cargarAtletas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar la categoría: {ex.Message}", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una categoría.", "Advertencia");
            }
        }

        private void frmDeleteAtleta_Load(object sender, EventArgs e)
        {
            cargarAtletas();
        }
    }
}
