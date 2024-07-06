using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class frmDeleteCompetencia : Form
    {
        public frmDeleteCompetencia()
        {
            InitializeComponent();
            LlenarCmbCompetencia();
        }

        private void btnBorrarCompetencia_Click(object sender, EventArgs e)
        {
            int idCompetencia = (int)cmbCompetencia.SelectedValue;
                Competencia competencia = TrabajoCompetencia.ObtenerCompetenciaById(idCompetencia);

                if (competencia == null)
                {
                    MessageBox.Show($"La competencia con ID {idCompetencia} no existe", "ID no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    TrabajoCompetencia.BorrarCompetenciaByID(idCompetencia.ToString());
                    MessageBox.Show("Competencia eliminada con éxito");
                }
        }

        private void LlenarCmbCompetencia()
        {
            List<Competencia> listaCompetencias = TrabajoCompetencia.obtenerListaCompetencia();
            cmbCompetencia.DataSource = listaCompetencias;
            cmbCompetencia.DisplayMember = "Com_Nombre";
            cmbCompetencia.ValueMember = "Com_ID";
        }
    }
}
