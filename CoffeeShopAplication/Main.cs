using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopAplication
{
    public partial class frmMain : Form
    {
        public static System.Data.SqlClient.SqlConnection
            con = new System.Data.SqlClient.SqlConnection();
        public static System.Data.SqlClient.SqlCommand
            cmd = new System.Data.SqlClient.SqlCommand();
        public static System.Data.SqlClient.SqlDataAdapter
            da = new System.Data.SqlClient.SqlDataAdapter();

        public static DataSet ds2 = new DataSet();
        public static DataSet ds1 = new DataSet();
        public frmMain()
        {
            InitializeComponent();
        }

        private void addProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddProducts AddProducts = new frmAddProducts();
            AddProducts.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(Commons.LogedUser == "Admin")
            {
                userToolStripMenuItem.Enabled = true;
                openPToolStripMenuItem.Enabled = true;
                addProductsToolStripMenuItem.Enabled = true;
                mnuViwePoroducts.Enabled = true;

            }
            else
            {
                if(Commons.LogedUser == "User")
                {
                    userToolStripMenuItem.Enabled = false;
                    openPToolStripMenuItem.Enabled = true;
                    addProductsToolStripMenuItem.Enabled = false;
                    mnuViwePoroducts.Enabled = true;
                }
            }
        }

        private void mnuViwePoroducts_Click(object sender, EventArgs e)
        {
            frmViweProducts ViweProducts = new frmViweProducts();
            ViweProducts.ShowDialog();
        }

        private void openPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoffeeShopPOS CoffeeShopPOS = new frmCoffeeShopPOS();
            CoffeeShopPOS.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser User = new frmUser();
            User.ShowDialog();
        }

        private void mnuViwePoroducts_Click_1(object sender, EventArgs e)
        {
            frmViweProducts viweProducts = new frmViweProducts();
            viweProducts.ShowDialog();
        }

        private void invoiceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoiceDetails invoiceDetails = new frmInvoiceDetails();
            invoiceDetails.ShowDialog();
        }
    }
}
