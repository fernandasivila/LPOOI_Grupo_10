
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
    public partial class frmResultados : Form
    {
        public frmResultados()
        {
            InitializeComponent();
        }

        private void frmCreateEvento_Load(object sender, EventArgs e)
        {
            LlenarComboBoxAtletas();
            LlenarComboBoxCompetencias();
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
            DataTable listaCompetencias = TrabajoCompetencia.obtenerCompetenciasActivas();
            cbxCompetencia.DataSource = listaCompetencias;
            cbxCompetencia.DisplayMember = "Com_Nombre";
            cbxCompetencia.ValueMember = "Com_ID";

            cbxCompetencia.Text = "Seleccione una competencia";
        }

        private void llblRegistrarAtleta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateAtleta frm_CreateAtleta = new frmCreateAtleta("registrar");
            (this.ParentForm as frmPrincipal)?.OpenFormChild(frm_CreateAtleta);
        }

        private bool ValidarCampos(out string mensajeError)
        {
            mensajeError = string.Empty;
            if (cbxAtleta.Text == "Seleccione un/a atleta")
            {
                mensajeError = "Debe elegir un Atleta para inscribir.";
                return false;
            }
            if (cbxCompetencia.Text == "Seleccione una competencia")
            {
                mensajeError = "Debe elegir una competencia para inscribir.";
                return false;
            }

            int Atl_ID = (int)cbxAtleta.SelectedValue;

            int Com_ID = (int)cbxCompetencia.SelectedValue;

            if (!TrabajoEvento.verificarInscripcionPrevia(Com_ID, Atl_ID))
            {
                mensajeError = "El atleta ya se inscribió previamente a esta competencia.";
                return false;
            }

            Competencia competencia= TrabajoCompetencia.ObtenerCompetenciaById(Com_ID);
            DateTime fechaHoraActual = DateTime.Now;

            if (competencia.Com_FechaInicio < fechaHoraActual)
            {
                mensajeError = $"La competencia {competencia.Com_Nombre} ya inició. No es posible realizar mas inscripciones";
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
        }

        private void btnRegistrarInscripcion_Click(object sender, EventArgs e)
        {
            string mensajeError;
            if (!ValidarCampos(out mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Evento oEvento = new Evento();
            oEvento.Atl_ID = (int)cbxAtleta.SelectedValue;
            oEvento.Com_ID = (int)cbxCompetencia.SelectedValue;
            oEvento.Eve_Estado = "Inscripto";

            Console.WriteLine(oEvento.Eve_Estado);

            TrabajoEvento.AgregarEvento(oEvento);
            MessageBox.Show("Se ha cargado exitosamente la inscripción", "Inscripción registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VaciarCampos();
        }
    }
}

