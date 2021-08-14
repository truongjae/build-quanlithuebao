using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
namespace QuanLyThueBao
{
    class Customer
    {
        private string idCard, name, sex, address, dob, email;
        private byte[] avatar, picFront, picBack;
        private Connection connection = new Connection();
        private SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLTHUEBAO;Integrated Security=True");
        public Customer() { }
        public Customer(string idCard, string name, string dob, string sex, string address,string email)
        {
            this.idCard = idCard;
            this.name = name;
            this.dob = dob;
            this.sex = sex;
            this.address = address;
            this.email = email;
        }
        public Customer(string idCard, string name, string dob, string sex, string address, string email,byte[] avatar, byte[] picFront, byte[] picBack)
        {
            this.idCard = idCard;
            this.name = name;
            this.dob = dob;
            this.sex = sex;
            this.address = address;
            this.email = email;
            this.avatar = avatar;
            this.picFront = picFront;
            this.picBack = picBack;
        }
        public void showListView(ListView item, string sql)
        {
            item.Items.Clear();
            DataTable DT = connection.getDataTable(sql);
            int i = 0;
            foreach (DataRow row in DT.Rows)
            {
                string idCard = row["id_card"].ToString();
                string name = row["name_customer"].ToString();
                string dob = Convert.ToDateTime(row["dob"].ToString()).ToString("dd-MM-yyyy");
                string sex = row["sex"].ToString();
                string address = row["address"].ToString();
                string email = row["email"].ToString();
                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(idCard);
                item.Items[i].SubItems.Add(name);
                item.Items[i].SubItems.Add(dob);
                item.Items[i].SubItems.Add(sex);
                item.Items[i].SubItems.Add(address);
                item.Items[i].SubItems.Add(email);
                i++;
            }
        }

        public void insert(Customer cm)
        {
            //string sql = "INSERT INTO customer VALUES('" + cm.idCard + "',N'" + cm.name + "','" + cm.dob + "',N'" + cm.sex + "'"+",N'"+cm.address+"')";
            /*string sql = "INSERT INTO customer VALUES('" + cm.idCard + "',N'" + cm.name +
                "','" + cm.dob + "',N'" + cm.sex + "'" + ",N'" + cm.address +
                "','"+cm.avatar+"','"+cm.picFront+"','"+cm.picBack+"')";
            excute(sql);*/


            string sql = "INSERT INTO customer VALUES(@id_card,@name,@dob,@sex,@address,@avatar,@pic_front,@pic_back,@email)";
            this.conn.Open();
            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id_card", cm.idCard);
            cmd.Parameters.AddWithValue("@name", cm.name);
            cmd.Parameters.AddWithValue("@dob", cm.dob);
            cmd.Parameters.AddWithValue("@sex", cm.sex);
            cmd.Parameters.AddWithValue("@address", cm.address);
            cmd.Parameters.AddWithValue("@avatar", cm.avatar);
            cmd.Parameters.AddWithValue("@pic_front", cm.picFront);
            cmd.Parameters.AddWithValue("@pic_back", cm.picBack);
            cmd.Parameters.AddWithValue("@email", cm.email);
            cmd.ExecuteNonQuery();
            this.conn.Close();

        }
        public void update(Customer cm)
        {
            /*string sql = "UPDATE customer set name_customer=N'" + cm.name + "',dob='" + cm.dob + "',sex=N'" +
                cm.sex + "',address=N'"+ cm.address+"',avatar="+cm.avatar+",pic_front="+
                cm.picFront+",pic_back="+cm.picBack+" where id_card='" + cm.idCard + "'";
            excute(sql);*/
            string sql = "UPDATE customer set name_customer= @name, dob= @dob,sex = @sex, address = @address, avatar = @avatar,pic_front= @pic_front, pic_back= @pic_back, email= @email ";
            sql += "where id_card = @id_card";
            this.conn.Open();
            SqlCommand cmd = new SqlCommand(sql, this.conn);
            cmd.Parameters.AddWithValue("@id_card", cm.idCard);
            cmd.Parameters.AddWithValue("@name", cm.name);
            cmd.Parameters.AddWithValue("@dob", cm.dob);
            cmd.Parameters.AddWithValue("@sex", cm.sex);
            cmd.Parameters.AddWithValue("@address", cm.address);
            cmd.Parameters.AddWithValue("@avatar", cm.avatar);
            cmd.Parameters.AddWithValue("@pic_front", cm.picFront);
            cmd.Parameters.AddWithValue("@pic_back", cm.picBack);
            cmd.Parameters.AddWithValue("@email", cm.email);
            cmd.ExecuteNonQuery();
            this.conn.Close();
        }
        public void delete(Customer cm)
        {
            string sql = "DELETE FROM customer where id_card=N'" + cm.idCard + "';DELETE FROM phone where id_card=N'"+cm.idCard+"'";
            connection.excute(sql);
        }
        public void deleteAll()
        {
            string sql = "DELETE FROM customer;DELETE FROM phone;";
            sql += "DELETE FROM account where username in (select p.phone_number from customer cs join phone p on p.id_card = cs.id_card);";
            sql += "DELETE FROM sended;";
            sql += "DELETE FROM called;";
            sql += "DELETE FROM reg_service;";
            sql += "DELETE FROM spending;";
            sql += "DELETE FROM history_recharge;";
            connection.excute(sql);
        }
        public bool checkKey(string key)
        {
            string sql = "SELECT id_card FROM customer";
            DataTable DT = connection.getDataTable(sql);
            foreach (DataRow row in DT.Rows)
            {
                string idRe = row["id_card"].ToString();
                if (String.Compare(idRe.Trim(), key.Trim(), true) == 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
