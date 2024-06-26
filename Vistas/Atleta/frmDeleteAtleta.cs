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
            string nombreUsuario = txtID.Text;

            if (TrabajoUsuario.comprobarDisponibilidadNombre(nombreUsuario))
            {
                MessageBox.Show($"El nombre de usuario {nombreUsuario} no existe", "Nombre no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                TrabajoUsuario.delete_user(nombreUsuario);
                MessageBox.Show("Usuario eliminado con exito");
            }
        }

    }
}
