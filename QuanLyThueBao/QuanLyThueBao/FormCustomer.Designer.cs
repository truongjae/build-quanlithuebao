namespace QuanLyThueBao
{
    partial class FormCustomer
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
            this.txtDOB = new QuanLyThueBao.RJDatePicker();
            this.txtSex = new QuanLyThueBao.RJComboBox();
            this.txtEmail = new QuanLyThueBao.RJTextBox();
            this.txtAddress = new QuanLyThueBao.RJTextBox();
            this.txtName = new QuanLyThueBao.RJTextBox();
            this.txtIdCard = new QuanLyThueBao.RJTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableCustomer = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idCard = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.avatar = new System.Windows.Forms.PictureBox();
            this.lbavt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbCardBack = new System.Windows.Forms.Label();
            this.lbCardFront = new System.Windows.Forms.Label();
            this.imgIdCardBack = new System.Windows.Forms.PictureBox();
            this.imgIdCardFront = new System.Windows.Forms.PictureBox();
            this.txtSearch = new QuanLyThueBao.RJTextBox();
            this.cboSearch = new QuanLyThueBao.RJComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIdCardBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIdCardFront)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDOB);
            this.groupBox1.Controls.Add(this.txtSex);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtIdCard);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 265);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Dữ Liệu";
            // 
            // txtDOB
            // 
            this.txtDOB.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.txtDOB.BorderSize = 0;
            this.txtDOB.CustomFormat = "dd-MM-yyyy";
            this.txtDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.txtDOB.Location = new System.Drawing.Point(156, 100);
            this.txtDOB.MinimumSize = new System.Drawing.Size(4, 35);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(200, 35);
            this.txtDOB.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDOB.TabIndex = 33;
            this.txtDOB.TextColor = System.Drawing.Color.White;
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txtSex.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSex.BorderSize = 2;
            this.txtSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.txtSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.Color.White;
            this.txtSex.IconColor = System.Drawing.Color.White;
            this.txtSex.ListBackColor = System.Drawing.Color.White;
            this.txtSex.ListTextColor = System.Drawing.Color.Black;
            this.txtSex.Location = new System.Drawing.Point(156, 141);
            this.txtSex.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtSex.Name = "txtSex";
            this.txtSex.Padding = new System.Windows.Forms.Padding(2);
            this.txtSex.Size = new System.Drawing.Size(200, 35);
            this.txtSex.TabIndex = 26;
            this.txtSex.Texts = "";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderSize = 3;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(156, 223);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(250, 35);
            this.txtEmail.TabIndex = 25;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAddress.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAddress.BorderSize = 3;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(156, 183);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(7);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.Size = new System.Drawing.Size(250, 35);
            this.txtAddress.TabIndex = 24;
            this.txtAddress.Texts = "";
            this.txtAddress.UnderlinedStyle = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtName.BorderSize = 3;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(156, 60);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(7);
            this.txtName.PasswordChar = false;
            this.txtName.Size = new System.Drawing.Size(250, 35);
            this.txtName.TabIndex = 23;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // txtIdCard
            // 
            this.txtIdCard.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdCard.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtIdCard.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIdCard.BorderSize = 3;
            this.txtIdCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCard.ForeColor = System.Drawing.Color.Black;
            this.txtIdCard.Location = new System.Drawing.Point(156, 20);
            this.txtIdCard.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCard.Multiline = false;
            this.txtIdCard.Name = "txtIdCard";
            this.txtIdCard.Padding = new System.Windows.Forms.Padding(7);
            this.txtIdCard.PasswordChar = false;
            this.txtIdCard.Size = new System.Drawing.Size(250, 35);
            this.txtIdCard.TabIndex = 22;
            this.txtIdCard.Texts = "";
            this.txtIdCard.UnderlinedStyle = false;
            this.txtIdCard._TextChanged += new System.EventHandler(this.txtIdCard__TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Và Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số CMND/CCCD";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(451, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 331);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(37, 250);
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
            this.button3.Location = new System.Drawing.Point(37, 98);
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
            this.button2.Location = new System.Drawing.Point(37, 174);
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
            this.button1.Location = new System.Drawing.Point(37, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableCustomer
            // 
            this.tableCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tableCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.idCard,
            this.name,
            this.dob,
            this.sex,
            this.address,
            this.email});
            this.tableCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableCustomer.FullRowSelect = true;
            this.tableCustomer.GridLines = true;
            this.tableCustomer.Location = new System.Drawing.Point(8, 356);
            this.tableCustomer.Name = "tableCustomer";
            this.tableCustomer.Size = new System.Drawing.Size(654, 256);
            this.tableCustomer.TabIndex = 4;
            this.tableCustomer.UseCompatibleStateImageBehavior = false;
            this.tableCustomer.View = System.Windows.Forms.View.Details;
            this.tableCustomer.SelectedIndexChanged += new System.EventHandler(this.tableCustomer_SelectedIndexChanged);
            this.tableCustomer.MouseLeave += new System.EventHandler(this.tableCustomer_MouseLeave);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // idCard
            // 
            this.idCard.Text = "CMND/CCCD";
            this.idCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idCard.Width = 200;
            // 
            // name
            // 
            this.name.Text = "Họ Và Tên";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 300;
            // 
            // dob
            // 
            this.dob.Text = "Ngày Sinh";
            this.dob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dob.Width = 200;
            // 
            // sex
            // 
            this.sex.Text = "Giới Tính";
            this.sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sex.Width = 100;
            // 
            // address
            // 
            this.address.Text = "Địa Chỉ";
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.address.Width = 300;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email.Width = 250;
            // 
            // avatar
            // 
            this.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.avatar.Location = new System.Drawing.Point(3, 3);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(181, 254);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 5;
            this.avatar.TabStop = false;
            this.avatar.Click += new System.EventHandler(this.avatar_Click);
            // 
            // lbavt
            // 
            this.lbavt.AutoSize = true;
            this.lbavt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbavt.Location = new System.Drawing.Point(33, 260);
            this.lbavt.Name = "lbavt";
            this.lbavt.Size = new System.Drawing.Size(123, 20);
            this.lbavt.TabIndex = 6;
            this.lbavt.Text = "Ảnh Chân Dung";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.avatar);
            this.panel1.Controls.Add(this.lbavt);
            this.panel1.Location = new System.Drawing.Point(674, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 285);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbCardBack);
            this.panel2.Controls.Add(this.lbCardFront);
            this.panel2.Controls.Add(this.imgIdCardBack);
            this.panel2.Controls.Add(this.imgIdCardFront);
            this.panel2.Location = new System.Drawing.Point(873, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 480);
            this.panel2.TabIndex = 8;
            // 
            // lbCardBack
            // 
            this.lbCardBack.AutoSize = true;
            this.lbCardBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardBack.Location = new System.Drawing.Point(88, 457);
            this.lbCardBack.Name = "lbCardBack";
            this.lbCardBack.Size = new System.Drawing.Size(169, 20);
            this.lbCardBack.TabIndex = 8;
            this.lbCardBack.Text = "CMND/CCCD Mặt Sau";
            // 
            // lbCardFront
            // 
            this.lbCardFront.AutoSize = true;
            this.lbCardFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCardFront.Location = new System.Drawing.Point(84, 5);
            this.lbCardFront.Name = "lbCardFront";
            this.lbCardFront.Size = new System.Drawing.Size(180, 20);
            this.lbCardFront.TabIndex = 7;
            this.lbCardFront.Text = "CMND/CCCD Mặt Trước";
            // 
            // imgIdCardBack
            // 
            this.imgIdCardBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgIdCardBack.Location = new System.Drawing.Point(0, 247);
            this.imgIdCardBack.Name = "imgIdCardBack";
            this.imgIdCardBack.Size = new System.Drawing.Size(346, 207);
            this.imgIdCardBack.TabIndex = 1;
            this.imgIdCardBack.TabStop = false;
            this.imgIdCardBack.Click += new System.EventHandler(this.imgIdCardBack_Click);
            // 
            // imgIdCardFront
            // 
            this.imgIdCardFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgIdCardFront.Location = new System.Drawing.Point(0, 27);
            this.imgIdCardFront.Name = "imgIdCardFront";
            this.imgIdCardFront.Size = new System.Drawing.Size(346, 207);
            this.imgIdCardFront.TabIndex = 0;
            this.imgIdCardFront.TabStop = false;
            this.imgIdCardFront.Click += new System.EventHandler(this.imgIdCardFront_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderSize = 3;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(250, 299);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.Size = new System.Drawing.Size(182, 35);
            this.txtSearch.TabIndex = 34;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
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
            this.cboSearch.Location = new System.Drawing.Point(12, 299);
            this.cboSearch.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Padding = new System.Windows.Forms.Padding(2);
            this.cboSearch.Size = new System.Drawing.Size(231, 35);
            this.cboSearch.TabIndex = 34;
            this.cboSearch.Texts = "";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1227, 624);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableCustomer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Khách Hàng";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIdCardBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIdCardFront)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView tableCustomer;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader idCard;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader dob;
        private System.Windows.Forms.ColumnHeader sex;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label lbavt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbCardBack;
        private System.Windows.Forms.Label lbCardFront;
        private System.Windows.Forms.PictureBox imgIdCardBack;
        private System.Windows.Forms.PictureBox imgIdCardFront;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader email;
        private RJTextBox txtEmail;
        private RJTextBox txtAddress;
        private RJTextBox txtName;
        private RJTextBox txtIdCard;
        private RJComboBox txtSex;
        private RJDatePicker txtDOB;
        private RJComboBox cboSearch;
        private RJTextBox txtSearch;
    }
}