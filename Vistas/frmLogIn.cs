using ClasesBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
                    Usuario usuario = new Usuario
                    {
                        Usu_ID = int.Parse(user.Rows[0]["Usu_ID"].ToString()),
                        Usu_NombreUsuario = user.Rows[0]["Usu_NombreUsuario"].ToString(),
                        Usu_Contrasenia = user.Rows[0]["Usu_Contraseña"].ToString(),
                        Usu_ApellidoNombre = user.Rows[0]["Usu_ApellidoNombre"].ToString(),
                        Rol_Codigo = int.Parse(user.Rows[0]["Rol_Codigo"].ToString())
                    };

                    UsuarioLogIn.Instance.Usuario = usuario;

                    Frm_Principal menu = new Frm_Principal();
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

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_Restore.Visible = false;
            btn_Maximize.Visible = true;
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_Maximize.Visible = false;
            btn_Restore.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void pnl_TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }


}
