using System;
using System.Data.SqlClient;
namespace Task25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection(@"Server=BEXININSIRINNOT\SQLEXPRESS;Database=Task15;Trusted_Connection=True");

            string sql = "insert Into Stadiums values ('Stadium 1', 10, 11), ('Stadium 2', 15, 11), ('Stadium 3', 20, 11)";
            conn.Open();
            SqlCommand sqlCMD = new SqlCommand(sql, conn);
            sqlCMD.ExecuteNonQuery();
            conn.Close();

        }
    }
}
