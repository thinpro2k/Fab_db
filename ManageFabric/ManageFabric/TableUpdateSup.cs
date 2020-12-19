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
    public partial class TableUpdateSup : Form
    {
        public TableUpdateSup()
        {
            InitializeComponent();
        }
        
        private void UpdateDataSup()
        {
            string name2 = TableSupplier.nameSup;
            String name, s_id, address, bankAcc, tax, phone;
            name = txbDisplayName.Text;
            s_id = txbSid.Text;
            address = txbAddress.Text;
            bankAcc = txbBankAcc.Text;
            tax = txbTax.Text;
            phone = txbPhoneNum.Text;
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = "UPDATE supplier set s_id=" + s_id + ", name ='" + name + "',address='" + address + "',bank_account='" + bankAcc + "',tax_code=" + tax + ",phone=" + phone + "where name='" + name2 + "'";
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

        private void TableUpdateSup_Load(object sender, EventArgs e)
        {
            string ten = TableSupplier.nameSup;
            string name="", s_id="", address="", bankAcc="", tax="", phone="";
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = "Select * from supplier where name='"+ten+"'";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            s_id = reader.GetValue(0).ToString();
                            name = reader.GetString(1);
                            address = reader.GetString(2);
                            bankAcc = reader.GetValue(3).ToString();
                            tax = reader.GetValue(4).ToString();
                            phone = reader.GetValue(5).ToString();
                        }
                    }
                }

                txbDisplayName.Text = name;
                txbSid.Text = s_id;
                txbAddress.Text = address;
                txbBankAcc.Text = bankAcc;
                txbTax.Text = tax;
                txbPhoneNum.Text = phone;
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
            UpdateDataSup();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
