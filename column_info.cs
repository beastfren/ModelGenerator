using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenClass
{
    public class column_info
    {
        public string name { get;set; }
        public string DATA_TYPE { get;set; }
        public int CHARACTER_MAXIMUM_LENGTH { get;set; }


        public static async Task<List<column_info>>  Get_Table(myCon con,  string DBName)
        {
            List<column_info> data;
            if (con.dbType == DB_Type.SQL)
            {

                var q = "SELECT TABLE_NAME name FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_CATALOG= @value";
                var p = new { value = DBName };

                var dictionary = new Dictionary<string, object>
                {
                    { "@value", DBName }
                };

                var d = new DynamicParameters(dictionary);
                data = await myDB.GetList<column_info>(con.Con(), q, d);
            }
            else
            {
                var q = "SELECT TABLE_NAME name FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA= @value";

                var dictionary = new Dictionary<string, object>
                {
                    { "@value", DBName }
                };
                var d = new DynamicParameters(dictionary);

                data = await myDB.GetListMySQL<column_info>(con.Con(), q, d);
            }

            if (data != null)
            {
                return data;
            }
            else
            {
                return new List<column_info>();
            }

        }

        public static async Task<List<column_info>> Get_Columns(myCon con, string table)
        {

            List<column_info> data;
            if (con.dbType == DB_Type.SQL)
            {
                var q = "SELECT  COLUMN_NAME name, DATA_TYPE,CHARACTER_MAXIMUM_LENGTH   FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME= @value";
                var dictionary = new Dictionary<string, object>
                {
                    { "@value", table }
                };

                var d = new DynamicParameters(dictionary);

                data = await myDB.GetList<column_info>(con.Con(), q, d);
            }
            else
            {
                var q = "SELECT  COLUMN_NAME name, DATA_TYPE,CHARACTER_MAXIMUM_LENGTH   FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME= @value and TABLE_SCHEMA = @value2";
                var dictionary = new Dictionary<string, object>
                {
                    { "@value", table },
                    { "@value2", con.Database}

                };

                var d = new DynamicParameters(dictionary);
                data = await myDB.GetListMySQL<column_info>(con.Con(), q,d);
            }

            if (data != null)
            {
                return data;
            }
            else
            {
                return new List<column_info>();
            }

        }




    }
}
