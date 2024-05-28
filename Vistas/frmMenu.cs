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
    public partial class frmMenu : Form
    {
        
        public frmMenu()
        {
            InitializeComponent();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            Usuario usuario = UsuarioLogIn.Instance.Usuario;
            int rolUser = usuario.Rol_Codigo;

            switch (rolUser)
            {

                //administrador:  acceso al módulo de gestión de Usuarios
                case 1:
                    GestionUsuariosMenuItem1.Visible = true;
                    sistemaToolStripMenuItem.Visible = false;
                    atletasToolStripMenuItem.Visible = false;
                    competenciasToolStripMenuItem.Visible = false;
                    eventosToolStripMenuItem.Visible = false;
                    break;

                //operador:  acceso al módulo Atletas y Competiciones
                case 2:
                    atletasToolStripMenuItem.Visible = true;
                    competenciasToolStripMenuItem.Visible = true;
                    GestionUsuariosMenuItem1.Visible = false;
                    sistemaToolStripMenuItem.Visible = false;
                    eventosToolStripMenuItem.Visible = false;
                    break;

                //auditor:  sin restricción de acceso.

                case 3:
                    GestionUsuariosMenuItem1.Enabled = true;
                    sistemaToolStripMenuItem.Enabled = true;
                    atletasToolStripMenuItem.Enabled = true;
                    competenciasToolStripMenuItem.Enabled = true;
                    eventosToolStripMenuItem.Enabled = true;
                    break;
/*
                default:
                    MessageBox.Show("Rol desconocido.");
                    this.Close();
                    break;*/
            }
        }
        private void registrarNuevaDisciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaDisciplina altaDisciplina = new frmAltaDisciplina();
            this.Hide();
            altaDisciplina.ShowDialog();
            this.Close();
        }

        private void registrarNuevoAtletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaAtleta altaAtleta = new frmAltaAtleta();
            this.Hide();
            altaAtleta.ShowDialog();
            this.Close();
        }

        private void registrarNuevaCompetenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaCompetencia altaCompetencia = new frmAltaCompetencia();
            this.Hide();
            altaCompetencia.ShowDialog();
            this.Close();
        }

        private void ingresarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario usuario = new frmUsuario();
            this.Hide();
            usuario.ShowDialog();
            this.Close(); 
        }

        private void borrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteUsuario deleteUsuario = new frmDeleteUsuario();
            this.Hide();
            deleteUsuario.ShowDialog();
            this.Close();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateUsuario updateUsuario = new frmUpdateUsuario();
            this.Hide();
            updateUsuario.ShowDialog();
            this.Close();
        }

       
    }
}
