using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenClass
{
    public  class dbase_info
    {
        public string Name { get; set; }
        public string State_desc { get; set; }

        //public string database { get; set; }

        public static async Task<List<dbase_info>> Get(myCon con)
        {
            List<dbase_info> data;
            if (con.dbType == DB_Type.SQL)
            {
                var q = "SELECT * FROM master.sys.databases where state_desc = 'online'";
                //var p = new { table = tableName, test = "test" };
                data = await myDB.GetList<dbase_info>(con.Con(), q);
            }
            else
            {
                var q = "SELECT distinct TABLE_SCHEMA Name  FROM information_schema.COLUMNS";
                //var p = new { table = tableName, test = "test" };
                data = await myDB.GetListMySQL<dbase_info>(con.Con(), q);
            }


            if (data != null)
            {
                return data;
            }
            else
            {
                return new List<dbase_info>();
            }

        }
    }
}
