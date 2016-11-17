namespace Commons.Entities
{
    public class Empleado
    {
        public int ID { get; set; }

        public int CompaniaID { get; set; }

        public Compania Compania { get; set; }

        public EmpleadoPerfil Perfil { get; set; }

    }
}