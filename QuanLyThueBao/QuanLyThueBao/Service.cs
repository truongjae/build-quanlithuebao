using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLyThueBao
{
    class Service
    {
        private string idService, nameService, network, info;
        private long price, promotion, expDate;
        private Connection connection = new Connection();

        public Service() { }
        public Service(string idService, string nameService,string network,long price, long promotion,long expDate,string info)
        {
            this.idService = idService;
            this.nameService = nameService;
            this.network = network;
            this.price = price;
            this.promotion = promotion;
            this.expDate = expDate;
            this.info = info;
        }
        public void showListView(ListView item, string sql)
        {
            item.Items.Clear();
            DataTable DT = connection.getDataTable(sql);
            int i = 0;
            foreach (DataRow row in DT.Rows)
            {
                string idService = row["id_service"].ToString();
                string nameService = row["name_service"].ToString();
                string idNetwork = row["id_network"].ToString();
                string price = row["price_service"].ToString();
                string promotion = row["promotion"].ToString();
                string expDate = row["exp_date"].ToString();
                string info = row["info"].ToString();
                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(idService);
                item.Items[i].SubItems.Add(nameService);
                item.Items[i].SubItems.Add(idNetwork);
                item.Items[i].SubItems.Add(price);
                item.Items[i].SubItems.Add(promotion);
                item.Items[i].SubItems.Add(expDate);
                item.Items[i].SubItems.Add(info);
                i++;
            }
        }
       /* public void excute(string sql)
        {
            SqlDataAdapter DA = new SqlDataAdapter(sql, conn);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            DA.Update(DT);
            DT.AcceptChanges();
        }*/
        public void insert(Service sv)
        {
            string sql = "INSERT INTO service VALUES(N'" + sv.idService + "',N'" + sv.nameService + "',N'" +
                sv.network + "'," + sv.price + ","+sv.promotion+","+sv.expDate+",N'"+sv.info+"')";
            connection.excute(sql);

        }
        public void update(Service sv)
        {
            string sql = "UPDATE service set name_service=N'" + sv.nameService+ "',id_network=N'" +
                sv.network + "', price_service=" + sv.price + ", promotion=" + sv.promotion + ", exp_date=" + sv.expDate + ",info=N'"+sv.info
                +"' where id_service=N'" + sv.idService + "'";
            connection.excute(sql);
        }
        public void delete(Service sv)
        {
            string sql = "DELETE FROM service where id_service=N'" + sv.idService+ "'";
            connection.excute(sql);
        }
        public void deleteAll()
        {
            string sql = "DELETE FROM service";
            connection.excute(sql);
        }
        public bool checkKey(string key)
        {
            string sql = "SELECT id_service FROM service";
            DataTable DT = connection.getDataTable(sql);
            foreach (DataRow row in DT.Rows)
            {
                string idService = row["id_service"].ToString();
                if (String.Compare(idService.Trim(), key.Trim(), true) == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
