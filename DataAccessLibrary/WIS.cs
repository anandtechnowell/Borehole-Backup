using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Npgsql;
using System.Configuration;

public class WIS
{
    string ConnectionString;
    public NpgsqlConnection conn = new NpgsqlConnection();
    List<string> data = new List<string>();
    public NpgsqlCommand cmd;
    //  public string UserName = "";
    object obj_lock = new object();
    string strpgcon = "SERVER=182.18.181.115;DATABASE=WISAdministration;UID=postgres;PASSWORD=technowell;";
    public WIS()
    {
        conn.ConnectionString = strpgcon;
    }
    public DataSet SelectQuery(NpgsqlCommand _cmd)
    {
        lock (obj_lock)
        {
            cmd = _cmd;

            lock (cmd)
            {
                try
                {
                    DataSet dsval = new DataSet();
                    cmd.Connection = conn;
                    conn.Open();

                    //cmd.ExecuteNonQuery();
                    NpgsqlDataAdapter sda = new NpgsqlDataAdapter();
                    sda.SelectCommand = cmd;
                    sda.Fill(dsval, "Table");
                    conn.Close();
                    return dsval;
                }
                catch (Exception ex)
                {
                    conn.Close();
                    throw new ApplicationException(ex.Message);
                }
            }
        }
    }
}
