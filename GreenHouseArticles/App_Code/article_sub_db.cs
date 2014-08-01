using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
/// <summary>
/// Summary description for article_sub_db
/// </summary>
public class article_sub_db
{
    static string MyConString = "SERVER=localhost;" +
                "DATABASE=db_article;" +
                "UID=root;" +
                "PASSWORD=;Pooling=true;" + "charset=utf8;";
    MySqlConnection connection = new MySqlConnection(MyConString);
    static Int32 userid = 0;
    static string username_ob;
    article_db ob_article = new article_db();
    public void insert_article(String title, string body, string email, string cat, Int32 pin)
    {

        body=body.Replace("'","&#39").Replace("\"","&#34");
        
        title=title.Replace("'", "&#39").Replace("\"","&#34");
       
        string cmd = "SET NAMES UTF8;" + "insert into article (article_title,article_body,email,catagory,pin_no)" +
                     "values('" + title + "','" + body + "','" + email + "','" + cat + "','" + pin + "');";

        CreateMySqlCommand(cmd, connection);
        //return ob_article.get_articleid(title);


    }
    public void insert_tag(string tag, int article_id)
    {

        string cmd = "insert into tag (tag_name,article_id)" +
                 "values('" + tag + "','" + article_id + "');";

        CreateMySqlCommand(cmd, connection);
        //return ob_article.get_articleid(title);


    }
    public void insert_comment(string body, string email, Int32 ac_id, string displayname)
    {

        string cmd = "SET NAMES UTF8;" + "insert into comment (email,article_id,com_des,display_name)" +
                     "values('" + email + "','" + ac_id + "','" + body.Replace("'", "&#39").Replace("\"", "&#34") + "','" + displayname.Replace("'", "&#39").Replace("\"", "&#34") + "');";

        CreateMySqlCommand(cmd, connection);
        //return ob_article.get_articleid(title);


    }
    public void CreateMySqlCommand(string myExecuteQuery, MySqlConnection myConnection)
    {
        MySqlCommand myCommand = new MySqlCommand(myExecuteQuery, myConnection);
        myCommand.Connection.Open();
        //myConnection.Open();
        myCommand.ExecuteNonQuery();
        myConnection.Close();
    }
}