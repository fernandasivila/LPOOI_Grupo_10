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
    public partial class frmAtletas : Form
    {
        public frmAtletas()
        {
            InitializeComponent();
        }

        private void frmMostrarAtleta_Load(object sender, EventArgs e)
        {
            List<Atleta> atletas = TrabajoAtleta.obtenerAtletas();
            dataGridViewAtleta.DataSource = atletas;
        }

        private void rbtnListarDNI_CheckedChanged(object sender, EventArgs e)
        {
            List<Atleta> atletas = TrabajoAtleta.obtenerAtletasPorDNI();
            dataGridViewAtleta.DataSource = atletas;
        }

        private void rbtnListarApellido_CheckedChanged(object sender, EventArgs e)
        {
            List<Atleta> atletas = TrabajoAtleta.obtenerAtletasPorApellido();
            dataGridViewAtleta.DataSource = atletas;
        }
    }
}
