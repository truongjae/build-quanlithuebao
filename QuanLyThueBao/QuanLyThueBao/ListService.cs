using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThueBao
{
    class ListService
    {
        private string idService, nameService, price, promotion, expDate, info, dateExp;

        public string DateExp
        {
            get { return dateExp; }
            set { dateExp = value; }
        }

        public string Info
        {
            get { return info; }
            set { info = value; }
        }

        public string ExpDate
        {
            get { return expDate; }
            set { expDate = value; }
        }

        public string Promotion
        {
            get { return promotion; }
            set { promotion = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public string NameService
        {
            get { return nameService; }
            set { nameService = value; }
        }

        public string IdService
        {
            get { return idService; }
            set { idService = value; }
        }
        private Connection connection = new Connection();
        public ListService() { }
        public ListService(string idService,string nameService,string price,string promotion,string expDate,string info)
        {
            this.idService = idService;
            this.nameService = nameService;
            this.price = price;
            this.promotion = promotion;
            this.expDate = expDate;
            this.info = info;
        }
        public ListService(string idService, string nameService, string price, string promotion, string expDate, string info,string dateExp)
        {
            this.idService = idService;
            this.nameService = nameService;
            this.price = price;
            this.promotion = promotion;
            this.expDate = expDate;
            this.info = info;
            this.dateExp = dateExp;
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        // get danh sach cac dich vu trong db
        public List<ListService> getListService(string username)
        {
            List<ListService> list = new List<ListService>();
            
            string sql = "select sv.* from service sv join phone p on p.id_network = sv.id_network and p.phone_number = N'"+username+"'";
            DataTable DT = connection.getDataTable(sql);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    string idService = row["id_service"].ToString();
                    string nameService = row["name_service"].ToString();
                    string price = row["price_service"].ToString();
                    string promotion = row["promotion"].ToString();
                    string expDate = row["exp_date"].ToString();
                    string info = row["info"].ToString();
                    ListService lsv = new ListService(idService, nameService, price, promotion, expDate, info);
                    list.Add(lsv);
                }
                return list;
            }
            else return null;
        }
        // dang ki dich vu moi
        public void regService(string username,string idService)
        {
            long balance = 0;
            long price = 0;
            int promotion = 0;
            int exp_date = 0;
            string type = "";
            // check gia tien dich vu
            string sql = "select sv.* from service sv join phone p on p.id_network = sv.id_network and p.phone_number = N'" + username + "' and id_service=N'"+idService+"'";
            DataTable DT = connection.getDataTable(sql);
            price = Int64.Parse(DT.Rows[0]["price_service"].ToString());
            promotion = Int32.Parse(DT.Rows[0]["promotion"].ToString());
            exp_date = Int32.Parse(DT.Rows[0]["exp_date"].ToString());
            // check loai thue bao
            sql = "select * from phone where phone_number = N'" + username + "'";
            DT = connection.getDataTable(sql);
            type = DT.Rows[0]["type"].ToString();
            if (checkReged(username, idService))
            {
                this.Alert("Bạn Không Thể Đăng Ký,\nVì Bạn Đang Sử Dụng Dịch Vụ Này", FormAlert.enmType.Error);
            }
            else
            {
                price = (int)(price - price * (float)promotion / 100);//
                DateTime date_exp = DateTime.Now.AddDays(exp_date);
                if (type.Equals("Trả Trước"))
                {
                    balance = Int64.Parse(DT.Rows[0]["account_balance"].ToString());
                    if (balance < price) this.Alert("Tài Khoản Của Bạn Không Đủ", FormAlert.enmType.Info);
                    else
                    {
                        sql = "UPDATE phone set account_balance = account_balance-" + price
                            + ", expiration_date='"+DateTime.Now.AddDays(90).ToString("yyyy-MM-dd")+"' where phone_number=N'" + username + "';";
                        sql += "INSERT INTO reg_service VALUES(N'" + username + "',N'" + idService + "',N'"+date_exp.ToString("yyyy-MM-dd")+"');";
                        sql += "INSERT INTO spending VALUES(N'" + username + "'," + price + ",'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                        connection.excute(sql);
                        this.Alert("Đăng Ký Dịch Vụ Thành Công", FormAlert.enmType.Success);
                    }
                }
                else
                {
                    balance = Int64.Parse(DT.Rows[0]["payment"].ToString());
                    sql = "UPDATE phone set payment = payment+" + price 
                        + ", expiration_date='" + DateTime.Now.AddDays(90).ToString("yyyy-MM-dd") + "' where phone_number=N'" + username + "';";
                    sql += "INSERT INTO reg_service VALUES(N'" + username + "',N'" + idService + "',N'" + date_exp.ToString("yyyy-MM-dd") + "');";
                    sql += "INSERT INTO spending VALUES(N'" + username + "'," + price + ",'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                    connection.excute(sql);
                    this.Alert("Đăng Ký Dịch Vụ Thành Công", FormAlert.enmType.Success);
                }
            }
        }



        // kiem tra xem da dang ki dich vu chua
        public bool checkReged(string username, string idService)
        {
            string sql = "select * from reg_service where phone_number = N'"+username+"' and id_service =N'"+idService+"'";
            DataTable DT = connection.getDataTable(sql);
            return DT.Rows.Count > 0;
        }

        // get danh sach dich vu da dang ki
        public List<ListService> getListServiceReged(string username)
        {
            List<ListService> list = new List<ListService>();

            string sql = "select * from service sv join reg_service regsv on sv.id_service = regsv.id_service and regsv.phone_number = N'" + username + "'";
            DataTable DT = connection.getDataTable(sql);
            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    string idService = row["id_service"].ToString();
                    string nameService = row["name_service"].ToString();
                    string price = row["price_service"].ToString();
                    string promotion = row["promotion"].ToString();
                    string expDate = row["exp_date"].ToString();
                    string info = row["info"].ToString();
                    string dateExp = row["date_exp"].ToString();
                    ListService lsv = new ListService(idService, nameService, price, promotion, expDate, info,dateExp);
                    list.Add(lsv);
                }
                return list;
            }
            else return null;
        }

        // huy dich vu
        public void cancelService(string username, string idService)
        {   
            string sql = "DELETE reg_service where phone_number=N'" + username + "' and id_service =N'"+idService+"'";
            connection.excute(sql);
            this.Alert("Hủy Dịch Vụ Thành Công", FormAlert.enmType.Success);  
        }

        // auto gia han
        public void autoCancelService()
        {
            string dateNow = DateTime.Now.ToString("yyyy-MM-dd");
            string sql = "DELETE reg_service where date_exp <='" + dateNow + "'";
            connection.excute(sql);
        }

    }
}
