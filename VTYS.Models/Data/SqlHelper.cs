using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using VTYS.Data;

namespace VTYS.Models.Data
{
    public static class SqlHelper
    {
        public static bool RunExecute(this NpgsqlCommand cmd, string sql)
        {
            cmd.Connection = DbModel.Connection;
            cmd.CommandText = sql;
            return cmd.Exec();
        }
    }
}
