using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace QuanLyThueBao
{
    public partial class FormDialog : Form
    {
        private bool answer = false;
        private string ask;        
        public FormDialog(string ask)
        {
            InitializeComponent();
            SystemSounds.Exclamation.Play(); 
            this.ask = ask;
            lbAsk.Text = this.ask;
            this.ShowDialog();
        }
        public bool resultAns()
        {
            return this.answer;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.answer = true;
            resultAns();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.answer = false;
            resultAns();
            this.Close();
        }
    }
}
