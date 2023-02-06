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
    string strpgcon = ConfigurationManager.ConnectionStrings["adminpgsql"].ConnectionString;
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

    public int Update(NpgsqlCommand _cmd)
    {
        lock (obj_lock)
        {
            try
            {
                int i = 0;
                cmd = _cmd;
                lock (cmd)
                {
                    cmd.Connection = conn;
                    cmd.Connection.Open();
                    i = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    return i;
                }
            }
            catch (Exception ex)
            {
                cmd.Connection.Close();
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
