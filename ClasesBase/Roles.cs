using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Roles
    {
        private int rol_Codigo;
        private string rol_Descripcion;

        public int Rol_Codigo { get => rol_Codigo; set => rol_Codigo = value; }
        public string Rol_Descripcion { get => rol_Descripcion; set => rol_Descripcion = value; }

        public Roles()
        {
        }
        public Roles(int rol_Codigo, string rol_Descripcion)
        {
            this.rol_Codigo = rol_Codigo;
            this.rol_Descripcion = rol_Descripcion;
        }
    }
}