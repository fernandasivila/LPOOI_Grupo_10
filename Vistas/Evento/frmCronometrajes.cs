
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
    public partial class frmCronometrajes : Form
    {
        public frmCronometrajes()
        {
            InitializeComponent();
        }

        private void frmCreateEvento_Load(object sender, EventArgs e)
        {
            LlenarComboBoxAtletas();
            LlenarComboBoxCompetencias();
            LlenarComboBoxEstados();
        }

        private void LlenarComboBoxAtletas()
        {
            List<Atleta> listaAtletas = TrabajoAtleta.obtenerAtletas();
            cbxAtleta.DataSource = listaAtletas;
            cbxAtleta.DisplayMember = "NombreCompleto";
            cbxAtleta.ValueMember = "Atl_ID";

            cbxAtleta.Text = "Seleccione un/a atleta";
        }
        private void LlenarComboBoxEstados()
        {
            List<string> estados = new List<string> {"Abandono","Descalificado"};
            cbxStateEvent.DataSource = estados;
        }
        private void LlenarComboBoxCompetencias()
        {
            DataTable listaCompetencias = TrabajoCompetencia.obtenerCompetenciasActivas();
            cbxCompetencia.DataSource = listaCompetencias;
            cbxCompetencia.DisplayMember = "Com_Nombre";
            cbxCompetencia.ValueMember = "Com_ID";

            cbxCompetencia.Text = "Seleccione una competencia";
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
            cbxStateEvent.Text = "Seleccione un estado";
        }

        private void btnRegistrarInscripcion_Click(object sender, EventArgs e)
        {
            string mensajeError;
            if (!ValidarCampos(out mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idAtleta = Convert.ToInt32(cbxAtleta.SelectedValue);
            int idComp = Convert.ToInt32(cbxCompetencia.SelectedValue);

            Evento oEvento = TrabajoEvento.getEventByComByAtl(idAtleta, idComp);
            Console.WriteLine("EVENTO ENCONTRADO", oEvento);
            if (oEvento != null)
            {
                oEvento.Eve_HoraFin = timeFin.Value;
                Console.WriteLine("HORARIO DE FINALIZACION",oEvento.Eve_HoraFin);

                TrabajoEvento.ModificarEvento(oEvento);
                MessageBox.Show("Se ha cargado exitosamente la llegada", "Llegada registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró un evento con los datos proporcionados.", "Evento no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            VaciarCampos();
        }

       
    }
}

