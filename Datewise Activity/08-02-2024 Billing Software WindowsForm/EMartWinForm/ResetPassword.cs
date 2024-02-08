using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace EMartWinForm
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = "data source=EPINHYDW0B0F\\SQLEXPRESS;initial catalog=WordVoyager;Integrated Security=True";

            Random random = new Random();
            int randNum = random.Next(65525, 122222);

            string emailAdressVal = textBox1.Text;

            MailAddress to = new MailAddress(emailAdressVal);
            MailAddress from = new MailAddress("lotushotmail111@gmail.com");

            MailMessage email = new MailMessage(from, to);

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("lotushotmail111@gmail.com", "rspc fohb yefs hyrf");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;

            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "UPDATE [dbo].[User] SET PasswordHash = @PasswordHash WHERE Email = @Email";
                cmd.Parameters.AddWithValue("@PasswordHash", randNum);
                cmd.Parameters.AddWithValue("@Email", emailAdressVal);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    email.Subject = "Your password was reset";
                    email.Body = "Your new password is " + randNum + ". Please try to login again with this password.";
                    smtpClient.Send(email);
                    label2.Text = "Email was sent successfully! Please check and login again with the provided password.";
                    Console.WriteLine("Update successfully done");
                }
                else
                {
                    Console.WriteLine("Failed to update");
                }
            }
            catch (Exception ex)
            {
                label2.Text = ex.Message;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
