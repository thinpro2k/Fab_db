using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial.SqlConn;

namespace ManageFabric
{
    public partial class TableNewCus : Form
    {
        public TableNewCus()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertDataCus()
        {
            string cus_id, fname, lname, address, phone,arreage,money,cus_date;
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
            string sql = "INSERT INTO customer VALUES (" + cus_id + "," + "'" + fname + "'" + "," + "'" + lname + "','" + address + "'," + phone + "," + arreage +"," + money + ",(TO_DATE('" + cus_date + "','DD/MM/YYYY'))" + ")";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            //handler
            conn.Close();
            conn.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                InsertDataCus();
                MessageBox.Show("Thêm  thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }


        }
    }
}




