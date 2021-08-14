using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThueBao
{
    public partial class FormService : Form
    {
        private Connection connection = new Connection();
        public FormService()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            List<string> listItemSearch = new List<string> { "Tìm Kiếm Mã Dịch Vụ", "Tìm Kiếm Tên Dịch Vụ","Tìm Kiếm Nhà Mạng" };
            cboSearch.DataSource = listItemSearch;
        }
        private void clearTextBox()
        {
            txtIdService.Texts = "";
            txtNameService.Texts = "";
            txtPrice.Texts = "";
            txtInfo.Texts = "";
            txtPromotion.Value = 0;
            txtExpDate.Value = 30;
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
                if (btns.GetType() == typeof(Label))
                {
                    Label btn = (Label)btns;
                    btn.ForeColor = Color.White; //ThemeColor.PrimaryColor;
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
            tableService.ForeColor = Color.White;//ThemeColor.SecondaryColor;
            groupBox1.ForeColor = Color.White; //ThemeColor.PrimaryColor;
            groupBox2.ForeColor= Color.White; //ThemeColor.PrimaryColor;

        }
        private bool checkTextBox()
        {
            if (txtIdService.Texts.Equals(""))
            {
                this.Alert("Mã Dịch Vụ Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtNameService.Texts.Equals(""))
            {
                this.Alert("Tên Dịch Vụ Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtPrice.Texts.Equals(""))
            {
                this.Alert("Giá Dịch Vụ Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtInfo.Texts.Equals(""))
            {
                this.Alert("Thông Tin Chi Tiết\nKhông Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtNetwork.Text.Equals(""))
            {
                this.Alert("Nhà Mạng Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            string specialChar = ".+-*/!@#$%^&*()_=[]{};'|\\\",<>?`~";
            foreach (char a in txtIdService.Texts)  //check ki tu dac biet madv
            {
                if (specialChar.Contains(a))
                {
                    this.Alert("Mã Dịch Vụ Không Được\nChứa Kí Tự Đặc Biệt", FormAlert.enmType.Info);
                    return false;
                }
            }
            foreach (char a in txtNameService.Texts)  //check ki tu dac biet ten dv
            {
                if (specialChar.Contains(a))
                {
                    this.Alert("Tên Dịch Vụ Không Được\nChứa Kí Tự Đặc Biệt", FormAlert.enmType.Info);
                    return false;
                }
            }
            foreach (char a in txtInfo.Texts)  //check ki tu dac biet chi tiet
            {
                if (specialChar.Contains(a))
                {
                    this.Alert("Thông Tin Chi Tiết Không Được\nChứa Kí Tự Đặc Biệt", FormAlert.enmType.Info);
                    return false;
                }
            }
            if (txtIdService.Texts.Length > 5)
            {
                this.Alert("Mã Dịch Vụ Tối Đa 5 Kí Tự", FormAlert.enmType.Info);
                return false;
            }
            if (txtNameService.Texts.Length > 50)
            {
                this.Alert("Tên Dịch Vụ Tối Đa 50 Kí Tự", FormAlert.enmType.Info);

                return false;
            }
            if (txtInfo.Texts.Length > 200)
            {
                this.Alert("Thông Tin Chi Tiết\nTối Đa 200 Kí Tự", FormAlert.enmType.Info);
                return false;
            }
            try
            {
                Int64.Parse(txtPrice.Texts);
            }
            catch
            {
                this.Alert("Giá Dịch Vụ Không Được Quá Lớn", FormAlert.enmType.Info);
                return false;
            }
            if (txtPrice.Texts.Length > 8)
            {
                this.Alert("Giá Dịch Vụ Tối Đa 99999999 VNĐ", FormAlert.enmType.Info);

                return false;
            }
            return true;
        }
        private void FormService_Load(object sender, EventArgs e)
        {
            Service sv = new Service();
            txtNetwork.DataSource = connection.getDataTable("select * from network");
            txtNetwork.DisplayMember = "name_network";
            txtNetwork.ValueMember = "id_network";
            sv.showListView(tableService, "SELECT * FROM service");
            LoadTheme();
            clearTextBox();
        }

        private void tableService_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in tableService.SelectedItems)
            {
                txtIdService.Texts = item.SubItems[1].Text;
                txtNameService.Texts = item.SubItems[2].Text;
                txtNetwork.SelectedValue = item.SubItems[3].Text;
                txtPrice.Texts = item.SubItems[4].Text;
                txtPromotion.Value = Int64.Parse(item.SubItems[5].Text);
                txtExpDate.Value = Int64.Parse(item.SubItems[6].Text);
                txtInfo.Texts = item.SubItems[7].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                Service sv = new Service(txtIdService.Texts, txtNameService.Texts, txtNetwork.SelectedValue.ToString(), Int64.Parse(txtPrice.Texts), Int64.Parse(txtPromotion.Text), Int64.Parse(txtExpDate.Text), txtInfo.Texts);
                if (sv.checkKey(txtIdService.Texts))
                    this.Alert("Mã Dịch Vụ Đã Tồn Tại", FormAlert.enmType.Info);
                else
                {
                    sv.insert(sv);
                    FormService_Load(sender, e);
                    this.Alert("Thêm Thành Công", FormAlert.enmType.Success);
                }
            }
        }

   

        private void button2_Click(object sender, EventArgs e)
        {
            int check = tableService.Items.Count;
            if (check > 0)
            {
                if (checkTextBox())
                {
                    bool result = new FormDialog("Bạn Có Muốn Xóa Không").resultAns();
                    if (result)
                    {
                        Service sv = new Service(txtIdService.Texts, txtNameService.Texts, txtNetwork.SelectedValue.ToString(), Int64.Parse(txtPrice.Texts), Int64.Parse(txtPromotion.Text), Int64.Parse(txtExpDate.Text), txtInfo.Texts);
                        sv.delete(sv);
                        FormService_Load(sender, e);
                        this.Alert("Xóa Thành Công", FormAlert.enmType.Success);
                    }
                }
            }
            else
            this.Alert("Không Có Dữ Liệu Trong Bảng Để Xóa", FormAlert.enmType.Info);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int check = tableService.Items.Count;
            if (check > 0)
            {
                if (checkTextBox())
                {
                    bool result = new FormDialog("Bạn Có Muốn Cập Nhật Không").resultAns();
                    if (result)
                    {
                        Service sv = new Service(txtIdService.Texts, txtNameService.Texts, txtNetwork.SelectedValue.ToString(), Int64.Parse(txtPrice.Texts), Int64.Parse(txtPromotion.Text), Int64.Parse(txtExpDate.Text), txtInfo.Texts);
                        sv.update(sv);
                        FormService_Load(sender, e);
                        this.Alert("Cập Nhật Thành Công", FormAlert.enmType.Success);
                    }
                }
            }
            else this.Alert("Không Có Dữ Liệu Trong Bảng Để Cập Nhật", FormAlert.enmType.Info);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int check = tableService.Items.Count;
            if (check > 0)
            {
                bool result = new FormDialog("Bạn Có Muốn Xóa Hết Không").resultAns();
                if (result )
                {
                    Service sv = new Service();
                    sv.deleteAll();
                    FormService_Load(sender, e);
                    this.Alert("Xóa Thành Công", FormAlert.enmType.Success);
                }
            }
            else this.Alert("Không Có Dữ Liệu Trong Bảng Để Xóa", FormAlert.enmType.Info);
        }
        Service sv = new Service();
        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSearch.Texts, "[']"))
            {
                txtSearch.Texts = txtSearch.Texts.Remove(txtSearch.Texts.Length - 1);
            }
            switch (cboSearch.SelectedIndex)
            {
                case 0:
                    sv.showListView(tableService, "select * from service where id_service like N'" + txtSearch.Texts + "%'");
                    break;
                case 1:
                    sv.showListView(tableService, "select * from service where name_service like N'" + txtSearch.Texts + "%'");
                    break;
                case 2:
                    sv.showListView(tableService, "select * from service where id_network like N'" + txtSearch.Texts + "%'");
                    break;
            }
        }

        private void txtPrice__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Texts, "[^0-9]"))
            {
                this.Alert("Giá Dịch Vụ Phải Là Số", FormAlert.enmType.Success);
                txtPrice.Texts = txtPrice.Texts.Remove(txtPrice.Texts.Length - 1);
            }
        }


    }
}
