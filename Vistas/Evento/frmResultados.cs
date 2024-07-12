
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
        DataTable resultadosTable = new DataTable();
        public frmResultados()
        {
            InitializeComponent();
        }

        private void frmCreateEvento_Load(object sender, EventArgs e)
        {
            LlenarComboBoxCompetencias();
        }

        private void LlenarDataGridResultados()
        {
            if (resultadosTable.Rows.Count != 0)
            {
                dgvResultados.DataSource = resultadosTable;
            }
        }

        private void LlenarComboBoxCompetencias()
        {
            DataTable listaCompetencias = TrabajoCompetencia.ObtenerCompetencias();
            cbxCompetencia.DataSource = listaCompetencias;
            cbxCompetencia.DisplayMember = "Com_Nombre";
            cbxCompetencia.ValueMember = "Com_ID";

            cbxCompetencia.Text = "Seleccione una competencia";
        }

        private void llblRegistrarAtleta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            VaciarCampos();
        }

        private void VaciarCampos()
        {
            
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

        private void btnRegistrarInscripcion_Click(object sender, EventArgs e)
        {
            int idComp = Convert.ToInt16(cbxCompetencia.SelectedValue);
            string mensajeError;
            if (!ValidarCampos(out mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            resultadosTable = TrabajoEvento.obtenerResultadosCompetencia(idComp);
            
            if(resultadosTable.Rows.Count != 0)
            {
                panel1.Visible = true;
                LlenarDataGridResultados();

                int participantes = 0;
                int abandonado = 0;
                int descalificado = 0;

                TrabajoEvento.contarParticipantes(idComp, out participantes, out abandonado, out descalificado);
                txtParticipantes.Text = participantes.ToString();
                txtAbandonos.Text = abandonado.ToString();
                txtDescalificados.Text = descalificado.ToString();

                string categoria;
                string disciplina;

                TrabajoCompetencia.ObtenerCategoriaDisciplina(idComp, out categoria, out disciplina);
                txtCategoria.Text = categoria.ToString();
                txtDisciplina.Text = disciplina.ToString();
            }
            else
            {
                MessageBox.Show("Esta competencia no tiene cronometrajes registrados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            
            
        }
    }
}

