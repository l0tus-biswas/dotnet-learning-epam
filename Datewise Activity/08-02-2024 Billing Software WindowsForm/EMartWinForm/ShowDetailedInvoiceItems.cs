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
    public partial class ShowDetailedInvoiceItems : Form
    {
        private int invoiceId;
        private string invoiceDate;
        private decimal totalAmount;
        private string customerName;
        public ShowDetailedInvoiceItems(int invoiceId, string invoiceDate, decimal totalAmount, string customerName)
        {
            InitializeComponent();
            this.invoiceId = invoiceId;
            this.invoiceDate = invoiceDate;
            this.totalAmount = totalAmount;
            this.customerName = customerName;
        }

        private void ShowDetailedInvoiceItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMartDBDataSet2.InvoiceItems' table. You can move, or remove it, as needed.
            this.invoiceItemsTableAdapter.Fill(this.eMartDBDataSet2.InvoiceItems);
            textBox1.Text = Convert.ToString(customerName);
            textBox2.Text = Convert.ToString(invoiceId);
            textBox3.Text = Convert.ToString(invoiceDate);
            textBox4.Text = Convert.ToString(totalAmount);

            // Iterate through the rows of the DataGridView in reverse order
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];

                // Assuming the condition is based on a specific column value
                int cellValue = Convert.ToInt32(row.Cells[0].Value);

                // Check if the cell value matches the condition
                if (cellValue != invoiceId)
                {
                    // If the condition is not met, remove the row
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
