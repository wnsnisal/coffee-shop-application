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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            txtAmountToPay.Text = Commons.Total.ToString();
        }

        private void btnPaymentMade_Click(object sender, EventArgs e)
        {
            try
            {
                int PaymentAmount = Convert.ToInt32(txtPaymentAmount.Text);
                int AmountToPay = Convert.ToInt32(txtAmountToPay.Text);
                if (txtAmountToPay.Text == PaymentAmount.ToString())
                {
                    Close();
                    PrintDialog dlg = new PrintDialog();
                    dlg.ShowDialog();

                }
                else
                {
                    if (Convert.ToInt32(txtAmountToPay.Text) > PaymentAmount)
                    {
                        txtAmountToPay.Text = (AmountToPay - PaymentAmount).ToString();
                        txtPaymentAmount.Text = "";
                    }
                    else
                    {
                        if (Convert.ToInt32(txtAmountToPay.Text) < PaymentAmount)
                        {
                            Close();
                            MessageBox.Show("Change to give " + (PaymentAmount - AmountToPay).ToString(), "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PrintDialog dlg = new PrintDialog();
                            dlg.ShowDialog();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("invalid input", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
