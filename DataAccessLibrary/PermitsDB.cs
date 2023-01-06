
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLibrary
{
    public class PermitsDB
    {

        // string ConnectionString;
        public NpgsqlConnection conn = new NpgsqlConnection();
        List<string> data = new List<string>();
        public NpgsqlCommand cmd;
        //  public string UserName = "";
        object obj_lock = new object();
        string strpgcon = ConfigurationManager.ConnectionStrings["permitspgsql"].ConnectionString;
        public PermitsDB()
        {
            conn.ConnectionString = strpgcon;
        }
        public DataSet GetData(NpgsqlCommand _cmd)
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
}

