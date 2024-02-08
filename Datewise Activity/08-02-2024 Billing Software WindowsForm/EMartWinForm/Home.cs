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

namespace EMartWinForm
{
    public partial class Home : Form
    {
        string cs = "data source=EPINHYDW0B0F\\SQLEXPRESS;initial catalog=EMartDB;Integrated Security=True";

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wordVoyagerDataSet.User' table. You can move, or remove it, as needed.

            label2.Text = "Current Date : " +  DateTime.Now.ToString("dd MMMM yyyy");

            DisplayTodaysEarnings();
            DisplayTotalEarnings();
        }

        private void DisplayTodaysEarnings()
        {
            DateTime today = DateTime.Today;

            decimal todaysEarnings = 0;

            using (SqlConnection connection = new SqlConnection(cs))
            {
                string query = "SELECT SUM(TotalAmount) FROM Invoices WHERE CONVERT(date, InvoiceDate) = @Today";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Today", today);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    todaysEarnings = Convert.ToDecimal(result);
                }
            }

            label6.Text = $"{todaysEarnings:C}";
        }

        private void DisplayTotalEarnings()
        {
            decimal totalEarnings = 0;

            using (SqlConnection connection = new SqlConnection(cs))
            {
                string query = "SELECT SUM(TotalAmount) FROM Invoices";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    totalEarnings = Convert.ToDecimal(result);
                }
            }

           label5.Text = $"{totalEarnings:C}";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewPurchase np = new NewPurchase();
            np.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListCustomer lc = new ListCustomer();
            lc.Show();
        }
    }
}
