using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Tutorial.SqlConn;

namespace ManageFabric
{
    public partial class TableCategory : Form
    {
        public TableCategory()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TableCategorys_Load(object sender, EventArgs e)
        {
            btnUpdate.Hide();
            btnDel.Hide();
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            listCate.Columns.Add("Danh mục", 150);
            listCate.View = View.Details;

            try
            {
                string sql = "Select cat_name from categorys";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            string Name = reader.GetString(0);
                            listCate.Items.Add(Name);
                        }
                    }
                }
            }
            catch 
            {
                MessageBox.Show("error", "thông báo");

            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        private void ShowInforCate(string name)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "Select * from categorys where cat_name='" + name + "'";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            DataTable data = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            adapter.Fill(data);
            dtgvCate.DataSource = data;
            conn.Close();
            conn.Dispose();
        }
        private void ShowInfoCatefromSup(string name)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string id = "";
            string sql = "select s_id from categorys where cat_name= '" + name + "'";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        id = reader.GetValue(0).ToString();

                    }
                }
            }
            sql = "select * from supplier where s_id= " + id;
            cmd.CommandText = sql;
            DataTable data = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            adapter.Fill(data);
            dtgvCatefromSup.DataSource = data;
            conn.Close();
            conn.Dispose();
        }

        public static string nameCate;
        private void listCate_MouseClick(object sender, MouseEventArgs e)
        {
            btnUpdate.Show();
            btnDel.Show();

            for (int i = 0; i < listCate.Items.Count; i++)
            {
                var rectangle = listCate.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    ListViewItem item = listCate.Items[i];
                    string name = item.Text;
                    ShowInforCate(name);
                    ShowInfoCatefromSup(name);
                    nameCate = name;
                    return;
                }
            }
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            listCate.Clear();
            dtgvCate.DataSource = null;
            dtgvCatefromSup.DataSource = null;
            TableCategorys_Load(sender, e);

        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = "delete from categorys where cat_name='" + nameCate + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công", "thông báo");
            }
            catch (Exception u)
            {
                MessageBox.Show("error", "thông báo");

            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void btnNewCate_Click(object sender, EventArgs e)
        {
            TableNewCate f = new TableNewCate();
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TableUpdateCate f = new TableUpdateCate();
            f.ShowDialog();
        }

        
    }
}
