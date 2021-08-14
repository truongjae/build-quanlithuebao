using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThueBao
{
    class ChangePw
    {
        private string username, password;
        private Connection connection = new Connection();
        private MD5Security md5 = new MD5Security();
        public ChangePw()
        {

        }
        public ChangePw(string username, string password)
        {
            this.username =username;
            this.password = password;
        }
        public void updatePassword()
        {
            string pwEncode = md5.Encode(this.password);
           // string sql = "UPDATE account set password=N'"+this.password+"' where username=N'"+this.username+"'";
            string sql = "UPDATE account set password=N'" + pwEncode + "' where username=N'" + this.username + "'";
            connection.excute(sql);
        }
        
    }
}
