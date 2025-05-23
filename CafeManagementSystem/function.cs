using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CafeManagementSystem
{
    class function
    {
        protected MySqlConnection getConnection()
        {
            string conn = "server=localhost;Database=cafe;Uid=root;Pwd=;";
            MySqlConnection connn = new MySqlConnection(conn);
            return connn;
        }

        public DataSet getData(string qurey)
        {
            MySqlConnection connn = getConnection();
            MySqlCommand cm = new MySqlCommand();
            cm.Connection = connn;
            cm.CommandText = qurey;
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(string qurey)
        {
            MySqlConnection connn = getConnection();
            MySqlCommand cm = new MySqlCommand();
            cm.Connection = connn;
            connn.Open();
            cm.CommandText = qurey;
            cm.ExecuteNonQuery();
            connn.Close();

            MessageBox.Show("Data processed successfully!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
