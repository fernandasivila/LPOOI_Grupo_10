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
    public partial class frmDisciplinas : Form
    {
        public frmDisciplinas()
        {
            InitializeComponent();
        }

        private void frmDisciplinas_Load(object sender, EventArgs e)
        {
            List<Disciplina> disciplinas = TrabajoDisciplina.obtenerListaDisciplinas();
            dataGridViewDisciplina.DataSource = disciplinas;
        }
    }
}
