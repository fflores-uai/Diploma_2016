using System.ComponentModel.DataAnnotations;

namespace Commons.Entities
{
    public class Pais
    {
        [Key]
        public int ID { get; set; }

        public string Descripcion { get; set; }

        public string IsoCode { get; set; }
    }
}