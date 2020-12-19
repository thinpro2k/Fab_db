using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial.SqlConn;

namespace ManageFabric
{
    public partial class TableLogin : Form
    {
        public TableLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muôn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsLogin())
            {
                TableManager f = new TableManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
                this.txbPassWord.ResetText();
            }
            


        }
        
        
        public static string nameUser="";
        private bool IsLogin()
        {


            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {

                string tk = txbUserName.Text;
                string mk = txbPassWord.Text;
                nameUser = tk;
                string sql = "select * from accountmanager where username='"+tk+"' and pass='"+mk+"'";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    { 
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }

    }
    
}
