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
    public partial class frmCreateCompetencia : Form
    {
        public frmCreateCompetencia()
        {
            InitializeComponent();
            LlenarComboBoxCategorias();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Ningun campo puede estar vacio", "Campos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               


                    int indice1 = cmbCategoria.SelectedIndex;
                    int indice2 = cmbDisciplina.SelectedIndex;
                    Competencia oCompetencia = new Competencia();
                    oCompetencia.Com_Nombre = txtNombre.Text;
                    oCompetencia.Com_Descripcion = txtDescripcion.Text;
                    oCompetencia.Com_FechaInicio = dtpFechaInicio.Value;
                    oCompetencia.Com_FechaFin = dtpFechaFin.Value;
                    oCompetencia.Com_Estado = cmbEstado.Text;
                    oCompetencia.Com_Ubicacion = txtUbicacion.Text;
                    oCompetencia.Com_Organizador = txtOrganizacion.Text;
                    oCompetencia.Com_Sponsors = txtSponsors.Text;
                    oCompetencia.Cat_ID = indice1;
                    oCompetencia.Dis_ID = indice2;

                    MessageBox.Show("Objeto guardado: " + "\n"
                        + " Nombre: " + oCompetencia.Com_Nombre + "\n"
                        + " Descripcion: " + oCompetencia.Com_Descripcion + "\n"
                        + " FechaInicio: " + oCompetencia.Com_FechaInicio + "\n"
                        + " FechaFin: " + oCompetencia.Com_FechaFin + "\n"
                        + " Estado : " + oCompetencia.Com_Estado + "\n"
                        + " Ubicacion: " + oCompetencia.Com_Ubicacion + "\n"
                        + " Organizacion: " + oCompetencia.Com_Organizador + "\n"
                        + " Sponsors: " + oCompetencia.Com_Sponsors + "\n"
                        + " Categoria: " + cmbCategoria.Items[oCompetencia.Cat_ID].ToString() + "\n"
                        + " Disciplina: " + cmbDisciplina.Items[oCompetencia.Dis_ID].ToString());
                   TrabajoCompetencia.AgregarComptencia(oCompetencia);
            }
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

            cmbCategoria.DisplayMember = "Cat_Nombre";
            cmbCategoria.ValueMember = "Cat_ID";

            cmbCategoria.DataSource = listaCategorias;
        }
    }
}
