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
    public partial class FormNetwork : Form
    {
        public FormNetwork()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            List<string> listItemSearch = new List<string> { "Tìm Kiếm Mã Nhà Mạng", "Tìm Kiếm Tên Nhà Mạng"};
            cboSearch.DataSource = listItemSearch;
        }
        private void clearTextBox()
        {
            txtIdNetwork.Texts = "";
            txtNameNetwork.Texts = "";
            txtPriceIn.Texts = "";
            txtPriceFo.Texts = "";
            txtMaxReg.Texts = "";
            txtMessIn.Texts = "";
            txtMessFo.Texts = "";
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
            tableNetwork.ForeColor = Color.White;//ThemeColor.SecondaryColor;
            groupBox1.ForeColor = Color.White;
            groupBox2.ForeColor = Color.White;
        }
        private bool checkTextBox()
        {
            if (txtIdNetwork.Texts.Equals(""))
            {
                this.Alert("Mã Nhà Mạng Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtNameNetwork.Texts.Equals(""))
            {
                this.Alert("Tên Nhà Mạng Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtPriceIn.Texts.Equals(""))
            {
                this.Alert("Giá Cước Nội Mạng Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtPriceFo.Texts.Equals(""))
            {
                this.Alert("Giá Cước Ngoại Mạng Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtMaxReg.Texts.Equals(""))
            {
                this.Alert("Số Lượng Tối Đa Đăng Ký Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            var checkId = new Regex("^[a-zA-Z0-9 ]*$");

            if (!checkId.IsMatch(txtIdNetwork.Texts))
            { // check ma nha mang ki tu dac biet
                this.Alert("Mã Nhà Mạng Không Được\nChứa Kí Tự Đặc Biệt", FormAlert.enmType.Info);
                return false;
            }


            string specialChar = "0123456789.+-*/!@#$%^&*()_=[]{};'|\\\",<>?`~";
            foreach (char a in txtNameNetwork.Texts) // check ten nha mang ki tu dac biet
            {
                if (specialChar.Contains(a))
                {
                    this.Alert("Tên Nhà Mạng Không Được\nChứa Kí Tự Đặc Biệt Hoặc Số", FormAlert.enmType.Info);
                    return false;
                }
            }

            try
            {
                Int64.Parse(txtPriceIn.Texts);
            }
            catch
            {
                this.Alert("Giá Cước Gọi Nội Mạng Phải Là Số\nVà Không Được Quá Lớn", FormAlert.enmType.Info);
                return false;
            }
            try
            {
                Int64.Parse(txtPriceFo.Texts);
            }
            catch
            {
                this.Alert("Giá Cước Gọi Ngoại Mạng Phải Là Số\nVà Không Được Quá Lớn", FormAlert.enmType.Info);
                return false;
            }
            try
            {
                Int64.Parse(txtMessIn.Texts);
            }
            catch
            {
                this.Alert("Giá Cước Nhắn Tin Nội Mạng Phải Là Số\nVà Không Được Quá Lớn", FormAlert.enmType.Info);
                return false;
            }
            try
            {
                Int64.Parse(txtMessFo.Texts);
            }
            catch
            {
                this.Alert("Giá Cước Nhắn Tin Ngoại Mạng Phải Là Số\nVà Không Được Quá Lớn", FormAlert.enmType.Info);
                return false;
            }
            try
            {
                Int64.Parse(txtMaxReg.Texts);
            }
            catch
            {
                this.Alert("Số Lượng Tối Đa Đăng Ký Phải Là Số\nVà Không Được Quá Lớn", FormAlert.enmType.Info);
                return false;
            }

            if (txtIdNetwork.Texts.Length > 5)
            {
                this.Alert("Mã Nhà Mạng Tối Đa 5 Chữ Số", FormAlert.enmType.Info);

                return false;
            }
            if (txtNameNetwork.Texts.Length > 30)
            {
                this.Alert("Tên Nhà Mạng Tối Đa 30 Kí Tự", FormAlert.enmType.Info);
                return false;
            }
            if (txtMaxReg.Texts.Length > 5)
            {
                this.Alert("Số Lượng Đăng Ký Quá Lớn", FormAlert.enmType.Info);
                return false;
            }
            if (txtPriceIn.Texts.Length > 8)
            {
                this.Alert("Giá Cước Nội Mạng\nTối Đa 99999999 VNĐ", FormAlert.enmType.Info);
                return false;
            }
            if (txtPriceFo.Texts.Length > 8)
            {
                this.Alert("Giá Cước Ngoại Mạng\nTối Đa 99999999 VNĐ", FormAlert.enmType.Info);
                return false;
            }
            if (txtMessIn.Texts.Length > 8)
            {
                this.Alert("Giá Cước Nhắn Nội Mạng\nTối Đa 99999999 VNĐ", FormAlert.enmType.Info);
                return false;
            }
            if (txtMessFo.Texts.Length > 8)
            {
                this.Alert("Giá Cước Nhắn Ngoại Mạng\nTối Đa 99999999 VNĐ", FormAlert.enmType.Info);
                return false;
            }
            return true;
        }
        private void FormNetwork_Load(object sender, EventArgs e)
        {
            Network nw = new Network();
            nw.showListView(tableNetwork, "SELECT * FROM network");
            LoadTheme();
            clearTextBox();
        }

        private void tableNetwork_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in tableNetwork.SelectedItems)
            {
                txtIdNetwork.Texts = item.SubItems[1].Text;
                txtNameNetwork.Texts = item.SubItems[2].Text;
                txtPriceIn.Texts = item.SubItems[3].Text;
                txtPriceFo.Texts = item.SubItems[4].Text;
                txtMessIn.Texts = item.SubItems[5].Text;
                txtMessFo.Texts = item.SubItems[6].Text;
                txtMaxReg.Texts = item.SubItems[7].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                Network nw = new Network(txtIdNetwork.Texts, txtNameNetwork.Texts, Int64.Parse(txtPriceIn.Texts), Int64.Parse(txtPriceFo.Texts),
                    Int64.Parse(txtMessIn.Texts),Int64.Parse(txtMessFo.Texts),Int64.Parse(txtMaxReg.Texts));
                    if (nw.checkKey(txtIdNetwork.Texts))
                    {
                        this.Alert("Mã Nhà Mạng Đã Tồn Tại", FormAlert.enmType.Info);
                    }
                    else
                    {
                        nw.insert(nw);
                        FormNetwork_Load(sender, e);
                        this.Alert("Thêm Thành Công", FormAlert.enmType.Success);
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int check = tableNetwork.Items.Count;
            if (check > 0)
            {
                if (checkTextBox())
                {
                    bool result = new FormDialog("Bạn Có Muốn Xóa Không").resultAns();
                    if (result)
                    {
                        Network nw = new Network(txtIdNetwork.Texts, txtNameNetwork.Texts, Int64.Parse(txtPriceIn.Texts), Int64.Parse(txtPriceFo.Texts),
                   Int64.Parse(txtMessIn.Texts), Int64.Parse(txtMessFo.Texts), Int64.Parse(txtMaxReg.Texts));
                        nw.delete(nw);
                        FormNetwork_Load(sender, e);
                        this.Alert("Xóa Thành Công", FormAlert.enmType.Success);
                    }
                }
            }
            else this.Alert("Không Có Dữ Liệu Trong Bảng Để Xóa", FormAlert.enmType.Info);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int check = tableNetwork.Items.Count;
            if (check > 0)
            {
                if (checkTextBox())
                {
                    bool result = new FormDialog("Bạn Có Muốn Cập Nhật Không").resultAns();
                    if (result)
                    {
                        Network nw = new Network(txtIdNetwork.Texts, txtNameNetwork.Texts, Int64.Parse(txtPriceIn.Texts), Int64.Parse(txtPriceFo.Texts),
                   Int64.Parse(txtMessIn.Texts), Int64.Parse(txtMessFo.Texts), Int64.Parse(txtMaxReg.Texts));
                        nw.update(nw);
                        FormNetwork_Load(sender, e);
                        this.Alert("Cập Nhật Thành Công", FormAlert.enmType.Success);
                    }
                }
            }
            else
            this.Alert("Không Có Dữ Liệu Trong Bảng Để Cập Nhật", FormAlert.enmType.Info);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int check = tableNetwork.Items.Count;
            if (check>0)
            {
                bool result = new FormDialog("Bạn Có Muốn Xóa Hết Không").resultAns();
                if (result)
                {
                    Network nw = new Network();
                    nw.deleteAll();
                    FormNetwork_Load(sender, e);
                    this.Alert("Xóa Thành Công", FormAlert.enmType.Success);

                }
            }
            else this.Alert("Không Có Dữ Liệu Trong Bảng Để Xóa", FormAlert.enmType.Info);
        }
        Network nw = new Network();

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSearch.Texts, "[']"))
            {
                txtSearch.Texts = txtSearch.Texts.Remove(txtSearch.Texts.Length - 1);
            }
            switch (cboSearch.SelectedIndex)
            {
                case 0:
                    nw.showListView(tableNetwork, "select * from network where id_network like N'" + txtSearch.Texts + "%'");
                    break;
                case 1:
                    nw.showListView(tableNetwork, "select * from network where name_network like N'" + txtSearch.Texts + "%'");
                    break;
            }
        }

        private void txtPriceIn__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPriceIn.Texts, "[^0-9]"))
            {
                this.Alert("Giá Cước Gọi Nội Mạng\nPhải Là Số", FormAlert.enmType.Info);
                txtPriceIn.Texts = txtPriceIn.Texts.Remove(txtPriceIn.Texts.Length - 1);
            }
        }

        private void txtPriceFo__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPriceFo.Texts, "[^0-9]"))
            {
                this.Alert("Giá Cước Gọi Ngoại Mạng\nPhải Là Số", FormAlert.enmType.Info);
                txtPriceFo.Texts = txtPriceFo.Texts.Remove(txtPriceFo.Texts.Length - 1);
            }
        }

        private void txtMessIn__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMessIn.Texts, "[^0-9]"))
            {
                this.Alert("Giá Cước Nhắn Tin Nội Mạng\nPhải Là Số", FormAlert.enmType.Info);
                txtMessIn.Texts = txtMessIn.Texts.Remove(txtMessIn.Texts.Length - 1);
            }
        }

        private void txtMessFo__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMessFo.Texts, "[^0-9]"))
            {
                this.Alert("Giá Cước Nhắn Tin Ngoại Mạng\nPhải Là Số", FormAlert.enmType.Info);
                txtMessFo.Texts = txtMessFo.Texts.Remove(txtMessFo.Texts.Length - 1);
            }
        }

        private void txtMaxReg__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMaxReg.Texts, "[^0-9]"))
            {
                this.Alert("Số Lượng Đăng Ký\nPhải Là Số", FormAlert.enmType.Info);
                txtMaxReg.Texts = txtMaxReg.Texts.Remove(txtMaxReg.Texts.Length - 1);
            }
        }


    }
}
