using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Evento
    {
        private int eve_ID;
        private int com_ID;
        private int atl_ID;
        private string eve_Estado;
        private System.DateTime eve_HoraIicio;
        private System.DateTime eve_HoraFin;

        public int Eve_ID { get => eve_ID; set => eve_ID = value; }
        public int Com_ID { get => com_ID; set => com_ID = value; }
        public int Atl_ID { get => atl_ID; set => atl_ID = value; }
        public string Eve_Estado { get => eve_Estado; set => eve_Estado = value; }
        public DateTime Eve_HoraIicio { get => eve_HoraIicio; set => eve_HoraIicio = value; }
        public DateTime Eve_HoraFin { get => eve_HoraFin; set => eve_HoraFin = value; }

        public Evento()
        {
        }
        public Evento(int eve_ID, int com_ID, int atl_ID, string eve_Estado, DateTime eve_HoraIicio, DateTime eve_HoraFin)
        {
            this.eve_ID = eve_ID;
            this.com_ID = com_ID;
            this.atl_ID = atl_ID;
            this.eve_Estado = eve_Estado;
            this.eve_HoraIicio = eve_HoraIicio;
            this.eve_HoraFin = eve_HoraFin;
        }
    }
}