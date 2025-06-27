using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace SuperFlightsApp.Utils
{
    class DBSetup
    {
        private static IDbConnection? instance = null;


        public static IDbConnection GetConnection(string connectionString)
        {
            if (instance == null || instance.State == ConnectionState.Closed)
            {
                instance = GetNewConnection(connectionString);
                instance.Open();
            }
            return instance;
        }

        private static IDbConnection GetNewConnection(string connectionString)
        {

            return new SQLiteConnection(connectionString);

        }
    }
}
