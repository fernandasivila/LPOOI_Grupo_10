﻿using ClasesBase;
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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            dgvListaCategorias.DataSource = TrabajoCategoria.ObtenerCategorias();

            dgvListaCategorias.Columns["Cat_ID"].HeaderText = "ID";
            dgvListaCategorias.Columns["Cat_Nombre"].HeaderText = "Nombre";
            dgvListaCategorias.Columns["Cat_Descripcion"].HeaderText = "Descripcion";
        }
    }
}
