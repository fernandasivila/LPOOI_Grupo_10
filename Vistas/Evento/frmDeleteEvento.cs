
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
    public partial class frmDeleteEvento : Form
    {
        public frmDeleteEvento()
        {
            InitializeComponent();
        }

        private void frmAnularEvento_Load(object sender, EventArgs e)
        {
            LlenarComboBoxAtletas();
            LlenarComboBoxCompetencias();
        }

        private void LlenarComboBoxAtletas()
        {
            List<Atleta> listaAtletas = TrabajoAtleta.obtenerAtletas();
            cmbAtleta.DataSource = listaAtletas;
            cmbAtleta.DisplayMember = "NombreCompleto";
            cmbAtleta.ValueMember = "Atl_ID";

            cmbAtleta.Text = "Seleccione un/a atleta";
        }

        private void LlenarComboBoxCompetencias()
        {
            DataTable listaCompetencias = TrabajoCompetencia.obtenerCompetenciasActivas();
            cmbCompetencia.DataSource = listaCompetencias;
            cmbCompetencia.DisplayMember = "Com_Nombre";
            cmbCompetencia.ValueMember = "Com_ID";

            cmbCompetencia.Text = "Seleccione una competencia";
        }

        private bool ValidarCampos(out string mensajeError)
        {
            mensajeError = string.Empty;
            if (cmbAtleta.Text == "Seleccione un/a atleta")
            {
                mensajeError = "Debe elegir un Atleta para anular.";
                return false;
            }
            if (cmbCompetencia.Text == "Seleccione una competencia")
            {
                mensajeError = "Debe elegir una competencia para anular.";
                return false;
            }
            return true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            VaciarCampos();
        }

        private void VaciarCampos()
        {
            cmbAtleta.Text = "Seleccione un/a atleta";
            cmbCompetencia.Text = "Seleccione una competencia";
        }

        private void btnAnularInscripcion_Click(object sender, EventArgs e)
        {
            string mensajeError;
            if (!ValidarCampos(out mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int atl_ID = (int)cmbAtleta.SelectedValue;
            int com_ID = (int)cmbCompetencia.SelectedValue;

            int rowsAffected = TrabajoEvento.AnularInscripcion(atl_ID, com_ID);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Se ha anulado exitosamente la inscripción", "Inscripción Anulada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VaciarCampos();
            }
            else
            {
                MessageBox.Show("No se encontró una inscripción para el atleta en la competencia seleccionada.");
            }
            
        }
    }
}

