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
    public partial class FormRecharge : Form
    {
        private string username;
        public FormRecharge(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        private bool checkTextBox()
        {
            if (txtCard.Text.Equals(""))
            {
                this.Alert("Mã Thẻ Nạp Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            //
            var checkId = new Regex("^[0-9]*$");
            if (!checkId.IsMatch(txtCard.Text))
            {
                this.Alert("Mã Thẻ Phải Là Số", FormAlert.enmType.Info);
                return false;
            }
          
            if (txtCard.Text.Length > 20)
            {
                this.Alert("Mã Thẻ Sai", FormAlert.enmType.Info);
                return false;
            }
           
            return true;
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                Recharge rec = new Recharge(this.username, txtCard.Text);
                if (rec.checkStatus())
                {
                    if (rec.countCard())
                    {
                        if (rec.acceptRecharge())
                            this.Alert("Nạp Thẻ Thành Công", FormAlert.enmType.Success);
                        else
                            this.Alert("Mã Thẻ Sai", FormAlert.enmType.Error);
                    }
                    else
                    {
                        this.Alert("Mã Thẻ Sai\nDo Nhà Mạng Của Bạn Đã Hết Thẻ", FormAlert.enmType.Info);
                    }
                }
                else
                    this.Alert("Thuê Bao Của Bạn Đã Bị\nChặn 1 Chiều Vui Lòng Liên Hệ\nHỗ Trợ Viên Để Mở Khóa", FormAlert.enmType.Error);
               
            }
        }
    }
}
