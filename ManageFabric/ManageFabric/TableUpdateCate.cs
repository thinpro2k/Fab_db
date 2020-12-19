using Oracle.DataAccess.Client;
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
using Tutorial.SqlConn;

namespace ManageFabric
{
    public partial class TableUpdateCate : Form
    {
        public TableUpdateCate()
        {
            InitializeComponent();
            
        }
        private void UpdateDataCate()
        {
            string name2 = TableCategory.nameCate;
            String name, cat_id, price, color, quantity, date,s_id;
            name = txbDisplayName.Text;
            cat_id=txbCatId.Text;
            price = txbPrice.Text;
            color = txbColor.Text;
            quantity = txbQuantity.Text;
            date = txbdate.Text;
            s_id = txbsid.Text;
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            
            try
            {
                //string sql = "UPDATE  set s_id=" + s_id + ", name ='" + name + "',address='" + address + "',bank_account='" + bankAcc + "',tax_code=" + tax + ",phone=" + phone + "where name='" + name2 + "'";
                string sql = "UPDATE categorys set cat_id=" + cat_id + ",cat_name='" + name + "',color='" + color + "',price=" + price + ",quantity=" + quantity + ",s_id=" + s_id + "where cat_name='" + name2 + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công", "thông báo");
            }
            catch
            {
                MessageBox.Show("error", "thông báo");
            }
            finally
            {
                //handler
                conn.Close();
                conn.Dispose();
            }
        }

        private void TableUpdateCate_Load(object sender, EventArgs e)
        {
            string ten = TableCategory.nameCate;
            string name = "", cat_id = "", price = "", color = "", date = "", quantity = "",s_id="";
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = "Select * from categorys where cat_name='" + ten + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            cat_id = reader.GetValue(0).ToString();
                            name = reader.GetString(1);
                            color = reader.GetString(2);
                            price = reader.GetValue(3).ToString();
                            date = reader.GetValue(4).ToString();
                            quantity = reader.GetValue(5).ToString();
                            s_id = reader.GetValue(6).ToString();
                        }
                    }
                }

                txbDisplayName.Text = name;
                txbCatId.Text = cat_id;
                txbPrice.Text = price;
                txbColor.Text = color;
                txbQuantity.Text = quantity;
                txbdate.Text = date;
                txbsid.Text = s_id;

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDataCate();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




