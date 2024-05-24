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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void registrarNuevaDisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaDisciplina altaDisciplina = new frmAltaDisciplina();
            this.Hide();
            altaDisciplina.ShowDialog();
            this.Close();
        }

        private void registrarNuevoAtletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaAtleta altaAtleta = new frmAltaAtleta();
            this.Hide();
            altaAtleta.ShowDialog();
            this.Close();
        }

        private void registrarNuevaCompetenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaCompetencia altaCompetencia = new frmAltaCompetencia();
            this.Hide();
            altaCompetencia.ShowDialog();
            this.Close();
        }
    }
}
