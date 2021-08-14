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
    public partial class FormSendMess : Form
    {
        private Connection connection = new Connection();
        private String myPhone;
        public FormSendMess(string myPhone)
        {
            InitializeComponent();
            this.myPhone = myPhone;
        }

        private void FormSendMess_Load(object sender, EventArgs e)
        {
            txtReceiver.DataSource = connection.getDataTable("select p.phone_number,cs.name_customer from phone p join customer cs on p.id_card = cs.id_card");
            txtReceiver.DisplayMember = "phone_number";
            txtReceiver.ValueMember = "phone_number";
            txtReceiver.Text = "";
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        private bool checkTextBox()
        {
            if (txtReceiver.Text.Equals(""))
            {
                this.Alert("Số Điện Thoại Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtContent.Text.Equals(""))
            {
                this.Alert("Nội Dung Tin Nhắn Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtReceiver.Text.Length > 11)
            {
                this.Alert("Số Điện Thoại Không Tồn Tại", FormAlert.enmType.Info);
                return false;
            }
            if (txtContent.Text.Length > 1000)
            {
                this.Alert("Nội Dung Tin Nhắn Tối Đa 1000 Ký Tự", FormAlert.enmType.Info);
                return false;
            }
            return true;
        }


        private void txtReceiver_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtReceiver.Text, "[^0-9]"))
            {
                txtReceiver.Text = txtReceiver.Text.Remove(txtReceiver.Text.Length - 1);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtReceiver.Text, "[^0-9]"))
            {
                DataTable DT = connection.getDataTable("select cs.name_customer,cs.avatar from phone p join customer cs on p.id_card = cs.id_card and p.phone_number =N'" + txtReceiver.Text + "'");
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

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Red;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = System.Drawing.Color.DodgerBlue; 

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                if (this.myPhone.Equals(txtReceiver.Text))
                    this.Alert("Bạn Không Thể Gửi Tin Nhắn\nCho Chính Bạn", FormAlert.enmType.Error);
                else
                {
                    Notification notification = new Notification(this.myPhone);
                    if (notification.checkBill(notification))
                        this.Alert("Thuê Bao Của Bạn Đã Bị Chưa Thanh Toán\nHóa Đơn Vui Lòng Thanh Toán\nĐể Sử Dụng Tiếp Dịch Vụ", FormAlert.enmType.Warning);
                    else
                    {
                        SendMess sm = new SendMess(this.myPhone, txtReceiver.Text, txtContent.Text);
                        if (sm.checkPhone(sm))
                        {
                            sm.sendMess(sm);
                            this.Close();
                        }
                        else this.Alert("Số Điện Thoại Không Tồn Tại", FormAlert.enmType.Error);
                    } 
                }
            }
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtContent.Text, "[']"))
            {
                txtContent.Text = txtContent.Text.Remove(txtContent.Text.Length - 1);
            }
        }


    }
}
