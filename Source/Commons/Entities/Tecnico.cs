using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Entities
{
    public class Tecnico
    {
        public int ID { get; set; }

        public int TipoID { get; set; }

        public virtual TecnicoTipo Tipo { get; set; }
    }
}
