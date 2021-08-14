using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace QuanLyThueBao
{
    class SendMess
    {
        private string phoneOut, phoneIn, content;
        private Connection connection = new Connection();
        public SendMess() { }
        public SendMess(string phoneOut)
        {
            this.phoneOut = phoneOut;
        }

        public SendMess(string phoneOut,string phoneIn,string content)
        {
            this.phoneOut = phoneOut;
            this.phoneIn = phoneIn;
            this.content = content;
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        public bool checkPhone(SendMess sendMess)
        {
            string sql = "SELECT * FROM phone where phone_number=N'" + sendMess.phoneIn +"'";
            DataTable DT = connection.getDataTable(sql);
            return DT.Rows.Count > 0;
        }
        public void sendMess(SendMess sendMess)
        {
            string sql = "SELECT * FROM phone where phone_number=N'" + sendMess.phoneOut + "'";
            DataTable DT = connection.getDataTable(sql);
            string idNetworkPhoneOut = DT.Rows[0]["id_network"].ToString(); // check ma nha mang sdt hien tai
            long accountBalance = Int64.Parse(DT.Rows[0]["account_balance"].ToString()); // check tai khoan goc
            long accountPromotion = Int64.Parse(DT.Rows[0]["account_promotion"].ToString()); // check tai khoan goc
            long payment = Int64.Parse(DT.Rows[0]["payment"].ToString()); // check so tien thanh toan
            string type = DT.Rows[0]["type"].ToString(); // check loai thue bao
            sql = "SELECT mess_internal,mess_foreign from network where id_network =N'" + idNetworkPhoneOut + "'";
            DT = connection.getDataTable(sql);
            long messInternal = Int64.Parse(DT.Rows[0]["mess_internal"].ToString()); // check gia nhan tin noi mang
            long messForeign = Int64.Parse(DT.Rows[0]["mess_foreign"].ToString()); // check gia nhan tin ngoai mang

            sql = "select * from phone p join phone pp on p.id_network = pp.id_network and p.phone_number =N'"+sendMess.phoneOut+"' and pp.phone_number =N'"+sendMess.phoneIn+"'";
            DT = connection.getDataTable(sql);
            // check cung nha mang hay khong
            bool checkNetwork = DT.Rows.Count > 0;

            //so tien phai tra
            long price = 0;

            if (type.Equals("Trả Trước"))
            {
                if (checkNetwork)
                {
                    price = messInternal;
                    if (accountBalance + accountPromotion >= messInternal)
                    {
                        if (accountPromotion >= messInternal) accountPromotion -= messInternal;
                        else
                        {
                            accountBalance = accountBalance + accountPromotion - messInternal;
                            accountPromotion = 0;
                        }
                        this.Alert("Gửi Thành Công", FormAlert.enmType.Success);
                    }
                    else this.Alert("Tài Khoản Của Bạn Không Đủ", FormAlert.enmType.Error);
                }
                else
                {
                    price = messForeign;
                    if (accountBalance >= messForeign)
                    {
                        accountBalance -= messForeign;
                        this.Alert("Gửi Thành Công", FormAlert.enmType.Success);
                    }
                    else this.Alert("Tài Khoản Của Bạn Không Đủ", FormAlert.enmType.Error);
                }
            }
            else
            {
                if (checkNetwork)
                {
                    payment += messInternal;
                    price = messInternal;
                }
                else
                {
                    payment += messForeign;
                    price = messForeign;
                }
                this.Alert("Gửi Thành Công", FormAlert.enmType.Success);
            }

            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            sql = "INSERT INTO sended VALUES(N'" + sendMess.phoneOut + "',N'" + sendMess.phoneIn + "', N'" + sendMess.content + "','" + time + "',N'0');";
            sql += "UPDATE phone set account_balance=" + accountBalance + ", account_promotion=" +
                accountPromotion+",payment="+payment+",expiration_date='"+DateTime.Now.AddDays(90).ToString("yyyy-MM-dd")+"' where phone_number=N'"+sendMess.phoneOut+"';";
            sql += "INSERT INTO spending VALUES(N'" + phoneOut + "'," + price + ",'" + time + "')";
            connection.excute(sql);
        }
        public List<string> ListMess(SendMess sendMess)
        {
            string tab = "";
            for (int i = 0; i < 10; i++)
            {
                tab += " ";
            }
            List<string> list = new List<string>();
            string sql = "select * from sended where phone_out = N'" + this.phoneOut + "' or phone_in =N'"+this.phoneOut+"' order by(time_send)";
            DataTable DT = connection.getDataTable(sql);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow item in DT.Rows)
                {
                    string info = "";
                    string time = Convert.ToDateTime(item["time_send"].ToString()).ToString("dd-MM-yyyy HH:mm:ss");
                    string phoneOut = item["phone_out"].ToString();
                    string phoneIn = item["phone_in"].ToString();
                    string content = item["contents"].ToString();
                    content = endLineString(content,20);
                    if (phoneOut.Equals(this.phoneOut))
                        info = "Từ Bạn Gửi Đến " + phoneIn + "\nNội Dung: " + content + "\nThời Gian: " + time;
                    else
                        info = "Từ " + phoneOut + " Gửi Đến Bạn" + "\nNội Dung: " + content + "\nThời Gian: " + time;
                    list.Add(info);
                }
                return list;
            }
            else return null;
        }
        public string endLineString(string str,int countText)
        {
            int j = 0;
            int i = 0;
            foreach (char x in str)
            {

                if (x == ' ')
                {
                    j++;
                    if (j % countText == 0)
                    {
                        str = ReplaceAt(str, i, '\n');
                    }
                }
                i++;
            }
            return str;
        }
        public static string ReplaceAt(string value, int index, char newchar)
        {
            if (value.Length <= index)
                return value;
            else
                return string.Concat(value.Select((c, i) => i == index ? newchar : c));
        }
        public int countMessUnread(SendMess sendMess)
        {
            string sql = "select * from sended where phone_in = N'" + sendMess.phoneOut + "' and status = N'0'";
            DataTable DT = connection.getDataTable(sql);
            return DT.Rows.Count;
        }
        public void updateMessReaded(SendMess sendMess)
        {
            string sql = "update sended set status = N'1' where phone_in = N'" + sendMess.phoneOut + "'";
            connection.excute(sql);
        }
    }
}
