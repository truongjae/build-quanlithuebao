namespace QuanLyThueBao
{
    partial class FormAccount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPermission = new QuanLyThueBao.RJComboBox();
            this.txtPw = new QuanLyThueBao.RJTextBox();
            this.txtUsername = new System.Windows.Forms.ComboBox();
            this.lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAccount = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.account = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pw = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.permission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboSearch = new QuanLyThueBao.RJComboBox();
            this.txtSearch = new QuanLyThueBao.RJTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPermission);
            this.groupBox1.Controls.Add(this.txtPw);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(84, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 221);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Dữ Liệu";
            // 
            // txtPermission
            // 
            this.txtPermission.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtPermission.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPermission.BorderSize = 2;
            this.txtPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.txtPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPermission.ForeColor = System.Drawing.Color.White;
            this.txtPermission.IconColor = System.Drawing.Color.White;
            this.txtPermission.ListBackColor = System.Drawing.Color.White;
            this.txtPermission.ListTextColor = System.Drawing.Color.Black;
            this.txtPermission.Location = new System.Drawing.Point(263, 96);
            this.txtPermission.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtPermission.Name = "txtPermission";
            this.txtPermission.Padding = new System.Windows.Forms.Padding(2);
            this.txtPermission.Size = new System.Drawing.Size(200, 35);
            this.txtPermission.TabIndex = 21;
            this.txtPermission.Texts = "";
            // 
            // txtPw
            // 
            this.txtPw.BackColor = System.Drawing.SystemColors.Window;
            this.txtPw.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPw.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPw.BorderSize = 3;
            this.txtPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPw.ForeColor = System.Drawing.Color.Black;
            this.txtPw.Location = new System.Drawing.Point(263, 158);
            this.txtPw.Margin = new System.Windows.Forms.Padding(4);
            this.txtPw.Multiline = false;
            this.txtPw.Name = "txtPw";
            this.txtPw.Padding = new System.Windows.Forms.Padding(7);
            this.txtPw.PasswordChar = false;
            this.txtPw.Size = new System.Drawing.Size(306, 35);
            this.txtPw.TabIndex = 23;
            this.txtPw.Texts = "";
            this.txtPw.UnderlinedStyle = false;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.FormattingEnabled = true;
            this.txtUsername.Location = new System.Drawing.Point(263, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(306, 28);
            this.txtUsername.TabIndex = 20;
            this.txtUsername.SelectedIndexChanged += new System.EventHandler(this.txtUsername_SelectedIndexChanged);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(108, 166);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(77, 20);
            this.lb.TabIndex = 6;
            this.lb.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(789, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 272);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(184, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 68);
            this.button4.TabIndex = 3;
            this.button4.Text = "Xóa Hết";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(184, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 68);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cập Nhật";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(32, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAccount
            // 
            this.tableAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tableAccount.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.account,
            this.pw,
            this.permission});
            this.tableAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableAccount.FullRowSelect = true;
            this.tableAccount.GridLines = true;
            this.tableAccount.Location = new System.Drawing.Point(84, 334);
            this.tableAccount.Name = "tableAccount";
            this.tableAccount.Size = new System.Drawing.Size(1058, 242);
            this.tableAccount.TabIndex = 24;
            this.tableAccount.UseCompatibleStateImageBehavior = false;
            this.tableAccount.View = System.Windows.Forms.View.Details;
            this.tableAccount.SelectedIndexChanged += new System.EventHandler(this.tableAccount_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // account
            // 
            this.account.Text = "Tên Tài Khoản";
            this.account.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.account.Width = 300;
            // 
            // pw
            // 
            this.pw.Text = "Mật Khẩu";
            this.pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pw.Width = 450;
            // 
            // permission
            // 
            this.permission.Text = "Quyền";
            this.permission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.permission.Width = 250;
            // 
            // cboSearch
            // 
            this.cboSearch.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cboSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboSearch.BorderSize = 2;
            this.cboSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSearch.ForeColor = System.Drawing.Color.White;
            this.cboSearch.IconColor = System.Drawing.Color.White;
            this.cboSearch.ListBackColor = System.Drawing.Color.White;
            this.cboSearch.ListTextColor = System.Drawing.Color.Black;
            this.cboSearch.Location = new System.Drawing.Point(217, 275);
            this.cboSearch.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Padding = new System.Windows.Forms.Padding(2);
            this.cboSearch.Size = new System.Drawing.Size(200, 35);
            this.cboSearch.TabIndex = 24;
            this.cboSearch.Texts = "";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderSize = 3;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(431, 275);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.Size = new System.Drawing.Size(199, 35);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1227, 583);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.tableAccount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAccount";
            this.Text = "Bảng Tài Khoản";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtUsername;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView tableAccount;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader account;
        private System.Windows.Forms.ColumnHeader permission;
        private System.Windows.Forms.ColumnHeader pw;
        private RJTextBox txtPw;
        private RJComboBox txtPermission;
        private RJComboBox cboSearch;
        private RJTextBox txtSearch;
    }
}