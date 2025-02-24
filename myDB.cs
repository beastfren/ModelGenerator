using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using System.Linq.Expressions;
using MySqlConnector;

namespace GenClass
{
    public class myDB
    {
        //public static readonly String Con = @"Data Source = 10.0.253.60\PIS; Initial Catalog = PKI_HRIS; User ID = sa; Password = Windows7;TrustServerCertificate=True ";

        public static async Task<List<T>> GetList<T>( string con, string q, DynamicParameters? parameters = null)
        {
            using (var connection = new SqlConnection(con))
            {
                connection.Open();
                //var r = await connection.QueryAsync<T>(q, parameters);
                if (parameters != null)
                {
                    var r = await connection.QueryAsync<T>(q, parameters);
                    return r.ToList();
                }
                else
                {
                    var r = await connection.QueryAsync<T>(q);
                    return r.ToList();
                }


            }

        }

        public static async Task<List<T>> GetListMySQL<T>(string con, string q, DynamicParameters? parameters = null)
        {
            using (var connection = new MySqlConnection(con))
            {
                connection.Open();
                //var r = await connection.QueryAsync<T>(q, parameters);
                if (parameters != null)
                {
                    var r = await connection.QueryAsync<T>(q, parameters);
                    return r.ToList();
                }
                else
                {
                    var r = await connection.QueryAsync<T>(q);
                    return r.ToList();
                }


            }

        }
    }

    public class myCon
    {
        public DB_Type dbType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }

        public  myCon(DB_Type dB_Type, string _username, string _password, string _server, string _database) {
            dbType = dB_Type;
            Username = _username;
            Password = _password;
            Server = _server;
            Database = _database;
        }

        public string Con()
        {
            if (dbType == DB_Type.SQL )
            {
                return $@"Data Source = {Server}; Initial Catalog = {Database}; User ID = {Username}; Password = {Password};TrustServerCertificate=True ";
            }
            else
            {
                string connectionString = $@"Server={Server}; User ID={Username}; Password={Password}; Database={Database}";

                return connectionString;
            }
        }
    }


    public enum DB_Type
    { 
        SQL,
        mySQL
    }

}
