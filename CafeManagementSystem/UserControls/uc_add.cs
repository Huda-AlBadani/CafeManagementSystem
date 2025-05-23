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
    public partial class uc_add : UserControl
    {

        function fn = new function();
        string query;

        public uc_add()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            cmbCategories.SelectedIndex = -1;
            txtProName.Clear();
            txtPrice.Clear();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            query = "Insert into products (name,categories,price) values ('" + txtProName.Text + "','" + cmbCategories.Text + "','" + txtPrice.Text + "')";
            fn.setData(query);
            clearAll();
        }

        private void Uc_add_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
