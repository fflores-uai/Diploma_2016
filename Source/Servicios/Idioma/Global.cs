using System.Collections.Generic;
using System.Linq;

namespace Servicios.Idioma
{
    public static class Global
    {
        public static Dictionary<string, string> Recursos { get; set; }

        public static void ActualizarRecursos(List<Commons.Entities.Recursos> lista)
        {
            Recursos = lista.ToDictionary(key => key.Clave, value => value.Valor);
        }

        public static string Traducir(this string key)
        {
            string value;
            return Recursos.TryGetValue(key, out value) ? value : key;
        }

        public static string AsTitle(this string value)
        {
            return string.Format("{0}_Title", value);
        }
    }
}