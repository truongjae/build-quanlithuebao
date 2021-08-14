using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QuanLyThueBao
{
    public partial class FormChangePass : Form
    {
        private string username;
        public FormChangePass(string username)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.username = username;
            txtTitle.Text = "Tạo Mật Khẩu Mới Cho Tài Khoản " + this.username;
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        private bool checkTextBox()
        {
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
            if (txtNewPw.Text != txtRePw.Text)
            {
                this.Alert("Mật Khẩu Xác Nhận\nKhông Khớp Với Mật Khẩu Mới", FormAlert.enmType.Warning);
                return false;
            }
            if (txtNewPw.Text.Length > 50)
            {
                this.Alert("Mật Khẩu Mới Tối Đa 50 Ký Tự", FormAlert.enmType.Warning);
                return false;
            }
            return true;
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                ChangePw changepw = new ChangePw(this.username,txtNewPw.Text);
                changepw.updatePassword();
                this.Alert("Mật Khẩu Đã Được Cập Nhật Thành Công\nVui Lòng Đăng Nhập Lại", FormAlert.enmType.Success);
                this.Close();
            }
        }


        private void FormChangePass_Load(object sender, EventArgs e)
        {

        }

        private void showPw_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showPw.Checked)
            {
                txtNewPw.UseSystemPasswordChar = false;
                txtRePw.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPw.UseSystemPasswordChar = true;
                txtRePw.UseSystemPasswordChar = true;
            }
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormChangePass_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
