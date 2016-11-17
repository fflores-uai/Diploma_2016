using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Commons.Entities
{
    public class EmpleadoPerfil
    {
        [Key]
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Documento { get; set; }

        [EmailAddress]
        public string EmailPersonal { get; set; }

        public List<Telefono> Telefonos { get; set; }
    }
}