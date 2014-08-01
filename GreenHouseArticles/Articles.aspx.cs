using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Articles : System.Web.UI.Page
{
    static int article_id;
    static int Page;
    MySqlConnection connection;
    static string MyConString = "SERVER=localhost;" +
               "DATABASE=db_article;" +
               "UID=root;" +
               "PASSWORD=;Pooling=true;" + "charset=utf8;";
    //MySqlConnection connection = new MySqlConnection(MyConString);

    protected void Page_Load(object sender, EventArgs e)
    {
        String strsql = null;
        String strComment = null;
        Double count=0;
        comment.Visible = false;

        article_id = 0;
        Page = Convert.ToInt32(Request.QueryString["pageid"]);
        if (Page == 0) Page = 1;
        article_id = Convert.ToInt32(Request.QueryString["id"]);
        connection = new MySqlConnection(MyConString);
            connection.Open();
            strsql = "select count(article_id) from article;";
            MySqlDataReader dtReader;
            MySqlCommand objCmd = new MySqlCommand(strsql, connection);
            dtReader = objCmd.ExecuteReader();
            while (dtReader.Read())
            {
                count = Convert.ToInt32(dtReader["count(article_id)"]);
            }
            dtReader.Close();

            if (article_id == 0)
            {
                
            //    Page = Convert.ToInt32(Request.QueryString["pageid"]);
                strsql = "Select* From article Limit " + (Page * 3 - 3) + ",3;";
                BindData(strsql,count);
                comment.Visible = false;

            }
            else
            {
                strsql = "select * from article where article_id = " + article_id;
                strComment = "select * from comment where article_id=" + article_id;
                Panel1.Visible = false;
                BindData(strsql,count);
                BindComment(strComment);


            }
        


    }
    protected void BindComment(String strComment)
    {

        MySqlDataReader dtReader;
        MySqlCommand objCmd = new MySqlCommand(strComment, connection);
        dtReader = objCmd.ExecuteReader();
        Repeater2.DataSource = dtReader;
        Repeater2.DataBind();
        dtReader = null;
    }



    protected void BindData(string strsql, Double Count)
    {
        MySqlDataReader dtReader;
        MySqlCommand objCmd = new MySqlCommand(strsql, connection);
        Panel1.Controls.Add(new LiteralControl("<table cellpadding='10' cellspacing='10'><tr><td align=center valign=middle width='40px'><a href=Articles.aspx?id=0&pageid=1>Prev</a><td>"));

        for (int i = 1; i <= Math.Ceiling((Count / 3)); i++)
        {
            Panel1.Controls.Add(new LiteralControl("<td align=center valign=middle width='40px'>"));
            Panel1.Controls.Add(new LiteralControl("<a href=Articles.aspx?pageid=" + i + ">"));

            Panel1.Controls.Add(new LiteralControl(i.ToString()));

            Panel1.Controls.Add(new LiteralControl("</a>"));

            Panel1.Controls.Add(new LiteralControl("</td>"));

        }

        Panel1.Controls.Add(new LiteralControl("<td align=center valign=middle width='40px'><a href=Articles.aspx?id=0&pageid=" + Math.Ceiling(Count / 3) +">Next</a><td></tr></table>"));

        dtReader = objCmd.ExecuteReader();
        Repeater1.DataSource = dtReader;
        Repeater1.DataBind();
        dtReader.Close();
        dtReader = null;

    }

    public static string Limit(object Desc, int length)
    {
        StringBuilder strDesc = new StringBuilder();
        strDesc.Insert(0, Desc.ToString());

        if (strDesc.Length > length && (article_id == 0))
            return strDesc.ToString().Substring(0, length) + "...............";
        else return strDesc.ToString();
    }
    protected string AddReadMore()
    {
        if (article_id == 0)
        {
            return "[Read More]";
        }
        else
        {
            return null;
        }
    }
    protected void submit_comment(object sender, EventArgs e)
    {
        if (isEmail(email.Text))
        {
            article_sub_db article_sub = new article_sub_db();
            article_sub.insert_comment(comment_des.Text, email.Text, article_id, displayname.Text);
            email_article email_ob = new email_article();
            email_ob.s_email_sub(email.Text, "You have submitted a comment", "comment submitted to Nature Articles");
            // this.ClientScript.RegisterStartupScript(this.GetType(), "alert3", "<script type='text/javascript'>alert('Submitted comment about" + txttitle.Text + "');</script>");
            Response.Redirect("Default.aspx");
        }
        else
            this.ClientScript.RegisterStartupScript(this.GetType(), "alert2", "<script type='text/javascript'>alert('Check your Email Id again');</script>");

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


}