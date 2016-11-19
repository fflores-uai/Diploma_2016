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
            string from)
        {
            var destino = new MailAddress(to);
            var origen = new MailAddress(from);

            var mail = new MailMessage(origen, destino)
            {
                Subject = subject,
                Body = body,
                BodyEncoding = UTF8Encoding.UTF8,
                Priority = MailPriority.Normal,
                IsBodyHtml = false,
                DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure,
            };

            SmtpClient smtpGmail = new SmtpClient()
            {
                Port = 587,
                Host = "smtp.gmail.com",
                Credentials = new NetworkCredential("correossmtp2016@gmail.com", "Novedad.01"),
                EnableSsl = true,
                UseDefaultCredentials = false,
                DeliveryMethod  = SmtpDeliveryMethod.Network
            };

            try
            {
                smtpGmail.Send(mail);
                return "OK";
            }
            catch (System.Exception ex)
            {
                smtpGmail.Dispose();
                return string.Format("ERROR : {0}", ex);
            }
        }
    }
}