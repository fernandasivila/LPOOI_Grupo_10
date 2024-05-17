using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_ID;
        private string usu_NombreUsuario;
        private string usu_Contrasenia;
        private string usu_ApellidoNombre;
        private int rol_Codigo;

        public int Usu_ID { get => usu_ID; set => usu_ID = value; }
        public string Usu_NombreUsuario { get => usu_NombreUsuario; set => usu_NombreUsuario = value; }
        public string Usu_Contrasenia { get => usu_Contrasenia; set => usu_Contrasenia = value; }
        public string Usu_ApellidoNombre { get => usu_ApellidoNombre; set => usu_ApellidoNombre = value; }
        public int Rol_Codigo { get => rol_Codigo; set => rol_Codigo = value; }

        public Usuario()
        {
        }
        public Usuario(int usu_ID, string usu_NombreUsuario, string usu_Contrasenia, string usu_ApellidoNombre, int rol_Codigo)
        {
            this.usu_ID = usu_ID;
            this.usu_NombreUsuario = usu_NombreUsuario;
            this.usu_Contrasenia = usu_Contrasenia;
            this.usu_ApellidoNombre = usu_ApellidoNombre;
            this.rol_Codigo = rol_Codigo;
        }
    }
}