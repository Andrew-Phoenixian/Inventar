using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventar_2._0.Classes
{
    internal class DatabaseHelper
    {

        public static MySqlCommand executeStoredProcedure(string ProcedureName, object[] Arguments)
        {
            using (MySqlConnection conn = getConnection())
            using (MySqlCommand cmd = conn.CreateCommand())
            {
                MySqlParameter param = new MySqlParameter();
                conn.Open();

                cmd.CommandText = ProcedureName;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                foreach (object[] o in Arguments)
                {
                    cmd.Parameters.Add((string)o[0], (MySqlDbType)o[1]);
                    cmd.Parameters[(string)o[0]].Direction = (ParameterDirection)o[2];
                }

                cmd.ExecuteNonQuery();

                return cmd;
            };
        }

        public static MySqlConnection getConnection()
        {
            return new MySqlConnection(string.Concat(new string[]
            {
                "SERVER=",
                "80.202.130.125",
                ",",
                "3306",
                ";DATABASE=",
                "inventardb",
                ";UID=",
                ProgramData.Username,
                ";PASSWORD=",
                ProgramData.Password
            }));
        }
    }
}
