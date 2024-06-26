using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class frmCreateAtleta : Form
    {
        private string accion;
        public frmCreateAtleta(string accion)
        {
            this.accion = accion;
            InitializeComponent();
        }

        private void frmAltaAtleta_Load(object sender, EventArgs e)
        {
            if (this.accion == "registrar")
            {
                btnRegistrar.Text = "REGISTRAR";
                lblTitulo.Text = "NUEVO ATLETA";
                txtID.Visible = false;
                btnObtener.Visible = false;
                lblID.Visible = false;
            }
            if (this.accion == "modificar")
            {
                btnRegistrar.Text = "ACTUALIZAR";
                lblTitulo.Text = "MODIFICAR ATLETA";
                
            }
            /*if (this.accion == "borrar")
            {
                btnRegistrar.Text = "Borrar Atleta";
                btnObtener.Visible = false;
                this.ClientSize = new System.Drawing.Size(550, 595);
                txtDNI.Visible = false;
                lblDNI.Visible = false;
                txtApellido.Visible = false;
                lblApellido.Visible = false;
                txtNombre.Visible = false;
                lblNombre.Visible = false;
                txtNacionalidad.Visible = false;
                lblNacionalidad.Visible = false;
                txtEntrenador.Visible = false;
                lblEntrenador.Visible = false;
                cmbGenero.Visible = false;
                lblGenero.Visible = false;
                txtAltura.Visible = false;
                lblAltura.Visible = false;
                txtPeso.Visible = false;
                lblPeso.Visible = false;
                dtpFechaNacimiento.Visible = false;
                lblFechaNacimiento.Visible = false;
                txtDireccion.Visible = false;
                lblDireccion.Visible = false;
                txtCorreoElectronico.Visible = false;
                lblCorreoElectronico.Visible = false;
            }*/
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (this.accion == "registrar")
            {
                if (!validarCampos())
                {
                    MessageBox.Show("Ningun campo puede estar vacio", "Campos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        Atleta oAtleta = new Atleta(0, txtDNI.Text, txtApellido.Text
                        , txtNombre.Text, txtNacionalidad.Text, txtEntrenador.Text
                        , char.Parse(cmbGenero.Text), double.Parse(txtAltura.Text),
                        double.Parse(txtPeso.Text), dtpFechaNacimiento.Value, txtDireccion.Text
                        , txtCorreoElectronico.Text);

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

                        TrabajoAtleta.agregarAtleta(oAtleta);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Error al convertir datos numéricos: " + ex.Message, "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (this.accion == "modificar")
            {
                if (!validarCampos() || !string.IsNullOrWhiteSpace(txtID.Text))
                {
                    if (TrabajoAtleta.obtenerAtletaById(Int32.Parse(txtID.Text)) != null)
                    {
                        Atleta oAtleta = new Atleta(Int32.Parse(txtID.Text), txtDNI.Text, txtApellido.Text
                        , txtNombre.Text, txtNacionalidad.Text, txtEntrenador.Text
                        , char.Parse(cmbGenero.Text), double.Parse(txtAltura.Text),
                        double.Parse(txtPeso.Text), dtpFechaNacimiento.Value, txtDireccion.Text
                        , txtCorreoElectronico.Text);
                        TrabajoAtleta.ModificarAtleta(oAtleta);
                        MessageBox.Show("Atleta Modificado!");
                    }
                    else
                    {
                        MessageBox.Show("El Atleta No Existe", "Objeto No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ningun campo puede estar vacio", "Campos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (this.accion == "borrar")
            {
                if (!string.IsNullOrWhiteSpace(txtID.Text))
                {
                    if (TrabajoAtleta.obtenerAtletaById(Int32.Parse(txtID.Text)) != null)
                    {
                        TrabajoAtleta.borrarAtleta(Int32.Parse(txtID.Text));
                        MessageBox.Show("Atleta Borrado!");
                    }
                    else
                    {
                        MessageBox.Show("El Atleta No Existe", "Objeto No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ningun campo puede estar vacio", "Campos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        
        private void btnObtener_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtID.Text))
            {
                Atleta oAtleta = TrabajoAtleta.obtenerAtletaById(Int32.Parse(txtID.Text));
                if (oAtleta != null)
                {
                    txtID.Text = oAtleta.Atl_ID.ToString();
                    txtDNI.Text = oAtleta.Atl_DNI.ToString();
                    txtApellido.Text = oAtleta.Atl_Apellido.ToString();
                    txtNombre.Text = oAtleta.Atl_Nombre.ToString();
                    txtNacionalidad.Text = oAtleta.Atl_Nacionalidad.ToString();
                    txtEntrenador.Text = oAtleta.Atl_Entrenador.ToString();
                    cmbGenero.Text = oAtleta.Atl_Genero.ToString();
                    txtAltura.Text = oAtleta.Atl_Altura.ToString();
                    txtPeso.Text = oAtleta.Atl_Peso.ToString();
                    dtpFechaNacimiento.Text = oAtleta.Atl_FechaNac.ToString();
                    txtDireccion.Text = oAtleta.Atl_Direccion.ToString();
                    txtCorreoElectronico.Text = oAtleta.Atl_Email.ToString();
                }
                else
                {
                    MessageBox.Show("El Atleta No Existe", "Objeto No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Campo de ID vacio", "Campos Obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
