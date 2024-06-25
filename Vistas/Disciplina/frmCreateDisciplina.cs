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
            if (!validarCampos())
            {
                MessageBox.Show("Ningun campo puede estar vacio", "Campos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Disciplina oDisciplina = new Disciplina();
                oDisciplina.Dis_Nombre = txtNombre.Text;
                oDisciplina.Dis_Descripcion = txtDescripcion.Text;
                oDisciplina.Dis_ID = 1;
                MessageBox.Show("Objeto Guardado: " + "\n"
                    + " Nombre: " + oDisciplina.Dis_Nombre + "\n"
                    + " Descripcion: " + oDisciplina.Dis_Descripcion);
            }
        }

        private bool validarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                return false;
            }

            return true;
        }
    }
}
