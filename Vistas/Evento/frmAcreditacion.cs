
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
    public partial class frmAcreditacion : Form
    {
        public frmAcreditacion()
        {
            InitializeComponent();
        }

        private void frmCreateEvento_Load(object sender, EventArgs e)
        {
            LlenarComboBoxAtletas();
        }

        private void LlenarComboBoxAtletas()
        {
            List<Atleta> listaAtletas = TrabajoAtleta.obtenerAtletas();
            cbxAtleta.DataSource = listaAtletas;
            cbxAtleta.DisplayMember = "NombreCompleto";
            cbxAtleta.ValueMember = "Atl_ID";

            cbxAtleta.Text = "Seleccione un/a atleta";
        }

        private void LlenarComboBoxCompetencias()
        {
            if (cbxAtleta.SelectedValue == null)
            {
                cbxCompetencia.DataSource = null;
                cbxCompetencia.Text = "Seleccione una competencia";
                return;
            }
            if (cbxAtleta.SelectedValue is int atletaID)
            {
                List<Competencia> listaCompetencias = TrabajoEvento.ObtenerListaCompetenciasPorAtleta(atletaID);
                cbxCompetencia.DataSource = listaCompetencias;
                cbxCompetencia.DisplayMember = "Com_Nombre";
                cbxCompetencia.ValueMember = "Com_ID";

                cbxCompetencia.Text = "Seleccione una competencia";

                DataTable listaCom = TrabajoEvento.ObtenerCompetenciasPorAtleta(atletaID);
                dgvAcreditacion.DataSource = listaCompetencias;
            }
            else
            {
                cbxCompetencia.DataSource = null;
                dgvAcreditacion.DataSource = null;
                cbxCompetencia.Text = "Seleccione una competencia";
            }
        }
        private bool ValidarCampos(out string mensajeError)
        {
            mensajeError = string.Empty;
            if (cbxAtleta.Text == "Seleccione un/a atleta")
            {
                mensajeError = "Debe elegir un Atleta para Acreditar.";
                return false;
            }
            if (cbxCompetencia.Text == "Seleccione una competencia")
            {
                mensajeError = "Debe elegir una competencia para Acreditar.";
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
            cbxAtleta.Text = "Seleccione un/a atleta";
            cbxCompetencia.Text = "Seleccione una competencia";
            cbxCompetencia.DataSource = null;
            dgvAcreditacion.DataSource = null;
        }

        private void cbxAtleta_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarComboBoxCompetencias();
        }

        private void btnRegistrarAcreditacion_Click(object sender, EventArgs e)
        {
            string mensajeError;
            if (!ValidarCampos(out mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int atl_ID;
            int com_ID;
            try
            {
                atl_ID = Convert.ToInt32(cbxAtleta.SelectedValue);
                com_ID = Convert.ToInt32(cbxCompetencia.SelectedValue);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Error al convertir los valores seleccionados. Asegúrese de seleccionar un atleta y una competencia válidos.", "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            TrabajoEvento.AcreditarInscripcion(atl_ID, com_ID);

            
                MessageBox.Show("Se ha acreditado exitosamente la Inscripcion", "Inscripción Acreditada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VaciarCampos();
        }
    }
}

