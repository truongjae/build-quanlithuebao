using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLyThueBao
{
    class Network
    {
        private string idNetwork, nameNetwork;
        private long priceInternal, priceForeign, messInternal, messForeign, maxReg;
        private Connection connection = new Connection();
        public Network() { }
        public Network(string idNetwork, string nameNetwork, long priceInternal, long priceForeign,long messInternal,long messForeign,long maxReg)
        {
            this.idNetwork = idNetwork;
            this.nameNetwork = nameNetwork;
            this.priceInternal = priceInternal;
            this.priceForeign = priceForeign;
            this.messInternal = messInternal;
            this.messForeign = messForeign;
            this.maxReg = maxReg;
        }
        public void showListView(ListView item, string sql)
        {
            item.Items.Clear();
            DataTable DT = connection.getDataTable(sql);
            int i = 0;
            foreach (DataRow row in DT.Rows)
            {
                string idNet = row["id_network"].ToString();
                string nameNet = row["name_network"].ToString();
                long priceIn = Int64.Parse(row["price_internal"].ToString());
                long priceFo = Int64.Parse(row["price_foreign"].ToString());
                long messIn = Int64.Parse(row["mess_internal"].ToString());
                long messFo = Int64.Parse(row["mess_foreign"].ToString());
                long maxReg = Int64.Parse(row["max_reg"].ToString());
                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(idNet);
                item.Items[i].SubItems.Add(nameNet);
                item.Items[i].SubItems.Add(priceIn.ToString());
                item.Items[i].SubItems.Add(priceFo.ToString());
                item.Items[i].SubItems.Add(messIn.ToString());
                item.Items[i].SubItems.Add(messFo.ToString());
                item.Items[i].SubItems.Add(maxReg.ToString());
                i++;
            }
        }
        public void insert(Network nw)
        {
            string sql = "INSERT INTO network VALUES(N'" + nw.idNetwork + "',N'" + nw.nameNetwork + "',"+nw.priceInternal+
                ","+nw.priceForeign+","+nw.messInternal+","+nw.messForeign+","+nw.maxReg+")";
            connection.excute(sql);
        }
        public void update(Network nw)
        {
            string sql = "UPDATE network set name_network=N'" + nw.nameNetwork 
                + "',price_internal="+nw.priceInternal+",price_foreign="+nw.priceForeign+",mess_internal="+nw.messInternal+",mess_foreign="+nw.messForeign+",max_reg="
                +nw.maxReg+" where id_network=N'" + nw.idNetwork + "'";
            connection.excute(sql);
        }
        public void delete(Network nw)
        {
            string sql = "DELETE FROM network where id_network=N'" + nw.idNetwork + "';DELETE FROM phone where id_network=N'" + nw.idNetwork + "';";
            sql += "DELETE FROM card where id_network=N'" + nw.idNetwork + "';";
            sql += "DELETE FROM service where id_network=N'" + nw.idNetwork + "'";
            
            connection.excute(sql);
        }
        public void deleteAll()
        {
            string sql = "DELETE FROM network;DELETE FROM phone;DELETE FROM card; DELETE FROM service; DELETE FROM phone;";
            sql += "DELETE FROM account where permission =N'0'";
            connection.excute(sql);
        }
        public bool checkKey(string key)
        {
            string sql = "SELECT id_network FROM network";
            DataTable DT = connection.getDataTable(sql);
            foreach (DataRow row in DT.Rows)
            {
                string idRe = row["id_network"].ToString();
                if (String.Compare(idRe.Trim(), key.Trim(), true) == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
