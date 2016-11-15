using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Entities
{
    public class TicketDetalle
    {
        public int ID { get; set; }

        public int TicketID { get; set; }

        public Ticket Ticket { get; set; }

    }
}
