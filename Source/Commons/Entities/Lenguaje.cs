using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Commons.Entities
{
    public class Lenguaje
    {
        [Key]
        public int ID { get; set; }

        public string IsoCode { get; set; }

        public string Descripcion { get; set; }

        public virtual ICollection<Cultura> Culturas { get; set; }
    }
}