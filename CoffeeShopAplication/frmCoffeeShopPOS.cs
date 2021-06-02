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
    public partial class frmCoffeeShopPOS : Form
    {
        public frmCoffeeShopPOS()
        {
            InitializeComponent();
        }

        private void tabHotDrinks_Click(object sender, EventArgs e)
        {
            frmMain.ds2.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblProduct WHERE ProductType = 'HotDrinks'", frmMain.con);
            frmMain.da.Fill(frmMain.ds2, "tblProduct");
            frmMain.con.Close();
            int n = 0;
            int currentRow = 0;
            int rowCount = frmMain.ds2.Tables["tblProduct"].Rows.Count;
            while (currentRow < rowCount)
            {

                Button IteamButton = new Button();

                // Set Button properties  
                IteamButton.Height = 100;
                IteamButton.Width = 100;
                IteamButton.BackColor = Color.White;
                //IteamButton.BackgroundImage = "":
                IteamButton.ForeColor = Color.Black;
                IteamButton.Location = new Point(10 + n, 10);
                IteamButton.Text = frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[2].ToString();
                IteamButton.Name = frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[2].ToString();
                IteamButton.Font = new Font("Georgia", 12);

                IteamButton.Click += new EventHandler(IteamButton_Click);

                // Add Button to the Form. Placement of the Button  
                // will be based on the Location and Size of button  
                tabHotDrinks.Controls.Add(IteamButton);
                n = n + 105;
                currentRow++;
                if (currentRow > rowCount)
                {
                    break;
                }
            }
        }

        private void IteamButton_Click(object sender, EventArgs e)
        {
            frmMain.ds2.Clear();
            Button IteamButton = sender as Button;
            string s = IteamButton.Text;
            libItemList.Items.Add(s);
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblProduct", frmMain.con);
            frmMain.da.Fill(frmMain.ds2, "tblProduct");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.ds2.Tables["tblProduct"].Rows.Count;
            while (currentRow<rowCount)
            {
                if (s == frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[2].ToString())
                {
                    int Total = Commons.Total;
                    txtCurrentItem.Text = "Rs:"+ frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[3].ToString();
                    Commons.Total = Total + Convert.ToInt32(frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[3].ToString());
                    txtTotal.Text = (Commons.Total).ToString();
                    break;
                }
                 
                currentRow++;
            }
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCoffeeShopPOS_Load(object sender, EventArgs e)
        {
            frmMain.ds2.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT invoiceNo FROM tblInvoice", frmMain.con);
            frmMain.da.Fill(frmMain.ds2, "tblInvoice");
            frmMain.con.Close();

            int rowCount = (frmMain.ds2.Tables["tblInvoice"].Rows.Count)-1;
            txtInvoiceNo.Text = (Convert.ToInt32(frmMain.ds2.Tables["tblInvoice"].Rows[rowCount].ItemArray[0].ToString())+1).ToString();
             
        }

        private void tabColdDrinks_Click(object sender, EventArgs e)
        {
            frmMain.ds2.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblProduct WHERE ProductType = 'ColdDrinks'", frmMain.con);
            frmMain.da.Fill(frmMain.ds2, "tblProduct");
            frmMain.con.Close();
            int n = 0;
            int currentRow = 0;
            int rowCount = frmMain.ds2.Tables["tblProduct"].Rows.Count;
            while (currentRow < rowCount)
            {

                Button IteamButton = new Button();

                // Set Button properties  
                IteamButton.Height = 100;
                IteamButton.Width = 100;
                IteamButton.BackColor = Color.White;
                //IteamButton.BackgroundImage = "":
                IteamButton.ForeColor = Color.Black;
                IteamButton.Location = new Point(10 + n, 10);
                IteamButton.Text = frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[2].ToString();
                IteamButton.Name = frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[2].ToString();
                IteamButton.Font = new Font("Georgia", 12);

                IteamButton.Click += new EventHandler(IteamButton_Click);

                // Add Button to the Form. Placement of the Button  
                // will be based on the Location and Size of button  
                tabColdDrinks.Controls.Add(IteamButton);
                n = n + 105;
                currentRow++;
                if (currentRow > rowCount)
                {
                    break;
                }
            }
        }

        private void tabFoods_Click(object sender, EventArgs e)
        {
            frmMain.ds2.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblProduct WHERE ProductType = 'Foods'", frmMain.con);
            frmMain.da.Fill(frmMain.ds2, "tblProduct");
            frmMain.con.Close();
            int n = 0;
            int currentRow = 0;
            int rowCount = frmMain.ds2.Tables["tblProduct"].Rows.Count;
            while (currentRow < rowCount)
            {

                Button IteamButton = new Button();

                // Set Button properties  
                IteamButton.Height = 100;
                IteamButton.Width = 100;
                IteamButton.BackColor = Color.White;
                //IteamButton.BackgroundImage = "":
                IteamButton.ForeColor = Color.Black;
                IteamButton.Location = new Point(10 + n, 10);
                IteamButton.Text = frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[2].ToString();
                IteamButton.Name = frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[2].ToString();
                IteamButton.Font = new Font("Georgia", 12);

                IteamButton.Click += new EventHandler(IteamButton_Click);

                // Add Button to the Form. Placement of the Button  
                // will be based on the Location and Size of button  
                tabFoods.Controls.Add(IteamButton);
                n = n + 105;
                currentRow++;
                if (currentRow > rowCount)
                {
                    break;
                }
            }
        }

        private void tabOthers_Click(object sender, EventArgs e)
        {
            frmMain.ds2.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblProduct WHERE ProductType = 'Others'", frmMain.con);
            frmMain.da.Fill(frmMain.ds2, "tblProduct");
            frmMain.con.Close();
            int n = 0;
            int currentRow = 0;
            int rowCount = frmMain.ds2.Tables["tblProduct"].Rows.Count;
            while (currentRow < rowCount)
            {

                Button IteamButton = new Button();

                // Set Button properties  
                IteamButton.Height = 100;
                IteamButton.Width = 100;
                IteamButton.BackColor = Color.White;
                //IteamButton.BackgroundImage = "":
                IteamButton.ForeColor = Color.Black;
                IteamButton.Location = new Point(10 + n, 10);
                IteamButton.Text = frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[2].ToString();
                IteamButton.Name = frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[2].ToString();
                IteamButton.Font = new Font("Georgia", 12);

                IteamButton.Click += new EventHandler(IteamButton_Click);

                // Add Button to the Form. Placement of the Button  
                // will be based on the Location and Size of button  
                tabOthers.Controls.Add(IteamButton);
                n = n + 105;
                currentRow++;
                if (currentRow > rowCount)
                {
                    break;
                }
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            frmMain.ds2.Clear();
            
            int currentTotal = Commons.Total;
            
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblProduct", frmMain.con);
            frmMain.da.Fill(frmMain.ds2, "tblProduct");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.ds2.Tables["tblProduct"].Rows.Count;
            while (currentRow < rowCount)
            {
                if (libItemList.SelectedItem.ToString() == frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[2].ToString())
                {
                    int currentPrice = Convert.ToInt32(frmMain.ds2.Tables["tblProduct"].Rows[currentRow].ItemArray[3].ToString());
                    Commons.Total = currentTotal - currentPrice;
                    txtTotal.Text = (Commons.Total).ToString();
                    break;
                    
                }
                
                currentRow++;
            }
            

            foreach (string s in libItemList.SelectedItems.OfType<string>().ToList())
                libItemList.Items.Remove(s);






        }

        private void libItemList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void libItemList_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void btnDeleteItem_MouseHover(object sender, EventArgs e)
        {
            btnDeleteItem.BackColor = Color.Red;
            btnDeleteItem.ForeColor = Color.White;
        }

        private void btnDeleteItem_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteItem.BackColor = Color.Lime;
            btnDeleteItem.ForeColor = Color.Black;
        }

        private void libItemList_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCurrentItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            String userName = Commons.UserName;
            DateTime InvoiceDate = dtmDate.Value;
            int currentItem = 0;
            int itemCount = libItemList.Items.Count;
            while (currentItem < itemCount)
            {
                frmMain.con.ConnectionString = Commons.DB_Con;
                frmMain.cmd.Connection = frmMain.con;
                frmMain.cmd.CommandText = "INSERT INTO tblTransactions(InvoicNo,ProductName) values('"+Convert.ToInt32(txtInvoiceNo.Text)+"','"+libItemList.Items[currentItem]+"')";
                frmMain.con.Open();
                frmMain.cmd.ExecuteNonQuery();
                frmMain.con.Close();
                currentItem++;
            }

            int total = Convert.ToInt32(txtTotal.Text);
            
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.cmd.Connection = frmMain.con;
            frmMain.cmd.CommandText = "INSERT INTO tblInvoice(invoiceDate,total,userName) VALUES('" + InvoiceDate + "','"+total+ "','" + userName + "')";
            frmMain.con.Open();
            frmMain.cmd.ExecuteNonQuery();
            frmMain.con.Close();

            frmPayment payment = new frmPayment();
            payment.ShowDialog();
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

