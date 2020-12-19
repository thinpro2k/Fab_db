using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageFabric
{
    public partial class TableManager : Form
    {
        public TableManager()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableProfile f = new TableProfile();
            f.ShowDialog();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            TableSupplier f = new TableSupplier();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnCategorys_Click(object sender, EventArgs e)
        {
            TableCategory f = new TableCategory();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            TableCustomer f = new TableCustomer();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

       
    }
}
