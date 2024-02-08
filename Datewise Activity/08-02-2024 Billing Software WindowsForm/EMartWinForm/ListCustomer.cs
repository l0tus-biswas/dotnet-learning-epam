using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMartWinForm
{
    public partial class ListCustomer : Form
    {
        public ListCustomer()
        {
            InitializeComponent();
        }

        private void ListCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMartDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.eMartDBDataSet.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int customerId = 0;
            string customerName = "";
            string customerEmail = "";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Assuming you want to retrieve data from specific cells (e.g., cells in the first and second column)
                customerId = Convert.ToInt32(selectedRow.Cells[0].Value); // Value from the first column
                customerName = Convert.ToString(selectedRow.Cells[1].Value);
                customerEmail = Convert.ToString(selectedRow.Cells[2].Value);
                // You can retrieve values from other columns in a similar way
            }

            ViewLatestTransactionOfUser vltu = new ViewLatestTransactionOfUser(customerId, customerEmail, customerName);
            vltu.Show();
            this.Hide();
        }
    }
}
