namespace QuanLyThueBao
{
    partial class FormService
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
            this.txtNetwork = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExpDate = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPromotion = new System.Windows.Forms.NumericUpDown();
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
            this.tableService = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.network = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.promotion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new QuanLyThueBao.RJTextBox();
            this.cboSearch = new QuanLyThueBao.RJComboBox();
            this.txtInfo = new QuanLyThueBao.RJTextBox();
            this.txtPrice = new QuanLyThueBao.RJTextBox();
            this.txtNameService = new QuanLyThueBao.RJTextBox();
            this.txtIdService = new QuanLyThueBao.RJTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPromotion)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNetwork);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtNameService);
            this.groupBox1.Controls.Add(this.txtIdService);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtExpDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPromotion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(96, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 338);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Dữ Liệu";
            // 
            // txtNetwork
            // 
            this.txtNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetwork.FormattingEnabled = true;
            this.txtNetwork.Location = new System.Drawing.Point(264, 99);
            this.txtNetwork.Name = "txtNetwork";
            this.txtNetwork.Size = new System.Drawing.Size(304, 28);
            this.txtNetwork.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(109, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Chi Tiết";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(351, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ngày";
            // 
            // txtExpDate
            // 
            this.txtExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpDate.Location = new System.Drawing.Point(263, 215);
            this.txtExpDate.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(73, 26);
            this.txtExpDate.TabIndex = 21;
            this.txtExpDate.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(524, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(352, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "%";
            // 
            // txtPromotion
            // 
            this.txtPromotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromotion.Location = new System.Drawing.Point(263, 180);
            this.txtPromotion.Name = "txtPromotion";
            this.txtPromotion.Size = new System.Drawing.Size(73, 26);
            this.txtPromotion.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(108, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Thời Gian Sử Dụng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Khuyến Mãi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá Dịch Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Nhà Mạng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Dịch Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Dịch Vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(778, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 272);
            this.groupBox2.TabIndex = 4;
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
            // tableService
            // 
            this.tableService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tableService.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.idService,
            this.nameService,
            this.network,
            this.price,
            this.promotion,
            this.expDate,
            this.info});
            this.tableService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableService.FullRowSelect = true;
            this.tableService.GridLines = true;
            this.tableService.Location = new System.Drawing.Point(96, 390);
            this.tableService.Name = "tableService";
            this.tableService.Size = new System.Drawing.Size(1035, 219);
            this.tableService.TabIndex = 5;
            this.tableService.UseCompatibleStateImageBehavior = false;
            this.tableService.View = System.Windows.Forms.View.Details;
            this.tableService.SelectedIndexChanged += new System.EventHandler(this.tableService_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // idService
            // 
            this.idService.Text = "Mã Dịch Vụ";
            this.idService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idService.Width = 150;
            // 
            // nameService
            // 
            this.nameService.Text = "Tên Dịch Vụ";
            this.nameService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameService.Width = 200;
            // 
            // network
            // 
            this.network.Text = "Mã Nhà Mạng";
            this.network.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.network.Width = 150;
            // 
            // price
            // 
            this.price.Text = "Giá";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.Width = 200;
            // 
            // promotion
            // 
            this.promotion.Text = "Khuyến Mãi";
            this.promotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.promotion.Width = 150;
            // 
            // expDate
            // 
            this.expDate.Text = "Thời Gian Dùng";
            this.expDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.expDate.Width = 150;
            // 
            // info
            // 
            this.info.Text = "Chi Tiết Gói";
            this.info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.info.Width = 400;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(611, 349);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.Size = new System.Drawing.Size(213, 35);
            this.txtSearch.TabIndex = 29;
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
            this.cboSearch.Location = new System.Drawing.Point(398, 349);
            this.cboSearch.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Padding = new System.Windows.Forms.Padding(2);
            this.cboSearch.Size = new System.Drawing.Size(206, 35);
            this.cboSearch.TabIndex = 28;
            this.cboSearch.Texts = "";
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.SystemColors.Window;
            this.txtInfo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtInfo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtInfo.BorderSize = 3;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.ForeColor = System.Drawing.Color.Black;
            this.txtInfo.Location = new System.Drawing.Point(263, 251);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Padding = new System.Windows.Forms.Padding(7);
            this.txtInfo.PasswordChar = false;
            this.txtInfo.Size = new System.Drawing.Size(305, 76);
            this.txtInfo.TabIndex = 28;
            this.txtInfo.Texts = "";
            this.txtInfo.UnderlinedStyle = false;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrice.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPrice.BorderSize = 3;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Location = new System.Drawing.Point(263, 137);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrice.PasswordChar = false;
            this.txtPrice.Size = new System.Drawing.Size(256, 35);
            this.txtPrice.TabIndex = 26;
            this.txtPrice.Texts = "";
            this.txtPrice.UnderlinedStyle = false;
            this.txtPrice._TextChanged += new System.EventHandler(this.txtPrice__TextChanged);
            // 
            // txtNameService
            // 
            this.txtNameService.BackColor = System.Drawing.SystemColors.Window;
            this.txtNameService.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNameService.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNameService.BorderSize = 3;
            this.txtNameService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameService.ForeColor = System.Drawing.Color.Black;
            this.txtNameService.Location = new System.Drawing.Point(264, 54);
            this.txtNameService.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameService.Multiline = false;
            this.txtNameService.Name = "txtNameService";
            this.txtNameService.Padding = new System.Windows.Forms.Padding(7);
            this.txtNameService.PasswordChar = false;
            this.txtNameService.Size = new System.Drawing.Size(306, 35);
            this.txtNameService.TabIndex = 25;
            this.txtNameService.Texts = "";
            this.txtNameService.UnderlinedStyle = false;
            // 
            // txtIdService
            // 
            this.txtIdService.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdService.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtIdService.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIdService.BorderSize = 3;
            this.txtIdService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdService.ForeColor = System.Drawing.Color.Black;
            this.txtIdService.Location = new System.Drawing.Point(263, 13);
            this.txtIdService.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdService.Multiline = false;
            this.txtIdService.Name = "txtIdService";
            this.txtIdService.Padding = new System.Windows.Forms.Padding(7);
            this.txtIdService.PasswordChar = false;
            this.txtIdService.Size = new System.Drawing.Size(306, 35);
            this.txtIdService.TabIndex = 22;
            this.txtIdService.Texts = "";
            this.txtIdService.UnderlinedStyle = false;
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1223, 621);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.tableService);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Dịch Vụ";
            this.Load += new System.EventHandler(this.FormService_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPromotion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txtPromotion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtExpDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView tableService;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader idService;
        private System.Windows.Forms.ColumnHeader nameService;
        private System.Windows.Forms.ColumnHeader network;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader promotion;
        private System.Windows.Forms.ColumnHeader expDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader info;
        private RJTextBox txtPrice;
        private RJTextBox txtNameService;
        private RJTextBox txtIdService;
        private RJTextBox txtInfo;
        private RJComboBox cboSearch;
        private RJTextBox txtSearch;
        private System.Windows.Forms.ComboBox txtNetwork;
    }
}