namespace CoffeeShopAplication
{
    partial class frmInvoiceDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblInvoiceDetails = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstInvoicNo = new System.Windows.Forms.ListBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.grpInvoiceDetails = new System.Windows.Forms.GroupBox();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.dgvTransition = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblIssuedUser = new System.Windows.Forms.Label();
            this.txtIssuedUser = new System.Windows.Forms.TextBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpInvoiceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransition)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvoiceDetails
            // 
            this.lblInvoiceDetails.AutoSize = true;
            this.lblInvoiceDetails.Font = new System.Drawing.Font("Franklin Gothic Book", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.lblInvoiceDetails.Location = new System.Drawing.Point(316, 14);
            this.lblInvoiceDetails.Name = "lblInvoiceDetails";
            this.lblInvoiceDetails.Size = new System.Drawing.Size(127, 24);
            this.lblInvoiceDetails.TabIndex = 11;
            this.lblInvoiceDetails.Text = "Invoice Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.lblInvoiceDetails);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 48);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CoffeeShopAplication.Properties.Resources.logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(8, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.btnClose.Location = new System.Drawing.Point(698, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstInvoicNo
            // 
            this.lstInvoicNo.FormattingEnabled = true;
            this.lstInvoicNo.Location = new System.Drawing.Point(12, 131);
            this.lstInvoicNo.Name = "lstInvoicNo";
            this.lstInvoicNo.Size = new System.Drawing.Size(151, 264);
            this.lstInvoicNo.TabIndex = 2;
            this.lstInvoicNo.SelectedIndexChanged += new System.EventHandler(this.lstInvoicNo_SelectedIndexChanged);
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInvoiceNo.Location = new System.Drawing.Point(12, 75);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(59, 13);
            this.lblInvoiceNo.TabIndex = 3;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // grpInvoiceDetails
            // 
            this.grpInvoiceDetails.Controls.Add(this.lblInvoiceDate);
            this.grpInvoiceDetails.Controls.Add(this.txtInvoiceDate);
            this.grpInvoiceDetails.Controls.Add(this.dgvTransition);
            this.grpInvoiceDetails.Controls.Add(this.lblTotal);
            this.grpInvoiceDetails.Controls.Add(this.txtTotal);
            this.grpInvoiceDetails.Controls.Add(this.lblIssuedUser);
            this.grpInvoiceDetails.Controls.Add(this.txtIssuedUser);
            this.grpInvoiceDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(151)))));
            this.grpInvoiceDetails.Location = new System.Drawing.Point(169, 54);
            this.grpInvoiceDetails.Name = "grpInvoiceDetails";
            this.grpInvoiceDetails.Size = new System.Drawing.Size(561, 380);
            this.grpInvoiceDetails.TabIndex = 4;
            this.grpInvoiceDetails.TabStop = false;
            this.grpInvoiceDetails.Text = "Invoice Details";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(27, 34);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(68, 13);
            this.lblInvoiceDate.TabIndex = 6;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(101, 31);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.Size = new System.Drawing.Size(205, 20);
            this.txtInvoiceDate.TabIndex = 5;
            // 
            // dgvTransition
            // 
            this.dgvTransition.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvTransition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemPrice});
            this.dgvTransition.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvTransition.Location = new System.Drawing.Point(35, 61);
            this.dgvTransition.Name = "dgvTransition";
            this.dgvTransition.Size = new System.Drawing.Size(493, 240);
            this.dgvTransition.TabIndex = 4;
            this.dgvTransition.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransition_CellContentClick);
            // 
            // ItemName
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.ItemName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 300;
            // 
            // ItemPrice
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.ItemPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.ItemPrice.HeaderText = "Item Price";
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            this.ItemPrice.Width = 150;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(64, 310);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(101, 307);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(205, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // lblIssuedUser
            // 
            this.lblIssuedUser.AutoSize = true;
            this.lblIssuedUser.Location = new System.Drawing.Point(32, 336);
            this.lblIssuedUser.Name = "lblIssuedUser";
            this.lblIssuedUser.Size = new System.Drawing.Size(63, 13);
            this.lblIssuedUser.TabIndex = 1;
            this.lblIssuedUser.Text = "Issued User";
            // 
            // txtIssuedUser
            // 
            this.txtIssuedUser.Location = new System.Drawing.Point(101, 333);
            this.txtIssuedUser.Name = "txtIssuedUser";
            this.txtIssuedUser.Size = new System.Drawing.Size(205, 20);
            this.txtIssuedUser.TabIndex = 0;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(12, 91);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(151, 20);
            this.txtInvoiceNo.TabIndex = 5;
            this.txtInvoiceNo.TextChanged += new System.EventHandler(this.txtInvoiceNo_TextChanged);
            this.txtInvoiceNo.MouseEnter += new System.EventHandler(this.txtInvoiceNo_MouseEnter);
            // 
            // frmInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(742, 446);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.grpInvoiceDetails);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.lstInvoicNo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInvoiceDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInvoiceDetails";
            this.Load += new System.EventHandler(this.frmInvoiceDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpInvoiceDetails.ResumeLayout(false);
            this.grpInvoiceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoiceDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstInvoicNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.GroupBox grpInvoiceDetails;
        private System.Windows.Forms.TextBox txtIssuedUser;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.DataGridView dgvTransition;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblIssuedUser;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.TextBox txtInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
    }
}