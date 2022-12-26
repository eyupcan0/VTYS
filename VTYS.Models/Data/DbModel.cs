using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace VTYS.Data
{
    public static class DbModel
    {
        private static NpgsqlConnection _connection;
        public static NpgsqlConnection Connection
        {
            get
            {
                if (_connection == null) _connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TREN"].ConnectionString);
                return _connection;
            }
            set { _connection = value; }
        }
        public static DataTable ToListDataTable(this NpgsqlDataAdapter adp)
        {
            try
            {
                if (Connection.State != ConnectionState.Open) Connection.Open();
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
            catch(Exception ex)
            {
                Messages.Messages.HataMesaji(ex.Message);
                return null;
            }
        }
        public static List<T> ToList<T>(this SqlDataAdapter adp) where T : class, new()
        {
            try
            {
                if (Connection.State != ConnectionState.Open) Connection.Open();
                DataTable dt = new DataTable();
                adp.Fill(dt);
                Type type = typeof(T);
                List<T> liste = new List<T>();
                PropertyInfo[] properties = type.GetProperties();
                foreach (DataRow dr in dt.Rows)
                {
                    T tip = new T();
                    foreach (PropertyInfo pi in properties)
                    {
                        object value = dr[pi.Name];
                        if (value != DBNull.Value)
                            if (value != null) pi.SetValue(tip, value);
                    }
                    liste.Add(tip);
                }

                return liste;
            }
            catch (Exception ex)
            {
                Messages.Messages.HataMesaji(ex.Message);
                return null;
            }
        }
        public static T ToSingle<T>(this NpgsqlDataAdapter adp) where T : class, new()
        {
            try
            {
                if (Connection.State != ConnectionState.Open) Connection.Open();
                DataTable dt = new DataTable();
                adp.Fill(dt);
                Type type = typeof(T);
                List<T> liste = new List<T>();
                PropertyInfo[] properties = type.GetProperties();
                foreach (DataRow dr in dt.Rows)
                {
                    T tip = new T();
                    foreach (PropertyInfo pi in properties)
                    {
                        object value = dr[pi.Name];
                        if (value != DBNull.Value)
                            if (value != null) pi.SetValue(tip, value);
                    }
                    liste.Add(tip);
                }

                return liste.First();
            }
            catch (Exception ex)
            {
                Messages.Messages.HataMesaji(ex.Message);
                return null;
            }
        }
        public static bool Exec(this NpgsqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open) cmd.Connection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result <= 0) return false;
                else return true;
            }
            catch (Exception ex)
            {
                Messages.Messages.HataMesaji(ex.Message);
                return false;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed) cmd.Connection.Close();
            }
        }
        public static object ExecReader(this NpgsqlCommand cmd)
        {
            object result = new object();
            try
            {
                if (cmd.Connection.State != ConnectionState.Open) cmd.Connection.Open();
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    result = reader[0];

                return result;
            }
            catch (Exception ex)
            {
                Messages.Messages.HataMesaji(ex.Message);
                return result = -1;
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed) cmd.Connection.Close();
            }
        }
    }
}
