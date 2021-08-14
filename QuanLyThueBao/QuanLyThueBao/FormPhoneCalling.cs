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
    public partial class FormPhoneCalling : Form
    {
        private string myPhone;
        private string callTo;
        private Connection connection = new Connection();
        public FormPhoneCalling(string myPhone,string callTo)
        {
            InitializeComponent();
            this.myPhone = myPhone;
            this.callTo = callTo;
            timeCountSecond.Interval = 1000;
            timeCountSecond.Start();
            timeNow.Start();
            showInfo();
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        /// <summary>
        /// thanh toan
        /// </summary>

        int count = 0;
        string timeStart = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string timeFinish="";
        long minutes=0;
        long priceCall=0;
        private void timeCountSecond_Tick(object sender, EventArgs e)
        {
            int second, minute,hour;
            int s = count;
            hour = s / 3600;
            s = s % 3600;
            minute = s / 60;
            second = s % 60;

            string strH = "", strM = "", strS = "";
            if (hour < 10) strH = "0";
            if (minute < 10) strM = "0";
            if (second < 10) strS = "0";

            if(hour >0)
                lbMinute.Text = strH+hour+":"+ strM+minute + ":" + strS+second;
            else
                lbMinute.Text = strM + minute + ":" + strS + second;

            timeFinish = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            minutes = minute+1;
            if (count % 60 == 0)
            {
                Call call = new Call(this.myPhone, this.callTo);
                priceCall = call.priceCall(call);
                if (call.calling(call))
                {
                    string sql = "INSERT INTO called VALUES(N'" + this.myPhone + "',N'" + this.callTo + "','" + timeStart + "','" + timeFinish + "'," + minutes + ",N'1');";
                    sql += "INSERT INTO spending VALUES(N'" + this.myPhone + "'," + (priceCall * minutes) + ",'" + timeStart + "')";
                    connection.excute(sql);
                    timeCountSecond.Stop();
                    timeCountSecond.Dispose();
                    this.Alert("Hết Tiền", FormAlert.enmType.Error);
                    this.Close();
                }
            }
            count++;
        }

        private void timeNow_Tick(object sender, EventArgs e)
        {
            lbTimeNow.Text = DateTime.Now.ToString("HH:mm");
        }

        private void btnCallCancel_Click(object sender, EventArgs e)
        {
            timeCountSecond.Stop();
            timeCountSecond.Dispose();
            string sql = "INSERT INTO called VALUES(N'" + this.myPhone + "',N'" + this.callTo + "','" + timeStart + "','" + timeFinish + "'," + minutes + ",N'1');";
            sql += "INSERT INTO spending VALUES(N'" + this.myPhone + "'," + (priceCall*minutes) + ",'" + timeStart + "')";
            connection.excute(sql);
            this.Alert("Kết Thúc Cuộc Gọi", FormAlert.enmType.Success);
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
