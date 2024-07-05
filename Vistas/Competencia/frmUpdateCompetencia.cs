using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class frmUpdateCompetencia : Form
    {
        public frmUpdateCompetencia()
        {
            InitializeComponent();
            LlenarComboBoxCategorias();
            LlenarComboBoxDisciplinas();
            LlenarComboBoxCompetencias();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(cmbEstado.Text) ||
                string.IsNullOrWhiteSpace(txtUbicacion.Text) ||
                string.IsNullOrWhiteSpace(txtOrganizacion.Text) ||
                string.IsNullOrWhiteSpace(txtSponsors.Text) ||
                cmbCategoria.SelectedIndex == -1 ||
                cmbDisciplina.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void LlenarComboBoxCategorias()
        {
            List<Categoria> listaCategorias = TrabajoCategoria.ObtenerListaCategorias();
            cmbCategoria.DataSource = listaCategorias;
            cmbCategoria.DisplayMember = "Cat_Nombre";
            cmbCategoria.ValueMember = "Cat_ID";
        }

        private void LlenarComboBoxDisciplinas()
        {
            List<Disciplina> listaDisciplinas = TrabajoDisciplina.obtenerListaDisciplinas();
           
            cmbDisciplina.DataSource = listaDisciplinas;
            cmbDisciplina.DisplayMember = "Dis_Descripcion";
            cmbDisciplina.ValueMember = "Dis_ID";
        }

        private void LlenarComboBoxCompetencias()
        {
            List<Competencia> listaCompetencias = TrabajoCompetencia.obtenerListaCompetencia();
            cmbCompetencia.DataSource = listaCompetencias;
            cmbCompetencia.DisplayMember = "Com_Nombre";
            cmbCompetencia.ValueMember = "Com_ID";
            cmbCompetencia.Text = "Seleccionar...";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cmbCompetencia.Text == "Seleccionar...")
            {
                MessageBox.Show("Debe seleccionar una competencia a modificar", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!ValidarCampos())
                {
                    MessageBox.Show("Ningun campo puede estar vacio", "Campos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Competencia oCompetencia = new Competencia
                    {
                        Com_ID = (int)cmbCompetencia.SelectedValue,
                        Com_Nombre = txtNombre.Text,
                        Com_Descripcion = txtDescripcion.Text,
                        Com_FechaInicio = dtpFechaInicio.Value,
                        Com_FechaFin = dtpFechaFin.Value,
                        Com_Estado = cmbEstado.Text,
                        Com_Ubicacion = txtUbicacion.Text,
                        Com_Organizador = txtOrganizacion.Text,
                        Com_Sponsors = txtSponsors.Text,
                        Cat_ID = (int)cmbCategoria.SelectedValue,
                        Dis_ID = (int)cmbDisciplina.SelectedValue
                    };

                    TrabajoCompetencia.ModificarCompetenciaByID(oCompetencia);

                    MessageBox.Show("Objeto guardado: " + "\n"
                        + " Nombre: " + oCompetencia.Com_Nombre + "\n"
                        + " Descripcion: " + oCompetencia.Com_Descripcion + "\n"
                        + " FechaInicio: " + oCompetencia.Com_FechaInicio + "\n"
                        + " FechaFin: " + oCompetencia.Com_FechaFin + "\n"
                        + " Estado : " + oCompetencia.Com_Estado + "\n"
                        + " Ubicacion: " + oCompetencia.Com_Ubicacion + "\n"
                        + " Organizacion: " + oCompetencia.Com_Organizador + "\n"
                        + " Sponsors: " + oCompetencia.Com_Sponsors + "\n"
                        + " Categoria: " + cmbCategoria.Text + "\n"
                        + " Disciplina: " + cmbDisciplina.Text);

                }
            }
        }

        private void btnBuscarUser_Click(object sender, EventArgs e)
        {
            if (cmbCompetencia.Text == "Seleccionar...")
            {
                MessageBox.Show("Debe seleccionar una competencia a modificar", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int competenciaId = (int)cmbCompetencia.SelectedValue;
                Competencia oCompetencia = TrabajoCompetencia.ObtenerCompetenciaById(competenciaId);
                if (oCompetencia != null)
                {
                    txtNombre.Text = oCompetencia.Com_Nombre;
                    txtDescripcion.Text = oCompetencia.Com_Descripcion;
                    txtOrganizacion.Text = oCompetencia.Com_Organizador;
                    txtSponsors.Text = oCompetencia.Com_Sponsors;
                    txtUbicacion.Text = oCompetencia.Com_Ubicacion;
                    dtpFechaInicio.Value = oCompetencia.Com_FechaInicio;
                    dtpFechaFin.Value = oCompetencia.Com_FechaFin;
                    cmbEstado.Text = oCompetencia.Com_Estado;
                    cmbCategoria.SelectedValue = oCompetencia.Cat_ID;
                    cmbDisciplina.SelectedValue = oCompetencia.Dis_ID;
                }
                else
                {
                    MessageBox.Show("No se encontró la competencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}