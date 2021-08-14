namespace QuanLyThueBao
{
    partial class FormRegion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableRegion = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new QuanLyThueBao.RJTextBox();
            this.cboSearch = new QuanLyThueBao.RJComboBox();
            this.txtNameRegion = new QuanLyThueBao.RJTextBox();
            this.txtIdRegion = new QuanLyThueBao.RJTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNameRegion);
            this.groupBox1.Controls.Add(this.txtIdRegion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(242, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Dữ Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Vùng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Vùng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(640, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(190, 101);
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
            this.button3.Location = new System.Drawing.Point(191, 26);
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
            this.button2.Location = new System.Drawing.Point(21, 100);
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
            this.button1.Location = new System.Drawing.Point(21, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableRegion
            // 
            this.tableRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tableRegion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.idRegion,
            this.nameRegion});
            this.tableRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableRegion.FullRowSelect = true;
            this.tableRegion.GridLines = true;
            this.tableRegion.Location = new System.Drawing.Point(79, 293);
            this.tableRegion.Name = "tableRegion";
            this.tableRegion.Size = new System.Drawing.Size(1068, 304);
            this.tableRegion.TabIndex = 2;
            this.tableRegion.UseCompatibleStateImageBehavior = false;
            this.tableRegion.View = System.Windows.Forms.View.Details;
            this.tableRegion.SelectedIndexChanged += new System.EventHandler(this.tableRegion_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 100;
            // 
            // idRegion
            // 
            this.idRegion.Text = "Mã Vùng";
            this.idRegion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idRegion.Width = 300;
            // 
            // nameRegion
            // 
            this.nameRegion.Text = "Tên Vùng";
            this.nameRegion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameRegion.Width = 700;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSearch.BorderSize = 3;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(617, 228);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.Size = new System.Drawing.Size(237, 35);
            this.txtSearch.TabIndex = 22;
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
            this.cboSearch.Location = new System.Drawing.Point(373, 228);
            this.cboSearch.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Padding = new System.Windows.Forms.Padding(2);
            this.cboSearch.Size = new System.Drawing.Size(237, 35);
            this.cboSearch.TabIndex = 20;
            this.cboSearch.Texts = "";
            // 
            // txtNameRegion
            // 
            this.txtNameRegion.BackColor = System.Drawing.SystemColors.Window;
            this.txtNameRegion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNameRegion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNameRegion.BorderSize = 3;
            this.txtNameRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameRegion.ForeColor = System.Drawing.Color.Black;
            this.txtNameRegion.Location = new System.Drawing.Point(113, 121);
            this.txtNameRegion.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameRegion.Multiline = false;
            this.txtNameRegion.Name = "txtNameRegion";
            this.txtNameRegion.Padding = new System.Windows.Forms.Padding(7);
            this.txtNameRegion.PasswordChar = false;
            this.txtNameRegion.Size = new System.Drawing.Size(250, 35);
            this.txtNameRegion.TabIndex = 21;
            this.txtNameRegion.Texts = "";
            this.txtNameRegion.UnderlinedStyle = false;
            // 
            // txtIdRegion
            // 
            this.txtIdRegion.BackColor = System.Drawing.SystemColors.Window;
            this.txtIdRegion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtIdRegion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIdRegion.BorderSize = 3;
            this.txtIdRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdRegion.ForeColor = System.Drawing.Color.Black;
            this.txtIdRegion.Location = new System.Drawing.Point(113, 47);
            this.txtIdRegion.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdRegion.Multiline = false;
            this.txtIdRegion.Name = "txtIdRegion";
            this.txtIdRegion.Padding = new System.Windows.Forms.Padding(7);
            this.txtIdRegion.PasswordChar = false;
            this.txtIdRegion.Size = new System.Drawing.Size(250, 35);
            this.txtIdRegion.TabIndex = 20;
            this.txtIdRegion.Texts = "";
            this.txtIdRegion.UnderlinedStyle = false;
            // 
            // FormRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1227, 634);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.tableRegion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormRegion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Vùng";
            this.Load += new System.EventHandler(this.FormRegion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView tableRegion;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader idRegion;
        private System.Windows.Forms.ColumnHeader nameRegion;
        private RJTextBox txtNameRegion;
        private RJTextBox txtIdRegion;
        private RJComboBox cboSearch;
        private RJTextBox txtSearch;
    }
}

