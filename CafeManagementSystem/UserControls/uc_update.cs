using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem.UserControls
{
    public partial class uc_update : UserControl
    {
        function fn = new function();
        string query;

        public uc_update()
        {
            InitializeComponent();
        }

        private void Uc_update_Load(object sender, EventArgs e)
        {
            query = "select * from products";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void TxtProNSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from products where name LIKE '" + txtProNSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void Guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtProName.Text = name;
            txtCategory.Text = category;
            txtPrice.Text = price.ToString();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            query = "UPDATE products set name ='" + txtProName.Text + "', categories='" + txtCategory.Text + "', price='" + txtPrice.Text + "' WHERE id=" + id + "";
            fn.setData(query);
            query = "select * from products";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

            txtProName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
        }
    }
}
