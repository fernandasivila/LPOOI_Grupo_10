using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class frmAltaDisciplina : Form
    {
        public frmAltaDisciplina()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
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
}
