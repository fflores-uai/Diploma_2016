using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Entities
{
    public class TecnicoTipo
    {
        public enum Options
        {
            HelpDesk = 1,
            Campo = 2,
            Infraestructura = 3
        }

        public int ID { get; set; }
        public string Descripcion { get; set; }
    }
}
