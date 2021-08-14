namespace QuanLyThueBao
{
    partial class FormShowListAllBill
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
            this.reportAllBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataBill = new QuanLyThueBao.dataBill();
            this.dataTableBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportAllBill
            // 
            this.reportAllBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.reportAllBill.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dataBill";
            reportDataSource1.Value = this.dataTableBillBindingSource;
            this.reportAllBill.LocalReport.DataSources.Add(reportDataSource1);
            this.reportAllBill.LocalReport.ReportEmbeddedResource = "QuanLyThueBao.reportBill.rdlc";
            this.reportAllBill.Location = new System.Drawing.Point(0, 0);
            this.reportAllBill.Name = "reportAllBill";
            this.reportAllBill.Size = new System.Drawing.Size(1227, 583);
            this.reportAllBill.TabIndex = 0;
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
            // FormShowListAllBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1227, 583);
            this.Controls.Add(this.reportAllBill);
            this.Name = "FormShowListAllBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DS Tất Cả Hóa Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormShowListAllBill_FormClosing);
            this.Load += new System.EventHandler(this.FormShowListAllBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBillBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportAllBill;
        private System.Windows.Forms.BindingSource dataTableBillBindingSource;
        private dataBill dataBill;
    }
}