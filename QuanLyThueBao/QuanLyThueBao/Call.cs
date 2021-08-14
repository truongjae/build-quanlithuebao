using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace QuanLyThueBao
{
    class Call
    {
        private string phoneOut, phoneIn;
        private Connection connection = new Connection();
        public Call() { }
        public Call(string phoneOut)
        {
            this.phoneOut = phoneOut;
        }
        public Call(string phoneOut,string phoneIn) {
            this.phoneOut = phoneOut;
            this.phoneIn = phoneIn;
        }
        public bool checkPhone(Call call)
        {
            string sql = "SELECT * FROM phone where phone_number=N'" + call.phoneIn + "'";
            DataTable DT = connection.getDataTable(sql);
            return DT.Rows.Count > 0;
        }
        public bool checkSameNetwork(Call call)
        {
            string sql = "select * from phone p join phone pp on p.id_network = pp.id_network and p.phone_number =N'" + call.phoneOut + "' and pp.phone_number =N'" + call.phoneIn + "'";
            DataTable DT = connection.getDataTable(sql);
            // check cung nha mang hay khong
            return DT.Rows.Count > 0;
        }
        public string idNetwork(Call call)
        {
            string sql = "SELECT id_network from phone where phone_number =N'" + call.phoneOut + "'";
            DataTable DT = connection.getDataTable(sql);
            return DT.Rows[0]["id_network"].ToString();
        }
        public long priceCall(Call call)
        {
            string sql = "SELECT price_internal,price_foreign from network where id_network =N'" + call.idNetwork(call) + "'";
            DataTable DT = connection.getDataTable(sql);
            long priceInternal = Int64.Parse(DT.Rows[0]["price_internal"].ToString()); // check gia goi dien noi mang
            long priceForeign = Int64.Parse(DT.Rows[0]["price_foreign"].ToString()); // check gia goi dien ngoai mang
            if (checkSameNetwork(call)) return priceInternal;
            else return priceForeign;
        }
        

       public bool calling(Call call)
        {
            string sql = "SELECT * FROM phone where phone_number=N'" + call.phoneOut + "'";
            DataTable DT = connection.getDataTable(sql);
            long accountBalance = Int64.Parse(DT.Rows[0]["account_balance"].ToString()); // check tai khoan goc
            long accountPromotion = Int64.Parse(DT.Rows[0]["account_promotion"].ToString()); // check tai khoan goc
            long payment = Int64.Parse(DT.Rows[0]["payment"].ToString()); // check so tien thanh toan
            string type = DT.Rows[0]["type"].ToString(); // check loai thue bao
            //check off may
            bool checkOff = false;
            //network
            bool checkNetwork = call.checkSameNetwork(call);
            //price 
            long price = call.priceCall(call);
            if (type.Equals("Trả Trước"))
            {
                if (checkNetwork)
                {

                    if (accountBalance + accountPromotion >= price)
                    {
                        if (accountPromotion >= price) accountPromotion -= price;
                        else
                        {
                            accountBalance = accountBalance + accountPromotion - price;
                            accountPromotion = 0;
                        }
                    }
                    else checkOff = true;
                }
                else
                {
                    if (accountBalance >= price)
                        accountBalance -= price;
                    else checkOff = true;
                }
            }
            else
            {
                if (checkNetwork)
                    payment += price;
                else
                    payment += price;
            }
            sql += "UPDATE phone set account_balance=" + accountBalance + ", account_promotion=" +
                accountPromotion + ",payment=" + payment + ",expiration_date='" + DateTime.Now.AddDays(90).ToString("yyyy-MM-dd") + "' where phone_number=N'" + call.phoneOut + "'";
            connection.excute(sql);
            return checkOff;
        }


       public List<string> ListCall(Call call)
       {
           string tab = "";
           for (int i = 0; i < 10; i++)
           {
               tab += " ";
           }
           List<string> list = new List<string>();
           string sql = "select * from called where phone_out = N'" + this.phoneOut + "' or phone_in =N'" + this.phoneOut + "'";
           DataTable DT = connection.getDataTable(sql);
           if (DT.Rows.Count > 0)
           {
               foreach (DataRow item in DT.Rows)
               {
                   string info = "";
                   string phoneOut = item["phone_out"].ToString();
                   string phoneIn = item["phone_in"].ToString();
                   string timeStart = item["time_start"].ToString();
                   string timeFinish = item["time_finish"].ToString();
                   string status = item["status"].ToString();
                   /*if (phoneOut.Equals(this.phoneOut))
                       info = "Cuộc Gọi Đi => " + phoneIn + tab + timeStart + " -- " + timeFinish;
                   else
                       info = "Cuộc Gọi Đến " + phoneOut + " => Bạn" + tab + timeStart + " -- " + timeFinish;*/
                   if (phoneOut.Equals(this.phoneOut))
                       info = "Cuộc Gọi Đi => " + phoneIn + tab + timeStart + " -- " + timeFinish;
                   else if (phoneIn.Equals(this.phoneOut) && (status.Equals("0") || status.Equals("2")))
                       info = "Cuộc Gọi Nhỡ " + phoneOut + " => Bạn" + tab + timeStart;
                   else
                      info = "Cuộc Gọi Đến " + phoneOut + " => Bạn" + tab + timeStart + " -- " + timeFinish;
                   list.Add(info);
               }
               return list;
           }
           else return null;
       }


       public void callCancel(Call call)
       {
           string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
           string sql = "INSERT INTO called VALUES(N'" + call.phoneOut + "',N'" + call.phoneIn + "','" + time + "','" + time + "',0,N'0')";
           connection.excute(sql);
       }
       public int countCallCancel(Call call)
       {
           string sql = "select * from called where phone_in = N'" + call.phoneOut + "' and status = N'0'";
           DataTable DT = connection.getDataTable(sql);
           return DT.Rows.Count;
       }
       public void updateCallCancel(Call call)
       {
           string sql = "update called set status = N'2' where phone_in = N'" + call.phoneOut + "' and status='0'";
           connection.excute(sql);
       }




       /* public bool calling(Call call)
        {
            string sql = "SELECT * FROM phone where phone_number=N'" + call.phoneOut + "'";
            DataTable DT = connection.getDataTable(sql);
            string idNetworkPhoneOut = DT.Rows[0]["id_network"].ToString(); // check ma nha mang sdt hien tai
            long accountBalance = Int64.Parse(DT.Rows[0]["account_balance"].ToString()); // check tai khoan goc
            long accountPromotion = Int64.Parse(DT.Rows[0]["account_promotion"].ToString()); // check tai khoan goc
            long payment = Int64.Parse(DT.Rows[0]["payment"].ToString()); // check so tien thanh toan
            string type = DT.Rows[0]["type"].ToString(); // check loai thue bao
            sql = "SELECT price_internal,price_foreign from network where id_network =N'" + idNetworkPhoneOut + "'";
            DT = connection.getDataTable(sql);
            long priceInternal = Int64.Parse(DT.Rows[0]["price_internal"].ToString()); // check gia nhan tin noi mang
            long priceForeign = Int64.Parse(DT.Rows[0]["price_foreign"].ToString()); // check gia nhan tin ngoai mang

            sql = "select * from phone p join phone pp on p.id_network = pp.id_network and p.phone_number =N'" + call.phoneOut + "' and pp.phone_number =N'" + call.phoneIn + "'";
            DT = connection.getDataTable(sql);
            // check cung nha mang hay khong
            bool checkNetwork = DT.Rows.Count > 0;

            //check off may
            bool checkOff = false;



            if (type.Equals("Trả Trước"))
            {
                if (checkNetwork)
                {

                    if (accountBalance + accountPromotion >= priceInternal)
                    {
                        if (accountPromotion >= priceInternal) accountPromotion -= priceInternal;
                        else
                        {
                            accountBalance = accountBalance + accountPromotion - priceInternal;
                            accountPromotion = 0;
                        }
                    }
                    else checkOff = true;
                }
                else
                {
                    if (accountBalance >= priceForeign)
                        accountBalance -= priceForeign;
                    else checkOff = true;
                }
            }
            else
            {
                if (checkNetwork)
                    payment += priceInternal;
                else
                    payment += priceForeign;
            }
             sql += "UPDATE phone set account_balance=" + accountBalance + ", account_promotion=" +
                 accountPromotion + ",payment=" + payment + " where phone_number=N'" + call.phoneOut + "'";
             connection.excute(sql);
             return checkOff;
        }*/
        
    }
}
