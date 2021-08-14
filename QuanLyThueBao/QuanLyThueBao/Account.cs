using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLyThueBao
{
    class Account
    {
        private string username, permission, password;
        private Connection connection = new Connection();
        private MD5Security md5 = new MD5Security();
        public Account() { }
        public Account(string myAccount) {
            this.username = myAccount;
        }
        public Account(string username,string password,string permission)
        {
            this.username = username;
            this.permission = permission;
            this.password = password;
        }
        public void insert(Account acc)
        {
            string pwEncode = md5.Encode(acc.password);
            //string sql = "INSERT INTO account VALUES(N'" + acc.username + "',N'" + acc.password + "',N'" + acc.permission + "')";
            string sql = "INSERT INTO account VALUES(N'" + acc.username + "',N'" + pwEncode + "',N'" + acc.permission + "')";
            connection.excute(sql);
        }
        public void update(Account acc)
        {
            string pwEncode = md5.Encode(acc.password);
            /*string sql = "UPDATE account set password=N'" + 
                acc.password + "', permission=N'" + acc.permission + "' where username=N'"+acc.username+"'";*/
            string sql = "UPDATE account set password=N'" +
                pwEncode + "', permission=N'" + acc.permission + "' where username=N'" + acc.username + "'";
            connection.excute(sql);
        }
        public void delete(Account acc)
        {
            string sql = "DELETE FROM account where username ='" + acc.username + "'";
            connection.excute(sql);
        }
        public void deleteAll(Account acc)
        {
            string sql = "DELETE FROM account where permission=N'0' or username != N'"+acc.username+"'";
            connection.excute(sql);
        }
        public bool checkKey(string key)
        {
            string sql = "SELECT username FROM account";
            DataTable DT = connection.getDataTable(sql);
            foreach (DataRow row in DT.Rows)
            {
                string acc = row["username"].ToString();
                if (String.Compare(acc.Trim(), key.Trim(), true) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public bool checkMyAccount(string myAccount,string key)
        {
            if (String.Compare(myAccount.Trim(), key.Trim(), true) == 0)
            {
                return true;
            }
            return false;
        }
        public void showListView(ListView item, string sql)
        {
            item.Items.Clear();
            DataTable DT = connection.getDataTable(sql);
            int i = 0;
            foreach (DataRow row in DT.Rows)
            {
                string username = row["username"].ToString();
                string password = row["password"].ToString();
                string permission = row["permission"].ToString();
                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(username);
                item.Items[i].SubItems.Add(password);
                item.Items[i].SubItems.Add(permission);
                i++;
            }
        }
    }
}
