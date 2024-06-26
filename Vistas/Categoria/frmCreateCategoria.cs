﻿
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
    public partial class frmCreateCategoria : Form
    {
        public frmCreateCategoria()
        {
            InitializeComponent();
        }


        private void frmUsuario_Load(object sender, EventArgs e)
        {
        }

        private void btnRegistrarCategoria_Click(object sender, EventArgs e)
        {
            string mensajeError;
            if (!ValidarCampos(out mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Categoria oCategoria = new Categoria();
            oCategoria.Cat_Nombre = txtNombre.Text;
            oCategoria.Cat_Descripcion = txtDescripcion.Text;

            TrabajoCategoria.AgregarCategoria(oCategoria);
            MessageBox.Show("OBJETO GUARDADO:\n"
            + "Nombre: " + oCategoria.Cat_Nombre + "\n"
            + "Descripcion: " + oCategoria.Cat_Descripcion);
        }

        private bool ValidarCampos(out string mensajeError)
        {
            mensajeError = string.Empty;
            if(txtNombre.Text == "")
            {
                mensajeError = "Debe ingresar un Nombre de categoría.";
                return false;
            }
            return true;
        }
    }
}
