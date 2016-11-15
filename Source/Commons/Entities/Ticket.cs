using System.ComponentModel.DataAnnotations;
namespace Commons.Entities
{
    public class Ticket
    {
        [Key]
        public int ID { get; set; }

        public int EstadoID { get; set; }

        public int TipoID { get; set; }


        public virtual TicketTipo Tipo { get; set; }

        public virtual TicketEstado Estado { get; set; }
    }
}