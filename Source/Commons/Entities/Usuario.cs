using System;

namespace Commons.Entities
{
    public class Usuario
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Clave { get; set; }

        public int EmpleadoID { get; set; }

        public string Email { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        public virtual Empleado Empleado { get; set; }
    }
}