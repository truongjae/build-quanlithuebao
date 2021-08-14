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
    public partial class FormChangePassLogin : Form
    {
        private string username;
        public FormChangePassLogin(string username)
        {
            InitializeComponent();
            this.username = username;
            txtTitle.Text = "Thay Đổi Mật Khẩu Cho Tài Khoản " + this.username;
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        private bool checkTextBox()
        {
            if (txtOldPw.Text.Equals(""))
            {
                this.Alert("Mật Khẩu Cũ Không Được Để Trống", FormAlert.enmType.Warning);
                return false;
            }

            if (txtNewPw.Text.Equals(""))
            {
                this.Alert("Mật Khẩu Mới Không Được Để Trống", FormAlert.enmType.Warning);
                return false;
            }
            if (txtRePw.Text.Equals(""))
            {
                this.Alert("Mật Khẩu Xác Nhận Không Được Để Trống", FormAlert.enmType.Warning);
                return false;
            }
            string specialChar = "'";
            foreach (char a in txtNewPw.Text) // check mk moi ki tu dac biet
            {
                if (specialChar.Contains(a))
                {
                    this.Alert("Mật Khẩu Mới Không Được\nChứa Ký Tự Đặc Biệt ( ' )", FormAlert.enmType.Warning);
                    return false;
                }
            }
            specialChar = "'";
            foreach (char a in txtOldPw.Text) // check mk cu ki tu dac biet
            {
                if (specialChar.Contains(a))
                {
                    this.Alert("Mật Khẩu Cũ Không Được\nChứa Ký Tự Đặc Biệt ( ' )", FormAlert.enmType.Warning);
                    return false;
                }
            }
            if (txtOldPw.Text.Length > 50)
            {
                this.Alert("Tài Khoản Mật Khẩu\nKhông Chính Xác", FormAlert.enmType.Warning);
                return false;
            }
            if (txtNewPw.Text.Length > 50)
            {
                this.Alert("Mật Khẩu Mới Tối Đa 50 Ký Tự", FormAlert.enmType.Warning);
                return false;
            }

            Login lg = new Login(this.username,txtOldPw.Text);
            if (lg.checkAccount(lg)==false)
            {
                this.Alert("Tài Khoản Mật Khẩu\nKhông Chính Xác", FormAlert.enmType.Error);
                return false;
            }
            
            if (txtNewPw.Text != txtRePw.Text)
            {
                this.Alert("Mật Khẩu Xác Nhận\nKhông Khớp Với Mật Khẩu Mới", FormAlert.enmType.Warning);
                return false;
            }

            return true;
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                //
                ChangePw changepw = new ChangePw(this.username, txtNewPw.Text);
                changepw.updatePassword();
                this.Alert("Mật Khẩu Đã Được Cập Nhật Thành Công\nVui Lòng Đăng Nhập Lại", FormAlert.enmType.Success);
                Login lg = new Login();
                lg.deleteCookie();
            }
        }

        private void showPw_CheckedChanged(object sender, EventArgs e)
        {
            if (showPw.Checked)
            {
                txtOldPw.UseSystemPasswordChar = false;
                txtNewPw.UseSystemPasswordChar = false;
                txtRePw.UseSystemPasswordChar = false;
            }
            else
            {
                txtOldPw.UseSystemPasswordChar = true;
                txtNewPw.UseSystemPasswordChar = true;
                txtRePw.UseSystemPasswordChar = true;
            }
        }
    }
}
