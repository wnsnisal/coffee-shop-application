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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            grpAddUser.Enabled = true;
            grpEditAndRemoveUser.Enabled = false;
        }

        private void btnEditAndRemove_Click(object sender, EventArgs e)
        {
            frmMain.ds2.Clear();
            lstUsers.Items.Clear();
            grpAddUser.Enabled = false;
            grpEditAndRemoveUser.Enabled = true;
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblUser", frmMain.con);
            frmMain.da.Fill(frmMain.ds2, "tblUser");
            frmMain.con.Close();

            int currentRow = 0;
            int rowCount = frmMain.ds2.Tables["tblUser"].Rows.Count;
            while (currentRow < rowCount)
            {
                lstUsers.Items.Add(frmMain.ds2.Tables["tblUser"].Rows[currentRow].ItemArray[1].ToString());
                currentRow++;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" || txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill the Mandatory fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               if( txtFullName.Text.Length > 70)
                {
                    MessageBox.Show("Maximum lenth of Full name is 70 charctors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               else
                {
                    if (txtUserName.Text.Length > 50)
                    {
                        MessageBox.Show("Maximum lenth of User name is 50 charctors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(txtPassword.Text.Length > 12)
                        {
                            MessageBox.Show("Maximum lenth of Password is 12 charctors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            String Password = Convert.ToBase64String(Encoding.Unicode.GetBytes(txtPassword.Text));
                            frmMain.con.ConnectionString = Commons.DB_Con;
                            frmMain.cmd.Connection = frmMain.con;
                            frmMain.cmd.CommandText = "INSERT INTO tblUser(FullName,UserName,Password,UserType) VALUES('" + txtFullName.Text + "','" + txtUserName.Text + "','" + Password + "','"+cmbUserType.Text+"')";
                            frmMain.con.Open();
                            frmMain.cmd.ExecuteNonQuery();
                            frmMain.con.Close();

                            MessageBox.Show("Sucess", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                    }
                }
            }
            
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMain.ds2.Clear();
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.con.Open();
            frmMain.da = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM tblUser WHERE FullName = '"+lstUsers.SelectedItem.ToString()+"'", frmMain.con);
            frmMain.da.Fill(frmMain.ds2, "tblUser");
            frmMain.con.Close();
            int currentRow = 0;
            int rowCount = frmMain.ds2.Tables["tblUser"].Rows.Count;
            while (currentRow<rowCount)
            {
                
                txtFullName2.Text = frmMain.ds2.Tables["tblUser"].Rows[currentRow].ItemArray[1].ToString();
                txtUserName2.Text = frmMain.ds2.Tables["tblUser"].Rows[currentRow].ItemArray[2].ToString();
                txtPassword2.Text = Encoding.Unicode.GetString(Convert.FromBase64String(frmMain.ds2.Tables["tblUser"].Rows[currentRow].ItemArray[3].ToString()));
                cmbUserType2.Text = frmMain.ds2.Tables["tblUser"].Rows[currentRow].ItemArray[4].ToString();
                break;
            }
            
        }

        private void btnSaveAndUpdate_Click(object sender, EventArgs e)
        {
            
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.cmd.Connection = frmMain.con;
            frmMain.cmd.CommandText = "UPDATE tblUser SET FullName = '"+txtFullName2.Text+"', UserName = '"+txtUserName2.Text+"', Password = '"+ Convert.ToBase64String(Encoding.Unicode.GetBytes(txtPassword2.Text))+"', UserType = '"+cmbUserType2.SelectedItem.ToString()+"' WHERE FullName = '"+lstUsers.SelectedItem.ToString()+"' ";
            frmMain.con.Open();
            frmMain.cmd.ExecuteNonQuery();
            frmMain.con.Close();
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmMain.con.ConnectionString = Commons.DB_Con;
            frmMain.cmd.Connection = frmMain.con;
            frmMain.cmd.CommandText = "DELETE FROM tblUser WHERE FullName = '" + lstUsers.SelectedItem.ToString() + "'";
            frmMain.con.Open();
            frmMain.cmd.ExecuteNonQuery();
            frmMain.con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
