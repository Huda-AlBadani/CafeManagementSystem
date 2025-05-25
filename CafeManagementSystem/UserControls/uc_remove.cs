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
    public partial class uc_remove : UserControl
    {
        function fn = new function();
        string query;

        public uc_remove()
        {
            InitializeComponent();
        }

        private void Uc_remove_Load(object sender, EventArgs e)
        {
            query = "select * from products";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from products where name LIKE '" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void Guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (MessageBox.Show("Delete Product? ", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "Delete from products where id=" + id + "";
                fn.getData(query);
                query = "select * from products";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Uc_remove_Enter(object sender, EventArgs e)
        {
            query = "select * from products";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
