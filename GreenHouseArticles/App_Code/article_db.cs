using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
/// <summary>
/// Summary description for article_db
/// </summary>
public class article_db
{
    static string MyConString = "SERVER=localhost;" +
                "DATABASE=db_article;" +
                "UID=root;" +
                "PASSWORD=;Pooling=true;";
    MySqlConnection connection = new MySqlConnection(MyConString);
    static Int32 userid = 0;
    static string username_ob;
    public Int32 get_articleid(string title)
    {

        Int32 log = 0;
        MySqlCommand command = connection.CreateCommand();
        MySqlDataReader Reader;
        command.CommandText = "select article_id from article where article_title ='" + title + "';";
        connection.Open();
        Reader = command.ExecuteReader();
        while (Reader.Read())
        {
            log = Convert.ToInt32(Reader["article_id"]);
            break;

        }
        Reader.Close();
        connection.Close();

        return log;
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