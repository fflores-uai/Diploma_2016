using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Entities
{
    public class TicketEstado
    {

        public enum Options
        {
            Borrador = 1,
            Pendiente = 2,
            EnProceso = 3,
            Finalizado = 4
        }

        public int ID { get; set; }
        public string Descripcion { get; set; }
    }
}
