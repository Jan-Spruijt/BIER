using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using MySql.Data.MySqlClient;

namespace Corona_B.I.E.R_V1.DataAccess
{
    public class SQLDataAccess
    {
        public static string GetConnectionString() {

                 return "Server=5.39.113.7;port=3306;user=CORONA;password=K?5zrU2~GmsV;database=bier_db;";
               //return "Server=84.86.167.197;port=3306;user=temp;password=K?5zrU2~GmsV;database=bier_db;";
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                return con.Query<T>(sql).ToList();
            }
        }

        // word gebruikt als je één item terug wilt krijgen
        public static T LoadFirstData<T>(string sql)
        {
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                try
                {
                    return con.Query<T>(sql).FirstOrDefault();
                }
                catch(InvalidCastException e)
                {
                    return default;
                }
            }
        }

        public static void SaveData<T>(string sql, T data)
        {
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Execute(sql, data);
            }
        }

        public static void DeleteData(string sql)
        {
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Execute(sql);
            }
        }
    }
}
