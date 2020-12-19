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
    public partial class TableSupplier : Form
    {
        public TableSupplier()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TableSupplier_Load(object sender, EventArgs e)
        {
            btnUpdate.Hide();
            btnDel.Hide();
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            ListSupplier.Columns.Add("Tên Nhà cung cấp", 150);
            ListSupplier.View = View.Details;
            //int i = 1;
            try
            {
                string sql = "Select name from supplier";
                //string sql = "Select * from supplier where s_id=1";
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
                            ListSupplier.Items.Add(Name);
                            //i++;


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
        private void ShowInforSup(string name)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "Select * from supplier where name='"+name+"'";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            DataTable data = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            adapter.Fill(data);
            dtgvInfoSup.DataSource = data;
            conn.Close();
            conn.Dispose();
        }
        private void ShowInforCateToSup(string name)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "Select cat_id,cat_name,color,price,cat_date,quantity  from categorys c, supplier s where  c.s_id=s.s_id and s.name='" + name + "'";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            DataTable data = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            adapter.Fill(data);
            dtgvCateToSup.DataSource = data;
            conn.Close();
            conn.Dispose();
        }

        public static string nameSup;
        private void ListSupplier_MouseClick(object sender, MouseEventArgs e)
        {
            btnUpdate.Show();
            btnDel.Show();
            
            for (int i = 0; i < ListSupplier.Items.Count; i++)
            {
                var rectangle = ListSupplier.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    ListViewItem item = ListSupplier.Items[i];
                    string name = item.Text;
                    ShowInforSup(name);
                    ShowInforCateToSup(name);
                    nameSup = name;
                    return;
                }
            }
        }

        private void btnNewSup_Click(object sender, EventArgs e)
        {
            TableNewSupplier f = new TableNewSupplier();
            f.ShowDialog();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ListSupplier.Clear();
            dtgvCateToSup.DataSource = null;
            dtgvInfoSup.DataSource=null;
            TableSupplier_Load(sender, e);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            TableUpdateSup f = new TableUpdateSup();
            f.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = "delete from supplier where name='"+nameSup+"'";
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
    }
}
