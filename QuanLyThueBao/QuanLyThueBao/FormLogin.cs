using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
namespace QuanLyThueBao
{
    public partial class FormLogin : Form
    {
        Login lg = new Login();
        public FormLogin()
        {
            try
            {
                Connection connection = new Connection();
                connection.excute("select username from account");
            }
            catch 
            {
                MessageBox.Show("Vui Lòng Cài Đặt SQLEXPRESS 2019 Và Tạo Cơ Sở Dữ Liệu Mọi Thông Tin Chi Tiết Vui Lòng Đọc Kỹ File Readme.md");
                return;
            }
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = string.Empty;
            this.ControlBox = false;
            ListService lsv = new ListService();
            lsv.autoCancelService(); // auto xoa dich vu het han
            Phone phone = new Phone();
            phone.autoDeletePhone(); // auto xoa sdt het han
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private bool checkTextBox()
        {
            if (txtUser.Text.Equals(""))
            {
                this.Alert("Tên Đăng Nhập Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtPw.Text.Equals(""))
            {
                this.Alert("Mật Khẩu Không Được Để Trống", FormAlert.enmType.Info);
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
            specialChar = "'";
            foreach (char a in txtPw.Text) // check mk dang nhap ki tu dac biet
            {
                if (specialChar.Contains(a))
                {
                    this.Alert("Xin Đừng Hack Nick Em :((", FormAlert.enmType.Warning);
                    return false;
                }
            }
            return true;
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (lg.checkCookie())
            {
                Login lgCookie = new Login(lg.accountCookie()[0], lg.accountCookie()[1]);
                if (lgCookie.checkAccount(lgCookie))
                {
                    //if (String.Compare(lgCookie.userName.Trim(), "admin".Trim(), true) == 0)
                    if (lg.checkPermission(lgCookie))
                    {
                        this.Hide();
                        Form f = new FormManager(lgCookie.accountCookie()[0]);
                        f.ShowDialog();
                        if (lg.checkCookie()) this.Close();
                        else
                        {
                            try
                            {
                                this.Show();
                            }
                            catch { }
                        }
                    }
                    else
                    {
                        this.Hide();
                        Form f = new FormUsers(lgCookie.userName);
                        f.ShowDialog();
                        if (lg.checkCookie()) this.Close();
                        else
                        {
                            try
                            {
                                this.Show();
                            }
                            catch { }
                        }
                    }
                }
                else
                {
                    this.Alert("Vui Lòng Đăng Nhập Lại", FormAlert.enmType.Info);
                }
            } 
        }
        private void showPw_CheckedChanged(object sender, EventArgs e)
        {
            if (showPw.Checked) txtPw.UseSystemPasswordChar = false;
            else txtPw.UseSystemPasswordChar = true;
        }
        private void linkForgotPw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form f = new FormForgotPW();
            f.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                Login lg = new Login(txtUser.Text, txtPw.Text);
                if (lg.checkAccount(lg))
                {
                    lg.deleteCookie();
                    lg.insertCookie(lg);
                    //if (String.Compare(lg.userName.Trim(), "admin".Trim(), true) == 0)
                   if(lg.checkPermission(lg))
                    {
                        this.Hide();
                        Form f = new FormManager(lg.userName);
                        f.ShowDialog();
                        if (lg.checkCookie()) this.Close();
                        else
                        {
                            try
                            {
                                this.Show();
                            }
                            catch { }
                        }
                    }
                    else
                    {
                        this.Hide();
                        Form f = new FormUsers(lg.userName);
                        f.ShowDialog();
                        if (lg.checkCookie()) this.Close();
                        {
                            try
                            {
                                this.Show();
                            }
                            catch { }
                        }
                    }
                }
                else this.Alert("Thông Tin Tài Khoản Hoặc Mật Khẩu\nKhông Chính Xác!", FormAlert.enmType.Info);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/100029031824085");
        }

    }
}
