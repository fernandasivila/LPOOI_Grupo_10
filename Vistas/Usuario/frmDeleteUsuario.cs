﻿using System;
using ClasesBase;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class frmDeleteUsuario : Form
    {
        public frmDeleteUsuario()
        {
            InitializeComponent();
        }

        private void btnBorrarUsuario_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombre.Text;

            if (TrabajoUsuario.comprobarDisponibilidadNombre(nombreUsuario))
            {
                MessageBox.Show($"El nombre de usuario {nombreUsuario} no existe", "Nombre no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                TrabajoUsuario.delete_user(nombreUsuario);
                MessageBox.Show("Usuario eliminado con exito");
            }
        }
    }
}
