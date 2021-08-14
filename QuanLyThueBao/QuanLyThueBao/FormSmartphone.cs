using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace QuanLyThueBao
{
    public partial class FormSmartphone : Form
    {
        private Connection connection = new Connection();
        private string myPhone;
        public FormSmartphone(string myPhone)
        {
            InitializeComponent();
            this.myPhone = myPhone;
            foreach (Control btns in this.Controls)
                 if (btns.GetType() == typeof(PictureBox))
                 {
                     if(!btns.Name.Equals("btnCall"))
                         btns.Click += btn_Click;
                 }
            timeNow.Start();
           
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
                this.Alert("Số Điện Thoại Không Được Để Trống", FormAlert.enmType.Error);
                return false;
            }
            if (cboPhone.Text.Length > 11)
            {
                this.Alert("Số Điện Thoại Không Tồn Tại", FormAlert.enmType.Error);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(cboPhone.Text, "[']"))
            {
                this.Alert("Số Điện Thoại Không Được\nChứa Ký Tự Đặc Biệt", FormAlert.enmType.Error);
                return false;
            }
            return true;
        }
        private void FormSmartphone_Load(object sender, EventArgs e)
        {
            cboPhone.DataSource = connection.getDataTable("select p.phone_number,cs.name_customer from phone p join customer cs on p.id_card = cs.id_card");
            cboPhone.DisplayMember = "phone_number";
            cboPhone.ValueMember = "phone_number";
            cboPhone.Text = "";
        }
        private void btn_Click(object sender, EventArgs e)
        {
            string x = "";
            if ((sender as PictureBox).Name.Equals("btnsao"))
            {
                x = "*";
            }
            else if ((sender as PictureBox).Name.Equals("btnthang"))
            {
                x = "#";

            }
            else
            {
                 x = (sender as PictureBox).Name.Substring(3);
            }
            cboPhone.Text += x;
           
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            if(checkTextBox()){
                if (this.myPhone.Equals(cboPhone.Text))
                    this.Alert("Bạn Không Thể Gọi\nCho Chính Bạn", FormAlert.enmType.Error);
                else
                {
                    Notification notification = new Notification(this.myPhone);
                    if (notification.checkBill(notification))
                        this.Alert("Thuê Bao Của Bạn Đã Bị Chưa Thanh Toán\nHóa Đơn Vui Lòng Thanh Toán Để\nSử Dụng Tiếp Dịch Vụ", FormAlert.enmType.Warning);
                    else
                    {
                        Call call = new Call(this.myPhone, cboPhone.Text);
                        if (call.checkPhone(call))
                        {
                            FormPhoneConnecting fConnect = new FormPhoneConnecting(this.myPhone, cboPhone.Text);
                            this.Hide();
                            fConnect.ShowDialog();
                            this.Show();
                        }
                        else this.Alert("Số Điện Thoại Không Tồn Tại", FormAlert.enmType.Error);
                    }
                }
            }
           
        }

        private void cboPhone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(cboPhone.Text, "[^0-9*#]"))
            {
                cboPhone.Text = cboPhone.Text.Remove(cboPhone.Text.Length - 1);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(cboPhone.Text, "[^0-9*#]"))
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

        private void timeNow_Tick(object sender, EventArgs e)
        {
            lbTimeNow.Text = DateTime.Now.ToString("HH:mm");
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
