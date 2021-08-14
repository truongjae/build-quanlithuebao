using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLyThueBao
{
    class Phone
    {
        private string phoneNumber,idCard,idNetwork, idRegion, type, actDate, expDate,status;
        private long accountBalance, promotion, payment;
        private Connection connection = new Connection();
        private MD5Security md5 = new MD5Security();
        public Phone() { }
        public Phone(string phoneNumber,string idCard, string idNetwork, string idRegion, string type, 
            string actDate, string expDate,long accountBalance,long promotion,long payment,string status)
        {
            this.phoneNumber = phoneNumber;
            this.idCard = idCard;
            this.idNetwork = idNetwork;
            this.idRegion = idRegion;
            this.type = type;
            this.actDate = actDate;
            this.expDate = expDate;
            this.accountBalance = accountBalance;
            this.promotion = promotion;
            this.payment = payment;
            this.status = status;
        }
        public void showListView(ListView item, string sql)
        {
            item.Items.Clear();
            DataTable DT = connection.getDataTable(sql);
            int i = 0;
            foreach (DataRow row in DT.Rows)
            {
                string phoneNumber = row["phone_number"].ToString();
                string idCard = row["id_card"].ToString();
                string idNetwork = row["id_network"].ToString();
                string idRegion = row["id_region"].ToString();
                string type = row["type"].ToString();
                string actDate = Convert.ToDateTime(row["activation_date"].ToString()).ToString("dd-MM-yyyy");
                string expDate = Convert.ToDateTime(row["expiration_date"].ToString()).ToString("dd-MM-yyyy");
                string accountBalance = row["account_balance"].ToString();
                string promotion = row["account_promotion"].ToString();
                string payment = row["payment"].ToString();
                string status = row["status"].ToString();
                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(phoneNumber);
                item.Items[i].SubItems.Add(idCard);
                item.Items[i].SubItems.Add(idNetwork);
                item.Items[i].SubItems.Add(idRegion);
                item.Items[i].SubItems.Add(type);
                item.Items[i].SubItems.Add(actDate);
                item.Items[i].SubItems.Add(expDate);
                item.Items[i].SubItems.Add(accountBalance);
                item.Items[i].SubItems.Add(promotion);
                item.Items[i].SubItems.Add(payment);
                item.Items[i].SubItems.Add(status);

                i++;
            }
        }
        public void insert(Phone ph)
        {

            string pwEncode = md5.Encode(ph.idCard);
            string sql = "INSERT INTO phone VALUES(N'" + ph.phoneNumber + "',N'" + ph.idNetwork + "','" + ph.actDate+ "','" + ph.expDate + "'" + ",'" + ph.idRegion+ "',"+
                ph.accountBalance+","+ph.payment+",N'"+ph.type+"',"+ph.promotion+",'"+ph.idCard+"',N'"+ph.status+"');";
            //sql += "INSERT INTO account VALUES('" + ph.phoneNumber + "','" + ph.idCard + "','0')";
            sql += "INSERT INTO account VALUES('" + ph.phoneNumber + "','" + pwEncode + "','0')";
            connection.excute(sql);
        }
        public void update(Phone ph)
        {
            string pwEncode = md5.Encode(ph.idCard);
            string sql = "UPDATE phone set id_network=N'" + ph.idNetwork + "',id_card ='"+ph.idCard+"',id_region='" + ph.idRegion + "',type=N'" + ph.type + "',activation_date='" + ph.actDate
                + "',expiration_date='" + ph.expDate + "',account_balance=" + ph.accountBalance + ",account_promotion="
                + ph.promotion + ",payment=" + ph.payment + ",status=N'"+ph.status+"' where phone_number=N'" + ph.phoneNumber + "';";
            //sql += "UPDATE account set password='" + ph.idCard+ "' where username='"+ph.phoneNumber+"'";
            //sql += "UPDATE account set password=N'" + pwEncode + "' where username=N'" + ph.phoneNumber + "'";
            connection.excute(sql);
        }
        public void delete(Phone ph)
        {
            string sql = "DELETE FROM phone where phone_number=N'" + ph.phoneNumber + "';";
            sql += "DELETE FROM account where username =N'" + ph.phoneNumber + "';";
            sql += "DELETE FROM sended where phone_out =N'" + ph.phoneNumber + "' or phone_out =N'" + ph.phoneNumber + "';";
            sql += "DELETE FROM called where phone_out =N'" + ph.phoneNumber + "' or phone_out =N'" + ph.phoneNumber + "';";
            sql += "DELETE FROM reg_service where phone_number=N'" + ph.phoneNumber + "';";
            sql += "DELETE FROM spending where phone_number=N'" + ph.phoneNumber + "';";
            sql += "DELETE FROM history_recharge where phone_number=N'" + ph.phoneNumber + "'";
            connection.excute(sql);
        }
        public void deleteAll()
        {
            string sql = "DELETE FROM phone;DELETE FROM account where permission=N'0';";
            sql += "DELETE FROM sended;";
            sql += "DELETE FROM called;";
            sql += "DELETE FROM reg_service;";
            sql += "DELETE FROM spending;";
            sql += "DELETE FROM history_recharge;";
            connection.excute(sql);
        }
        public bool checkKey(string key)
        {
            string sql = "SELECT phone_number FROM phone";
            DataTable DT = connection.getDataTable(sql);
            foreach (DataRow row in DT.Rows)
            {
                string idRe = row["phone_number"].ToString();
                if (String.Compare(idRe.Trim(), key.Trim(), true) == 0)
                {
                    return true;
                }
            }
            return false;
        }
       public bool checkMaxReg(string card,string netWork)
        {
            long maxReg=0, valueReg=0;
            string sql = "select count(id_card) as countIdCard from phone where id_card ='" + card + "' and id_network='" + netWork + "'";
            DataTable DT = connection.getDataTable(sql);
           //get valuereg
            foreach (DataRow row in DT.Rows)
            {
                valueReg = Int64.Parse(row["countIdCard"].ToString());
                break;
            }
           //get maxreg
            sql = "select max_reg from network where id_network ='" + netWork + "'";
            DT = connection.getDataTable(sql);
            foreach (DataRow row in DT.Rows)
            {
                maxReg = Int64.Parse(row["max_reg"].ToString());
                break;
            }
            if (valueReg >= maxReg)
            {
                return true;
            }
            return false;
        }
       public bool checkIdCard(string card) {
           string sql = "select id_card from customer";
           DataTable DT = connection.getDataTable(sql);
           foreach (DataRow row in DT.Rows)
           {
               string checkIdCard = row["id_card"].ToString();
               if (String.Compare(checkIdCard.Trim(), card.Trim(), true) == 0) return true;  
           }
           return false;
       }
       public void autoDeletePhone()
       {
           string dateNow = DateTime.Now.ToString("yyyy-MM-dd");
           string sql = "select * from phone where expiration_date <='" + dateNow + "'";
           DataTable DT = connection.getDataTable(sql);
           List<string> listPhone = new List<string>();
               foreach (DataRow row in DT.Rows)
               {
                   string phone = row["phone_number"].ToString();
                   listPhone.Add(phone);
               }
               if (listPhone.Count > 0)
               {
                   foreach (string item in listPhone)
                   {
                       string str = "DELETE phone where phone_number=N'" + item + "';";
                       str += "DELETE account where username=N'" + item + "'";
                       connection.excute(str);
                   }
               }
       }
    }
}
