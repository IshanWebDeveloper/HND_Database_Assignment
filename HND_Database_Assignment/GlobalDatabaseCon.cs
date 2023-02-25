using System.Data.SqlClient;

namespace HND_Database_Assignment
{
    public static class GlobalDatabaseCon
    {
        private static readonly string con_string = "Data Source=ISHAN-PC\\SQLEXPRESS;Initial Catalog=film_production;Integrated Security=true";

        public static SqlConnection con { get; set; }


        public static void intitializeDBCon()
        {
            con = new SqlConnection(con_string);
            con.Open();
        }

        public static void closeDBCon()
        {
            con.Close();
        }
    }
}
