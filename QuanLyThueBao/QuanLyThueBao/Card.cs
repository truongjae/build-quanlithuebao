using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLyThueBao
{
    class Card
    {
        private Connection connection = new Connection();
        private string code, network;
        private int price, promotion;
        public Card() { }
        public Card(string code, int price,string network,int promotion)
        {
            this.code = code;
            this.price = price;
            this.network = network;
            this.promotion = promotion;
        }
        public void showListView(ListView item, string sql)
        {
            item.Items.Clear();
            DataTable DT = connection.getDataTable(sql);
            int i = 0;
            foreach (DataRow row in DT.Rows)
            {
                string code = row["code"].ToString();
                string price = row["price"].ToString();
                string network = row["id_network"].ToString();
                string promotion = row["promotion"].ToString();
                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(code);
                item.Items[i].SubItems.Add(price);
                item.Items[i].SubItems.Add(network);
                item.Items[i].SubItems.Add(promotion);
                i++;
            }
        }
        public void insert(Card cd)
        {
            string sql = "INSERT INTO card VALUES(N'" + cd.code + "'," + cd.price + ",N'" + cd.network + "'," + cd.promotion + ")";
            connection.excute(sql);
            
        }
        public void update(Card cd)
        {
            string sql = "UPDATE card set price=" + cd.price + ",promotion=" +
                cd.promotion + " where code=N'" + cd.code + "' and id_network=N'" + cd.network + "'";
            connection.excute(sql);
        }
        public void delete(Card cd)
        {
            string sql = "DELETE FROM card where code=N'" + cd.code + "' and id_network=N'"+cd.network+"'";
            connection.excute(sql);
        }
        public void deleteAll()
        {
            string sql = "DELETE FROM card";
            connection.excute(sql);
        }
        public bool checkKey(string c,string n)
        {
            string sql = "SELECT code,id_network FROM card";
            DataTable DT = connection.getDataTable(sql);
            foreach (DataRow row in DT.Rows)
            {
                string code = row["code"].ToString();
                string network = row["id_network"].ToString();
                if (String.Compare(code.Trim(), c.Trim(), true) == 0 && String.Compare(network.Trim(), n.Trim(), true)==0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
