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
    public partial class TableNewSupplier : Form
    {
        public TableNewSupplier()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void InsertDataSup()
        {
            string name, s_id, address, bankAcc, tax, phone;
            name = txbDisplayName.Text;
            s_id = txbSid.Text;
            address = txbAddress.Text;
            bankAcc = txbBankAcc.Text;
            tax = txbTax.Text;
            phone = txbPhoneNum.Text;
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "INSERT INTO supplier VALUES ("+s_id+","+"'"+name+"'"+","+"'"+address+"','"+bankAcc+"',"+tax+","+phone+")";
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
            try {
                InsertDataSup();
                MessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            
            
        }
    }
}
