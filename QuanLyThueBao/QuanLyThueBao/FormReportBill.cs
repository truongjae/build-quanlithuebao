using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace QuanLyThueBao
{
    public partial class FormReportBill : Form
    {
        private Connection connection = new Connection();
        public FormReportBill()
        {
            InitializeComponent();
            List<string> listOption= new List<string>{"Tất Cả Thuê Bao","Thuê Bao Cá Nhân"};
            cboOption.DataSource = listOption;
           
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        private bool checkTextBox()
        {
            if (cboPhone.Text.Equals(""))
            {
                this.Alert("Số Điện Thoại Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (cboPhone.Text.Length > 11)
            {
                this.Alert("Số Điện Thoại Không Tồn Tại", FormAlert.enmType.Info);
                return false;
            }
            return true;
        }
        public bool checkPhone()
        {
            string sql = "select * from phone where phone_number =N'" + cboPhone.Text+"'";
            DataTable DT = connection.getDataTable(sql);
            return DT.Rows.Count > 0;
        }
        public bool checkBilled(string phone)
        {
            string sql = "select * from bill where phone_number =N'" + phone + "' and status= '0'";
            DataTable DT = connection.getDataTable(sql);
            return DT.Rows.Count > 0;
        }
        public bool checKAllBilled()
        {
            string sql = "select * from bill where status= '0'";
            DataTable DT = connection.getDataTable(sql);
            return DT.Rows.Count == 0;
        }
        private void FormReportBill_Load(object sender, EventArgs e)
        {
            cboPhone.DataSource = connection.getDataTable("select phone_number from phone where type = N'Trả Sau' or type = N'Cố Định'");
            cboPhone.DisplayMember = "phone_number";
            cboPhone.ValueMember = "phone_number";
            this.reportBill.RefreshReport();
            panelInfo.Visible = false;
        }
        public void showBillAllPhone()
        {
            createAllBill();
            string sql = "select * from bill where status = '0'";
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
                this.Alert("Không Có Thuê Bao Nào Để Tạo Hóa Đơn", FormAlert.enmType.Info);
               
        }
        public void showBillPhone()
        {
            if (checkTextBox())
            {
                if (checkPhone())
                {
                    if (checkBilled(cboPhone.Text))
                        this.Alert("Không Thể Tạo Hóa Đơn Trong Khi\nThuê Bao Này Chưa Thanh Toán", FormAlert.enmType.Error);
                    else
                    {
                        string sql = "select * from phone where phone_number = N'" + cboPhone.Text + "' and payment>0";
                        DataTable DT = connection.getDataTable(sql);
                        if (DT.Rows.Count > 0)
                        {
                            createBill();
                            sql = "select * from bill where phone_number = N'" + cboPhone.Text + "' and status='0'";
                            DT = connection.getDataTable(sql);
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
                                this.Alert("Không Có Dữ Liệu", FormAlert.enmType.Info);
                        }
                        else
                            this.Alert("Số Điện Thoại Không Không Đủ\nĐiều Kiện Thanh Toán\nSố Tiền Thanh Toán Phải Lớn Hơn 0", FormAlert.enmType.Error);
                    }
                }
                else
                    this.Alert("Số Điện Thoại Không Tồn Tại", FormAlert.enmType.Error);
            }

        }
        public void createBill()
        {
            //string sql = "select * from phone p join customer cs on p.id_card = cs.id_card where p.phone_number =N'" + cboPhone.Text+"'";
            string sql = "select *,(select sum(minutes) from called where phone_out = p.phone_number and status = '1' and time_start > all(select date from bill where phone_number= p.phone_number)) as count_minute_call,";
            sql += "(select count(*) from sended where phone_out = p.phone_number and time_send > all(select date from bill where phone_number=p.phone_number)) as count_mess,";
            //sql += "(select count(*) from reg_service where phone_number = p.phone_number) as count_service ";
            sql += "(select count(*) from reg_service regsv join service sv on sv.id_service = regsv.id_service ";
            sql += "and DATEADD(DAY,-(select exp_date from service where id_service = regsv.id_service)+1,regsv.date_exp) >= all(select date from bill where phone_number= regsv.phone_number) where regsv.phone_number = p.phone_number) as count_service ";
            sql += "from phone p join customer cs on p.id_card = cs.id_card where p.phone_number =N'" + cboPhone.Text + "'";
            DataTable DT = connection.getDataTable(sql);
            if (DT.Rows.Count > 0)
            {
                string idCard = DT.Rows[0]["id_card"].ToString();
                string name = DT.Rows[0]["name_customer"].ToString();
                string address = DT.Rows[0]["address"].ToString();
                string phone = DT.Rows[0]["phone_number"].ToString();
                string type = DT.Rows[0]["type"].ToString();
                string countMinuteCall = DT.Rows[0]["count_minute_call"].ToString();
                if (countMinuteCall.Equals(string.Empty)) countMinuteCall = "0";
                string countMess = DT.Rows[0]["count_mess"].ToString();
                string countService = DT.Rows[0]["count_service"].ToString();
                string payment = DT.Rows[0]["payment"].ToString();
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                sql = "INSERT INTO bill VALUES(N'" + idCard + "',N'" + name + "',N'" + address + "',N'" + phone + "',N'" + type +
                    "',"+countMinuteCall+","+countMess+","+countService+"," + payment + ",'" + date + "','0');";
                sql += "UPDATE phone set payment = 0 where phone_number = N'" + cboPhone.Text + "'";
                connection.excute(sql);
            }
        }
        public void createAllBill()
        {
            string sql = "select *,(select sum(minutes) from called where phone_out = p.phone_number and status = '1' and time_start > all(select date from bill where phone_number= p.phone_number)) as count_minute_call,";
            sql += "(select count(*) from sended where phone_out = p.phone_number and time_send > all(select date from bill where phone_number=p.phone_number)) as count_mess,";
            //sql += "(select count(*) from reg_service where phone_number = p.phone_number) as count_service ";
            //sql += "(select count(*) from reg_service regsv join service sv on sv.id_service = regsv.id_service where regsv.phone_number = p.phone_number and ) as count_service ";
            sql+= "(select count(*) from reg_service regsv join service sv on sv.id_service = regsv.id_service ";
            sql += "and DATEADD(DAY,-(select exp_date from service where id_service = regsv.id_service)+1,regsv.date_exp) >= all(select date from bill where phone_number= regsv.phone_number) where regsv.phone_number = p.phone_number) as count_service ";
            sql += "from phone p join customer cs on p.id_card = cs.id_card where (type = N'Trả Sau' or type = N'Cố Định') and payment>0 ";
            DataTable DT = connection.getDataTable(sql);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    string idCard = row["id_card"].ToString();
                    string name = row["name_customer"].ToString();
                    string address = row["address"].ToString();
                    string phone = row["phone_number"].ToString();
                    string type = row["type"].ToString();
                    string countMinuteCall = row["count_minute_call"].ToString();
                    if (countMinuteCall.Equals(string.Empty)) countMinuteCall = "0";
                    string countMess = row["count_mess"].ToString();
                    string countService = row["count_service"].ToString();
                    string payment = row["payment"].ToString();
                    string dateNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    if (checkBilled(phone) == false)
                    {
                        sql = "INSERT INTO bill VALUES(N'" + idCard + "',N'" + name + "',N'" + address + "',N'" + phone + "',N'" + type +
                        "'," + countMinuteCall + "," + countMess + "," + countService + "," + payment + ",'" + dateNow + "','0');";
                        sql += "UPDATE phone set payment = 0 where phone_number = N'" + phone + "'";
                        connection.excute(sql);
                    }
                }
            }
        }
        private void btnBill_Click(object sender, EventArgs e)
        {
            reportBill.Clear();
            switch (cboOption.SelectedIndex)
            {
                case 0:
                    showBillAllPhone();
                    break;
                case 1:
                    
                    showBillPhone();
                    break;
            }
        }

        private void cboPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cboPhone.Text, "[^0-9]"))
            {
                cboPhone.Text = cboPhone.Text.Remove(cboPhone.Text.Length - 1);
            }
            if (cboOption.SelectedIndex == 1)
            {
                
                if (!System.Text.RegularExpressions.Regex.IsMatch(cboPhone.Text, "[^0-9]"))
                {
                    DataTable DT = connection.getDataTable("select cs.name_customer,cs.avatar from phone p join customer cs on p.id_card = cs.id_card and p.phone_number =N'" + cboPhone.Text + "'");
                    if (DT.Rows.Count > 0)
                    {
                        txtName.Text = "(" + DT.Rows[0]["name_customer"].ToString() + ")";
                        MemoryStream stream;
                        byte[] arr;
                        arr = (byte[])DT.Rows[0]["avatar"];
                        stream = new MemoryStream(arr);
                        picAvt.Image = Image.FromStream(stream);
                        panelInfo.Visible = true;
                    }
                    else panelInfo.Visible = false;
                }
            }
        }

        private void cboOption_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOption.SelectedIndex == 0)
            {
                panelInfo.Visible = false;
                cboPhone.Visible = false;
            }
            else
            {
                cboPhone.Visible = true;
                cboPhone_TextChanged(sender, e);
            }
        }

        private void FormReportBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportBill.LocalReport.ReleaseSandboxAppDomain();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
