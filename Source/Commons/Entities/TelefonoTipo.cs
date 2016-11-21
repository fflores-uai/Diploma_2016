namespace Commons.Entities
{
    public class TelefonoTipo
    {

        public enum Options
        { 
            Oficina = 1,
            Personal = 2,
            Celular = 3
        }

        public int ID { get; set; }
        public string Descripcion { get; set; }
    }
}