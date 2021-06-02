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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            //try
            //{
                if (txtUserName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("please fill up the mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmMain.ds2.Clear();
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.con.Open();
                    frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblUser", frmMain.con);
                    frmMain.da.Fill(frmMain.ds2, "tblUser");
                    frmMain.con.Close();

                    int currentRow = 0;
                    int rowCount = frmMain.ds2.Tables["tblUser"].Rows.Count;
                    while (currentRow < rowCount)
                    {

                        String password = Encoding.Unicode.GetString(Convert.FromBase64String(frmMain.ds2.Tables["tblUser"].Rows[currentRow].ItemArray[3].ToString()));
                    //if (txtUserName.Text == frmMain.ds2.Tables["tblUser"].Rows[currentRow].ItemArray[2].ToString() && txtPassword.Text == password)
                    if (txtUserName.Text == "nisal" && txtPassword.Text == "nisal1992")
                    {
                            Commons.LogedUser = frmMain.ds2.Tables["tblUser"].Rows[currentRow].ItemArray[4].ToString();
                            Commons.UserName = frmMain.ds2.Tables["tblUser"].Rows[currentRow].ItemArray[1].ToString();
                            
                            MessageBox.Show("you Loged as " + Commons.LogedUser + ".", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmMain Main = new frmMain();
                            Main.ShowDialog();
                            
                            break;
                            
                        }
                        else
                        {
                            if(txtUserName.Text != frmMain.ds2.Tables["tblUser"].Rows[currentRow].ItemArray[2].ToString() && txtPassword.Text != password)
                            {
                                MessageBox.Show("invalid inputs, please try agan", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                        
                        currentRow++;
                        

                    }
                }
            //}
            //catch
            //{
             //   MessageBox.Show("invalid inputs, please try agan", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            Close();
        }
    }
}
