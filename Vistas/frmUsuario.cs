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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (TrabajoUsuario.comprobarDisponibilidadNombre(txtUsuario.Text))
            {
                Usuario oUser = new Usuario();

                oUser.Usu_ApellidoNombre = txtApellidoNombre.Text;
                oUser.Usu_NombreUsuario = txtUsuario.Text;
                oUser.Usu_Contrasenia = txtContraseña.Text;
                oUser.Rol_Codigo = (int)cmbRoles.SelectedValue;

                TrabajoUsuario.insert_users(oUser);

                MessageBox.Show("Usuario Registrado con exito");
                volver_al_menu();
            }
            else {
                MessageBox.Show($"El nombre de usuario {txtUsuario.Text} no se encuentra disponible.", "Nombre no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();
        }
        private void load_combo_roles()
        {
            cmbRoles.DisplayMember = "Rol_Descripcion";
            cmbRoles.ValueMember = "Rol_Codigo";
            cmbRoles.DataSource = TrabajoUsuario.list_roles();

        }
        private void volver_al_menu()
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            volver_al_menu();
        }
    }
}
