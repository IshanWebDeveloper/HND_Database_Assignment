using System.Data.SqlClient;

namespace HND_Database_Assignment
{
    public static class GlobalDatabaseCon
    {
        private static readonly string con_string = "Data Source=ISHAN-PC\\SQLEXPRESS;Initial Catalog=film_production;Integrated Security=true";

        private static SqlConnection Con { get; set; }


        public static void IntitializeDBCon()
        {
            Con = new SqlConnection(con_string);
            Con.Open();
        }

        public static void CloseDBCon()
        {
            Con.Close();
        }

        public static SqlConnection GetConObj()
        {
            return Con;
        }

    }
}
