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
    public partial class frmAddProducts : Form
    {
        public frmAddProducts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pibProduct.Image = new Bitmap(open.FileName);
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescription.Text == "" || txtPrice.Text == "" || cmbCatagery.Text == "")
                {
                    MessageBox.Show("Plsase fill the rquird fields", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmMain.con.ConnectionString = Commons.DB_Con;
                    frmMain.cmd.Connection = frmMain.con;
                    frmMain.cmd.CommandText = "INSERT INTO tblProduct(ProductType,Description,Price,Image) VALUES ('" + cmbCatagery.SelectedItem + "','" + txtDescription.Text + "','" + txtPrice.Text + "','" + pibProduct.Image + "')";
                    frmMain.con.Open();
                    frmMain.cmd.ExecuteNonQuery();
                    frmMain.con.Close();
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("invalid input", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void frmAddProducts_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Black;
            btnSave.ForeColor = Color.White;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Peru;
            btnSave.ForeColor = Color.Black;
        }
    }
}
