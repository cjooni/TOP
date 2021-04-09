using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP.lib
{
    public class CMySql
    {
        public MySqlConnection Connection;
        private string ConnString;

        public CMySql()
        {

        }

        public MySqlConnection Connect()
        {
            ConnString = String.Format("Database={0};Data Source={1}; User Id={2}; Password={3}", "TOPS", "localhost", "UTOPS", "kdaccho1");
            Connection = new MySqlConnection(ConnString);

            Connection.Open();
            return Connection;
        }


    }
}
