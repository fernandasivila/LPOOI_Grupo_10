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
    public partial class frmCreateUsuario : Form
    {
        public frmCreateUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            string mensajeError;

            if (!ValidarCampos(out mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
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
                    frmUsuarios listadoUsuarios = new frmUsuarios();
                    (this.ParentForm as frmPrincipal)?.OpenFormChild(listadoUsuarios);
                }
                else
                {
                    MessageBox.Show($"El nombre de usuario {txtUsuario.Text} no se encuentra disponible.", "Nombre no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
            cmbRoles.Text = "Seleccione el rol";

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtApellidoNombre.Clear();
            txtContraseña.Clear();
            txtUsuario.Clear();
            cmbRoles.Text = "Seleccione el rol";
        }

        private bool ValidarCampos(out string mensajeError)
        {
            mensajeError = "";

            if (cmbRoles.Text == "Seleccione el rol")
            {
                mensajeError = "Debe seleccionar una rol para el usuario";
                return false;
            }

            if (txtUsuario.Text == "")
            {
                mensajeError = "Debe ingresar un Nombre de Usuario";
                return false;
            }

            if (txtApellidoNombre.Text == "")
            {
                mensajeError= "Debe ingresar el Nombre Completo del Usuario";
                return false;
            }

            if (txtContraseña.Text == "")
            {
                mensajeError = "Debe ingresar una Contraseña";
                return false;
            }
            return true;
        }
    }
}
