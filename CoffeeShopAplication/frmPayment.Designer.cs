namespace CoffeeShopAplication
{
    partial class frmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPaymentMade = new System.Windows.Forms.Button();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.lblAmountToOPay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPayment = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(151)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.btnClose.Location = new System.Drawing.Point(334, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 27);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPaymentMade
            // 
            this.btnPaymentMade.BackColor = System.Drawing.Color.Crimson;
            this.btnPaymentMade.FlatAppearance.BorderSize = 0;
            this.btnPaymentMade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentMade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPaymentMade.Location = new System.Drawing.Point(112, 143);
            this.btnPaymentMade.Name = "btnPaymentMade";
            this.btnPaymentMade.Size = new System.Drawing.Size(170, 54);
            this.btnPaymentMade.TabIndex = 11;
            this.btnPaymentMade.Text = "Payment Made";
            this.btnPaymentMade.UseVisualStyleBackColor = false;
            this.btnPaymentMade.Click += new System.EventHandler(this.btnPaymentMade_Click);
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(112, 104);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(170, 20);
            this.txtPaymentAmount.TabIndex = 10;
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPaymentAmount.Location = new System.Drawing.Point(19, 107);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(87, 13);
            this.lblPaymentAmount.TabIndex = 9;
            this.lblPaymentAmount.Text = "Payment Amount";
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.Location = new System.Drawing.Point(112, 78);
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.Size = new System.Drawing.Size(170, 20);
            this.txtAmountToPay.TabIndex = 8;
            // 
            // lblAmountToOPay
            // 
            this.lblAmountToOPay.AutoSize = true;
            this.lblAmountToOPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAmountToOPay.Location = new System.Drawing.Point(31, 81);
            this.lblAmountToOPay.Name = "lblAmountToOPay";
            this.lblAmountToOPay.Size = new System.Drawing.Size(75, 13);
            this.lblAmountToOPay.TabIndex = 7;
            this.lblAmountToOPay.Text = "Amount to pay";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.lblPayment);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 36);
            this.panel1.TabIndex = 13;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Franklin Gothic Book", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.lblPayment.Location = new System.Drawing.Point(158, 7);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(80, 24);
            this.lblPayment.TabIndex = 7;
            this.lblPayment.Text = "Payment";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(376, 218);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPaymentMade);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.lblPaymentAmount);
            this.Controls.Add(this.txtAmountToPay);
            this.Controls.Add(this.lblAmountToOPay);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPaymentMade;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.Label lblAmountToOPay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPayment;
    }
}