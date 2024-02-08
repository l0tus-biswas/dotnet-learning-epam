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
    public partial class ViewLatestTransactionOfUser : Form
    {
        private int customerId;

        private string customerName;
        private string customerEmail;

        public ViewLatestTransactionOfUser(int customerId, string customerEmail, string customerName)
        {
            InitializeComponent();
            this.customerId = customerId;
            this.customerEmail = customerEmail;
            this.customerName = customerName;
        }

        private void ViewLatestTransactionOfUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMartDBDataSet1.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.eMartDBDataSet1.Invoices);
            textBox1.Text = this.customerName;
            textBox2.Text = this.customerEmail;

            // Iterate through the rows of the DataGridView in reverse order
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];

                // Assuming the condition is based on a specific column value
                int cellValue = Convert.ToInt32(row.Cells[1].Value);

                // Check if the cell value matches the condition
                if (cellValue != customerId)
                {
                    // If the condition is not met, remove the row
                    dataGridView1.Rows.RemoveAt(i);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int invoiceId = 0;
;           string invoiceDate = "";
            decimal totalAmount =0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Assuming you want to retrieve data from specific cells (e.g., cells in the first and second column)
                invoiceId = Convert.ToInt32(selectedRow.Cells[0].Value); // Value from the first column
                invoiceDate = Convert.ToString(selectedRow.Cells[2].Value);
                totalAmount = Convert.ToDecimal(selectedRow.Cells[3].Value);
                // You can retrieve values from other columns in a similar way
            }
            ShowDetailedInvoiceItems sdit = new ShowDetailedInvoiceItems(invoiceId, invoiceDate, totalAmount, customerName);
            sdit.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }
    }
}
