using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for membership_db
/// </summary>
public class membership_db
{
    static string MyConString = "SERVER=localhost;" +
                "DATABASE=mlmbd;" +
                "UID=Gunner;" +
                "PASSWORD=gunner;Pooling=true;";
    MySqlConnection connection = new MySqlConnection(MyConString);
    static Int32 userid = 0;
    static string username_ob;
    public void update_royalty(Int16 id, double notes)
    {
        string cmd = "UPDATE db_payment SET  Notes = '" + notes + "' WHERE  uid ='" + id + "' and DATEDIFF(time,CURDATE())='0';";
        CreateMySqlCommand(cmd, connection);

    }
    public Boolean checkLogin(string uname, string pass)
    {

        Boolean log = false;
        MySqlCommand command = connection.CreateCommand();
        MySqlDataReader Reader;
        command.CommandText = "select * from db_userinfo where username ='" + uname + "';";
        connection.Open();
        Reader = command.ExecuteReader();
        while (Reader.Read())
        {
            if (pass == Convert.ToString(Reader["password"]))
            {

                log = true;
                userid = Convert.ToInt32(Reader["uid"]);
                username_ob = uname;
                break;
            }
        }
        Reader.Close();
        // get_user_id(uname);
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