using System.ComponentModel.DataAnnotations;

namespace Commons.Entities
{
    public class Cultura
    {
        [Key]
        public int ID { get; set; }

        public string Descripcion { get; set; }

        public virtual int LenguajeID { get; set; }

        public virtual Lenguaje Lenguaje { get; set; }
    }
}