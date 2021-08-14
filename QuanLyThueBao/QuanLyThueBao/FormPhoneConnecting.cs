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
    public partial class FormPhoneConnecting : Form
    {
        private string myPhone;
        private string callTo;
        private Connection connection = new Connection();
        public FormPhoneConnecting(string myPhone,string callTo)
        {
            InitializeComponent();
            this.myPhone = myPhone;
            this.callTo = callTo;
            timeNow.Start();
            timeLoading.Start();
            showInfo();
        }

        private void btnCallCancel_Click(object sender, EventArgs e)
        {
            timeShowCall.Stop();
            timeShowCall.Dispose();
            timeLoading.Stop();
            timeLoading.Stop();
            this.Close();
        }

        private void timeNow_Tick(object sender, EventArgs e)
        {
            lbTimeNow.Text = DateTime.Now.ToString("HH:mm");

        }
        //
        int count = 0;
        private void timeLoading_Tick(object sender, EventArgs e)
        {
            if (count >= 3)
            {
                lbMinute.Text = "Đang Gọi";
                count = 0;
            }
            lbMinute.Text+=".";
            count++;      
        }

        private void FormPhoneConnecting_Load(object sender, EventArgs e)
        {
            timeShowCall.Interval = 3000;
            timeShowCall.Start();
        }

        private void timeShowCall_Tick(object sender, EventArgs e)
        {

            timeShowCall.Stop();
            timeShowCall.Dispose();
            //this.Hide();
            FormPhoneIncoming fIncoming = new FormPhoneIncoming(this.myPhone,this.callTo);
            fIncoming.ShowDialog();
            this.Close();
        }
        public void showInfo()
        {
            DataTable DT = connection.getDataTable("select cs.name_customer,cs.avatar from phone p join customer cs on p.id_card = cs.id_card and p.phone_number =N'" + this.callTo + "'");
            //txtName.Text = "(" + DT.Rows[0]["name_customer"].ToString() + ")";
            txtName.Text = this.callTo;
            MemoryStream stream;
            byte[] arr;
            arr = (byte[])DT.Rows[0]["avatar"];
            stream = new MemoryStream(arr);
            picAvt.Image = Image.FromStream(stream);
        }
    }
}
