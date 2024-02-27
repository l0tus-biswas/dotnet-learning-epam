using Quartz;
using System;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace QuartzImpleEG
{
    public class PrintJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("lotushotmail111@gmail.com");
                    mail.To.Add("biswamohan_dwari@epam.com");

                    mail.Subject = "Hello this is a automted email";
                    mail.Body = "Triggering after every 10 secs.";
                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("lotushotmail111@gmail.com", "tnwkvispsqjnnycd");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }

                    Console.WriteLine($"[{DateTime.Now}] Email sent!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception " + ex);
            }

            
            return Task.CompletedTask;
        }

      

    }
}