using System.Data;
using Microsoft.Data.Sqlite;

namespace MarketStokTakip.Database
{
    public class SQLiteDbConnection                          // Sqlite bağlantısı için kullanılan sınıf.
    {
        private static string yol = "Data Source=MarketStok.db";

        public static SqliteConnection BaglantiGetir()
        {
            var con = new SqliteConnection(yol);
            con.Open();
            return con;
        }
    }
}
