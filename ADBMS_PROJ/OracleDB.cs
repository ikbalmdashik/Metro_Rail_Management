using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace ADBMS_PROJ
{
    public static class OracleDb
    {
        // Static connection string (set in Program.cs)
        public static string ConnectionString { get; set; }

        public static OracleConnection GetConnection()
        {
            return new OracleConnection(ConnectionString);
        }

        // For simple queries (no parameters)
        public static DataTable ExecuteQuery(string sql)
        {
            using (OracleConnection conn = GetConnection())
            {
                conn.Open();
                using (OracleDataAdapter adapter = new OracleDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        // For parameterized queries
        public static DataTable ExecuteQuery(string sql, List<OracleParameter> parameters)
        {
            using (OracleConnection conn = GetConnection())
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    if (parameters != null && parameters.Count > 0)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }

                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
