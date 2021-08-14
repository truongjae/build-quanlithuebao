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
    public partial class FormAccount : Form
    {
        private Connection connection = new Connection();
        private string myAccount;
        public FormAccount(string myAccount)
        {
            InitializeComponent();
            this.myAccount = myAccount;
            List<string> listItem = new List<string> { "Không","Admin" };
            txtPermission.DataSource = listItem;
            List<string> listItemSearch = new List<string> { "Tìm Kiếm Tên Tài Khoản", "Tìm Kiếm Theo Quyền" };
            cboSearch.DataSource = listItemSearch;
        }
        private void clearTextBox()
        {
            txtPw.Texts = "";
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
            tableAccount.ForeColor = Color.White; //ThemeColor.SecondaryColor;
            groupBox1.ForeColor = Color.White; //ThemeColor.PrimaryColor;
            groupBox2.ForeColor = Color.White; //ThemeColor.PrimaryColor;

        }
        private bool checkTextBox()
        {
            if (txtUsername.Text.Equals(""))
            {
                this.Alert("Tài Khoản Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtPw.Texts.Equals(""))
            {
                this.Alert("Mật Khẩu Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }

            string specialChar = "'";
            foreach (char a in txtUsername.Text)  //check ki tu dac biet tk
            {
                if (specialChar.Contains(a))
                {
                    this.Alert("Tài Khoản Không Được\nChứa Kí Tự Đặc Biệt ( ' )", FormAlert.enmType.Info);
                    return false;
                }
            }
            foreach (char a in txtPw.Texts)  //check ki tu dac biet mat khau
            {
                if (specialChar.Contains(a))
                {
                    this.Alert("Mật Khẩu Không Được\nChứa Kí Tự Đặc Biệt ( ' )", FormAlert.enmType.Info);
                    return false;
                }
            }
            if (txtUsername.Text.Length > 11)
            {
                this.Alert("Tài Khoản Tối Đa 11 Kí Tự", FormAlert.enmType.Info);
                return false;
            }
            if (txtPw.Texts.Length > 50)
            {
                this.Alert("Mật Khẩu Tối Đa 50 Kí Tự", FormAlert.enmType.Info);
                return false;
            }
            return true;
        }
        private bool checkTextBox2()
        {
            if (txtUsername.Text.Equals(""))
            {
                this.Alert("Tài Khoản Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            string specialChar = "'";
            foreach (char a in txtUsername.Text)  //check ki tu dac biet tk
            {
                if (specialChar.Contains(a))
                {
                    this.Alert("Tài Khoản Không Được\nChứa Kí Tự Đặc Biệt ( ' )", FormAlert.enmType.Info);
                    return false;
                }
            }
            foreach (char a in txtPw.Texts)  //check ki tu dac biet mat khau
            {
                if (specialChar.Contains(a))
                {
                    this.Alert("Mật Khẩu Không Được\nChứa Kí Tự Đặc Biệt ( ' )", FormAlert.enmType.Info);
                    return false;
                }
            }
            if (txtUsername.Text.Length > 11)
            {
                this.Alert("Tài Khoản Tối Đa 11 Kí Tự", FormAlert.enmType.Info);
                return false;
            }
            if (txtPw.Texts.Length > 50)
            {
                this.Alert("Mật Khẩu Tối Đa 50 Kí Tự", FormAlert.enmType.Info);
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                string permission = "";
                switch (txtPermission.SelectedIndex)
                { 
                    case 0:
                        permission = "0";
                        break;
                    case 1:
                        permission = "1";
                        break;
                }
                Account acc = new Account(txtUsername.Text, txtPw.Texts, permission);
                if (acc.checkKey(txtUsername.Text))
                    this.Alert("Tài Khoản Đã Tồn Tại", FormAlert.enmType.Info);
                else
                {
                    acc.insert(acc);
                    FormAccount_Load(sender, e);
                    this.Alert("Thêm Thành Công", FormAlert.enmType.Success);
                }
            }
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            Account acc = new Account();
            txtUsername.DataSource = connection.getDataTable("select * from account");
            txtUsername.DisplayMember = "username";
            txtUsername.ValueMember = "username";
            acc.showListView(tableAccount, "SELECT * FROM account");
            LoadTheme();
            clearTextBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int check = tableAccount.Items.Count;
            if (check > 0)
            {
                if (checkTextBox2())
                {
                    bool result = new FormDialog("Bạn Có Muốn Xóa Không").resultAns();
                    if (result)
                    {
                        string permission = "";
                        switch (txtPermission.SelectedIndex)
                        {
                            case 0:
                                permission = "0";
                                break;
                            case 1:
                                permission = "1";
                                break;
                        }
                        Account acc = new Account(txtUsername.Text, txtPw.Texts, permission);

                        if (acc.checkMyAccount(this.myAccount,txtUsername.Text)) this.Alert("Không Thể Tự Xóa Tài Khoản Của Bạn", FormAlert.enmType.Error);
                        else
                        {
                            acc.delete(acc);
                            FormAccount_Load(sender, e);
                            this.Alert("Xóa Thành Công", FormAlert.enmType.Success);
                        }
                    }
                }
            }
            else
                this.Alert("Không Có Dữ Liệu Trong Bảng Để Xóa", FormAlert.enmType.Info);
        }

        private void tableAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in tableAccount.SelectedItems)
            {
                txtUsername.SelectedValue = item.SubItems[1].Text;
                //txtPw.Text = item.SubItems[2].Text;
                switch (item.SubItems[3].Text)
                {
                    case "0":
                        txtPermission.SelectedIndex = 0;
                        break;
                    case "1":
                        txtPermission.SelectedIndex = 1;
                        break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int check = tableAccount.Items.Count;
            if (check > 0)
            {
                if (checkTextBox())
                {
                    bool result = new FormDialog("Bạn Có Muốn Cập Nhật Không").resultAns();
                    if (result)
                    {
                        string permission = "";
                        switch (txtPermission.SelectedIndex)
                        {
                            case 0:
                                permission = "0";
                                break;
                            case 1:
                                permission = "1";
                                break;
                        }
                        Account acc = new Account(txtUsername.Text, txtPw.Texts, permission);
                        acc.update(acc);
                        FormAccount_Load(sender, e);
                        this.Alert("Cập Nhật Thành Công", FormAlert.enmType.Success);
                    }
                }
            }
            else this.Alert("Không Có Dữ Liệu Trong Bảng Để Cập Nhật", FormAlert.enmType.Info);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int check = tableAccount.Items.Count;
            if (check > 0)
            {
                bool result = new FormDialog("Bạn Có Muốn Xóa Hết Không").resultAns();
                if (result)
                {
                    Account acc = new Account(this.myAccount);
                    acc.deleteAll(acc);
                    FormAccount_Load(sender, e);
                    this.Alert("Xóa Thành Công", FormAlert.enmType.Success);
                }
            }
            else this.Alert("Không Có Dữ Liệu Trong Bảng Để Xóa", FormAlert.enmType.Info);
        }

        private void txtUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable DT = connection.getDataTable("select password,permission from account where username = N'"+txtUsername.Text+"'");
            if (DT.Rows.Count > 0)
            {
                string password = DT.Rows[0]["password"].ToString();
                string permission = DT.Rows[0]["permission"].ToString();
                switch (permission)
                {
                    case "0":
                        txtPermission.SelectedIndex = 0;
                        break;
                    case "1":
                        txtPermission.SelectedIndex = 1;
                        break;
                }
                //txtPw.Text = password;
            }

        }
        Account acc = new Account();

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSearch.Texts, "[']"))
            {
                txtSearch.Texts = txtSearch.Texts.Remove(txtSearch.Texts.Length - 1);
            }
            switch (cboSearch.SelectedIndex)
            {
                case 0:
                    acc.showListView(tableAccount, "select * from account where username like N'" + txtSearch.Texts + "%'");
                    break;
                case 1:
                    acc.showListView(tableAccount, "select * from account where permission like N'" + txtSearch.Texts + "%'");
                    break;
            }
        }
    }
}
