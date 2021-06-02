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
    public partial class frmViweProducts : Form
    {
        
        public frmViweProducts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmViweProducts_Load(object sender, EventArgs e)
        {
            frmMain.ds2.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblProduct",frmMain.con);
            frmMain.da.Fill(frmMain.ds2, "tblProduct");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.ds2.Tables["tblProduct"].Rows.Count;
            while (currentRow<rowCount)
            {
                int n = dgvProducts.Rows.Add();
                
                    dgvProducts.Rows[n].Cells[0].Value = frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[0].ToString();
                    dgvProducts.Rows[n].Cells[1].Value = frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[1].ToString();
                    dgvProducts.Rows[n].Cells[2].Value = frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[2].ToString();
                    dgvProducts.Rows[n].Cells[3].Value = frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[3].ToString();
                    dgvProducts.Rows[n].Cells[4].Value = frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[4].ToString();
                    
                    currentRow++;
                
                if (currentRow > rowCount)
                {
                    break;
                }
                
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
