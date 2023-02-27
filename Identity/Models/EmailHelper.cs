using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Hosting.Server;
using System.Net.Mail;
using System.Net.Sockets;

namespace Identity.Models
{
    public class EmailHelper
    {
        

        public bool SendEmailTwoFactorCode(string userEmail, string code)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("rohitchawla119@gmail.com");
            mailMessage.To.Add(new MailAddress(userEmail));

            mailMessage.Subject = "Two Factor Code";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = code;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("rohitchawla119@gmail.com", "fdrqcsusujfglyvv");
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            //SSL(Secure Sockets Layer) is a transaction security standard that provides
            //encrypted protection between browsers and App Servers.
            client.Port = 25;

            try
            {
                client.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("wrong OTP");
            }
            return false;
        }
    }
}