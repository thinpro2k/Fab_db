
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
    public partial class TableNewCate : Form
    {
        public TableNewCate()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertDataCate()
        {
            string name, cat_id, color, price, cate_date, quantity,s_id;
            name = txbDisplayName.Text;
            cat_id = txbCatId.Text;
            color = txbColor.Text;
            price = txbPrice.Text;
            cate_date = txbdate.Text;
            quantity = txbQuantity.Text;
            s_id = txbSID.Text;
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "INSERT INTO categorys VALUES (" + cat_id + ",'" +name+"','"+ color + "',"  + price + ",(TO_DATE('"+cate_date+"','DD/MM/YYYY'))"+"," +quantity+","+s_id+")";
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
                InsertDataCate();
                MessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            


        }

        
    }

        
    
}

