using ClasesBase;
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

namespace Vistas
{
    public partial class frmDeleteCategoria : Form
    {
        public frmDeleteCategoria()
        {
            InitializeComponent();
        }



        private void cargarCategorias()
        {
            cmbCategoria.DataSource = TrabajoCategoria.ObtenerCategorias();
            cmbCategoria.DisplayMember = "Cat_Nombre";
            cmbCategoria.ValueMember = "Cat_ID";
        }

        private void frmDeleteCategoria_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem != null)
            {
                string catId = (string)cmbCategoria.SelectedValue;
                string catNombre = cmbCategoria.Text;

                var confirmar = MessageBox.Show($"¿Estás seguro de que deseas eliminar la categoría '{catNombre}'?",
                                                    "Confirmar Eliminación",
                                                    MessageBoxButtons.YesNo);

                if (confirmar == DialogResult.Yes)
                {
                    try
                    {
                        TrabajoCategoria.BorrarCategoriaPorID(catId);
                        MessageBox.Show("Categoría eliminada con éxito.", "Éxito");
                        cargarCategorias();
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
    }
}
