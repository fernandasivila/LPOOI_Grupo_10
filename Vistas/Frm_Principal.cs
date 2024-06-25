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
using Vistas.Usuario;

namespace Vistas
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            Load_UserLoggedData();
            Load_Priviliges(UsuarioLogIn.Instance.Usuario.Rol_Codigo);
        }

        private void Load_Priviliges(int rol)
        {
            switch (rol)
            {
                case 1:
                    btn_Users.Visible = true;
                    decoration_ToBtnUsers.Visible = true;
                    break;
                case 2:
                    btn_Athletes.Visible = true;
                    decoration_ToBtnAthletes.Visible = true;
                    btn_Competitions.Visible = true;
                    decoration_ToBtnCompetitions.Visible = true;
                    btn_Events.Visible = true;
                    decoration_ToBtnEvents.Visible = true;
                    break;
                case 3:
                    btn_Users.Visible = true;
                    decoration_ToBtnUsers.Visible = true;
                    btn_Athletes.Visible = true;
                    decoration_ToBtnAthletes.Visible = true;
                    btn_Competitions.Visible = true;
                    decoration_ToBtnCompetitions.Visible = true;
                    btn_Events.Visible = true;
                    decoration_ToBtnEvents.Visible = true;
                    break;
            }
        }
        private void Load_UserLoggedData()
        {
            lbl_FullName.Text = UsuarioLogIn.Instance.Usuario.Usu_ApellidoNombre;
            lbl_ID.Text = $"ID: {UsuarioLogIn.Instance.Usuario.Usu_ID.ToString()}";
            //lbl_Rol.Text = Necesitamos un service para traer el nombre del rol apartir del ID
        }
        private void btn_Users_Click(object sender, EventArgs e)
        {
            pnl_SubMenuUsers.Visible = !pnl_SubMenuUsers.Visible;
        }

        private void btn_CreateUser_Click(object sender, EventArgs e)
        {
            pnl_SubMenuUsers.Visible = false;
            OpenFormChild(new frmCreateUsuario());
        }

        private void btn_ListUsers_Click(object sender, EventArgs e)
        {
            pnl_SubMenuUsers.Visible = false;
            OpenFormChild(new frmUsuarios());
        }

        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
            pnl_SubMenuUsers.Visible = false;
            OpenFormChild(new frmUpdateUsuario());
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            pnl_SubMenuUsers.Visible = false;
            OpenFormChild(new frmDeleteUsuario());
        }

        private void btn_Competitions_Click(object sender, EventArgs e)
        {
            pnl_SubMenuCompetitions.Visible = !pnl_SubMenuCompetitions.Visible;
        }

        private void btn_CreateCompetition_Click(object sender, EventArgs e)
        {
            pnl_SubMenuCompetitions.Visible = false;
            OpenFormChild(new frmCreateCompetencia());
        }

        private void btn_ListCompetitions_Click(object sender, EventArgs e)
        {
            pnl_SubMenuCompetitions.Visible = false;
            OpenFormChild(new frmCompetencias());
        }

        private void btn_UpdateCompetition_Click(object sender, EventArgs e)
        {
            pnl_SubMenuCompetitions.Visible = false;
            OpenFormChild(new frmUpdateCompetencia());
        }

        private void btn_DeleteCompetition_Click(object sender, EventArgs e)
        {
            pnl_SubMenuCompetitions.Visible = false;
            OpenFormChild(new frmDeleteCompetencia());
        }

        private void btn_Athletes_Click(object sender, EventArgs e)
        {
            pnl_SubMenuAthletes.Visible = !pnl_SubMenuAthletes.Visible;
        }

        private void btn_CreateAthlete_Click(object sender, EventArgs e)
        {
            pnl_SubMenuAthletes.Visible = false;
            OpenFormChild(new frmCreateAtleta("registrar"));
        }

        private void btn_ListAthletes_Click(object sender, EventArgs e)
        {
            pnl_SubMenuAthletes.Visible = false;
            OpenFormChild(new frmAtletas());
        }

        private void btn_UpdateAthlete_Click(object sender, EventArgs e)
        {
            pnl_SubMenuAthletes.Visible = false;
            OpenFormChild(new frmCreateAtleta("modificar"));
        }

        private void btn_DeleteAthlete_Click(object sender, EventArgs e)
        {
            pnl_SubMenuAthletes.Visible = false;
            OpenFormChild(new frmDeleteAtleta());
        }

        private void btn_Events_Click(object sender, EventArgs e)
        {
            pnl_SubMenuEvents.Visible = !pnl_SubMenuEvents.Visible;
        }

        private void btn_CreateEvent_Click(object sender, EventArgs e)
        {

        }

        private void btn_ListEvents_Click(object sender, EventArgs e)
        {

        }

        private void btn_Categories_Click(object sender, EventArgs e)
        {
            pnl_SubMenuCategory.Visible = !pnl_SubMenuCategory.Visible;
        }

        private void btn_CreateCategory_Click(object sender, EventArgs e)
        {
            pnl_SubMenuCategory.Visible = false;
            OpenFormChild(new frmCreateCategoria());
        }

        private void btn_ListCategories_Click(object sender, EventArgs e)
        {
            pnl_SubMenuCategory.Visible = false;
            OpenFormChild(new frmCategorias());
        }

        private void btn_UpdateCategory_Click(object sender, EventArgs e)
        {
            pnl_SubMenuCategory.Visible = false;
            OpenFormChild(new frmUpdateCategoria());
        }

        private void btn_DeleteCategory_Click(object sender, EventArgs e)
        {
            pnl_SubMenuCategory.Visible = false;
            OpenFormChild(new frmDeleteCategoria());
        }

        private void btn_Disciplines_Click(object sender, EventArgs e)
        {
            pnl_SubMenuDiscipline.Visible = !pnl_SubMenuDiscipline.Visible;
        }

        private void btn_CreateDiscipline_Click(object sender, EventArgs e)
        {
            pnl_SubMenuDiscipline.Visible = false;
            OpenFormChild(new frmCreateDisciplina());
        }

        private void btn_ListDisciplines_Click(object sender, EventArgs e)
        {
            pnl_SubMenuDiscipline.Visible = false;
            OpenFormChild(new frmDisciplinas());
        }

        private void btn_UpdateDiscipline_Click(object sender, EventArgs e)
        {
            pnl_SubMenuDiscipline.Visible = false;
            OpenFormChild(new frmUpdateDisciplina());
        }

        private void btn_DeleteDiscipline_Click(object sender, EventArgs e)
        {
            pnl_SubMenuDiscipline.Visible = false;
            OpenFormChild(new frmDeleteDisciplina());
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

        public void OpenFormChild(object formChild)
        {
            if (this.pnl_Container.Controls.Count > 0)
                this.pnl_Container.Controls.RemoveAt(0);
            Form fc = formChild as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.pnl_Container.Controls.Add(fc);
            this.pnl_Container.Tag = fc;
            fc.Show();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás seguro/a que quieres cerrar sesión?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        
    }
}
