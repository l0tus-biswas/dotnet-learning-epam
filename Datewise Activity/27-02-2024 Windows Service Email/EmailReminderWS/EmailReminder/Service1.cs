using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmailReminder
{
    public partial class Service1 : ServiceBase
    {
        public Timer ScheduleTimer;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Thread startThread = new Thread(new ThreadStart(ScheduleService));
            startThread.Start();
        }

        public void ScheduleService()
        {
            try
            {
                ScheduleTimer = new Timer(new TimerCallback(SendMail));
                DateTime scheduleTime = DateTime.MinValue;
                scheduleTime = DateTime.Parse("12:50 PM");
                if (DateTime.Now > scheduleTime)
                    scheduleTime = scheduleTime.AddMinutes(5);
                TimeSpan timeSpan = scheduleTime.Subtract(DateTime.Now);
                int dueMilli = Convert.ToInt32(timeSpan.TotalMilliseconds);
                ScheduleTimer.Change(dueMilli, Timeout.Infinite);
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex);
            }
        }

        public static void WriteErrorLog(Exception ex)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + ex.Source.ToString().Trim() + "; " + ex.Message.ToString().Trim());
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }

        public void SendMail(object e)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("lotushotmail111@gmail.com");
                    mail.To.Add("lotus_biswas@epam.com");
                    mail.Subject = "Hello Service";
                    mail.Body = "Hello Service";
                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("lotushotmail111@gmail.com", "tnwkvispsqjnnycd");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        WriteErrorLog("Mail Sent " + DateTime.Now);
                    }
                    this.ScheduleService();
                }
            }
            catch (Exception ex)
            {
                WriteErrorLog(ex);
            }
        }
        public static void WriteErrorLog(string Message)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + Message);
                sw.Flush();
                sw.Close();
            }
            catch
            {
            }
        }

        protected override void OnStop()
        {
            ScheduleTimer.Dispose();
        }
    }
}
