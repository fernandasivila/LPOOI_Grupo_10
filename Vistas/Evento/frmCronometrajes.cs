
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
        private Evento oEvento;
        private DateTime horaInicioGeneral;
        public frmCronometrajes()
        {
            InitializeComponent();
            panelHorarios.Visible = false;
        }

        private void frmCreateEvento_Load(object sender, EventArgs e)
        {
            LlenarComboBoxAtletas();
            LlenarComboBoxCompetencias();
           // LlenarComboBoxEstados();
        }

        private void LlenarComboBoxAtletas()
        {
            List<Atleta> listaAtletas = TrabajoAtleta.obtenerAtletas();
            cbxAtleta.DataSource = listaAtletas;
            cbxAtleta.DisplayMember = "NombreCompleto";
            cbxAtleta.ValueMember = "Atl_ID";

            cbxAtleta.Text = "Seleccione un/a atleta";
        }
      /*  private void LlenarComboBoxEstados()
        {
            List<string> estados = new List<string> {"Abandono","Descalificado"};
            cbxStateEvent.DataSource = estados;
        }
      */
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
            panelHorarios.Visible = false;
          //  cbxStateEvent.Text = "Seleccione un estado";
        }

       

      
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string mensajeError;
            if (!ValidarCampos(out mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idAtleta = Convert.ToInt32(cbxAtleta.SelectedValue);
            int idComp = Convert.ToInt32(cbxCompetencia.SelectedValue);

             oEvento = TrabajoEvento.getEventByComByAtl(idAtleta, idComp);

            if (oEvento != null)
            {
                Competencia auxCom = TrabajoCompetencia.ObtenerCompetenciaById(idComp);

                if (auxCom != null) 
                {
                    panelHorarios.Visible = true;
                    dtInicio.Visible = true;
                    if (auxCom.Com_FechaInicio != DateTime.MinValue)
                    {
                        dtInicio.Value = auxCom.Com_FechaInicio;
                        oEvento.Eve_HoraIicio = auxCom.Com_FechaInicio;
                        
                        dtInicio.Enabled = false;
                    }
                    else
                    {
                        dtInicio.Enabled = true;
                    }


                }
                else
                {
                    MessageBox.Show("La competencia no exisete :O", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("No se encontró un evento con los datos proporcionados.", "Evento no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                VaciarCampos();

            }
        }

        private void btnRegistrarInscripcion_Click(object sender, EventArgs e)
        {
            try
            { 
             oEvento.Eve_HoraFin = dtLlegada.Value;
                Console.WriteLine("ESTADO", oEvento.Eve_Estado);
                if (oEvento.Eve_Estado == "Inscripto")
                {
                    TrabajoEvento.ModificarEvento(oEvento);
                    MessageBox.Show("Se ha cargado exitosamente la llegada", "Llegada registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El atleta no se encuentra en estado de inscripción", "Error de inscripion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VaciarCampos();
                }

            
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}

