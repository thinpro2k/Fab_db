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
    public partial class TableReport : Form
    {
        public TableReport()
        {
            InitializeComponent();
        }

        private void TableReport_Load(object sender, EventArgs e)
        {
            string name = TableCustomer.nameCus;
            showInforCus(name);
            showINforOrder(name);
        }
        private void showInforCus(string name) {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string sql = "Select * from customer where lname='" + name + "'";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            DataTable data = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            adapter.Fill(data);
            dtgvCus.DataSource = data;
            conn.Close();
            conn.Dispose();
        }
        private void showINforOrder(string name)
        {
            OracleConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string id = "";
            string sql = "select cus_id from customer where lname= '" + name + "'";
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
            sql = "select * from orders where cus_id= " + id;
            cmd.CommandText = sql;
            DataTable data = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            adapter.Fill(data);
            dtgvOrder.DataSource = data;
            conn.Close();
            conn.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintScreen();
            printPreviewDialog1.ShowDialog();
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;

        private void PrintScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
