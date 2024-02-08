using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMartWinForm
{
    public partial class NewPurchase : Form
    {
        public string cs = "data source=EPINHYDW0B0F\\SQLEXPRESS;initial catalog=EMartDB;Integrated Security=True";

        public NewPurchase()
        {
            InitializeComponent();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewPurchase_Load(object sender, EventArgs e)
        {
           

            // Adding to item quantity
            comboBox2.Items.Add(1);
            comboBox2.Items.Add(2);
            comboBox2.Items.Add(3);
            comboBox2.Items.Add(4);
            comboBox2.Items.Add(5);


            SqlConnection con = null;
            try
            {

                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT Name FROM Products";

                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.HasRows) {
                        while(reader.Read())
                        {
                            string productName = reader.GetString(0);
                            comboBox1.Items.Add(productName);
                        }
                    }
                }   
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally{
                con.Close();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if a product and quantity are selected
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a product and quantity.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve selected product name and quantity
            string selectedProductName = comboBox1.SelectedItem.ToString();
            int selectedItemQuantity = Convert.ToInt32(comboBox2.SelectedItem);

            // Retrieve product details
            decimal productGST = GetProductGSTByName(selectedProductName);
            decimal productPrice = GetProductPriceByName(selectedProductName);

            // Calculate total amount with GST
            decimal totalAmountWithGST = CalculateTotalAmountWithGST(productPrice, productGST, selectedItemQuantity);

            // Assuming you have data to add to the DataGridView, for example:
            string[] rowData = new string[] { selectedProductName, selectedItemQuantity.ToString(), productPrice.ToString(), productGST.ToString(), totalAmountWithGST.ToString() };

            // Add the row to the DataGridView
            dataGridView1.Rows.Add(rowData);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Retrieve customer details
            string customerName = textBox1.Text;
            string customerEmail = textBox3.Text;

            // Check if customer already exists
            int customerId = CheckCustomerExists(customerEmail);
            if (customerId == -1)
            {
                // Create new customer
                customerId = CreateNewCustomer(customerName, customerEmail);
            }

            // Loop through DataGridView rows
            decimal totalInvoiceAmount = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow) // Skip the new row if it's being edited
                {
                    // Retrieve product details from DataGridView
                    string productName = row.Cells[0].Value.ToString(); // Assuming product name is in the first cell
                    int quantity = Convert.ToInt32(row.Cells[1].Value); // Assuming quantity is in the second cell

                    // Retrieve product details from database
                    int productId = GetProductIdByName(productName);
                    decimal productGST = GetProductGSTByName(productName);

                    // Calculate total amount for this product
                    decimal totalAmount = CalculateTotalAmount(productId, quantity, productGST);
                   
                    // Add total amount to the invoice total
                    totalInvoiceAmount += totalAmount;
                }
            }
           int gettingInvoiceId =  CreateNewInvoice(customerId,totalInvoiceAmount); // Assuming productId and quantity are not needed for the invoice


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow) // Skip the new row if it's being edited
                {
                    decimal newtotalInvoiceAmount = 0;
                    // Retrieve product details from DataGridView
                    string productName = row.Cells[0].Value.ToString(); // Assuming product name is in the first cell
                    int quantity = Convert.ToInt32(row.Cells[1].Value); // Assuming quantity is in the second cell

                    // Retrieve product details from database
                    int productId = GetProductIdByName(productName);
                    decimal productGST = GetProductGSTByName(productName);

                    // Calculate total amount for this product
                    decimal totalAmount = CalculateTotalAmount(productId, quantity, productGST);

                    // Add total amount to the invoice total
                    newtotalInvoiceAmount += totalAmount;


                    CreateNewInvoiceForEachItem(gettingInvoiceId, productId, quantity, newtotalInvoiceAmount);
                }
            }


            // Create new invoice

            MessageBox.Show("Invoice created successfully.");

            sendReceipt(customerEmail, totalInvoiceAmount);

            OncompletePurchase ocp = new OncompletePurchase();

            ocp.Show();
            this.Hide();

        }

        private void sendReceipt(string customerEmail, decimal totalInvoiceAmount)
        {

            StringBuilder emailBody = new StringBuilder();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row != null && !row.IsNewRow)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[3].Value != null)
                    {
                         emailBody.AppendLine($"Item Name: {row.Cells[0].Value.ToString()}, Item Quantity: {row.Cells[1].Value.ToString()}, Product Price: {row.Cells[2].Value.ToString()}, Product Price: {row.Cells[1].Value.ToString()}, Product With GST: {row.Cells[4].Value.ToString()}");
                    }
                    else
                    {
                        MessageBox.Show("One or more cell values are null.");
                    }
                }
            }

            string emailAdressVal = textBox1.Text;

            MailAddress to = new MailAddress(customerEmail);
            MailAddress from = new MailAddress("lotushotmail111@gmail.com");

            MailMessage email = new MailMessage(from, to);

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.Credentials = new NetworkCredential("lotushotmail111@gmail.com", "rspc fohb yefs hyrf");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.EnableSsl = true;

            email.Subject = "Thanks for shopping with us!";
            email.Body = "Your payment receipt:\n\n" + emailBody.ToString() + "\n\n" + "Your Total is : " + "Rs "+ totalInvoiceAmount + "/-";

            smtpClient.Send(email);
            MessageBox.Show("Email sent successfully.");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Please select a row to remove.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private int CheckCustomerExists(string email)
        {
            int customerId = -1;
            using (SqlConnection connection = new SqlConnection(cs))
            {
                string query = "SELECT CustomerID FROM Customers WHERE Email = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    customerId = Convert.ToInt32(result);
                }
            }
            return customerId;
        }

        private int CreateNewCustomer(string name, string email)
        {
            int customerId = -1;
            using (SqlConnection connection = new SqlConnection(cs))
            {
                string query = "INSERT INTO Customers (Name, Email) VALUES (@Name, @Email); SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    customerId = Convert.ToInt32(result);
                }
            }
            return customerId;
        }


        private decimal CalculateTotalAmount(int productId, int quantity, decimal productGST)
        {
            decimal totalAmount = 0;
            using (SqlConnection connection = new SqlConnection(cs))
            {
                string query = "SELECT Price FROM Products WHERE ProductID = @ProductID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", productId);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    decimal price = Convert.ToDecimal(result);
                    decimal totalWithoutGST = price * quantity;
                    decimal gstAmount = totalWithoutGST * (productGST / 100); // Calculate GST amount
                    totalAmount = totalWithoutGST + gstAmount; // Add GST amount to the total
                }
            }
            totalAmount = Math.Round(totalAmount, 2);
            return totalAmount;
        }


        private int CreateNewInvoice(int customerId, decimal totalAmount)
        {
            int invoiceId = -1;
            using (SqlConnection connection = new SqlConnection(cs))
            {
                string query = "INSERT INTO Invoices (CustomerID, InvoiceDate, TotalAmount) OUTPUT INSERTED.InvoiceID VALUES (@CustomerID, @InvoiceDate, @TotalAmount)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerId);
                command.Parameters.AddWithValue("@InvoiceDate", DateTime.Now);
                command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                connection.Open();
                invoiceId = (int)command.ExecuteScalar();
            }
            return invoiceId;
        }

        private void CreateNewInvoiceForEachItem(int invoiceID, int productId, int quantity, decimal totalAmount)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                string query = "INSERT INTO InvoiceItems (InvoiceID, ProductID,Quantity, Amount) VALUES (@InvoiceID, @ProductId, @Quantity, @TotalAmount)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@InvoiceID", invoiceID);
                command.Parameters.AddWithValue("@ProductId", productId);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private int GetProductIdByName(string productName)
        {
            int productId = -1;
            using (SqlConnection connection = new SqlConnection(cs))
            {
                string query = "SELECT ProductID FROM Products WHERE Name = @ProductName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", productName);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    productId = Convert.ToInt32(result);
                }
            }
            return productId;
        }
        private decimal GetProductGSTByName(string productName)
        {
            decimal productGST = -1;
            using (SqlConnection connection = new SqlConnection(cs))
            {
                string query = "SELECT ProductGST FROM Products WHERE Name = @ProductName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", productName);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    productGST = Convert.ToDecimal(result);
                }
            }
            return productGST;
        }
        private decimal GetProductPriceByName(string productName)
        {
            decimal productPrice = -1;
            using (SqlConnection connection = new SqlConnection(cs))
            {
                string query = "SELECT Price FROM Products WHERE Name = @ProductName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", productName);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    productPrice = Convert.ToDecimal(result);
                }
            }
            return productPrice;
        }

        private decimal CalculateTotalAmountWithGST(decimal productPrice, decimal productGST, int quantity)
        {
            decimal totalAmount = 0;

            decimal totalWithoutGST = productPrice * quantity;
            decimal gstAmount = totalWithoutGST * (productGST / 100);
            totalAmount = totalWithoutGST + gstAmount;
            totalAmount = Math.Round(totalAmount, 2);
            return totalAmount;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
