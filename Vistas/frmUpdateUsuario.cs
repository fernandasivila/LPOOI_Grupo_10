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
    public partial class frmUpdateUsuario : Form
    {
        public frmUpdateUsuario()
        {
            InitializeComponent();
            load_combo_usuarios();
        }
        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            if (TrabajoUsuario.comprobarDisponibilidadNombre(txtUsuario.Text))
            {
                Usuario user = new Usuario
                {
                    Usu_ID = Convert.ToInt32(cmbDbUsuario.SelectedValue),
                    Usu_NombreUsuario = txtUsuario.Text,
                    Usu_ApellidoNombre = txtApellidoNombre.Text,
                    Usu_Contrasenia = txtContraseña.Text,
                    Rol_Codigo = Convert.ToInt32(cmbRoles.SelectedValue)
                };
                TrabajoUsuario.update_user(user);
                MessageBox.Show("Usuario actualizado con éxito.");
                volver_al_menu();
            }
            else
            {
                MessageBox.Show($"El nombre de usuario {txtUsuario.Text} no se encuentra disponible.","Nombre no disponible",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnBuscarUser_Click(object sender, EventArgs e)
        {
            int idUser = Convert.ToInt32(cmbDbUsuario.SelectedValue);
            cmbDbUsuario.Enabled = false;
            btnBuscarUser.Enabled = false;
            Usuario user = TrabajoUsuario.GetUserById(idUser);

            txtUsuario.Text = user.Usu_NombreUsuario;
            txtApellidoNombre.Text = user.Usu_ApellidoNombre;
            txtContraseña.Text = user.Usu_Contrasenia;
            cmbRoles.SelectedValue = user.Rol_Codigo;

            pnlDatosUsuario.Visible = true;
        }
        private void volver_al_menu()
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
        private void load_combo_usuarios()
        {
            cmbDbUsuario.DisplayMember = "Usu_NombreUsuario";
            cmbDbUsuario.ValueMember = "Usu_ID";
            cmbDbUsuario.DataSource = TrabajoUsuario.list_usuarios();
        }
        private void load_combo_roles()
        {
            cmbRoles.DisplayMember = "Rol_Descripcion";
            cmbRoles.ValueMember = "Rol_Codigo";
            cmbRoles.DataSource = TrabajoUsuario.list_roles();

        }

        private void frmUpdateUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            volver_al_menu();
        }
    }
}
