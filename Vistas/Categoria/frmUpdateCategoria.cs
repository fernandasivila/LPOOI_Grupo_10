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
    public partial class frmUpdateCategoria : Form
    {
        public frmUpdateCategoria()
        {
            InitializeComponent();
        }

        private void frmUpdateCategoria_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        private void cargarCategorias()
        {
            //TODO: Agregar carga de categorias
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string mensajeError;
            if (!validarCampos(out mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Categoria oCategoria = new Categoria();
            oCategoria.Cat_ID = Convert.ToInt32(cmbDbCategoria.SelectedValue);
            oCategoria.Cat_Nombre = txtNombre.Text;
            oCategoria.Cat_Descripcion = txtDescripcion.Text;
        }

        private bool validarCampos(out string mensajeError)
        {
            mensajeError = string.Empty;
            if (txtNombre.Text == "")
            {
                mensajeError = "Debe ingresar un Nombre de Categoría.";
                return false;
            }
            return true;
        }
    }
}
