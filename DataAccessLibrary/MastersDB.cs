using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;


    public class MastersDB
    {
        public NpgsqlConnection conn = new NpgsqlConnection();
        public NpgsqlCommand cmd;
        object obj_lock = new object();
        string strpgcon = ConfigurationManager.ConnectionStrings["MstDB"].ConnectionString;
    public MastersDB()
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

