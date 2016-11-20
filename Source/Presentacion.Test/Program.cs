using System;

namespace Presentacion.Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TestMailEnvio();
        }

        private static void TestMailEnvio()
        {
            var result = Servicios.Correo.Mailer.Enviar(
                subject: "Mails Test",
                body: "<p>Hola<p>",
                from: "francisco.floresfanelli@gmail.com",
                to: "pachu.flores@gmail.com",
                isHtml: true);

            Console.WriteLine(result);
        }
    }
}