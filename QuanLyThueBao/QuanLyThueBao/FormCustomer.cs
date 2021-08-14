using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Data.SqlClient;
namespace QuanLyThueBao
{
    public partial class FormCustomer : Form
    {
        private Connection connection = new Connection();
        public FormCustomer()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            List<string> listItemSex = new List<string> { "Nam", "Nữ" };
            txtSex.DataSource = listItemSex;
            List<string> listItemSearch = new List<string> { "Tìm Kiếm CMND/CCCD", "Tìm Kiếm Tên Khách Hàng","Tìm Kiếm Năm Sinh",
                "Tìm Kiếm Giới Tính","Tìm Kiếm Địa Chỉ", "Tìm Kiếm Email"};
            cboSearch.DataSource = listItemSearch;
            resetImg();
            avatar.SizeMode = PictureBoxSizeMode.Zoom;
            imgIdCardFront.SizeMode = PictureBoxSizeMode.Zoom;
            imgIdCardBack.SizeMode = PictureBoxSizeMode.Zoom;
            avatar.BackColor = Color.White;
            imgIdCardFront.BackColor = Color.White;
            imgIdCardBack.BackColor = Color.White;  
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        private void clearTextBox()
        {
            txtIdCard.Texts = "";
            txtName.Texts = "";
            txtAddress.Texts = "";
            txtEmail.Texts = "";
        }
        private void resetImg()
        {
            avatar.Image = Properties.Resources.avtdefault;
            imgIdCardFront.Image = Properties.Resources.frontbg;
            imgIdCardBack.Image = Properties.Resources.backbg;
        }
        private void LoadTheme()
        {
            foreach (Control btns in groupBox1.Controls)
            {
                if (btns.GetType() == typeof(Label))
                {
                    Label btn = (Label)btns;
                    btn.ForeColor = Color.White;//ThemeColor.PrimaryColor;
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
            avatar.BackColor = ThemeColor.PrimaryColor;
            imgIdCardFront.BackColor = ThemeColor.PrimaryColor;
            imgIdCardBack.BackColor = ThemeColor.PrimaryColor;
            tableCustomer.ForeColor = Color.White;//ThemeColor.PrimaryColor;
            lbavt.ForeColor = Color.White;//ThemeColor.PrimaryColor;
            lbCardFront.ForeColor = Color.White;//ThemeColor.PrimaryColor;
            lbCardBack.ForeColor = Color.White;//ThemeColor.PrimaryColor;
            groupBox1.ForeColor = Color.White;
            groupBox2.ForeColor = Color.White;
            
        }

       /* private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }*/

        private bool checkTextBox()
        {
            if (txtIdCard.Texts.Equals(""))
            {
                this.Alert("Số CMND/CCCD Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtName.Texts.Equals(""))
            {
                this.Alert("Họ Và Tên Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtAddress.Texts.Equals(""))
            {
                this.Alert("Địa Chỉ Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            if (txtEmail.Texts.Equals(""))
            {
                this.Alert("Email Không Được Để Trống", FormAlert.enmType.Info);
                return false;
            }
            //
            var checkId = new Regex("^[0-9]*$");
            if (!checkId.IsMatch(txtIdCard.Texts))
            { // check cmnd
                this.Alert("Số CMND/CCCD Không Được\nChứa Kí Tự Đặc Biệt", FormAlert.enmType.Info);
                return false;
            }
            string specialChar = "0123456789.+-*/!@#$%^&*()_=[]{};'|\\\",<>?`~";
            foreach (char a in txtName.Texts) // check ho ten
            {
                if (specialChar.Contains(a))
                {
                    this.Alert("Họ Và Tên Không Được Chứa\nKí Tự Đặc Biệt Hoặc Số", FormAlert.enmType.Info);
                    return false;
                }
            }
            specialChar = "'";
            foreach (char a in txtAddress.Texts) // check dia chi
            {
                if (specialChar.Contains(a))
                {
                    this.Alert("Địa Chỉ Không Được Chứa Kí Tự Đặc Biệt (')", FormAlert.enmType.Info);
                    return false;
                }
            }

            specialChar = "+-*\\/!#$%^&*()=[]{};'|\\\",<>?`~";
            foreach (char a in txtEmail.Texts) // check email
            {
                if (specialChar.Contains(a))
                {
                    this.Alert("Email Không Được Chứa Kí Tự Đặc Biệt (')", FormAlert.enmType.Info);
                    return false;
                }
            }
            if (txtIdCard.Texts.Length != 12 && txtIdCard.Texts.Length != 9)
            {
                this.Alert("CMND/CCCD Sai Định Dạng\n(CMND 9 Số và CCCD 12 Số)", FormAlert.enmType.Info);
                return false;
            }
            if (txtName.Texts.Length > 50)
            {
                this.Alert("Họ Và Tên Tối Đa 50 Kí Tự", FormAlert.enmType.Info);
                return false;
            }
            if (txtAddress.Texts.Length > 100)
            {
                this.Alert("Địa Chỉ Tối Đa 100 Kí Tự", FormAlert.enmType.Info);
                return false;
            }
            if (txtEmail.Texts.Length > 50)
            {
                this.Alert("Email Tối Đa 50 Kí Tự", FormAlert.enmType.Info);
                return false;
            }
            int yearDOB = Int32.Parse((txtDOB.Value).ToString("yyyy"));
            int yearNow = Int32.Parse(DateTime.Now.ToString("yyyy"));
            if (yearNow - yearDOB < 15)
            {
                this.Alert("Khách Hàng Phải Từ 15 Tuổi Trở Lên", FormAlert.enmType.Info);
                return false;
            }
            return true;
        }
        private bool checkImg() 
        {
            if (compare((Bitmap)avatar.Image, Properties.Resources.avtdefault))//
            {
                this.Alert("Vui Lòng Chọn Ảnh Chân Dung", FormAlert.enmType.Info);
                return false;
            }
            if(compare((Bitmap)imgIdCardFront.Image, Properties.Resources.frontbg))
            {
                this.Alert("Vui Lòng Chọn Ảnh CMND/CCCD Mặt Trước", FormAlert.enmType.Info);
                return false;
            }
            if(compare((Bitmap)imgIdCardBack.Image, Properties.Resources.backbg))
            {
                this.Alert("Vui Lòng Chọn Ảnh CMND/CCCD Mặt Sau", FormAlert.enmType.Info);
                return false;
            }
            return true;
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            Customer cm = new Customer();
            cm.showListView(tableCustomer, "SELECT * FROM customer");
            LoadTheme();
            clearTextBox();
            resetImg();
        }
        private bool compare(Bitmap bmp1, Bitmap bmp2)
        {
            bool equals = true;
            bool flag = true; 
            if (bmp1.Size == bmp2.Size)
            {
                for (int x = 0; x < bmp1.Width; ++x)
                {
                    for (int y = 0; y < bmp1.Height; ++y)
                    {
                        if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                        {
                            equals = false;
                            flag = false;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        break;
                    }
                }
            }
            else
            {
                equals = false;
            }
            return equals;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkTextBox()&&checkImg())
            {
                Customer cm = new Customer(txtIdCard.Texts, txtName.Texts, txtDOB.Value.ToString("yyyy-MM-dd"), 
                    txtSex.Texts, txtAddress.Texts,txtEmail.Texts,ImageToStream(avatar.ImageLocation), ImageToStream(imgIdCardFront.ImageLocation), 
                    ImageToStream(imgIdCardBack.ImageLocation));
                    if (cm.checkKey(txtIdCard.Texts))
                    {
                        this.Alert("Số CMND/CCCD Đã Tồn Tại", FormAlert.enmType.Info);
                    }
                    else
                    {
                        cm.insert(cm);
                        FormCustomer_Load(sender, e);
                        this.Alert("Thêm Thành Công", FormAlert.enmType.Success);
                    }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int check = tableCustomer.Items.Count;
            if (check > 0)
            {
                if (checkTextBox())
                {
                    bool result = new FormDialog("Bạn Có Muốn Xóa Không").resultAns();
                    if (result)
                    {
                        Customer cm = new Customer(txtIdCard.Texts, txtName.Texts, txtDOB.Value.ToString("yyyy-MM-dd"), txtSex.Texts, txtAddress.Texts, txtEmail.Texts);
                        cm.delete(cm);
                        FormCustomer_Load(sender, e);
                        this.Alert("Xóa Thành Công", FormAlert.enmType.Success);
                    }
                }
            }
            else this.Alert("Không Có Dữ Liệu Trong Bảng Để Xóa", FormAlert.enmType.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int check = tableCustomer.Items.Count;
            if (check > 0)
            {
                if (checkTextBox() && checkImg())
                {
                    bool result = new FormDialog("Bạn Có Muốn Cập Nhật Không").resultAns();
                    if (result)
                    {
                        Customer cm = new Customer(txtIdCard.Texts, txtName.Texts, txtDOB.Value.ToString("yyyy-MM-dd"),
                           txtSex.Texts, txtAddress.Texts, txtEmail.Texts, ImageToStream(avatar.ImageLocation), ImageToStream(imgIdCardFront.ImageLocation),
                           ImageToStream(imgIdCardBack.ImageLocation));
                        cm.update(cm);
                        FormCustomer_Load(sender, e);                        
                        this.Alert("Cập Nhật Thành Công", FormAlert.enmType.Success);

                    }
                }
            }
            else this.Alert("Không Có Dữ Liệu Trong Bảng Để Cập Nhật", FormAlert.enmType.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int check = tableCustomer.Items.Count;
            if (check > 0)
            {
                bool result = new FormDialog("Bạn Có Muốn Xóa Hết Không").resultAns();
                if (result)
                {
                    Customer cm = new Customer();
                    cm.deleteAll();
                    FormCustomer_Load(sender, e);
                    this.Alert("Xóa Thành Công", FormAlert.enmType.Success);
                }
            }
            else this.Alert("Không Có Dữ Liệu Trong Bảng Để Xóa", FormAlert.enmType.Error);
        }

        // convert img to stream
        public byte[] ImageToStream(string fileName)
        {
            MemoryStream stream = new MemoryStream();
        tryagain:
            try
            {
                Bitmap image = new Bitmap(fileName);
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch
            {
                goto tryagain;
            }

            return stream.ToArray();
        }
        // get source img
        public string getPathImg()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png,jpg files |*.JPG;*.PNG";
            dialog.Title = "Chọn File Ảnh";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialog.FileName))
                {
                    return dialog.FileName;
                }
                else
                {
                    MessageBox.Show(dialog.FileName + " Không Tồn Tại");
                    return null;
                }
            }
            return null;
        }

        private void avatar_Click(object sender, EventArgs e)
        {
            string path = getPathImg();
            if (path != null) avatar.ImageLocation = path;
        }

        private void imgIdCardFront_Click(object sender, EventArgs e)
        {
            string path = getPathImg();
            if (path != null) imgIdCardFront.ImageLocation = path;
        }

        private void imgIdCardBack_Click(object sender, EventArgs e)
        {
            string path = getPathImg();
            if (path != null) imgIdCardBack.ImageLocation = path;
        }
        private void tableCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in tableCustomer.SelectedItems)
            {
                txtIdCard.Texts = item.SubItems[1].Text;
                txtName.Texts = item.SubItems[2].Text;
                txtDOB.Value = Convert.ToDateTime(item.SubItems[3].Text);
                txtSex.Texts = item.SubItems[4].Text;
                txtAddress.Texts = item.SubItems[5].Text;
                txtEmail.Texts = item.SubItems[6].Text;
                string sql = "select avatar,pic_front,pic_back from customer where id_card='" + item.SubItems[1].Text + "'"; 
                DataTable DT;
                MemoryStream stream;
                byte[] arr;
                Customer cm = new Customer();
                // avatar
                DT = connection.getDataTable(sql);
                arr = (byte[])DT.Rows[0]["avatar"];
                stream = new MemoryStream(arr);
                avatar.Image = Image.FromStream(stream);
                // front
                arr = (byte[])DT.Rows[0]["pic_front"];
                stream = new MemoryStream(arr);
                imgIdCardFront.Image = Image.FromStream(stream);
                // back
                arr = (byte[])DT.Rows[0]["pic_back"];
                stream = new MemoryStream(arr);
                imgIdCardBack.Image = Image.FromStream(stream);
            }
        }
        private void tableCustomer_MouseLeave(object sender, EventArgs e)
        {
            resetImg();
        }
        Customer cm = new Customer();
        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSearch.Texts, "[']"))
            {
                txtSearch.Texts = txtSearch.Texts.Remove(txtSearch.Texts.Length - 1);
            }
            switch (cboSearch.SelectedIndex)
            {
                case 0:
                    cm.showListView(tableCustomer, "select * from customer where id_card like N'" + txtSearch.Texts + "%'");
                    break;
                case 1:
                    cm.showListView(tableCustomer, "select * from customer where name_customer like N'" + txtSearch.Texts + "%'");
                    break;
                case 2:
                    cm.showListView(tableCustomer, "select * from customer where CAST(year(dob) as nvarchar) like N'" + txtSearch.Texts + "%'");
                    break;
                case 3:
                    cm.showListView(tableCustomer, "select * from customer where sex like N'" + txtSearch.Texts + "%'");
                    break;
                case 4:
                    cm.showListView(tableCustomer, "select * from customer where address like N'" + txtSearch.Texts + "%'");
                    break;
                case 5:
                    cm.showListView(tableCustomer, "select * from customer where email like N'" + txtSearch.Texts + "%'");
                    break;
            }
        }

        private void txtIdCard__TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtIdCard.Texts, "[^0-9]"))
            {
                this.Alert("Số CMND/CCCD Phải Là Số", FormAlert.enmType.Info);
                txtIdCard.Texts = txtIdCard.Texts.Remove(txtIdCard.Texts.Length - 1);
            }
        }
    }
}
