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
    public partial class FormShowListNotification : Form
    {
        private string myPhone;
        private Notification notification;

        public FormShowListNotification(string myPhone)
        {
            InitializeComponent();
            this.myPhone = myPhone;
            notification = new Notification(this.myPhone);
            loadListNotification();
        }
        public void loadListNotification()
        {
            for (int i = 0; i < 5; i++)
            {
                ///
                foreach (Control btns in flpanelListMess.Controls) // clear btn
                    if (btns.GetType() == typeof(Button))
                        flpanelListMess.Controls.Remove(btns);
                foreach (Control btns in flpanelListMess.Controls) // clear pic
                    if (btns.GetType() == typeof(RJCircularPictureBox))
                        flpanelListMess.Controls.Remove(btns);
                foreach (Control btns in flpanelListMess.Controls) // clear label
                    if (btns.GetType() == typeof(Label))
                        flpanelListMess.Controls.Remove(btns);
                ///
            }
            if (notification.checkBill(notification))
            {
                    Button btn = new Button()
                    {
                        Width = flpanelListMess.Width + 25,
                        AutoSize = true,
                        Dock = DockStyle.None,
                    };
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Text = "Bạn Có Hóa Đơn Cần Được Xử Lý";
                    btn.BackColor = Color.Gray;
                    btn.Click += btn_Click;
                    flpanelListMess.Controls.Add(btn);
            }
            else
            {
                Label lb = new Label()
                {
                    Width = flpanelListMess.Width,
                    Height = flpanelListMess.Height,
                    AutoSize = false,
                    Dock = DockStyle.None,
                };
                lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Text = "Xin Lỗi, Hiện Tại Bạn Chưa Có Thông Báo";
                flpanelListMess.Controls.Add(lb);
            }

        }
        void btn_Click(object sender, EventArgs e)
        {
            FormShowInfoBill formShowInfoBill = new FormShowInfoBill(this.myPhone);
            formShowInfoBill.ShowDialog();
            loadListNotification();
        }
    }
}
