using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
namespace QuanLyThueBao
{
    class SendMailForgotPW
    {
        private string username;
        private Connection connection = new Connection();

        public SendMailForgotPW() { }
        public SendMailForgotPW(string username)
        {
            this.username = username;
        }
        public void deleteCookie()
        {
            string sql = "DELETE FROM cookie";
            connection.excute(sql);
        }
        public bool checkAccount(SendMailForgotPW fg)
        {
            string sql = "SELECT * FROM account where username=N'" + fg.username + "' and permission = N'0'";
            DataTable DT = connection.getDataTable(sql);
            return DT.Rows.Count > 0;
        }
        public List<string> getInfo()
        {
            List<string> info = new List<string>();
            string sql = "select cs.name_customer,cs.email,ac.username ";
            sql += "from customer cs join phone p on cs.id_card = p.id_card ";
            sql += "join account ac on ac.username = p.phone_number ";
            sql += "and ac.username = N'" + this.username + "'";
            DataTable DT = connection.getDataTable(sql);
            string name =  DT.Rows[0]["name_customer"].ToString();
            string email = DT.Rows[0]["email"].ToString();
            string username = DT.Rows[0]["username"].ToString();
            info.Add(username);
            info.Add(email);
            info.Add(name);
            return info;
        }
        public void sendMail(string code)
        {
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "xacnhankhoiphuc2001@gmail.com",
                    Password = "truongjae27"
                }
            };
            List<string> info = getInfo();
            string username = info[0];
            string email = info[1];
            string name = info[2];
            string content = "Xin Chào " + name + " (" + username + ")" + ". Bạn đang yêu cầu khôi phục tài khoản.\nMã khôi phục tài khoản của bạn là: " + code;
            content += "\nNếu bạn không thực hiện hành động này vui lòng liên hệ cho quản trị viên.";
            MailAddress fromEmail = new MailAddress("xacnhankhoiphuc2001@gmail.com", "Xác Nhận Mã Khôi Phục");
            MailAddress toEmail = new MailAddress(email,"Thông Báo");
            MailMessage mess = new MailMessage()
            {
                From = fromEmail,
                Subject = "Xác Nhận Mã Khôi Phục",
                Body = content
            };
            mess.To.Add(toEmail);
            try
            {
                client.Send(mess);
            }
            catch
            {
                //
            }

        }
    }
}
