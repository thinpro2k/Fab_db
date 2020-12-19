using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Tutorial.SqlConn;

namespace ManageFabric
{
    public partial class TableCustomer : Form
    {
        public TableCustomer()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TableCustomer_Load(object sender, EventArgs e)
        {
            btnUpdate.Hide();
            btnDel.Hide();
            btnPrint.Hide();
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            listCus.Columns.Add("Tên Khách hàng", 150);
            listCus.View = View.Details;
            
            try
            {
                string sql = "Select lname from customer";
                
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
                            listCus.Items.Add(Name);
                        }
                    }
                }
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
        private void ShowInforCus(string name)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "Select * from customer where lname='" + name + "'";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            DataTable data = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            adapter.Fill(data);
            dtgvEmp.DataSource = data;
            conn.Close();
            conn.Dispose();
        }
        private void ShowInforOrderFromCus(string name)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string id = "";
            string sql = "select cus_id from customer where lname= '"+name+"'";
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
            sql = "select * from orders where cus_id= " + id ;
            cmd.CommandText = sql;
            DataTable data = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            adapter.Fill(data);
            dtgvOrderFromEmp.DataSource = data;
            conn.Close();
            conn.Dispose();
        }

        public static string nameCus;
        private void listCus_MouseClick(object sender, MouseEventArgs e)
        {
            btnUpdate.Show();
            btnDel.Show();
            btnPrint.Show();

            for (int i = 0; i < listCus.Items.Count; i++)
            {
                var rectangle = listCus.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    ListViewItem item = listCus.Items[i];
                    string name = item.Text;
                    ShowInforCus(name);
                    ShowInforOrderFromCus(name);
                    nameCus = name;
                    return;
                }
            }
        }

        

        private void btnReset_Click(object sender, EventArgs e)
        {
            listCus.Clear();
            dtgvEmp.DataSource = null;
            dtgvOrderFromEmp.DataSource = null;
            TableCustomer_Load(sender, e);

        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = "delete from customer where lname='" + nameCus + "'";
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

        private void btnNewCus_Click(object sender, EventArgs e)
        {
            TableNewCus f = new TableNewCus();
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TableUpdateCus f = new TableUpdateCus();
            f.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            TableReport f = new TableReport();
            f.ShowDialog();
        }
    }
}
