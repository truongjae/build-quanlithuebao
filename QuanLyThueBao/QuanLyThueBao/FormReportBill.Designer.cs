namespace QuanLyThueBao
{
    partial class FormReportBill
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.picAvt = new QuanLyThueBao.RJCircularPictureBox();
            this.txtName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboPhone = new System.Windows.Forms.ComboBox();
            this.cboOption = new QuanLyThueBao.RJComboBox();
            this.btnBill = new System.Windows.Forms.Button();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.dataBill = new QuanLyThueBao.dataBill();
            this.dataTableBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportBill
            // 
            this.reportBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.reportBill.ForeColor = System.Drawing.Color.White;
            reportDataSource1.Name = "dataBill";
            reportDataSource1.Value = this.dataTableBillBindingSource;
            this.reportBill.LocalReport.DataSources.Add(reportDataSource1);
            this.reportBill.LocalReport.ReportEmbeddedResource = "QuanLyThueBao.reportBill.rdlc";
            this.reportBill.Location = new System.Drawing.Point(4, 169);
            this.reportBill.Name = "reportBill";
            this.reportBill.Size = new System.Drawing.Size(1218, 409);
            this.reportBill.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.picAvt);
            this.panelInfo.Controls.Add(this.txtName);
            this.panelInfo.Location = new System.Drawing.Point(430, 94);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(342, 69);
            this.panelInfo.TabIndex = 51;
            // 
            // picAvt
            // 
            this.picAvt.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picAvt.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picAvt.BorderColor2 = System.Drawing.Color.HotPink;
            this.picAvt.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.picAvt.BorderSize = 3;
            this.picAvt.GradientAngle = 50F;
            this.picAvt.Location = new System.Drawing.Point(3, -1);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(70, 70);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvt.TabIndex = 46;
            this.picAvt.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtName.Location = new System.Drawing.Point(86, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(0, 25);
            this.txtName.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboPhone);
            this.panel1.Controls.Add(this.cboOption);
            this.panel1.Location = new System.Drawing.Point(315, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 50);
            this.panel1.TabIndex = 53;
            // 
            // cboPhone
            // 
            this.cboPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhone.FormattingEnabled = true;
            this.cboPhone.Location = new System.Drawing.Point(246, 11);
            this.cboPhone.Name = "cboPhone";
            this.cboPhone.Size = new System.Drawing.Size(200, 28);
            this.cboPhone.TabIndex = 53;
            this.cboPhone.TextChanged += new System.EventHandler(this.cboPhone_TextChanged);
            // 
            // cboOption
            // 
            this.cboOption.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cboOption.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboOption.BorderSize = 2;
            this.cboOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOption.ForeColor = System.Drawing.Color.White;
            this.cboOption.IconColor = System.Drawing.Color.White;
            this.cboOption.ListBackColor = System.Drawing.Color.White;
            this.cboOption.ListTextColor = System.Drawing.Color.Black;
            this.cboOption.Location = new System.Drawing.Point(11, 8);
            this.cboOption.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboOption.Name = "cboOption";
            this.cboOption.Padding = new System.Windows.Forms.Padding(2);
            this.cboOption.Size = new System.Drawing.Size(200, 35);
            this.cboOption.TabIndex = 52;
            this.cboOption.Texts = "";
            this.cboOption.OnSelectedIndexChanged += new System.EventHandler(this.cboOption_OnSelectedIndexChanged);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Location = new System.Drawing.Point(778, 32);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(143, 63);
            this.btnBill.TabIndex = 54;
            this.btnBill.Text = "Tạo Hóa Đơn";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Image = global::QuanLyThueBao.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(1199, -2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(32, 32);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 55;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // dataBill
            // 
            this.dataBill.DataSetName = "dataBill";
            this.dataBill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableBillBindingSource
            // 
            this.dataTableBillBindingSource.DataMember = "dataTableBill";
            this.dataTableBillBindingSource.DataSource = this.dataBill;
            // 
            // FormReportBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1227, 583);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.reportBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Hóa Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReportBill_FormClosing);
            this.Load += new System.EventHandler(this.FormReportBill_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBillBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportBill;
        private System.Windows.Forms.Panel panelInfo;
        private RJCircularPictureBox picAvt;
        private System.Windows.Forms.Label txtName;
        private RJComboBox cboOption;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboPhone;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.BindingSource dataTableBillBindingSource;
        private dataBill dataBill;
    }
}