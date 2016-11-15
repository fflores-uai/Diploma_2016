namespace Commons.Entities
{
    public class Telefono
    {
        public int ID { get; set; }
        public string Numero { get; set; }

        public int TipoID { get; set; }
        
        public TelefonoTipo Tipo { get; set; }
    }
}