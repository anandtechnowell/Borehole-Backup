using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

using System.Text;

namespace DataAccessLibrary
{
   
    public class UMManager
    {

        // string ConnectionString;
        public NpgsqlConnection conn = new NpgsqlConnection();
        List<string> data = new List<string>();
        public NpgsqlCommand cmd;
        //  public string UserName = "";
        object obj_lock = new object();
        string strpgcon = ConfigurationManager.ConnectionStrings["UMM"].ConnectionString;
        public UMManager()
        {
            conn.ConnectionString = strpgcon;
        }
        public bool Insert(NpgsqlCommand _cmd)
        {
            try
            {
                cmd = _cmd;
                lock (cmd)
                {
                    cmd.Connection = conn;
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();

                }
                return true;

            }
            catch (Exception ex)
            {
                cmd.Connection.Close();
                throw new ApplicationException(ex.Message);
            }
        }
        public int Modify(NpgsqlCommand _cmd)
        {
            try
            {
                cmd = _cmd;
                lock (cmd)
                {
                    cmd.Connection = conn;
                    cmd.Connection.Open();
                    int i = cmd.ExecuteNonQuery();
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
