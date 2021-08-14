using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace QuanLyThueBao
{
    public partial class FormPhoneIncoming : Form
    {
        private string myPhone;
        private string callTo;
        private Connection connection = new Connection();
        public FormPhoneIncoming(string myPhone,string callTo)
        {
            InitializeComponent();
            this.myPhone = myPhone;
            this.callTo = callTo;
            timeNow.Start();
            timeClose.Interval = 15000;
            timeClose.Start();
            showInfo();

        }
        private void timeNow_Tick(object sender, EventArgs e)
        {
            lbTimeNow.Text = DateTime.Now.ToString("HH:mm");
        }
        private void btnCallCancel_Click(object sender, EventArgs e)
        {
            timeClose.Stop();
            timeClose.Dispose();
            Call call = new Call(this.myPhone, this.callTo);
            call.callCancel(call);
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timeClose.Stop();
            timeClose.Dispose();
            FormPhoneCalling fCalling = new FormPhoneCalling(this.myPhone,this.callTo);
            this.Hide();
            fCalling.ShowDialog();
            this.Close();
        }

        private void timeClose_Tick(object sender, EventArgs e)
        {
            timeClose.Stop();
            timeClose.Dispose();
            Call call = new Call(this.myPhone, this.callTo);
            call.callCancel(call);
            this.Close();
        }
        public void showInfo()
        {
            DataTable DT = connection.getDataTable("select cs.name_customer,cs.avatar from phone p join customer cs on p.id_card = cs.id_card and p.phone_number =N'" + this.myPhone + "'");
            //txtName.Text = "(" + DT.Rows[0]["name_customer"].ToString() + ")";
            txtName.Text = this.myPhone;
            MemoryStream stream;
            byte[] arr;
            arr = (byte[])DT.Rows[0]["avatar"];
            stream = new MemoryStream(arr);
            picAvt.Image = Image.FromStream(stream);
        }

        private void FormPhoneIncoming_Load(object sender, EventArgs e)
        {
        }
    }
}
