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
    public partial class FormShowListCall : Form
    {
        private string myPhone;
        public FormShowListCall(string myPhone)
        {
            InitializeComponent();
            this.myPhone = myPhone;
        }
        public void loadListCall()
        {
            Call call = new Call(this.myPhone);
            List<string> list = call.ListCall(call);
            ///
            for (int i = 0; i < 5; i++)
            {
                foreach (Control btns in flpanelListCall.Controls) // clear btn
                    if (btns.GetType() == typeof(Button))
                        flpanelListCall.Controls.Remove(btns);
                foreach (Control btns in flpanelListCall.Controls) // clear pic
                    if (btns.GetType() == typeof(RJCircularPictureBox))
                        flpanelListCall.Controls.Remove(btns);
                foreach (Control btns in flpanelListCall.Controls) // clear label
                    if (btns.GetType() == typeof(Label))
                        flpanelListCall.Controls.Remove(btns);
            }
            ///
            if (list != null)
            {
           
                //list.Reverse();
                foreach (string called in list)
                {
                    Button btn = new Button()
                    {
                        Width = flpanelListCall.Width + 25,
                        AutoSize = true,
                        Dock = DockStyle.None,
                    };
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    // btn.BackColor = Color.Orange;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Text = called;
                    if (called.Substring(0, 11).Equals("Cuộc Gọi Đi")) btn.BackColor = Color.Orange;
                    else if (called.Substring(0, 12).Equals("Cuộc Gọi Nhỡ")) btn.BackColor = Color.Tomato;
                    else btn.BackColor = Color.LightSkyBlue;
                    flpanelListCall.Controls.Add(btn);
                }
                // create btn write mess
                RJCircularPictureBox btnCall = new RJCircularPictureBox();
                btnCall.Size = new Size(63, 63);
                btnCall.Image = Properties.Resources.call;
                btnCall.SizeMode = PictureBoxSizeMode.CenterImage;
                btnCall.BorderSize = 3;
                btnCall.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                btnCall.Click += btn_Click;
                flpanelListCall.Controls.Add(btnCall);
                flpanelListCall.ScrollControlIntoView(btnCall);

            }
            else
            {
                
                Label lb = new Label()
                {
                    Width = flpanelListCall.Width,
                    Height = flpanelListCall.Height,
                    AutoSize = false,
                    Dock = DockStyle.None,
                };
                lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Text = "Xin Lỗi, Hiện Tại Bạn Chưa Có Cuộc Gọi";
                // create btn write mess
                RJCircularPictureBox btnCall = new RJCircularPictureBox();
                btnCall.Size = new Size(63, 63);
                btnCall.Image = Properties.Resources.call;
                btnCall.SizeMode = PictureBoxSizeMode.CenterImage;
                btnCall.BorderSize = 3;
                btnCall.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                btnCall.Click += btn_Click;
                flpanelListCall.Controls.Add(lb);
                flpanelListCall.Controls.Add(btnCall);     
            }

        }
        void btn_Click(object sender, EventArgs e)
        {
            FormSmartphone fSmartphone = new FormSmartphone(this.myPhone);
            fSmartphone.ShowDialog();
            FormShowListCall_Load(sender, e);
        }

        private void FormShowListCall_Load(object sender, EventArgs e)
        {
            loadListCall();
        }
    }
}
