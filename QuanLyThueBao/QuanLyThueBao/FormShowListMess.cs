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
    public partial class FormShowListMess : Form
    {
        private string myPhone;
        public FormShowListMess(string myPhone)
        {
            InitializeComponent();
            this.myPhone = myPhone;
            btnWriteMess.Image = Properties.Resources.write;
        }

        private void FormShowListMess_Load(object sender, EventArgs e)
        {
            loadListMess();
        }
        public void loadListMess()
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
            btnWriteMess.Hide();
            SendMess sm = new SendMess(this.myPhone);
            List<string> list = sm.ListMess(sm);

            
            if (list != null)
            {
                //list.Reverse();
                foreach (string mess in list)
                {
                    Button btn = new Button()
                    {
                        Width = flpanelListMess.Width + 25,
                        //Height = flpanelListMess.Height / 4,
                        AutoSize = true,
                        Dock = DockStyle.None,
                    };
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                   // btn.BackColor = Color.Orange;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Text = mess;
                    if (mess.Substring(0, 6).Equals("Từ Bạn")) btn.BackColor = Color.Orange;
                    else btn.BackColor = Color.Tomato;
                    flpanelListMess.Controls.Add(btn);
                }
                // create btn write mess
                RJCircularPictureBox btnWrite = new RJCircularPictureBox();
                btnWrite.Size = new Size(63, 63);
                btnWrite.Image = Properties.Resources.write;
                btnWrite.SizeMode = PictureBoxSizeMode.CenterImage;
                btnWrite.BorderSize = 3;
                btnWrite.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                btnWrite.Click += btn_Click;
                flpanelListMess.Controls.Add(btnWrite);
                flpanelListMess.ScrollControlIntoView(btnWrite);

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
                lb.Text = "Xin Lỗi, Hiện Tại Bạn Chưa Có Tin Nhắn";
                // create btn write mess
                RJCircularPictureBox btnWrite = new RJCircularPictureBox();
                btnWrite.Size = new Size(63, 63);
                btnWrite.Image = Properties.Resources.write;
                btnWrite.SizeMode = PictureBoxSizeMode.CenterImage;
                btnWrite.BorderSize = 3;
                btnWrite.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                btnWrite.Click += btn_Click;
                flpanelListMess.Controls.Add(lb);
                flpanelListMess.Controls.Add(btnWrite);
            }
           
        }
        void btn_Click(object sender, EventArgs e)
        {
            FormSendMess f = new FormSendMess(this.myPhone);
            f.ShowDialog();
            FormShowListMess_Load(sender, e);
        }

        private void btnWriteMess_Click(object sender, EventArgs e)
        {
            FormSendMess f = new FormSendMess(this.myPhone);
            f.ShowDialog();
            FormShowListMess_Load(sender, e);
        }
    }
}
