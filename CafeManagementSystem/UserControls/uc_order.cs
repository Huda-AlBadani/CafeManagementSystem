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
