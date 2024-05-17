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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
