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
    public partial class frmLogIn : Form
    {
        private readonly Usuarios usuariosLogIn = new Usuarios();
        private List<Usuario> usuarios;

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string password = txtContraseña.Text;

            if (ValidarCampos(username, password))
            {
                MessageBox.Show("Ningun campo puede estar vacio", "Campos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                usuarios = usuariosLogIn.ObtenerUsuarios();
                Usuario usuarioValido = usuarios.FirstOrDefault(usuario => usuario.Usu_NombreUsuario == username && usuario.Usu_Contrasenia == password);

                if (usuarioValido != null)
                {
                    frmMenu menu = new frmMenu();
                    this.Hide();
                    menu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error de Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool ValidarCampos(string username, string password)
        {
            bool camposVacios = false;
            if (username == "" || password == "")
            {
                camposVacios = true;
            }

            return camposVacios;
        }
    }


}
