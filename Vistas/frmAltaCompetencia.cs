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
    public partial class frmAltaCompetencia : Form
    {
        public frmAltaCompetencia()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Competencia oCompetencia = new Competencia();
            oCompetencia.Com_Nombre = txtNombre.Text;
            oCompetencia.Com_Descripcion = txtDescripcion.Text;
            oCompetencia.Com_FechaInicio = dtpFechaInicio.Value;
            oCompetencia.Com_FechaFin = dtpFechaFin.Value;
            oCompetencia.Com_Estado = cmbEstado.Text;
            oCompetencia.Com_Ubicacion = txtUbicacion.Text;
            oCompetencia.Com_Organizador = txtOrganizacion.Text;
            oCompetencia.Com_Sponsors = txtSponsors.Text;

            MessageBox.Show("Objeto guardado: " + "\n"
                + " Nombre: " + oCompetencia.Com_Nombre + "\n"
                + " Descripcion: " + oCompetencia.Com_Descripcion + "\n"
                + " FechaInicio: " + oCompetencia.Com_FechaInicio + "\n"
                + " FechaFin: " + oCompetencia.Com_FechaFin + "\n"
                + " Estado : " + oCompetencia.Com_Estado + "\n"
                + " Ubicacion: " + oCompetencia.Com_Ubicacion + "\n"
                + " Organizacion: "+ oCompetencia.Com_Organizador + "\n"
                + " Sponsors: "+ oCompetencia.Com_Sponsors);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
