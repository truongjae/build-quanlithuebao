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
    public partial class FormShowListService : Form
    {
        private string username;
        private int type;
        public FormShowListService(string username,int type)
        {
            InitializeComponent();
            this.username = username;
            this.type = type;
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        private void FormShowListService_Load(object sender, EventArgs e)
        {
            if (type == 1) loadListService();
            else loadListServiceReged();
        }
        
        private void loadListService()
        {
            ListService lsv = new ListService();
            List<ListService> list = lsv.getListService(this.username);
            if (list != null)
            {
                foreach (ListService l in list)
                {
                    FlowLayoutPanel pn = new FlowLayoutPanel() { Width = flpanelListSv.Width / 4 - 6, Height = flpanelListSv.Height / 2 };
                    Button btn = new Button()
                    {
                        Width = pn.Width-5,
                        Height = pn.Height-45,
                        AutoSize = false,
                        Dock = DockStyle.None,
                    };
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //btn.BackColor = Color.Orange;
                    Random r = new Random();
                    btn.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 120);
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    //btn.Click += btn_Click;
                    //btn.Name = l.IdService;
                    btn.FlatAppearance.BorderSize = 0;
                    string str = "Mã Dịch Vụ: {0}\nTên Dịch Vụ: {1}\nChi Tiết Gói: {2}\nGiá: {3} VNĐ\nKhuyến Mãi: {4}%\nHạn Sử Dụng: {5} Ngày";
                    str = string.Format(str, l.IdService, l.NameService, l.Info, l.Price, l.Promotion, l.ExpDate);
                    btn.Text = str;//l.IdService+"\n"+l.NameService+"\n"+l.Info+"\n"+l.Price+"\n"+l.Promotion+"\n"+l.ExpDate;
                    // btn dang ki

                    // btn dang ki dich vu
                    Button btnReg = new Button()
                    {
                        Width = pn.Width -5,
                        Height = 40,
                        AutoSize = false,
                        Dock = DockStyle.None,
                    };
                    btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnReg.ForeColor = Color.White;
                   // btnReg.BackColor = Color.YellowGreen;
                    btnReg.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 150);
                    btnReg.FlatStyle = FlatStyle.Flat;
                    btnReg.FlatAppearance.BorderSize = 0;
                    btnReg.Text = "Đăng Ký";
                    btnReg.Click += btn_Click;
                    btnReg.Name = l.IdService;
                    pn.Controls.Add(btn);
                    pn.Controls.Add(btnReg);
                    flpanelListSv.Controls.Add(pn);

                }

            }
            else
            {
                Label lb = new Label()
                {
                    Width = flpanelListSv.Width,
                    Height = flpanelListSv.Height,
                    AutoSize = false,
                    Dock = DockStyle.None,
                };
                lb.Font= new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Text = "Xin Lỗi, Hiện Tại Nhà Mạng Của Bạn Chưa Cung Cấp Dịch Vụ Nào";
                flpanelListSv.Controls.Add(lb);
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            string id = (sender as Button).Name;
            regService(id);
        }
        void regService(string id)
        {
            bool result = new FormDialog("Bạn Muốn Đăng Ký Dịch Vụ Này?").resultAns();
            if (result)
            {
                Notification notification = new Notification(this.username);
                if (notification.checkBill(notification))
                    this.Alert("Thuê Bao Của Bạn Đã Bị Chưa Thanh Toán\nHóa Đơn Vui Lòng Thanh Toán\nĐể Sử Dụng Tiếp Dịch Vụ", FormAlert.enmType.Warning);
                else
                {
                    Recharge rec = new Recharge(this.username);
                    if (rec.checkStatus())
                    {
                        ListService lsv = new ListService();
                        lsv.regService(this.username, id);
                    }
                    else this.Alert("Thuê Bao Của Bạn Đã Bị\nChặn 1 Chiều Vui Lòng Liên Hệ\nHỗ Trợ Viên Để Mở Khóa", FormAlert.enmType.Error); 
                }
            }   
        }
        // show danh sach dich vu da dang ki
        private void loadListServiceReged()
        {
            ListService lsv = new ListService();
            List<ListService> list = lsv.getListServiceReged(this.username);
            if (list != null)
            {
                foreach (ListService l in list)
                {
                    FlowLayoutPanel pn = new FlowLayoutPanel() { Width = flpanelListSv.Width / 4 - 6, Height = flpanelListSv.Height / 2 };
                    // btn thong tin
                    Button btn = new Button()
                    {
                        Width = pn.Width-5,
                        Height = pn.Height-45,
                        AutoSize = false,
                        Dock = DockStyle.None,
                    };
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.ForeColor = Color.White;
                    //btn.BackColor = Color.Orange;
                    Random r = new Random();
                    btn.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 120);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    string str = "Mã Dịch Vụ: {0}\nTên Dịch Vụ: {1}\nChi Tiết Gói: {2}\nGiá: {3} VNĐ\nKhuyến Mãi: {4}%\nHSD: {5}";
                    string dateExp = Convert.ToDateTime(l.DateExp).ToString("dd/MM/yyyy");
                    str = string.Format(str, l.IdService, l.NameService, l.Info, l.Price, l.Promotion, dateExp);
                    btn.Text = str;

                    // btn huy dich vu
                    Button btnCancel = new Button()
                    {
                        Width = pn.Width-5,
                        Height = 40,
                        AutoSize = false,
                        Dock = DockStyle.None,
                    };
                    btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnCancel.ForeColor = Color.White;
                    btnCancel.BackColor = Color.Tomato;
                    btnCancel.FlatStyle = FlatStyle.Flat;
                    btnCancel.FlatAppearance.BorderSize = 0;
                    btnCancel.Text = "Hủy";
                    btnCancel.Click += btn_Click2;
                    btnCancel.Name = l.IdService;
                    pn.Controls.Add(btn);
                    pn.Controls.Add(btnCancel);
                    pn.Name = "pnSV" + l.IdService;
                    flpanelListSv.Controls.Add(pn);
                }

            }
            else
            {
                Label lb = new Label()
                {
                    Width = flpanelListSv.Width,
                    Height = flpanelListSv.Height,
                    AutoSize = false,
                    Dock = DockStyle.None,
                };
                lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Text = "Xin Lỗi, Hiện Tại Bạn Chưa Đăng Ký Dịch Vụ Nào";
                flpanelListSv.Controls.Add(lb);
            }
        }
        void btn_Click2(object sender, EventArgs e)
        {
            string id = (sender as Button).Name;
            serviceReged(id);
        }
        void serviceReged(string id)
        {
            bool result = new FormDialog("Bạn Có Muốn Hủy Dịch Vụ Này Không").resultAns();
            if (result)
            {
                ListService lsv = new ListService();
                lsv.cancelService(this.username, id);
                foreach (Control pns in flpanelListSv.Controls)
                {
                    if (pns.GetType() == typeof(FlowLayoutPanel))
                    {
                        FlowLayoutPanel pn = (FlowLayoutPanel)pns;
                        if (pn.Name.ToString().Equals("pnSV"+id))
                        {
                            pn.Hide();
                        }
                    }
                }
            }
        }

    }
}
