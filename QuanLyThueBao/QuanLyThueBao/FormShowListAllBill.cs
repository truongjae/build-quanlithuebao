using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyThueBao
{
    public partial class FormShowListAllBill : Form
    {
        private Connection connection = new Connection();
        private string myPhone ="";
        public FormShowListAllBill()
        {
            InitializeComponent();
           
        }
        public FormShowListAllBill(string myPhone)
        {
            InitializeComponent();
            this.myPhone = myPhone;
            
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        private void FormShowListAllBill_Load(object sender, EventArgs e)
        {
            this.reportAllBill.RefreshReport();
            string sql ="";
            if (myPhone.Equals("")) sql = "select * from bill";
            else sql = "select * from bill where phone_number = N'"+this.myPhone+"'";
            DataTable DT = connection.getDataTable(sql);
            reportAllBill.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            if (DT.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dataBill";
                rds.Value = DT;
                reportAllBill.LocalReport.DataSources.Clear();
                reportAllBill.LocalReport.DataSources.Add(rds);
                reportAllBill.RefreshReport();
            }
            else
                this.Alert("Không Có Hóa Đơn Nào", FormAlert.enmType.Info);
        }

        private void FormShowListAllBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportAllBill.LocalReport.ReleaseSandboxAppDomain();
        }


    }
}
