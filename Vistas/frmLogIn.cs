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
            string usernameVista = txtUsuario.Text;
            string passwordVista = txtContraseña.Text;
            if ( ValidarCampos(usernameVista,passwordVista) )
            {
                MessageBox.Show("Ningun campo puede estar vacio", "Campos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable user = TrabajoUsuario.login(usernameVista, passwordVista);

                if (user.Rows.Count > 0)
                {
                    frmMenu menu = new frmMenu();
                    int rolUser = int.Parse(user.Rows[0]["Rol_Codigo"].ToString());
                    menu.rolUser = rolUser;
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
