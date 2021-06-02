namespace CoffeeShopAplication
{
    partial class frmUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.grpAddUser = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUserType = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.grpEditAndRemoveUser = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveAndUpdate = new System.Windows.Forms.Button();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUserType2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullName2 = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnEditAndRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpAddUser.SuspendLayout();
            this.grpEditAndRemoveUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CoffeeShopAplication.Properties.Resources.logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(8, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(151)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 46);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.btnClose.Location = new System.Drawing.Point(812, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Franklin Gothic Book", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.lblUser.Location = new System.Drawing.Point(395, 12);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(47, 24);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "User";
            // 
            // grpAddUser
            // 
            this.grpAddUser.Controls.Add(this.btnSave);
            this.grpAddUser.Controls.Add(this.lblUserType);
            this.grpAddUser.Controls.Add(this.cmbUserType);
            this.grpAddUser.Controls.Add(this.lblPassword);
            this.grpAddUser.Controls.Add(this.txtPassword);
            this.grpAddUser.Controls.Add(this.lblUserName);
            this.grpAddUser.Controls.Add(this.txtUserName);
            this.grpAddUser.Controls.Add(this.lblFullName);
            this.grpAddUser.Controls.Add(this.txtFullName);
            this.grpAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpAddUser.Enabled = false;
            this.grpAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(151)))));
            this.grpAddUser.Location = new System.Drawing.Point(12, 51);
            this.grpAddUser.Name = "grpAddUser";
            this.grpAddUser.Size = new System.Drawing.Size(413, 221);
            this.grpAddUser.TabIndex = 4;
            this.grpAddUser.TabStop = false;
            this.grpAddUser.Text = "Add User";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Peru;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(169, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 36);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(58, 113);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(56, 13);
            this.lblUserType.TabIndex = 13;
            this.lblUserType.Text = "User Type";
            // 
            // cmbUserType
            // 
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmbUserType.Location = new System.Drawing.Point(124, 110);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(184, 21);
            this.cmbUserType.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(58, 87);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(124, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(184, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(58, 61);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(124, 58);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(184, 20);
            this.txtUserName.TabIndex = 8;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(58, 35);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 7;
            this.lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(124, 32);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(184, 20);
            this.txtFullName.TabIndex = 6;
            // 
            // grpEditAndRemoveUser
            // 
            this.grpEditAndRemoveUser.Controls.Add(this.btnDelete);
            this.grpEditAndRemoveUser.Controls.Add(this.btnSaveAndUpdate);
            this.grpEditAndRemoveUser.Controls.Add(this.lblUsers);
            this.grpEditAndRemoveUser.Controls.Add(this.lstUsers);
            this.grpEditAndRemoveUser.Controls.Add(this.label1);
            this.grpEditAndRemoveUser.Controls.Add(this.cmbUserType2);
            this.grpEditAndRemoveUser.Controls.Add(this.label2);
            this.grpEditAndRemoveUser.Controls.Add(this.txtPassword2);
            this.grpEditAndRemoveUser.Controls.Add(this.label3);
            this.grpEditAndRemoveUser.Controls.Add(this.txtUserName2);
            this.grpEditAndRemoveUser.Controls.Add(this.label4);
            this.grpEditAndRemoveUser.Controls.Add(this.txtFullName2);
            this.grpEditAndRemoveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpEditAndRemoveUser.Enabled = false;
            this.grpEditAndRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpEditAndRemoveUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(151)))));
            this.grpEditAndRemoveUser.Location = new System.Drawing.Point(431, 51);
            this.grpEditAndRemoveUser.Name = "grpEditAndRemoveUser";
            this.grpEditAndRemoveUser.Size = new System.Drawing.Size(412, 221);
            this.grpEditAndRemoveUser.TabIndex = 5;
            this.grpEditAndRemoveUser.TabStop = false;
            this.grpEditAndRemoveUser.Text = "Edit And Remove User";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(140, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 36);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveAndUpdate
            // 
            this.btnSaveAndUpdate.BackColor = System.Drawing.Color.Peru;
            this.btnSaveAndUpdate.FlatAppearance.BorderSize = 0;
            this.btnSaveAndUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnSaveAndUpdate.Location = new System.Drawing.Point(140, 134);
            this.btnSaveAndUpdate.Name = "btnSaveAndUpdate";
            this.btnSaveAndUpdate.Size = new System.Drawing.Size(123, 36);
            this.btnSaveAndUpdate.TabIndex = 16;
            this.btnSaveAndUpdate.Text = "Save And Update";
            this.btnSaveAndUpdate.UseVisualStyleBackColor = false;
            this.btnSaveAndUpdate.Click += new System.EventHandler(this.btnSaveAndUpdate_Click);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Location = new System.Drawing.Point(270, 12);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(34, 13);
            this.lblUsers.TabIndex = 23;
            this.lblUsers.Text = "Users";
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(270, 28);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(136, 186);
            this.lstUsers.TabIndex = 22;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "User Type";
            // 
            // cmbUserType2
            // 
            this.cmbUserType2.FormattingEnabled = true;
            this.cmbUserType2.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmbUserType2.Location = new System.Drawing.Point(80, 107);
            this.cmbUserType2.Name = "cmbUserType2";
            this.cmbUserType2.Size = new System.Drawing.Size(184, 21);
            this.cmbUserType2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(80, 81);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(184, 20);
            this.txtPassword2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "User Name";
            // 
            // txtUserName2
            // 
            this.txtUserName2.Location = new System.Drawing.Point(80, 55);
            this.txtUserName2.Name = "txtUserName2";
            this.txtUserName2.Size = new System.Drawing.Size(184, 20);
            this.txtUserName2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Full Name";
            // 
            // txtFullName2
            // 
            this.txtFullName2.Location = new System.Drawing.Point(80, 29);
            this.txtFullName2.Name = "txtFullName2";
            this.txtFullName2.Size = new System.Drawing.Size(184, 20);
            this.txtFullName2.TabIndex = 14;
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(151)))));
            this.btnAddNew.FlatAppearance.BorderSize = 0;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Location = new System.Drawing.Point(181, 278);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(79, 28);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEditAndRemove
            // 
            this.btnEditAndRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(151)))));
            this.btnEditAndRemove.FlatAppearance.BorderSize = 0;
            this.btnEditAndRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAndRemove.Location = new System.Drawing.Point(572, 278);
            this.btnEditAndRemove.Name = "btnEditAndRemove";
            this.btnEditAndRemove.Size = new System.Drawing.Size(122, 28);
            this.btnEditAndRemove.TabIndex = 12;
            this.btnEditAndRemove.Text = "Edit And Remove";
            this.btnEditAndRemove.UseVisualStyleBackColor = false;
            this.btnEditAndRemove.Click += new System.EventHandler(this.btnEditAndRemove_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(58)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(855, 320);
            this.Controls.Add(this.btnEditAndRemove);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.grpEditAndRemoveUser);
            this.Controls.Add(this.grpAddUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpAddUser.ResumeLayout(false);
            this.grpAddUser.PerformLayout();
            this.grpEditAndRemoveUser.ResumeLayout(false);
            this.grpEditAndRemoveUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.GroupBox grpAddUser;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.GroupBox grpEditAndRemoveUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveAndUpdate;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUserType2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullName2;
        private System.Windows.Forms.Button btnEditAndRemove;
    }
}