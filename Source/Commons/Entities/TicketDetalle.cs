using System;
namespace Commons.Entities
{
    public class TicketDetalle
    {
        public int ID { get; set; }

        public int TicketID { get; set; }

        public int TecnicoID { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaActualizacion { get; set; }


        public Tecnico Tecnico { get; set; }

        public Ticket Ticket { get; set; }
    }
}