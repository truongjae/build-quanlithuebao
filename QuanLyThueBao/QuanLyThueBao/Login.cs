using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyThueBao
{

    class Login
    {
        private string username, password;
        private Connection connection = new Connection();
        private MD5Security md5 = new MD5Security();
        public Login() { }
        public Login(string username,string password)
        {
            this.username = username;
            this.password = password;
        }
        
        public string userName   
        {
            get { return this.username; }   
            set { username = value; }
        }
        public void insertCookie(Login lg)
        {
            string cookie = lg.username +","+ lg.password;
            string sql = "INSERT INTO cookie VALUES(N'" +Base64Encode(cookie)+ "')";
            connection.excute(sql);
        }
        public void deleteCookie()
        {
            string sql = "DELETE FROM cookie";
            connection.excute(sql);
        }
        public bool checkAccount(Login lg)
        {
            string pwEncode = md5.Encode(lg.password);
            //string sql = "SELECT * FROM account where username=N'"+lg.username+"' and password=N'"+lg.password+"'";
            string sql = "SELECT * FROM account where username=N'" + lg.username + "' and password=N'" + pwEncode + "'";
            DataTable DT = connection.getDataTable(sql);
            return DT.Rows.Count > 0;
        }
        public bool checkPermission(Login lg)
        {
            string sql = "SELECT * FROM account where username=N'" + lg.username + "' and permission=N'1'";
            DataTable DT = connection.getDataTable(sql);
            return DT.Rows.Count > 0;
        }
        public List<string> accountCookie()
        {
            List<string> info = new List<string>();
            string sql = "SELECT * FROM cookie";
            DataTable DT = connection.getDataTable(sql);
            string decodeCookie = Base64Decode(DT.Rows[0]["cookie"].ToString());
            int position = decodeCookie.IndexOf(",");
            string user = decodeCookie.Substring(0, position);
            string pw = decodeCookie.Substring(position + 1);
            info.Add(user);
            info.Add(pw);
            return info;
        }
        public bool checkCookie()
        {
            string sql = "SELECT * FROM cookie";
            DataTable DT = connection.getDataTable(sql);
            return DT.Rows.Count>0;
        }

        public static string Base64Encode(string str)
        {
            var cookieByte = System.Text.Encoding.UTF8.GetBytes(str);
            return System.Convert.ToBase64String(cookieByte);
        }
        public static string Base64Decode(string cookie)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(cookie);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
