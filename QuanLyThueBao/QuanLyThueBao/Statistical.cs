using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
namespace QuanLyThueBao
{
    class Statistical
    {
        private Connection connection = new Connection();
        public Statistical() { }
        public void showTop(ListView item)
        {
            string month = DateTime.Now.Month.ToString();
            string sql = "select top(5) phone_number,sum(payment) as price from spending group by(phone_number) having MONTH(GETDATE()) = '"+month+"' order by sum(payment) desc";
            item.Items.Clear();
            DataTable DT = connection.getDataTable(sql);
            int i = 0;
            foreach (DataRow row in DT.Rows)
            {
                string phoneNumber = row["phone_number"].ToString();
                string price = row["price"].ToString()+ " VNĐ";
                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(phoneNumber);
                item.Items[i].SubItems.Add(price);
                i++;
            }
        }
    }
}
