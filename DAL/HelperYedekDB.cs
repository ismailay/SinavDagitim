using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.OleDb;
using System.Data;

namespace Batl.DAL
{
  public   class HelperYedekDB
    {
        public static readonly string connStr = ConfigurationManager.ConnectionStrings["batl.yedek"].ToString();

        public int ExecuteNonQuery(string cmdText, params OleDbParameter[] param)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = cmdText;
                SqlCommandParam(cmd, param);

                return cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public OleDbDataReader ExecuteReader(string cmdText, params OleDbParameter[] param)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            try
            {
                OleDbCommand cmd = new OleDbCommand(cmdText, conn);
                SqlCommandParam(cmd, param);
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                throw ex;
            }
        }

        public DataSet ExecuteDataSet(string cmdText, params OleDbParameter[] param)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            try
            {
                OleDbCommand cmd = new OleDbCommand(cmdText, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                SqlCommandParam(cmd, param);
                conn.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public object ExecuteScalar(string cmdText, params OleDbParameter[] param)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            try
            {
                OleDbCommand cmd = new OleDbCommand(cmdText, conn);
                SqlCommandParam(cmd, param);
                conn.Open();
                return cmd.ExecuteScalar();
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void SqlCommandParam(OleDbCommand cmd, params OleDbParameter[] param)
        {
            for (int i = 0; i < param.Length; i++)
            {
                cmd.Parameters.Add(param[i]);
            }
        }
    }
}
