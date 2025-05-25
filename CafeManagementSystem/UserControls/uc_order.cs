using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;

namespace CafeManagementSystem.UserControls
{
    public partial class uc_order : UserControl
    {
        function fn = new function();
        string query;

        public uc_order()
        {
            InitializeComponent();
        }

        int n, total = 0;

        private void CmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string combobox = cmbCategory.Text;
            query = "select name from products where categories='" + combobox + "'";
            showList(query);
        }

        private void showList(string query)
        {
            lstProduct.Items.Clear();
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lstProduct.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void LstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudQuantity.ResetText();
            txtTotal.Clear();

            string text = lstProduct.GetItemText(lstProduct.SelectedItem);
            txtProName.Text = text;
            query = "select price from products where name = '" + text + "'";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string combobox = cmbCategory.Text;
            query = "select name from products where categories='" + combobox + "' AND name LIKE '" + txtSearch.Text + "%'";
            showList(query);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells[0].Value = txtProName.Text;
                guna2DataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                guna2DataGridView1.Rows[n].Cells[2].Value = nudQuantity.Value;
                guna2DataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total += int.Parse(txtTotal.Text);
                LblTotalAmount.Text = "RY: " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int amount;

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                total -= amount;
                LblTotalAmount.Text = "RY. " + total;
            }
            catch { }
            
        }

        private void NudQuantity_ValueChanged(object sender, EventArgs e)
        {
            Int64 qu = Int64.Parse(nudQuantity.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);
            txtTotal.Text = (qu * price).ToString();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string amPm = now.Hour < 12 ? "pm" : "am"; 

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Bill";
            printer.SubTitle = "Date: " + now.ToString("yyyy/MM/dd") + " , " + now.ToString("hh:mm:ss") + " " + amPm;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payment Amount: " + LblTotalAmount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);


            try
            {
                string conn = "server=localhost;Database=cafe;Uid=root;Pwd=;";
                MySqlConnection connn = new MySqlConnection(conn);
                connn.Open();
                MySqlTransaction transaction = connn.BeginTransaction();

                try
                {
                    string insertOrderQuery = "INSERT INTO orders (order_date, total_amount) VALUES (@orderDate, @totalAmount)";
                    MySqlCommand Cmd = new MySqlCommand(insertOrderQuery, connn, transaction);
                    Cmd.Parameters.AddWithValue("@orderDate", DateTime.Now);
                    Cmd.Parameters.AddWithValue("@totalAmount", total);
                    Cmd.ExecuteNonQuery();

                    string getLastIdQuery = "SELECT LAST_INSERT_ID()";
                    MySqlCommand idCmd = new MySqlCommand(getLastIdQuery, connn, transaction);
                    int orderId = Convert.ToInt32(idCmd.ExecuteScalar());

                    foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[1].Value != null &&
                            row.Cells[2].Value != null && row.Cells[3].Value != null)
                        {
                            string productName = row.Cells[0].Value.ToString();
                            decimal price = decimal.Parse(row.Cells[1].Value.ToString());
                            int quantity = Convert.ToInt32(row.Cells[2].Value);
                            decimal totalPrice = decimal.Parse(row.Cells[3].Value.ToString());

                            string getProductIdQuery = "SELECT id FROM products WHERE name = @productName";
                            MySqlCommand productCmd = new MySqlCommand(getProductIdQuery, connn, transaction);
                            productCmd.Parameters.AddWithValue("@productName", productName);
                            int productId = Convert.ToInt32(productCmd.ExecuteScalar());

                            string insertDetailQuery = @"INSERT INTO order_details 
                                               (order_id, product_id, quantity, unit_price, total_price) 
                                               VALUES (@orderId, @productId, @quantity, @unitPrice, @totalPrice)";
                            MySqlCommand detailCmd = new MySqlCommand(insertDetailQuery, connn, transaction);
                            detailCmd.Parameters.AddWithValue("@orderId", orderId);
                            detailCmd.Parameters.AddWithValue("@productId", productId);
                            detailCmd.Parameters.AddWithValue("@quantity", quantity);
                            detailCmd.Parameters.AddWithValue("@unitPrice", price);
                            detailCmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                            detailCmd.ExecuteNonQuery();


                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Bill Added Successfully into Database!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Bill Added into Database error: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error connection: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            total = 0;
            guna2DataGridView1.Rows.Clear();
            LblTotalAmount.Text = "RY: " + total;
        }

        private void Guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }

        

    }
}
