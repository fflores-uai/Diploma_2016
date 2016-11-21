using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Entities
{
    public class TicketTipo
    {

        public enum Options
        {
            Local = 1,
            Redes = 2,
            Infraestructura = 3,
            Seguridad = 4
        }

        public int ID { get; set; }

        public string Descripcion { get; set; }

    }
}
