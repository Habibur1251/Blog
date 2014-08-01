using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Text.RegularExpressions;
public partial class submit_articles : System.Web.UI.Page
{
    static Int32 pin = 0;
    static Random _r = new Random();
    
    string email = "You have sumitted an article about \nPin no";
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
            Session.Clear();
    }


    protected void submit_article(object sender, EventArgs e)
    {
        if (isEmail(txtemail.Text) && (lsttype.SelectedValue)!="")
        {
            if (ValidateUserCode(txtcapcha.Text))
            {
                article_sub_db article_sub = new article_sub_db();
                article_db article_id = new article_db();
                pin = _r.Next(99999);
                article_sub.insert_article(txttitle.Text, txtmain.Text, txtemail.Text,lsttype.SelectedItem.Text,pin);
                Int32 ar_id = article_id.get_articleid(txttitle.Text.Replace("'","&#39").Replace("\"","&#34"));
                string tags = txttags.Text;
                string[] tagTokens = tags.Split(new char[1] { ',' });
                foreach (string tok in tagTokens)
                {
                    article_sub.insert_tag(tok, ar_id);
                }
                email_article email_ob = new email_article();
                email_ob.s_email_sub(txtemail.Text, email, "Article submitted to Green Articles");
                this.ClientScript.RegisterStartupScript(this.GetType(), "alert3", "<script type='text/javascript'>alert('Submitted Article about" + txttitle.Text + "');</script>");
                Response.Redirect("Default.aspx");
            }
            else
                this.ClientScript.RegisterStartupScript(this.GetType(), "alert", "<script type='text/javascript'>alert('Wrong Captha code');</script>");
        }
        else
            this.ClientScript.RegisterStartupScript(this.GetType(), "alert2", "<script type='text/javascript'>alert('Check your Email Id again/select a list');</script>");
        
    }
    public static bool isEmail(string inputEmail)
    {
        //inputEmail = NulltoString(inputEmail);
        string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
              @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
              @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        Regex re = new Regex(strRegex);
        if (re.IsMatch(inputEmail))
            return (true);
        else
            return (false);
    }
    private bool ValidateUserCode(string userEnteredCode)
    {
        bool flag = false;
        if (Session["Code"].ToString().Equals(userEnteredCode))
        {
            flag = true;
        }
        else
        {
            // clear the session and generate a new code 
            Session["Code"] = null;
            flag = false;
            //lblmsg.Text = "Please enter the Image code correctly";
        }

        return flag;
    }

}