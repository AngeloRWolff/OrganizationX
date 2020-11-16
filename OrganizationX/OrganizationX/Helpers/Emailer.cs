using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace OrganizationX.Helpers
{
    public class Emailer
    {
                       
        public bool SendEmail(string to, string token)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("angelorafaelwolff@gmail.com");
                mail.To.Add("kaimanserweebo@gmail.com");
                mail.Subject = "Test Mail";
                mail.Body = "<html>\n<body>\n" +
                    " <div style=\"width:100%; height:100%; text-align:center; background-color:#333f50\">\n" +
                       "<div style = \"width:100%; height: 80px;\" >\n" +
                        "<img style=\"width:200px; height: 80px; object-fit:cover\" src=\"https://i.imgur.com/lAPNDly.png\" />\n" +
                        "</div> \n" +
                        "<h3 style = \"color:white\" > Welcome to Organization X</h3>\n" +
                        "<h6 style = \"color:white\" > Click the following link to register your OX Account</h6>\n" +
                        $"<a href = \"https://localhost:5001/Register?token="+token+"\" style= \"border:none; background-color: #3878d1; color: white; width:100%;\"> Register </a>\n" +
                        "</div>\n" +
                         " </body>\n </html>\n";
                mail.IsBodyHtml = true;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("angelorafaelwolff@gmail.com", "An@0725544135");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Console.WriteLine("Emtail Send Success");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
