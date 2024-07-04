
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
    public partial class frmCreateDisciplina : Form
    {
        public frmCreateDisciplina()
        {
            InitializeComponent();
        }


        private void frmUsuario_Load(object sender, EventArgs e)
        {
        }

        private void btnRegistrarDisciplina_Click(object sender, EventArgs e)
        {

            string mensajeError;
            if (!ValidarCampos(out mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Disciplina oDisciplina = new Disciplina();
            oDisciplina.Dis_Nombre = txtNombre.Text;
            oDisciplina.Dis_Descripcion = txtDescripcion.Text;


            TrabajoDisciplina.AgregarDisciplina(oDisciplina);
            MessageBox.Show("Se ha cargado exitosamente una nueva disciplina", "Disciplina registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private bool ValidarCampos(out string mensajeError)
        {
            mensajeError = string.Empty;
            if (txtNombre.Text == "")
            {
                mensajeError = "Debe ingresar un Nombre de Disciplina.";
                return false;
            }
            return true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        
    }
}

