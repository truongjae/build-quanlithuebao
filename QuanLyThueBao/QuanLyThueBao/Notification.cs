using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace QuanLyThueBao
{
    class Notification
    {
        private string myPhone;
        private Connection connection = new Connection();
        public Notification() { }
        public Notification(string myPhone)
        {
            this.myPhone = myPhone;
        }
        public bool checkBill(Notification notification){
            string sql = "select * from bill where phone_number = N'"+notification.myPhone+"' and status = '0'";
            DataTable DT = connection.getDataTable(sql);
            return DT.Rows.Count >0;
        }
        public void updateBill(Notification notification)
        {
            string sql = "update bill set status='1' where phone_number = N'" + notification.myPhone + "'";
            connection.excute(sql);
        }
    }
}
