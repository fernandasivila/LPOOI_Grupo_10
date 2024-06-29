

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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int? id = TrabajoDisciplina.obtenerDisciplinaIdByNombre(nombre);

            if (id == null)
            {
                MessageBox.Show($"La disciplina {nombre} no existe", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                TrabajoDisciplina.BorrarDisciplinaPorID(id.Value);

                MessageBox.Show($"Disciplina {nombre} eliminada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}


