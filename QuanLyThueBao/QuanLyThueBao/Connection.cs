using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyThueBao
{
   public class Connection
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLTHUEBAO;Integrated Security=True");
        public Connection() { }
        public SqlConnection getConnection
        {
            get { return conn; }
        }
        public DataTable getDataTable(string sql)
        {
                DataTable DT = new DataTable();
                SqlCommand CMD = new SqlCommand(sql, this.conn);
                SqlDataAdapter DA = new SqlDataAdapter();
                DA.SelectCommand = CMD;
                DA.Fill(DT);
                DT.AcceptChanges();
                return DT;
        }
        public void excute(string sql)
        {
                SqlDataAdapter DA = new SqlDataAdapter(sql, conn);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                DA.Update(DT);
                DT.AcceptChanges();
        }
    }


}
