using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using MySql.Data.MySqlClient;

namespace Corona_B.I.E.R_V1.DataAcces
{
    public class SQLDataAccess
    {
        public static string GetConnectionString(string connectionName = "DefaultConnection")
        {

          return "Server=localhost;user=root;password=;database=bier_db;";
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                return con.Query<T>(sql).ToList();
            }
        }

        public static void SaveData<T>(string sql, T data)
        {
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Execute(sql, data);
            }
        }
    }
}
