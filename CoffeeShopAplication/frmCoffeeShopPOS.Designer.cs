namespace CoffeeShopAplication
{
    partial class frmCoffeeShopPOS
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCoffeeShopPOS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.libItemList = new System.Windows.Forms.ListBox();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.tabProducts = new System.Windows.Forms.TabControl();
            this.tabHotDrinks = new System.Windows.Forms.TabPage();
            this.tabColdDrinks = new System.Windows.Forms.TabPage();
            this.tabFoods = new System.Windows.Forms.TabPage();
            this.tabOthers = new System.Windows.Forms.TabPage();
            this.txtCurrentItem = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CoffeeShopAplication.Properties.Resources.logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.btnClose.Location = new System.Drawing.Point(814, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCoffeeShopPOS
            // 
            this.lblCoffeeShopPOS.AutoSize = true;
            this.lblCoffeeShopPOS.Font = new System.Drawing.Font("Franklin Gothic Book", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeShopPOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.lblCoffeeShopPOS.Location = new System.Drawing.Point(384, 12);
            this.lblCoffeeShopPOS.Name = "lblCoffeeShopPOS";
            this.lblCoffeeShopPOS.Size = new System.Drawing.Size(86, 24);
            this.lblCoffeeShopPOS.TabIndex = 12;
            this.lblCoffeeShopPOS.Text = "WelCome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.dtmDate);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblCoffeeShopPOS);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 46);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dtmDate
            // 
            this.dtmDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDate.Location = new System.Drawing.Point(624, 12);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(141, 20);
            this.dtmDate.TabIndex = 10;
            // 
            // libItemList
            // 
            this.libItemList.FormattingEnabled = true;
            this.libItemList.Location = new System.Drawing.Point(562, 57);
            this.libItemList.Name = "libItemList";
            this.libItemList.Size = new System.Drawing.Size(280, 420);
            this.libItemList.TabIndex = 3;
            this.libItemList.SelectedIndexChanged += new System.EventHandler(this.libItemList_SelectedIndexChanged);
            this.libItemList.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.libItemList_ControlAdded);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Lime;
            this.btnDeleteItem.FlatAppearance.BorderSize = 0;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Location = new System.Drawing.Point(562, 489);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(84, 30);
            this.btnDeleteItem.TabIndex = 4;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            this.btnDeleteItem.MouseLeave += new System.EventHandler(this.btnDeleteItem_MouseLeave);
            this.btnDeleteItem.MouseHover += new System.EventHandler(this.btnDeleteItem_MouseHover);
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.tabHotDrinks);
            this.tabProducts.Controls.Add(this.tabColdDrinks);
            this.tabProducts.Controls.Add(this.tabFoods);
            this.tabProducts.Controls.Add(this.tabOthers);
            this.tabProducts.Location = new System.Drawing.Point(12, 92);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.SelectedIndex = 0;
            this.tabProducts.Size = new System.Drawing.Size(536, 385);
            this.tabProducts.TabIndex = 5;
            // 
            // tabHotDrinks
            // 
            this.tabHotDrinks.ForeColor = System.Drawing.Color.Black;
            this.tabHotDrinks.Location = new System.Drawing.Point(4, 22);
            this.tabHotDrinks.Name = "tabHotDrinks";
            this.tabHotDrinks.Padding = new System.Windows.Forms.Padding(3);
            this.tabHotDrinks.Size = new System.Drawing.Size(528, 359);
            this.tabHotDrinks.TabIndex = 0;
            this.tabHotDrinks.Text = "Hot Drinks";
            this.tabHotDrinks.UseVisualStyleBackColor = true;
            this.tabHotDrinks.Click += new System.EventHandler(this.tabHotDrinks_Click);
            // 
            // tabColdDrinks
            // 
            this.tabColdDrinks.Location = new System.Drawing.Point(4, 22);
            this.tabColdDrinks.Name = "tabColdDrinks";
            this.tabColdDrinks.Padding = new System.Windows.Forms.Padding(3);
            this.tabColdDrinks.Size = new System.Drawing.Size(528, 359);
            this.tabColdDrinks.TabIndex = 1;
            this.tabColdDrinks.Text = "Cold Drinks";
            this.tabColdDrinks.UseVisualStyleBackColor = true;
            this.tabColdDrinks.Click += new System.EventHandler(this.tabColdDrinks_Click);
            // 
            // tabFoods
            // 
            this.tabFoods.Location = new System.Drawing.Point(4, 22);
            this.tabFoods.Name = "tabFoods";
            this.tabFoods.Padding = new System.Windows.Forms.Padding(3);
            this.tabFoods.Size = new System.Drawing.Size(528, 359);
            this.tabFoods.TabIndex = 2;
            this.tabFoods.Text = "Foods";
            this.tabFoods.UseVisualStyleBackColor = true;
            this.tabFoods.Click += new System.EventHandler(this.tabFoods_Click);
            // 
            // tabOthers
            // 
            this.tabOthers.Location = new System.Drawing.Point(4, 22);
            this.tabOthers.Name = "tabOthers";
            this.tabOthers.Padding = new System.Windows.Forms.Padding(3);
            this.tabOthers.Size = new System.Drawing.Size(528, 359);
            this.tabOthers.TabIndex = 3;
            this.tabOthers.Text = "Others";
            this.tabOthers.UseVisualStyleBackColor = true;
            this.tabOthers.Click += new System.EventHandler(this.tabOthers_Click);
            // 
            // txtCurrentItem
            // 
            this.txtCurrentItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentItem.Location = new System.Drawing.Point(335, 57);
            this.txtCurrentItem.Name = "txtCurrentItem";
            this.txtCurrentItem.Size = new System.Drawing.Size(213, 20);
            this.txtCurrentItem.TabIndex = 6;
            this.txtCurrentItem.TextChanged += new System.EventHandler(this.txtCurrentItem_TextChanged);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Crimson;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPay.Location = new System.Drawing.Point(151, 489);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(246, 30);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(652, 494);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(190, 20);
            this.txtTotal.TabIndex = 0;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceNo.Location = new System.Drawing.Point(179, 57);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(135, 20);
            this.txtInvoiceNo.TabIndex = 8;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblInvoiceNo.Location = new System.Drawing.Point(114, 59);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(59, 13);
            this.lblInvoiceNo.TabIndex = 9;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // frmCoffeeShopPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(854, 528);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtCurrentItem);
            this.Controls.Add(this.tabProducts);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.libItemList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCoffeeShopPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCoffeeShopPOS";
            this.Load += new System.EventHandler(this.frmCoffeeShopPOS_Load);
            this.TextChanged += new System.EventHandler(this.libItemList_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabProducts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCoffeeShopPOS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox libItemList;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.TabControl tabProducts;
        private System.Windows.Forms.TabPage tabHotDrinks;
        private System.Windows.Forms.TabPage tabColdDrinks;
        private System.Windows.Forms.TabPage tabFoods;
        private System.Windows.Forms.TabPage tabOthers;
        private System.Windows.Forms.TextBox txtCurrentItem;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.DateTimePicker dtmDate;
    }
}