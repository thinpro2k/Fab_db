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
    public partial class TableProfile : Form
    {
        public TableProfile()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TableProfile_Load(object sender, EventArgs e)
        {
            string ten = TableLogin.nameUser;
            string username = "", fullname = "";
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string sql = "Select * from accountmanager where username='" + ten + "'";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            username = reader.GetString(0);
                            fullname = reader.GetString(2);
                             
                        }
                    }
                }
                txbUserName.Text = username;
                txbDisplayName.Text = fullname;

           

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
        public void updateDataacc()
        {
            string name2 = TableLogin.nameUser;
            string fullname, oldpass, newpass, renewpass;
            fullname = txbDisplayName.Text;
            oldpass = txbPass.Text;
            newpass = txbNewPass.Text;
            renewpass = txbReEnterPass.Text;
            
            string oldpasstodata="";
            
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                //string sql = "UPDATE  set s_id=" + s_id + ", name ='" + name + "',address='" + address + "',bank_account='" + bankAcc + "',tax_code=" + tax + ",phone=" + phone + "where name='" + name2 + "'";
                //string sql = "UPDATE categorys set cat_id=" + cat_id + ",cat_name='" + name + "',color='" + color + "',price=" + price + ",quantity=" + quantity + ",s_id=" + s_id + "where cat_name='" + name2 + "'";
                string sql = "SELECT * from accountmanager where username='"+name2+"'";

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            oldpasstodata = reader.GetString(1);
                            

                        }
                    }
                }

                if (oldpass == oldpasstodata)
                {
                    if (newpass == renewpass)
                    {
                        sql = "UPDATE accountmanager set pass='" + newpass + "'where username='" + name2 + "'";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thành công", "thông báo");
                    }
                    else
                    {

                        MessageBox.Show("mật khẩu không trùng nhau", "thông báo");
                    }
                    

                }
                else
                {
                    MessageBox.Show("Nhập sai mật khẩu", "thông báo");
                }

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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateDataacc();
            
        }
    }
}
