using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace QuanLyThueBao
{
    public partial class FormPhone : Form
    {
        private Connection connection = new Connection();
        public FormPhone()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            List<string> listItem = new List<string> { "Trả Trước", "Trả Sau" ,"Cố Định"};
            txtType.DataSource = listItem;
            List<string> listItemSearch = new List<string> { "Tìm Kiếm SĐT", "Tìm Kiếm Nhà Mạng","Tìm Kiếm Vùng","Tìm Kiếm Loại Thuê Bao",
            "Tìm Kiếm CMND/CCCD","Tìm Kiếm Theo Năm Kích Hoạt","Tìm Kiếm Theo Năm Hết Hạn"};
            cboSearch.DataSource = listItemSearch;
            txtAct.Value =Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
            txtExp.Value = txtAct.Value.AddDays(90);
            clearTextBox();
        }
        private void clearTextBox()
        {
            txtPhone.Texts = "";
            txtBalance.Texts = "0";
            txtPromotion.Texts = "0";
            txtPay.Texts = "0";
            btnStatus.Checked = true;
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        private void LoadTheme()
        {
            foreach (Control btns in groupBox1.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            foreach (Control btns in groupBox2.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            foreach (Control btns in groupBox3.Controls)
            {
                if (btns.GetType() == typeof(Label))
                {
                    Label btn = (Label)btns;
                    btn.ForeColor = Color.White; //ThemeColor.PrimaryColor;
                }
            }
            foreach (Control btns in groupBox4.Controls)
            {
                if (btns.GetType() == typeof(Label))
                {
                    Label btn = (Label)btns;
                    btn.ForeColor = Color.White; //ThemeColor.PrimaryColor;
                }
            }
            tablePhone.ForeColor = Color.White; //ThemeColor.PrimaryColor;
            groupBox1.ForeColor = Color.White;
            groupBox2.ForeColor = Color.White;
            lbList.ForeColor = Color.White;
        }
        private bool checkTextBox()
        {
            if (txtPhone.Texts.Equals(""))
            {
                this.Alert("Số Điện Thoại Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtNetwork.Text.Equals(""))
            {
                this.Alert("Nhà Mạng Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtRegion.Text.Equals(""))
            {
                this.Alert("Mã Vùng Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            //
            var checkId = new Regex("^[0-9]*$");
            if (!checkId.IsMatch(txtPhone.Texts))
            { // check sdt
                this.Alert("Số Điện Thoại Không Được\nChứa Kí Tự Đặc Biệt", FormAlert.enmType.Info);
                return false;
            }
            // check stk
            try
            {
                Int64.Parse(txtBalance.Texts);

            }
            catch
            {
                this.Alert("Số Dư Tài Khoản Phải Là Số\nVà Không Được Quá Lớn", FormAlert.enmType.Info);

                return false;
            }

            try
            {
                Int64.Parse(txtPromotion.Texts);
            }
            catch
            {
                this.Alert("Tài Khoản Khuyến Mãi Phải Là Số\nVà Không Được Quá Lớn", FormAlert.enmType.Info);
                return false;
            }

            try
            {
                Int64.Parse(txtPay.Texts);
            }
            catch
            {
                this.Alert("Số Tiền Thanh Toán Phải Là Số\nVà Không Được Quá Lớn", FormAlert.enmType.Info);
                return false;
            }
            if (txtBalance.Texts.Length > 8)
            {
                this.Alert("Số Dư Tài Khoản\nTối Đa 99999999 VNĐ", FormAlert.enmType.Info);

                return false;
            }
            if (txtPromotion.Texts.Length > 8)
            {
                this.Alert("Tài Khoản Khuyến Mãi\nTối Đa 99999999 VNĐ", FormAlert.enmType.Info);

                return false;
            }
            if (txtPay.Texts.Length > 8)
            {
                this.Alert("Số Tiền Thanh Toán\nTối Đa 99999999 VNĐ", FormAlert.enmType.Info);

                return false;
            }

            if (txtPhone.Texts.Length !=11 && txtPhone.Texts.Length !=10)
            {
                this.Alert("Số Điện Thoại Sai Định Dạng(10 Số Đối Với\nThuê Bao Di Động Và 11 Số Đối Với\nThuê Bao Cố Định)", FormAlert.enmType.Info);
                return false;
            }
            // check sdt
            if (txtPhone.Texts.Length == 10 && txtType.Text == "Cố Định")
            {
                this.Alert("Thuê Bao Cố Định Có Định Dạng 11 Số", FormAlert.enmType.Info);

                return false;
            }
            if (txtPhone.Texts.Length == 11 && (txtType.Text == "Trả Trước" || txtType.Text == "Trả Sau"))
            {
                this.Alert("Thuê Bao Di Động Có Định Dạng 10 Số", FormAlert.enmType.Info);

                return false;
            }
            // check stk 2 thue bao
            if (txtType.Text == "Trả Trước" && txtPay.Texts != "0") {
                this.Alert("Số Tiền Thanh Toán Chỉ Áp Dụng Với\nThuê Bao Trả Sau Hoặc Thuê Bao Cố Định", FormAlert.enmType.Info);
                return false;
            }
            if ((txtType.Text == "Trả Sau" || txtType.Text == "Cố Định") && (txtBalance.Texts !="0" || txtPromotion.Texts !="0"))
            {
                this.Alert("Số Dư Tài Khoản Và Tài Khoản Khuyến Mãi\nChỉ Áp Dụng Với Thuê Bao Trả Trước", FormAlert.enmType.Info);
                return false;
            }
            // check ngay het han
            DateTime d1 = Convert.ToDateTime(txtAct.Value);
            DateTime d2 = Convert.ToDateTime(txtExp.Value);
            double checkDay = (d2 - d1).TotalDays;
            if (checkDay <= 0)
            {
                this.Alert("Ngày Hết Hạn Phải Lớn Hơn Ngày Đăng Ký", FormAlert.enmType.Info);
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            
            if (checkTextBox())
            {
                string status = "";
                if (btnStatus.Checked) status = "1";
                else status = "0";
                Phone ph = new Phone(txtPhone.Texts, txtIdCard.Text, txtNetwork.SelectedValue.ToString(), txtRegion.SelectedValue.ToString(), txtType.SelectedValue.ToString(), 
                    txtAct.Value.ToString("yyyy-MM-dd"), txtExp.Value.ToString("yyyy-MM-dd"),
                   Int64.Parse(txtBalance.Texts),Int64.Parse(txtPromotion.Texts),Int64.Parse(txtPay.Texts),status);
                if (ph.checkKey(txtPhone.Texts))
                {
                    this.Alert("Số Điện Thoại Đã Tồn Tại", FormAlert.enmType.Info);
                }
                else
                {
                    if (!ph.checkIdCard(txtIdCard.Text))
                        this.Alert("Số CMND/CCCD Không Tồn Tại", FormAlert.enmType.Info);
                    else
                    {
                        if (ph.checkMaxReg(txtIdCard.SelectedValue.ToString(), txtNetwork.SelectedValue.ToString()))
                            this.Alert("Số CMND/CCCD Đã Đạt Tối Đa Số Lượng\nĐăng Ký Cho Phép Của Nhà Mạng", FormAlert.enmType.Info);
                        else
                        {
                            ph.insert(ph);
                            FormPhone_Load(sender, e);
                            this.Alert("Đăng Ký Thành Công", FormAlert.enmType.Success);
                        }
                    }
                }
            }
        }
         
        private void FormPhone_Load(object sender, EventArgs e)
        {
            Phone ph = new Phone();
            txtNetwork.DataSource = connection.getDataTable("select * from network");
            txtNetwork.DisplayMember = "name_network";
            txtNetwork.ValueMember = "id_network";
            txtRegion.DataSource = connection.getDataTable("select * from region");
            txtRegion.DisplayMember = "name_region";
            txtRegion.ValueMember = "id_region";
            txtIdCard.DataSource = connection.getDataTable("select * from customer");
            txtIdCard.DisplayMember = "id_card";
            txtIdCard.ValueMember = "id_card";
            txtIdCard.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtIdCard.AutoCompleteSource = AutoCompleteSource.ListItems;
            ph.showListView(tablePhone, "SELECT * FROM phone");
            LoadTheme();
            clearTextBox();
        }


        private void tablePhone_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (ListViewItem item in tablePhone.SelectedItems)
            {
                txtPhone.Texts = item.SubItems[1].Text;
                txtIdCard.Text = item.SubItems[2].Text;
                txtNetwork.SelectedValue = item.SubItems[3].Text;
                txtRegion.SelectedValue = item.SubItems[4].Text;
                txtType.Text = item.SubItems[5].Text;
                txtAct.Value = Convert.ToDateTime(item.SubItems[6].Text);
                txtExp.Value = Convert.ToDateTime(item.SubItems[7].Text);
                txtBalance.Texts = item.SubItems[8].Text;
                txtPromotion.Texts = item.SubItems[9].Text;
                txtPay.Texts = item.SubItems[10].Text;
                if (item.SubItems[11].Text.Equals("1")) btnStatus.Checked = true;
                else btnStatus.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int check = tablePhone.Items.Count;
            if (check > 0)
            {
                if (checkTextBox())
                {
                    string status = "";
                    if (btnStatus.Checked) status = "1";
                    else status = "0";
                    bool result = new FormDialog("Bạn Có Muốn Xóa Không").resultAns();
                    if (result)
                    {
                        Phone ph = new Phone(txtPhone.Texts, txtIdCard.Text, txtNetwork.SelectedValue.ToString(), txtRegion.SelectedValue.ToString(), txtType.SelectedValue.ToString(),
                   txtAct.Value.ToString("yyyy-MM-dd"), txtExp.Value.ToString("yyyy-MM-dd"),
                  Int64.Parse(txtBalance.Texts), Int64.Parse(txtPromotion.Texts), Int64.Parse(txtPay.Texts), status);
                        ph.delete(ph);
                        FormPhone_Load(sender, e);
                        this.Alert("Xóa Thành Công", FormAlert.enmType.Success);
                    }
                }
            }
            else  this.Alert("Không Có Dữ Liệu Trong Bảng Để Xóa", FormAlert.enmType.Info);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int check = tablePhone.Items.Count;
            if (check > 0)
            {
                if (checkTextBox())
                {
                    bool result = new FormDialog("Bạn Có Muốn Cập Nhật Không").resultAns();
                    if (result)
                    {
                        string status = "";
                        if (btnStatus.Checked==true) status = "1";
                        else status = "0";
                        Phone ph = new Phone(txtPhone.Texts, txtIdCard.Text, txtNetwork.SelectedValue.ToString(), txtRegion.SelectedValue.ToString(), txtType.SelectedValue.ToString(),
                   txtAct.Value.ToString("yyyy-MM-dd"), txtExp.Value.ToString("yyyy-MM-dd"),
                  Int64.Parse(txtBalance.Texts), Int64.Parse(txtPromotion.Texts), Int64.Parse(txtPay.Texts), status);

                        if (ph.checkMaxReg(txtIdCard.SelectedValue.ToString(), txtNetwork.SelectedValue.ToString()))
                            this.Alert("Số CMND/CCCD Đã Đạt Tối Đa Số Lượng\nĐăng Ký Cho Phép Của Nhà Mạng", FormAlert.enmType.Info);
                        else
                        {
                            ph.update(ph);
                            FormPhone_Load(sender, e);
                            this.Alert("Cập Nhật Thành Công", FormAlert.enmType.Success);
                        }
                    }
                }
            }
            else this.Alert("Không Có Dữ Liệu Trong Bảng Để Cập Nhật", FormAlert.enmType.Info);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int check = tablePhone.Items.Count;
            if (check > 0)
            {
                bool result = new FormDialog("Bạn Có Muốn Xóa Hết Không").resultAns();
                if (result)
                {
                    Phone ph = new Phone();
                    ph.deleteAll();
                    FormPhone_Load(sender, e);
                    this.Alert("Xóa Thành Công", FormAlert.enmType.Success);
                }
            }
            else
            this.Alert("Không Có Dữ Liệu Trong Bảng Để Xóa", FormAlert.enmType.Info);
        }

        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBalance.Texts = "0";
            txtPromotion.Texts = "0";
            txtPay.Texts = "0";
        }
        Phone ph = new Phone();

        private void txtSearch__TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSearch.Texts, "[']"))
            {
                txtSearch.Texts = txtSearch.Texts.Remove(txtSearch.Texts.Length - 1);
            }
            switch (cboSearch.SelectedIndex)
            {
                case 0:
                    ph.showListView(tablePhone, "Select * from phone where phone_number like N'" + txtSearch.Texts + "%'");
                    break;
                case 1:
                    ph.showListView(tablePhone, "Select * from phone where id_network like N'" + txtSearch.Texts + "%'");
                    break;
                case 2:
                    ph.showListView(tablePhone, "Select * from phone where id_region like N'" + txtSearch.Texts + "%'");
                    break;
                case 3:
                    ph.showListView(tablePhone, "Select * from phone where type like N'" + txtSearch.Texts + "%'");
                    break;
                case 4:
                    ph.showListView(tablePhone, "Select * from phone where id_card like N'" + txtSearch.Texts + "%'");
                    break;
                case 5:
                    ph.showListView(tablePhone, "Select * from phone where CAST(year(activation_date) as nvarchar) like N'" + txtSearch.Texts + "%'");
                    break;
                case 6:
                    ph.showListView(tablePhone, "Select * from phone where  CAST(year(expiration_date) as nvarchar) like N'" + txtSearch.Texts + "%'");
                    break;
            }
        }

        private void txtPhone__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Texts, "[^0-9]"))
            {
                this.Alert("Số Điện Thoại Phải Là Số", FormAlert.enmType.Info);
                txtPhone.Texts = txtPhone.Texts.Remove(txtPhone.Texts.Length - 1);
            }
        }

        private void txtBalance__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBalance.Texts, "[^0-9]"))
            {
                this.Alert("Số Dư Tài Khoản Phải Là Số", FormAlert.enmType.Info);
                txtBalance.Texts = txtBalance.Texts.Remove(txtBalance.Texts.Length - 1);
            }
        }

        private void txtPromotion__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPromotion.Texts, "[^0-9]"))
            {
                this.Alert("Tài Khoản Khuyến Mãi Phải Là Số", FormAlert.enmType.Info);
                txtPromotion.Texts = txtPromotion.Texts.Remove(txtPromotion.Texts.Length - 1);
            }
        }

        private void txtPay__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPay.Texts, "[^0-9]"))
            {
                this.Alert("Tài Khoản Thanh Toán Phải Là Số", FormAlert.enmType.Info);
                txtPay.Texts = txtPay.Texts.Remove(txtPay.Texts.Length - 1);
            }
        }


    }
}
