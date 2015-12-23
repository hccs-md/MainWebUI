using Microsoft.AspNet.Identity;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Hccs.WebApp.Data
{
    public static class GmailService
    {

        public static async Task SendMail(IdentityMessage msg)
        {
            string FROM = ConfigurationManager.AppSettings["Gmail.Account"];
            string PWD = ConfigurationManager.AppSettings["Gmail.Secrete"];
            int port = int.Parse(ConfigurationManager.AppSettings["Gmail.Port"]);

            using(SmtpClient smtp = new SmtpClient{
                Host = "smtp.gmail.com",
                Port = port,
                EnableSsl = true, 
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(FROM, PWD)
            })
            {
                await smtp.SendMailAsync(FROM, msg.Destination, msg.Subject, msg.Body);
            }
        }
    }
}