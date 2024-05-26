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
        }
        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            if (txtIdUser == null)
            {
                MessageBox.Show("Debe ingresar id");
            }else
            {
                Usuario user = new Usuario
                {
                    Usu_ID = Convert.ToInt32(txtIdUser.Text),
                    Usu_NombreUsuario = txtUsuario.Text,
                    Usu_ApellidoNombre = txtApellidoNombre.Text,
                    Usu_Contrasenia = txtContraseña.Text,
                    Rol_Codigo = Convert.ToInt32(cmbRoles.SelectedValue)
                };

                TrabajarUsuario.update_user(user);

                MessageBox.Show("Usuario actualizado con éxito.");
            }
        }

        private void btnBuscarUser_Click(object sender, EventArgs e)
        {   if (txtIdUser.Text == "")
            {
                MessageBox.Show("Dato Erroneo");
            }
            else
            {
                int idUser = Convert.ToInt32(txtIdUser.Text);
                Usuario user = TrabajarUsuario.GetUserById(idUser);
                if (user != null)
                {
                    txtUsuario.Text = user.Usu_NombreUsuario;
                    txtApellidoNombre.Text = user.Usu_ApellidoNombre;
                    txtContraseña.Text = user.Usu_Contrasenia;
                    cmbRoles.SelectedValue = user.Rol_Codigo;
                }
                else
                {
                    MessageBox.Show("INGRESO INCORRECTO");
                }
            }
            
        }

        private void load_combo_roles()
        {
            cmbRoles.DisplayMember = "Rol_Descripcion";
            cmbRoles.ValueMember = "Rol_Codigo";
            cmbRoles.DataSource = TrabajarUsuario.list_roles();

        }

        private void frmUpdateUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();
        }
    }
}
