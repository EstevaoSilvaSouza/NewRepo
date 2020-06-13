using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB
{
    public class Conexao
    {
        public static string server = "localhost";
        public static string database = "web_session";
        public static string user = "root";
        public static string password = "Tilindo@14";

        private static string conectionString = $@"Server={server}; Database={database};Uid={user};Pwd={password};SslMode=None;";

        public static MySqlConnection Connection = new MySqlConnection (conectionString);

        public static void Conectar() { 
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public static void Desconectar()
        {
            if(Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }

        }


    }
}