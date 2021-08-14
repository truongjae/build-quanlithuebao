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
    public partial class FormCard : Form
    {
        private Connection connection = new Connection();
        public FormCard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            List<string> listItem = new List<string> { "10000", "20000", "50000", "100000", "200000", "500000" };
            txtPrice.DataSource = listItem;

        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        private void clearTextBox()
        {
            txtCode.Texts = "";
            txtPromotion.Value = 0;
        }
        private bool checkTextBox()
        {
            if (txtCode.Texts.Equals(""))
            {
                this.Alert("Mã Thẻ Nạp Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtNetwork.Text.Equals(""))
            {
                this.Alert("Nhà Mạng Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtCode.Texts.Length > 20)
            {
                this.Alert("Mã Thẻ Nạp Tối Đa 20 Kí Tự", FormAlert.enmType.Info);
                return false;
            }

            return true;
        }
        private void LoadTheme()
        {
            foreach (Control btns in groupBox1.Controls)
            {
                if (btns.GetType() == typeof(Label))
                {
                    Label btn = (Label)btns;
                    btn.ForeColor = Color.White;//ThemeColor.PrimaryColor;
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
            tableCard.ForeColor = Color.White; //ThemeColor.SecondaryColor;
            groupBox1.ForeColor = Color.White;
            groupBox2.ForeColor = Color.White;
           
        }


        private void FormCard_Load(object sender, EventArgs e)
        {
            Card cd = new Card();
            txtNetwork.DataSource = connection.getDataTable("select * from network");
            txtNetwork.DisplayMember = "name_network";
            txtNetwork.ValueMember = "id_network";
            cd.showListView(tableCard, "SELECT * FROM card");
            LoadTheme();
            clearTextBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                Card cd = new Card(txtCode.Texts, Int32.Parse(txtPrice.Texts), txtNetwork.SelectedValue.ToString(), Int32.Parse(txtPromotion.Text));
                if (cd.checkKey(txtCode.Texts, txtNetwork.SelectedValue.ToString()))
                {
                    this.Alert("Mã Thẻ Nạp Đã Tồn Tại", FormAlert.enmType.Info);
                }
                else
                {
                    cd.insert(cd);
                    FormCard_Load(sender, e);
                    this.Alert("Thêm Thành Công", FormAlert.enmType.Success);
                }
            }
        }

        private void tableCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in tableCard.SelectedItems)
            {
                txtCode.Texts = item.SubItems[1].Text;
                txtPrice.Texts = item.SubItems[2].Text;
                txtNetwork.SelectedValue = item.SubItems[3].Text;
                txtPromotion.Value = Int32.Parse(item.SubItems[4].Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int check = tableCard.Items.Count;
            if (check > 0)
            {
                if (checkTextBox())
                {
                    bool result = new FormDialog("Bạn Có Muốn Xóa Không").resultAns();
                    if (result)
                    {
                        Card cd = new Card(txtCode.Texts, Int32.Parse(txtPrice.Texts), txtNetwork.SelectedValue.ToString(), Int32.Parse(txtPromotion.Text));
                        cd.delete(cd);
                        FormCard_Load(sender, e);
                        this.Alert("Xóa Thành Công", FormAlert.enmType.Success);

                    }
                }
            }
            else this.Alert("Không Có Dữ Liệu Trong Bảng Để Xóa", FormAlert.enmType.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int check = tableCard.Items.Count;
            if (check > 0)
            {
                if (checkTextBox())
                {
                    bool result = new FormDialog("Bạn Có Muốn Cập Nhật Không").resultAns();
                    if (result)
                    {
                        Card cd = new Card(txtCode.Texts, Int32.Parse(txtPrice.Texts), txtNetwork.SelectedValue.ToString(), Int32.Parse(txtPromotion.Text));
                        cd.update(cd);
                        FormCard_Load(sender, e);
                        this.Alert("Cập Nhật Thành Công", FormAlert.enmType.Success);
                    }
                }
            }
            else
            this.Alert("Không Có Dữ Liệu Trong Bảng Để Cập Nhật", FormAlert.enmType.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int check = tableCard.Items.Count;
            if (check > 0)
            {
                bool result = new FormDialog("Bạn Có Muốn Xóa Hết Không").resultAns();
                if (result)
                {
                    Card cd = new Card();
                    cd.deleteAll();
                    FormCard_Load(sender, e);
                    this.Alert("Xóa Thành Công", FormAlert.enmType.Success);
                }
            }
            else this.Alert("Không Có Dữ Liệu Trong Bảng Để Xóa", FormAlert.enmType.Error);
        }

        private void txtCode__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCode.Texts, "[^0-9]"))
            {
                this.Alert("Mã Thẻ Phải Là Số", FormAlert.enmType.Info);
                txtCode.Texts = txtCode.Texts.Remove(txtCode.Texts.Length - 1);
            }
        }
    }
}
