
using ClasesBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class frmCronometrajes : Form
    {
        private Evento oEvento;
        private Competencia oCompentencia;
        private DataTable atletasTable = new DataTable();
        private DateTime horaInicioGeneral;
        public frmCronometrajes()
        {
            InitializeComponent();
            panelHorarios.Visible = false;
        }

        private void frmCreateEvento_Load(object sender, EventArgs e)
        {
            LlenarComboBoxCompetencias();
            LlenarComboBoxAtletas();
            LlenarComboBoxEstados();
        }

        private void LlenarComboBoxAtletas()
        {    
            if(atletasTable.Rows.Count != 0)
            {
                cbxAtleta.DataSource = atletasTable;
                cbxAtleta.DisplayMember = "NombreCompleto";
                cbxAtleta.ValueMember = "Alt_ID";
            }
            
            cbxAtleta.Text = "Seleccione un/a atleta";
        }

        private void LlenarDataGridAtletas()
        {
            if (atletasTable.Rows.Count != 0)
            {
                dgvCronometraje.DataSource = atletasTable;
            }
        }
       private void LlenarComboBoxEstados()
          {
              List<string> estados = new List<string> {"Finalizado", "Abandono","Descalificado"};
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

            if (cbxCompetencia.Text == "Seleccione una competencia")
            {
                mensajeError = "Debe elegir una competencia para inscribir.";
                return false;
            }            

            return true;
        }

        private bool ValidarTiempos(out string mensajeError)
        {
            mensajeError = string.Empty;
            if (cbxAtleta.Text == "Seleccione un/a atleta")
            {
                mensajeError = "Debe elegir un Atleta para inscribir.";
                return false;
            }
            if (dtInicio.Value < oCompentencia.Com_FechaInicio || dtInicio.Value > oCompentencia.Com_FechaFin)
            {
                mensajeError = "La hora y fecha de inicio no es valida.";
                return false;
            }
            if (dtInicio.Value>=dtLlegada.Value || (dtLlegada.Value < oCompentencia.Com_FechaInicio || dtLlegada.Value > oCompentencia.Com_FechaFin))
            {
                mensajeError = "La hora y fecha de llegada no es valida.";
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
            atletasTable = TrabajoAtleta.obtenerAtletasPorCompetencia(Convert.ToInt32(cbxCompetencia.SelectedValue));

            LlenarComboBoxAtletas();
            LlenarDataGridAtletas();

            int idComp = Convert.ToInt32(cbxCompetencia.SelectedValue);
            
            if (atletasTable.Rows.Count != 0)
            {
                oCompentencia = TrabajoCompetencia.ObtenerCompetenciaById(idComp);
                if (oCompentencia != null) 
                {
                    panelHorarios.Visible = true;
                    dtInicio.Visible = true;

                    DateTime? horaInicio = TrabajoEvento.ObtenerHoraInicio(idComp);

                    //Asignar valores default a campos
                    dtInicio.Value = oCompentencia.Com_FechaInicio;
                    dtLlegada.Value = oCompentencia.Com_FechaInicio;

                    if(horaInicio != null) //Existe una hora de inicio registrada
                    {
                        dtInicio.Value = horaInicio.Value;
                        dtInicio.Enabled = false;
                    }

                }
                else
                {
                    MessageBox.Show("La competencia no existe :O", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("No se encontraron atletas acreditados para el evento.", "Evento no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                VaciarCampos();

            }
        }

        private void btnRegistrarInscripcion_Click(object sender, EventArgs e)
        {
            string mensajeError;
            if (!ValidarTiempos(out mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                oEvento = TrabajoEvento.getEventByComByAtl(Convert.ToInt32(cbxAtleta.SelectedValue), Convert.ToInt32(cbxCompetencia.SelectedValue));  
                oEvento.Eve_HoraIicio = dtInicio.Value;
                oEvento.Eve_HoraFin = dtLlegada.Value;
                Console.WriteLine("ESTADO", oEvento.Eve_Estado);
                if (oEvento.Eve_Estado == "Acreditado")
                {
                    oEvento.Eve_Estado = cbxStateEvent.SelectedValue.ToString();
                    panelHorarios.Visible = false;
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

