using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Competencia
    {
        private int com_ID;
        private string com_Nombre;
        private string com_Descripcion;
        private DateTime com_FechaInicio;
        private DateTime com_FechaFin;
        private string com_Estado;
        private string com_Organizador;
        private string com_Ubicacion;
        private string com_Sponsors;
        private int cat_ID;
        private int dis_ID;

        public int Com_ID { get => com_ID; set => com_ID = value; }
        public string Com_Nombre { get => com_Nombre; set => com_Nombre = value; }
        public string Com_Descripcion { get => com_Descripcion; set => com_Descripcion = value; }
        public DateTime Com_FechaInicio { get => com_FechaInicio; set => com_FechaInicio = value; }
        public DateTime Com_FechaFin { get => com_FechaFin; set => com_FechaFin = value; }
        public string Com_Estado { get => com_Estado; set => com_Estado = value; }
        public string Com_Organizador { get => com_Organizador; set => com_Organizador = value; }
        public string Com_Ubicacion { get => com_Ubicacion; set => com_Ubicacion = value; }
        public string Com_Sponsors { get => com_Sponsors; set => com_Sponsors = value; }
        public int Cat_ID { get => cat_ID; set => cat_ID = value; }
        public int Dis_ID { get => dis_ID; set => dis_ID = value; }
    }
}