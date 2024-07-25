using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Otomatik_Mail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cs = /* sql bağlantın    @"";*/ "onbeş";
            string sql = "select * from Orders Where OrderDate>=DATEADD(DAY,-720,CONVERT(date,sysdatetime()))";

            SqlDataAdapter adapter = new SqlDataAdapter(sql,cs);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);

            string mailbody = "";
            foreach (var item in dt.Rows)
            {
                mailbody += item["OrderDate"] + " " + item["CustomerID"];
            }

            mailGönder(mailbody);
        }

       private static void mailGönder(string mailbody)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("dersingrkmefe2003@gmail.com");
            mail.To.Add("info@adartistanbul.com");
            mail.Subject = "İşlem Tamam";
            mail.Body = mailbody;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("dersingrkmefe2003@gmail.com", "Şifre");
            smtp.Port = 587;
            smtp.Host = "stmp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}
