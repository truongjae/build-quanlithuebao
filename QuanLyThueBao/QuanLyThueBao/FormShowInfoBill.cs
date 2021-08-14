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
    public partial class FormShowInfoBill : Form
    {
        private Connection connection = new Connection();
        private string myPhone;
        public FormShowInfoBill(string myPhone)
        {
            InitializeComponent();
            this.myPhone = myPhone;
            showBill();
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        public void showBill()
        {
                string sql = "select * from bill where phone_number = N'" + this.myPhone + "' and status='0'";
                DataTable DT = connection.getDataTable(sql);
                reportBill.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                if (DT.Rows.Count > 0)
                {
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "dataBill";
                    rds.Value = DT;
                    reportBill.LocalReport.DataSources.Clear();
                    reportBill.LocalReport.DataSources.Add(rds);
                    reportBill.RefreshReport();
                }
                else
                    this.Alert("Không Có Hóa Đơn", FormAlert.enmType.Info);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            reportBill.LocalReport.ReleaseSandboxAppDomain();
            FormPaymentMethod formPaymentMethod = new FormPaymentMethod(this.myPhone);
            this.Hide();
            formPaymentMethod.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            reportBill.LocalReport.ReleaseSandboxAppDomain();
            this.Close();
        }

        private void FormShowInfoBill_Load(object sender, EventArgs e)
        {

        }
    }
}
