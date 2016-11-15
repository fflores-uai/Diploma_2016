using System.Collections.Generic;

namespace Commons.Entities
{
    public class EmpleadoPerfil
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public List<Telefono> Telefonos { get; set; }
    }
}