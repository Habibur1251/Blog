using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

/// <summary>
/// Summary description for email_article
/// </summary>
public class email_article
{
    public void s_email_sub(string send_to, string mail_content, string sub)
    {
        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("XXXXXo@gmail.com");
            mail.To.Add(send_to);
            mail.Subject = sub;
            mail.Body = mail_content;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            //SystemException..Show("mail Send");
        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.ToString());
        }

    }
}