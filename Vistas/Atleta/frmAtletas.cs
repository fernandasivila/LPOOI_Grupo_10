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
    public partial class frmAtletas : Form
    {
        public frmAtletas()
        {
            InitializeComponent();
        }

        private void frmMostrarAtleta_Load(object sender, EventArgs e)
        {
            List<Atleta> atletas = TrabajoAtleta.obtenerAtletas();
           
            Fill_DataGridView(atletas);
        }

        private void rbtnListarDNI_CheckedChanged(object sender, EventArgs e)
        {
            List<Atleta> atletas = TrabajoAtleta.obtenerAtletasPorDNI();
         
            Fill_DataGridView(atletas);
        }

        private void rbtnListarApellido_CheckedChanged(object sender, EventArgs e)
        {
            List<Atleta> atletas = TrabajoAtleta.obtenerAtletasPorApellido();
            
            Fill_DataGridView(atletas);
        }

        private void Fill_DataGridView(List<Atleta> atletas)
        {
            dataGridViewAtleta.DataSource = atletas;
            dataGridViewAtleta.Columns["Atl_ID"].HeaderText = "ID";
            dataGridViewAtleta.Columns["Atl_DNI"].HeaderText = "DNI";
            dataGridViewAtleta.Columns["Atl_Apellido"].HeaderText = "Apellido";
            dataGridViewAtleta.Columns["Atl_Nombre"].HeaderText = "Nombre";
            dataGridViewAtleta.Columns["Atl_Nacionalidad"].HeaderText = "Nacionalidad";
            dataGridViewAtleta.Columns["Atl_Entrenador"].HeaderText = "Entrenador";
            dataGridViewAtleta.Columns["Atl_Genero"].HeaderText = "Genero";
            dataGridViewAtleta.Columns["Atl_Altura"].HeaderText = "Altura";
            dataGridViewAtleta.Columns["Atl_Peso"].HeaderText = "Peso";
            dataGridViewAtleta.Columns["Atl_FechaNac"].HeaderText = "Nacimiento";
            dataGridViewAtleta.Columns["Atl_Direccion"].HeaderText = "Direccion";
            dataGridViewAtleta.Columns["Atl_Email"].HeaderText = "Email";
        }
    }
}
