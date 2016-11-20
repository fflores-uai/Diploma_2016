using System.Net;
using System.Net.Mail;
using System.Text;

namespace Servicios.Correo
{
    public static class Mailer
    {
        public static string Enviar(
            string body,
            string subject,
            string to,
            string from,
            bool isHtml = false)
        {
            var destino = new MailAddress(to);
            var origen = new MailAddress(from);
            var credentials = new NetworkCredential("correossmtp2016@gmail.com", "Novedad.01");

            using (MailMessage mail = new MailMessage())
            {
                mail.From = origen;
                mail.To.Add(destino);
                mail.Subject = subject;
                mail.Body = body;
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.Priority = MailPriority.Normal;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                mail.IsBodyHtml = isHtml;

                using (var client = new SmtpClient())
                {
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.Credentials = credentials;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;

                    try
                    {
                        client.Send(mail);
                        return "Email Sent";
                    }
                    catch (System.Exception ex)
                    {
                        client.Dispose();
                        return string.Format("ERROR : {0}", ex);
                    }
                }
            }
            ;
        }
    }
}