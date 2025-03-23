using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BackendCS
{
    public interface NotificationMethod
    {

    }

    class SMS : NotificationMethod
    {
        public static void Send(string number, string message)
        {
            string mail = "smarthealthjewelry@gmail.com";
            string pw = "dvnz ufel zien mfvo";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(mail, pw),
                EnableSsl = true,
            };

            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress(mail),
                Body = message
            };

            // accepting format "+49176......"
            mailMessage.To.Add(number + "@t-d1-sms.de");

            smtpClient.Send(mailMessage);


            Console.WriteLine("sending was successful");
        }
    }

    public class Email : NotificationMethod
    {
        public static void Send(string email, string subject, string message)
        {
            string mail = "smarthealthjewelry@gmail.com";
            string pw = "dvnz ufel zien mfvo";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(mail, pw),
                EnableSsl = true,
            };

            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress(mail),
                Subject = subject,
                Body = message
            };
            try
            {
                mailMessage.To.Add(email);
                smtpClient.Send(mailMessage);
            }
            catch (FormatException)
            {
            }
            

            


            Console.WriteLine("sending was successful");

        }

        static void Main(string[] args)
        {

            //Email.Send("eduard.wegele1511@gmail.com", "Warning", "Patient Life is in danger");
            SMS.Send("+4917630548044", "Patient Life is in Danger");
        }
    }
}
