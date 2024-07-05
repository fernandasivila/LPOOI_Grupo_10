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
    public partial class frmDisciplinas : Form
    {
        public frmDisciplinas()
        {
            InitializeComponent();
            
        }

        private void frmDisciplinas_Load(object sender, EventArgs e)
        {
            List<Disciplina> disciplinas = TrabajoDisciplina.obtenerListaDisciplinas();

            
           dataGridViewDisciplina.DataSource = disciplinas;
            dataGridViewDisciplina.Columns["Dis_ID"].HeaderText = "ID";
            dataGridViewDisciplina.Columns["Dis_Nombre"].HeaderText = "Nombre";
            dataGridViewDisciplina.Columns["Dis_Descripcion"].HeaderText = "Descripcion";
        }
        
        /*
            private void btnBuscarDisciplina_Click(object sender, EventArgs e)
        {
            string nombreD = txtNombre.Text;
            if (!string.IsNullOrWhiteSpace(nombreD))
            {
                DataTable disciplinasEncontradas = TrabajoDisciplina.GetDisciplinaByName(nombreD);
                if (disciplinasEncontradas != null && disciplinasEncontradas.Rows.Count > 0)
                {
                    dataGridViewDisciplina.DataSource = disciplinasEncontradas;
                    dataGridViewDisciplina.Columns["Dis_ID"].HeaderText = "ID";
                    dataGridViewDisciplina.Columns["Dis_Nombre"].HeaderText = "Nombre";
                    dataGridViewDisciplina.Columns["Dis_Descripcion"].HeaderText = "Descripcion";

                    
                   // btnMostrarTodos.Visible = true;
                }
                else
                {
                    MessageBox.Show($"No se encontraron coincidencias para '{nombreD}'", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    
                }
            }
        }
       */
    }
}
