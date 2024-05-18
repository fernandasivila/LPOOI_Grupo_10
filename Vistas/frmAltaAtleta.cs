using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesBase;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Vistas
{
    public partial class frmAltaAtleta : Form
    {
        public frmAltaAtleta()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!validarCampos()){
                MessageBox.Show("Ningun campo puede estar vacio", "Campos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Atleta oAtleta = new Atleta(1,txtDNI.Text,txtApellido.Text
                    ,txtNombre.Text, txtNacionalidad.Text, txtEntrenador.Text
                    ,char.Parse(cmbGenero.Text), double.Parse(txtAltura.Text),
                    double.Parse(txtPeso.Text),dtpFechaNacimiento.Value,txtDireccion.Text
                    ,txtCorreoElectronico.Text);

                    MessageBox.Show("OBJETO GUARDADO:\n"
                    + "Dni: " + oAtleta.Atl_DNI + "\n"
                    + "Nombre: " + oAtleta.Atl_Nombre + "\n"
                    + "Apellido: " + oAtleta.Atl_Apellido + "\n"
                    + "Nacionalidad: " + oAtleta.Atl_Nacionalidad + "\n"
                    + "Entrenador: " + oAtleta.Atl_Entrenador + "\n"
                    + "Genero: " + oAtleta.Atl_Genero + "\n"
                    + "Altura: " + oAtleta.Atl_Altura + "\n"
                    + "Peso: " + oAtleta.Atl_Peso + "\n"
                    + "FechaNacimiento: " + oAtleta.Atl_FechaNac + "\n"
                    + "Direccion: " + oAtleta.Atl_Direccion + "\n"
                    + "CorreoElectronico: " + oAtleta.Atl_Email);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error al convertir datos numéricos: " + ex.Message, "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        public bool validarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtNacionalidad.Text) ||
                string.IsNullOrWhiteSpace(txtEntrenador.Text) ||
                string.IsNullOrWhiteSpace(cmbGenero.Text) ||
                string.IsNullOrWhiteSpace(txtAltura.Text) ||
                string.IsNullOrWhiteSpace(txtPeso.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtCorreoElectronico.Text))
            {
                return false;
            }

            return true;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
