using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLyThueBao
{
    class Regions
    {
        private string idRegion, nameRegion;
        private Connection connection = new Connection();
        public Regions() { }
        public Regions(string idRegion,string nameRegion){
            this.idRegion=idRegion;
            this.nameRegion=nameRegion;
        }
        public void showListView(ListView item, string sql)
        {
            item.Items.Clear();
            DataTable DT = connection.getDataTable(sql);
            int i = 0;
            foreach (DataRow row in DT.Rows)
            {
                string idRe = row["id_region"].ToString();
                string nameRe = row["name_region"].ToString();
                item.Items.Add((i + 1).ToString());
                item.Items[i].SubItems.Add(idRe);
                item.Items[i].SubItems.Add(nameRe);
                i++;
            }
        }
        public void insert(Regions rg)
        {
            string sql = "INSERT INTO region VALUES(N'" + rg.idRegion + "',N'" + rg.nameRegion + "')";
            connection.excute(sql);

        }
        public void update(Regions rg)
        {
            string sql = "UPDATE region set name_region=N'" + rg.nameRegion + "' where id_region=N'" + rg.idRegion + "'";
            connection.excute(sql);
        }
        public void delete(Regions rg)
        {
            string sql = "DELETE FROM region where id_region=N'" + rg.idRegion + "'";
            connection.excute(sql);
        }
        public void deleteAll()
        {
            string sql = "DELETE FROM region";
            connection.excute(sql);
        }
        public bool checkKey(string key)
        {
            string sql = "SELECT id_region FROM region";
            DataTable DT = connection.getDataTable(sql);
            foreach (DataRow row in DT.Rows)
            {
                string idRe = row["id_region"].ToString();
                if (String.Compare(idRe.Trim(), key.Trim(), true) == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
