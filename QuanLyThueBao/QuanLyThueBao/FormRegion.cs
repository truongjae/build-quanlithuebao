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
    public partial class FormRegion : Form
    {
        public FormRegion()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            List<string> listItemSearch = new List<string> { "Tìm Kiếm Mã Vùng", "Tìm Kiếm Tên Vùng" };
            cboSearch.DataSource = listItemSearch;
        }
        private void clearTextBox()
        {
            txtIdRegion.Texts = "";
            txtNameRegion.Texts = "";
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
            tableRegion.ForeColor = Color.White;//ThemeColor.SecondaryColor;
            groupBox1.ForeColor = Color.White;
            groupBox2.ForeColor = Color.White; 

        }
        private bool checkTextBox()
        {
            if (txtIdRegion.Texts.Equals(""))
            {
                this.Alert("Mã Vùng Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtNameRegion.Texts.Equals(""))
            {
                this.Alert("Tên Vùng Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }

            try
            {
                Int64.Parse(txtIdRegion.Texts);
            }
            catch
            {
                this.Alert("Mã Vùng Phải Là Số\nVà Không Được Quá Lớn", FormAlert.enmType.Info);
                return false;
            }
            string specialChar = "0123456789.+-*/!@#$%^&*()_=[]{};'|\\\",<>?`~";
            foreach (char a in txtNameRegion.Texts) // check ten vung ki tu dac biet
            {
                if (specialChar.Contains(a))
                {
                    this.Alert("Tên Vùng Không Được\nChứa Kí Tự Đặc Biệt Hoặc Số", FormAlert.enmType.Info);
                    return false;
                }
            }
            if (txtIdRegion.Texts.Length > 5)
            {
                this.Alert("Mã Vùng Tối Đa 5 Chữ Số", FormAlert.enmType.Info);
                return false;
            }
            if (txtNameRegion.Texts.Length > 50)
            {
                this.Alert("Tên Vùng Tối Đa 50 Kí Tự", FormAlert.enmType.Info);
                return false;
            }
            return true;
        }
        private void FormRegion_Load(object sender, EventArgs e)
        {
            Regions rg = new Regions();
            rg.showListView(tableRegion, "SELECT * FROM region");
            LoadTheme();
            clearTextBox();
        }
        
        private void tableRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in tableRegion.SelectedItems)
            {
                txtIdRegion.Texts = item.SubItems[1].Text;
                txtNameRegion.Texts = item.SubItems[2].Text;
            }
        }
        private void button1_Click(object sender, EventArgs e) // button insert
        {
            if (checkTextBox())
            {
                    Regions rg = new Regions(txtIdRegion.Texts, txtNameRegion.Texts);
                    if (rg.checkKey(txtIdRegion.Texts))
                    {
                        this.Alert("Mã Vùng Đã Tồn Tại", FormAlert.enmType.Info);
                    }
                    else
                    {
                        rg.insert(rg);
                        FormRegion_Load(sender, e);
                        this.Alert("Thêm Thành Công", FormAlert.enmType.Success);
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int check = tableRegion.Items.Count;
            if (check > 0)
            {
                if (checkTextBox())
                {
                    bool result = new FormDialog("Bạn Có Muốn Xóa Không").resultAns();
                    if (result)
                    {
                        Regions rg = new Regions(txtIdRegion.Texts, txtNameRegion.Texts);
                        rg.delete(rg);
                        FormRegion_Load(sender, e);
                        this.Alert("Xóa Thành Công", FormAlert.enmType.Success);
                    }
                }
            }
            else
            this.Alert("Không Có Dữ Liệu Trong Bảng Để Xóa", FormAlert.enmType.Info);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int check = tableRegion.Items.Count;
            if (check > 0)
            {
                if (checkTextBox())
                {
                    bool result = new FormDialog("Bạn Có Muốn Cập Nhật Không").resultAns();
                    if (result)
                    {
                        Regions rg = new Regions(txtIdRegion.Texts, txtNameRegion.Texts);
                        rg.update(rg);
                        FormRegion_Load(sender, e);                        
                        this.Alert("Cập Nhật Thành Công", FormAlert.enmType.Success);
                    }
                }
            }
            else this.Alert("Không Có Dữ Liệu Trong Bảng Để Cập Nhật", FormAlert.enmType.Info);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int check = tableRegion.Items.Count;
            if (check>0)
            {
                bool result = new FormDialog("Bạn Có Muốn Xóa Hết Không").resultAns();
                if (result)
                {
                    Regions rg = new Regions();
                    rg.deleteAll();
                    FormRegion_Load(sender, e);
                    this.Alert("Xóa Thành Công", FormAlert.enmType.Success);
                }
            }
            else this.Alert("Không Có Dữ Liệu Trong Bảng Để Xóa", FormAlert.enmType.Info);
        }
        Regions rg = new Regions();

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSearch.Texts, "[']"))
            {
                txtSearch.Texts = txtSearch.Texts.Remove(txtSearch.Texts.Length - 1);
            }
            switch (cboSearch.SelectedIndex)
            {
                case 0:
                    rg.showListView(tableRegion, "select * from region where id_region like N'" + txtSearch.Texts + "%'");
                    break;
                case 1:
                    rg.showListView(tableRegion, "select * from region where name_region like N'" + txtSearch.Texts + "%'");
                    break;
            }
        }
    }
}
