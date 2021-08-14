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
    public partial class FormInfoUser : Form
    {
        private string username;
        private Connection connection = new Connection();
        public FormInfoUser(string username)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.username = username;
            //this.Text =this.username;
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
                    btn.ForeColor = Color.White;
                }
            }
            foreach (Control btns in groupBox2.Controls)
            {
                if (btns.GetType() == typeof(Label))
                {
                    Label btn = (Label)btns;
                    btn.ForeColor = Color.White;
                }
            }
            groupBox1.ForeColor = Color.White; //ThemeColor.PrimaryColor;
            groupBox2.ForeColor = Color.White; //ThemeColor.PrimaryColor;
            //titleInfo.ForeColor = Color.White;
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            LoadTheme();
            User user = new User(this.username);
            try
            {
                user.showInfo(lbName, lbIdCard, lbDOB, lbSex, lbAddress, lbEmail, lbPhone, lbRegion, lbNetwork, lbType, lbAct, lbExp, lbBalance, lbPromotion, lbPayment,lbStatus);
            }
            catch
            {
                this.Alert("Tài Khoản Không Hợp Lệ\nVui Lòng Đăng Nhập Lại", FormAlert.enmType.Info);
                Login lg = new Login();
                lg.deleteCookie();
                this.Close();
            }
            try
            {
                string sql = "select avatar from customer cs join phone p on p.id_card = cs.id_card join account acc on p.phone_number = acc.username and acc.username='" + this.username + "'";
                MemoryStream stream;
                byte[] arr;
                Customer cm = new Customer();
                // avatar
                DataTable DT = connection.getDataTable(sql);
                arr = (byte[])DT.Rows[0]["avatar"];
                stream = new MemoryStream(arr);
                picAvt.Image = Image.FromStream(stream);
            }
            catch { }
        }

        private void nạpThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Đăng Xuất Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login lg = new Login();
                lg.deleteCookie();
                this.Close();
            }
        }

    }
}
