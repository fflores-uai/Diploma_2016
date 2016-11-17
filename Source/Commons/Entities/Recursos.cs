namespace Commons.Entities
{
    public class Recursos
    {
        public string Clave { get; set; }
        public int LenguageID { get; set; }
        public string Valor { get; set; }

        public Lenguaje Lenguage { get; set; }
    }
}