using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HND_Database_Assignment
{
    public static class GlobalDatabaseCon
    {
        private static readonly string con_string = "Data Source=ISHAN-PC\\SQLEXPRESS;Initial Catalog=film_production;Integrated Security=true";
        private static string con_stringWithSQLAuth;

        private static SqlConnection con { get; set; }



        public static void IntitializeDBCon()
        {
            con = new SqlConnection(con_string);
            con.Open();
        }
        public static void IntializeDBCon(string userName, string password)
        {
            try
            {
                if (userName.Length > 0 & password.Length > 0)
                {
                    con_stringWithSQLAuth = $"Data Source=ISHAN-PC;Initial Catalog=databaseName;User ID={userName};Password={password}";
                    con = new SqlConnection(con_stringWithSQLAuth);
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public static void CloseDBCon()
        {
            con.Close();
        }

        public static SqlConnection GetConObj()
        {
            return con;
        }

        public static string GetConnectionString()
        {
            return con_string;
        }

    }
}
