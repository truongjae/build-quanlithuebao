using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyThueBao
{
    class Recharge
    {
        private string username, network,code;
        private Connection connection = new Connection();
        public Recharge() { }
        public Recharge(string username)
        {
            this.username = username;
        }
        public Recharge(string username,string code)
        {
            this.username = username;
            this.code = code;
        }
        public bool countCard(){
            string sql = "select * from phone where phone_number = N'" + this.username + "'";
            DataTable DT = connection.getDataTable(sql);
            this.network = DT.Rows[0]["id_network"].ToString();
            sql = "select * from card where id_network =N'" + this.network + "'";
            DT = connection.getDataTable(sql);
            return DT.Rows.Count > 0;
        }
        public bool acceptRecharge()
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //
            string sql = "select * from card where code= N'" + this.code + "' and id_network=N'"+this.network+"'";
            DataTable DT = connection.getDataTable(sql);
                if (DT.Rows.Count > 0)
                {
                    int price = Int32.Parse(DT.Rows[0]["price"].ToString());
                    int promotion = Int32.Parse(DT.Rows[0]["promotion"].ToString());
                    int bonus = (int)(price * (float)promotion / 100);
                    sql = "update phone set account_balance=account_balance+" +
                        price + ", account_promotion =account_promotion+" + bonus +
                        ",expiration_date='" + DateTime.Now.AddDays(90).ToString("yyyy-MM-dd") + "' where phone_number=N'" + this.username + "';";
                    sql += "delete from card where code =N'" + this.code + "' and id_network=N'" + this.network + "';";
                    sql += "delete from history_recharge where phone_number=N'" + this.username + "' and status=N'0';";
                    sql += "insert into history_recharge values(N'" + this.username + "',N'" + this.code + "',N'1'," + price + "," + bonus + ",'" + time + "')";
                    connection.excute(sql);
                    return true;
                }
                else
                {
                    sql = "insert into history_recharge values(N'" + this.username + "',N'" + this.code + "',N'0',0,0,'"+time+"')";
                    connection.excute(sql);
                    sql = "select count(phone_number) as fail from history_recharge where phone_number =N'" + this.username + "' and status =N'0'";
                    DT = connection.getDataTable(sql);
                    int fail = Int32.Parse(DT.Rows[0]["fail"].ToString());
                    if (fail >= 5)
                    {
                        sql = "update phone set status=N'0' where phone_number=N'" + this.username + "'";
                        connection.excute(sql);
                    }
                    return false;
                }
        }
        public bool checkStatus()
        {
            string sql = "select * from phone where phone_number =N'" + this.username + "' and status=N'1'";
            DataTable DT = connection.getDataTable(sql);
            return DT.Rows.Count > 0;
        }
    }
}
