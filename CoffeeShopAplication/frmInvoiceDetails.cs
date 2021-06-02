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
    public partial class frmInvoiceDetails : Form
    {
        public frmInvoiceDetails()
        {
            InitializeComponent();
        }

        private void frmInvoiceDetails_Load(object sender, EventArgs e)
        {
            frmMain.ds2.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblInvoice", frmMain.con);
            frmMain.da.Fill(frmMain.ds2, "tblInvoice");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.ds2.Tables["tblInvoice"].Rows.Count;
            while (currentRow < rowCount)
            {
                lstInvoicNo.Items.Add(frmMain.ds2.Tables["tblInvoice"].Rows[currentRow].ItemArray[0].ToString());
                currentRow++;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstInvoicNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                
                frmMain.ds2.Clear();
                frmMain.ds1.Clear();
                frmMain.con.ConnectionString = Commons.DB_Con;
                frmMain.con.Open();
                frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblTransactions", frmMain.con);
                frmMain.da.Fill(frmMain.ds2, "tblTransactions");
                frmMain.con.Close();

                int currentRow = 0;
                int rowCount = frmMain.ds2.Tables["tblTransactions"].Rows.Count;
                while (currentRow < rowCount)
                {
                    if (lstInvoicNo.SelectedItem.ToString() == frmMain.ds2.Tables["tblTransactions"].Rows[currentRow].ItemArray[0].ToString())
                    {
                        int n = dgvTransition.Rows.Add();

                        dgvTransition.Rows[n].Cells[0].Value = frmMain.ds2.Tables["tblTransactions"].Rows[currentRow].ItemArray[1].ToString();
                        String ItemName = frmMain.ds2.Tables["tblTransactions"].Rows[currentRow].ItemArray[1].ToString();

                        
                        
                        frmMain.con.ConnectionString = Commons.DB_Con;
                        frmMain.con.Open();
                        frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT Price FROM tblProduct WHERE Description = '"+ ItemName + "'", frmMain.con);
                        frmMain.da.Fill(frmMain.ds1, "tblProduct");
                        frmMain.con.Close();

                        dgvTransition.Rows[n].Cells[1].Value = frmMain.ds1.Tables["tblProduct"].Rows[0].ItemArray[0].ToString();
                    }
                    currentRow++;
                }

                frmMain.con.ConnectionString = Commons.DB_Con;
                frmMain.con.Open();
                frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblInvoice", frmMain.con);
                frmMain.da.Fill(frmMain.ds2, "tblInvoice");
                frmMain.con.Close();

                int currentRow1 = 0;
                int rowCount1 = frmMain.ds2.Tables["tblInvoice"].Rows.Count;
                while (currentRow1 < rowCount1)
                {
                    if (lstInvoicNo.SelectedItem.ToString() == frmMain.ds2.Tables["tblInvoice"].Rows[currentRow1].ItemArray[0].ToString())
                    {
                        txtInvoiceDate.Text = frmMain.ds2.Tables["tblInvoice"].Rows[currentRow1].ItemArray[1].ToString();
                        txtIssuedUser.Text = frmMain.ds2.Tables["tblInvoice"].Rows[currentRow1].ItemArray[3].ToString();
                        txtTotal.Text = frmMain.ds2.Tables["tblInvoice"].Rows[currentRow1].ItemArray[2].ToString();

                    }
                    currentRow1++;
                }
            }
            catch
            {
                MessageBox.Show("please select invoice No", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void txtInvoiceNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtInvoiceNo_MouseEnter(object sender, EventArgs e)
        {
            frmMain.ds2.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT invoiceNo FROM tblInvoice", frmMain.con);
            frmMain.da.Fill(frmMain.ds2, "tblInvoice");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.ds2.Tables["tblInvoice"].Rows.Count;
            while (currentRow < rowCount)
            {
                if (txtInvoiceNo.Text == frmMain.ds2.Tables["tblInvoice"].Rows[currentRow].ItemArray[0].ToString())
                {
                    lstInvoicNo.Items.Add(frmMain.ds2.Tables["tblInvoice"].Rows[currentRow].ItemArray[0].ToString());
                }
                currentRow++;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvTransition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
