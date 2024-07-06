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
    public partial class frmCompetencias : Form
    {
        public frmCompetencias()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frmCompetencias_Load);
        }

        private void frmCompetencias_Load(object sender, EventArgs e)
        {
            DataTable dt = TrabajoCompetencia.ObtenerCompetencias();
            dgvListaCompetencias.DataSource = dt;
        }

        private void btnBuscarCompetencia_Click(object sender, EventArgs e)
        {
            dgvListaCompetencias.DataSource = TrabajoCompetencia.obtenerCompetenciasByNombre(txtNombre.Text);
        }
        
    }
}