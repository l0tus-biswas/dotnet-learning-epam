using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace EMartWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            string cs = "data source=EPINHYDW0B0F\\SQLEXPRESS;initial catalog=EMartDB;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[Admins] WHERE Email = @Email AND PasswordHash = @Password", con))
                    {
                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        // Execute the command
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            // Login successful
                            this.Hide();

                            Home hm = new Home();
                            hm.Show();
                        }
                        else
                        {
                            // Login failed
                            label3.Text = "FAILED";

                            // Do something else if needed
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*ResetPassword rp = new ResetPassword();
            rp.Show();
            this.Hide();*/


            ListCustomer lc = new ListCustomer();
            lc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* this.Hide();
             CreateNewAccount cna = new CreateNewAccount();
             cna = new CreateNewAccount();*/
            /*
                        NewPurchase np = new NewPurchase();
                        np.Show();*/

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
