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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vistas
{
    public partial class frmUsuarios : Form
    { private const string PlaceholderText = "Ingrese el usuario";
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            Load_All_Users();

            
            txtBuscador.Text = PlaceholderText;
            txtBuscador.ForeColor = Color.Gray;

            txtBuscador.GotFocus += RemovePlaceholder;
            txtBuscador.LostFocus += ShowPlaceholder;
        }
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (txtBuscador.Text == PlaceholderText)
            {
                txtBuscador.Text = "";
                txtBuscador.ForeColor = Color.Black;
            }
        }

        private void ShowPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscador.Text))
            {
                txtBuscador.Text = PlaceholderText;
                txtBuscador.ForeColor = Color.Gray;
            }
        }
        private void btnBuscarUser_Click(object sender, EventArgs e)
        {

            string keyword = txtBuscador.Text;

           

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                DataTable usuariosEncontrados = TrabajoUsuario.GetUsersByFullname(keyword);
                if (usuariosEncontrados.Rows.Count > 0)
                {
                    Fill_DataGridView(usuariosEncontrados);
                    btnMostrarTodos.Visible = true;
                }
                else
                {
                    if (MessageBox.Show("No se encontraron coincidencias", "Error de Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Load_All_Users();
                    }
                    btnMostrarTodos.Visible = false;
                    txtBuscador.Text = string.Empty;
                }

            }
            else
            {
                MessageBox.Show("Debe ingresar una palabra clave para realizar la busqueda", "Error de Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Load_All_Users()
        {
            DataTable usuarios = TrabajoUsuario.list_usuarios();
            Fill_DataGridView(usuarios);
        }
        private void Fill_DataGridView(DataTable usuarios)
        {
            dgvListaUsuarios.DataSource = usuarios;
            dgvListaUsuarios.Columns["Usu_ID"].HeaderText = "ID";
            dgvListaUsuarios.Columns["Usu_NombreUsuario"].HeaderText = "Usuario";
            dgvListaUsuarios.Columns["Usu_ApellidoNombre"].HeaderText = "Nombre Completo";
            dgvListaUsuarios.Columns["Rol_Descripcion"].HeaderText = "Rol";
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtBuscador.Text = string.Empty;
            Load_All_Users();
            btnMostrarTodos.Visible = false;
        }
    }
}
