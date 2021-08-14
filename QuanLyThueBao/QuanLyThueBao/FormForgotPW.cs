using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Runtime.InteropServices;
namespace QuanLyThueBao
{
    public partial class FormForgotPW : Form
    {
        public FormForgotPW()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            txtCode.Hide();
            btnA.Hide();
            panelCode.Hide();
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
        string code = "";
        Random rnd = new Random();
        private bool checkTextBox()
        {
            if (txtUser.Text.Equals(""))
            {
                this.Alert("Tài Khoản Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            string specialChar = "'";
            foreach (char a in txtUser.Text) // check ten dang nhap ki tu dac biet
            {
                if (specialChar.Contains(a))
                {
                    this.Alert("Xin Đừng Hack Nick Em :((", FormAlert.enmType.Warning);
                    return false;
                }
            }
            if (txtUser.Text.Length > 11)
            {
                this.Alert("Tài Khoản Không Tồn Tại", FormAlert.enmType.Warning);
                return false;
            }
            return true;
        }
        private void FormForgotPW_Load(object sender, EventArgs e)
        {

        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                SendMailForgotPW fg = new SendMailForgotPW(txtUser.Text);
                if (fg.checkAccount(fg))
                {
                    code = rnd.Next(100001, 999999).ToString();
                    fg.sendMail(code);
                    this.Alert("Mã Xác Nhận Đã Được Gửi Đến:\n"+fg.getInfo()[1], FormAlert.enmType.Info);
                    txtCode.Show();
                    btnA.Show();
                    panelCode.Show();
                    btnSendCode.Text = "Gửi Lại Mã";
                }
                else this.Alert("Tài Khoản Không Tồn Tại", FormAlert.enmType.Error);
            } 
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals(""))
                this.Alert("Mã Xác Nhận Không Được Để Trống", FormAlert.enmType.Info);
            else
            {
                if (String.Compare(txtCode.Text.Trim(), code.Trim(), true) == 0)
                {
                    this.Hide();
                    Form f = new FormChangePass(txtUser.Text);
                    f.ShowDialog();
                    this.Close();
                }
                else
                this.Alert("Mã Xác Nhận Không Chính Xác", FormAlert.enmType.Error);
            }
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormForgotPW_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


    }
}
