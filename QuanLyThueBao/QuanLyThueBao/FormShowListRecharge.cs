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
    public partial class FormShowListRecharge : Form
    {
        private string username;
        public FormShowListRecharge(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void FormShowListRecharge_Load(object sender, EventArgs e)
        {
            loadHistoryRecharge();
        }
        private void loadHistoryRecharge()
        {
            HistoryRecharge hisRec = new HistoryRecharge(this.username);
            List<string> list = hisRec.ListRecharge();
            if (list != null)
            {
                list.Reverse();
                foreach (string info in list)
                {
                    Button btn = new Button()
                    {
                        Width = flpanelListRec.Width+25,
                        Height = flpanelListRec.Height /6,
                        AutoSize = false,
                        Dock = DockStyle.None,
                    };
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.BackColor = Color.Orange;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Text = info;
                    flpanelListRec.Controls.Add(btn);

                }

            }
            else
            {
                Label lb = new Label()
                {
                    Width = flpanelListRec.Width,
                    Height = flpanelListRec.Height,
                    AutoSize = false,
                    Dock = DockStyle.None,
                };
                lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.Text = "Xin Lỗi, Hiện Tại Bạn Chưa Nạp Thẻ";
                flpanelListRec.Controls.Add(lb);
            }
        }
    }
}
