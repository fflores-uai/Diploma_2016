using System;
namespace Presentacion.Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var result = Servicios.Correo.Mailer.Enviar(
                subject: "test",
                body: "subject Test",
                from: "correossmtp2016@gmail.com",
                to: "pachu.flores@gmail.com");

            Console.WriteLine(result);
            Console.Read();
        }
    }
}