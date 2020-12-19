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
    public partial class TableUpdateCus : Form
    {
        public TableUpdateCus()
        {
            InitializeComponent();
        }
        private void UpdateDataCus()
        {
            string name2 = TableCustomer.nameCus;
            string cus_id, fname, lname, address, phone, arreage, money, cus_date;
            cus_id = txbCusId.Text;
            fname = txbFname.Text;
            lname = txbLname.Text;
            address = txbAddress.Text;
            phone = txbPhone.Text;
            arreage = txbArr.Text;
            money = txbMoney.Text;
            cus_date = txbCusdate.Text;

            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                
                string sql = "UPDATE customer set cus_id=" + cus_id + ", fname ='" + fname + "',lname='" + lname + "',address='" + address + "',phone_number=" + phone + ",arreage=" + arreage+",money="+money + "where lname='" + name2 + "'";
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

        private void TableUpdateCus_Load(object sender, EventArgs e)
        {
            string ten = TableCustomer.nameCus;
            string cus_id="", fname="", lname="", address="", phone="", arreage="", money="", cus_date="";
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = "Select * from customer where lname='" + ten + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            cus_id = reader.GetValue(0).ToString();
                            fname = reader.GetString(1);
                            lname = reader.GetString(2);
                            address = reader.GetString(3);
                            phone = reader.GetValue(4).ToString();
                            arreage = reader.GetValue(5).ToString();
                            money = reader.GetValue(6).ToString();
                            cus_date = reader.GetValue(7).ToString();
                        }
                    }
                }
                txbCusId.Text = cus_id ;
                txbFname.Text = fname;
                txbLname.Text= lname;
                txbAddress.Text = address;
                txbPhone.Text = phone;
                txbArr.Text = arreage;
                txbMoney.Text = money;
                txbCusdate.Text = cus_date;

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
            UpdateDataCus();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
