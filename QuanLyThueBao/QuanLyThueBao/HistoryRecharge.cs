using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace QuanLyThueBao
{
    class HistoryRecharge
    {
        private string phone;
        private Connection connection = new Connection();
        public HistoryRecharge() { }
        public HistoryRecharge(string phone)
        {
            this.phone = phone;
        }
        
        public List<string> ListRecharge()
        {
            string tab = "";
            for (int i = 0; i < 10; i++)
            {
                tab += " ";
            }
            List<string> list = new List<string>();
            string sql = "select * from history_recharge where phone_number = N'" + this.phone + "'";
            DataTable DT = connection.getDataTable(sql);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow item in DT.Rows)
                {
                    string time = Convert.ToDateTime(item["time"].ToString()).ToString("dd-MM-yyyy HH:mm:ss");
                    string code = item["code"].ToString();
                    string price = item["price"].ToString();
                    string promotion = item["promotion"].ToString();
                    string info = "Thời Gian: " + time + tab + "Mã Thẻ: " + code + tab + "TK +" + price + " VNĐ"+tab+"KM +"+promotion+" VNĐ";
                    list.Add(info);
                }
                return list;
            }
            else return null;
        }
    }
}
