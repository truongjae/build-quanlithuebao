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
    public partial class FormBocBatHo : Form
    {
        public FormBocBatHo()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/100053133309597");
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBocBatHo_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }




    }
}
