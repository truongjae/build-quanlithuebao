using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLyThueBao
{
    class User
    {
        private string username;
        private Connection connection = new Connection();

        public User() { }
        public User(string username)
        {
            this.username = username;
        }
        public void showInfo(Label name,Label idCard,Label DOB,Label sex,Label address, 
            Label email, Label phone, Label region,Label network, Label type, Label actDate, Label expDate,
            Label balance, Label promotion, Label payment,Label status)
        {
                string sql = "select cm.name_customer, cm.id_card, cm.dob, cm.sex, cm.address, cm.email, p.phone_number,p.status,";
                sql += "re.name_region, nw.name_network, p.type, p.activation_date, p.expiration_date, p.account_balance,";
                sql += "p.account_promotion, p.payment,re.id_region,nw.id_network ";
                sql += "from customer cm join phone p on cm.id_card = p.id_card ";
                sql += "join region re on re.id_region = p.id_region ";
                sql += "join network nw on nw.id_network = p.id_network ";
                sql += "and p.phone_number = '" + this.username + "'";
                DataTable DT = connection.getDataTable(sql);
                name.Text = DT.Rows[0]["name_customer"].ToString();
                idCard.Text = DT.Rows[0]["id_card"].ToString();
                DOB.Text = Convert.ToDateTime(DT.Rows[0]["dob"]).ToString("dd/MM/yyyy");
                sex.Text = DT.Rows[0]["sex"].ToString();
                address.Text = DT.Rows[0]["address"].ToString();
                email.Text = DT.Rows[0]["email"].ToString();
                phone.Text = DT.Rows[0]["phone_number"].ToString();
                region.Text = "(" + DT.Rows[0]["id_region"].ToString() + ") " + DT.Rows[0]["name_region"].ToString();
                network.Text = "(" + DT.Rows[0]["id_network"].ToString() + ") " + DT.Rows[0]["name_network"].ToString();
                type.Text = DT.Rows[0]["type"].ToString();
                actDate.Text = Convert.ToDateTime(DT.Rows[0]["activation_date"]).ToString("dd/MM/yyyy");
                expDate.Text = Convert.ToDateTime(DT.Rows[0]["expiration_date"]).ToString("dd/MM/yyyy");
                balance.Text = DT.Rows[0]["account_balance"].ToString() + " VNĐ";
                promotion.Text = DT.Rows[0]["account_promotion"].ToString() + " VNĐ";
                payment.Text = DT.Rows[0]["payment"].ToString() + " VNĐ";
                if (DT.Rows[0]["status"].ToString().Equals("1")) status.Text = "Đang Hoạt Động";
                else status.Text = "Khóa 1 Chiều";
        }

    }
}
