using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class frmDeleteAtleta : Form
    {
        public frmDeleteAtleta()
        {
            InitializeComponent();
        }

        private void btnBorrarUsuario_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;

            if (TrabajoAtleta.obtenerAtletaById(Int32.Parse(id)) == null)
            {
                MessageBox.Show($"El id de atleta {id} no existe", "Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                TrabajoAtleta.borrarAtleta(Int32.Parse(id));
                MessageBox.Show("Atleta eliminado con exito");
            }
        }

    }
}
