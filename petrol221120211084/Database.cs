using System;
using System.Data.SqlClient;

public class Database
{
    private SqlConnection connection;

    public Database()
    {
        // Burada, veritabanı bağlantı stringi yer alacak
        connection = new SqlConnection("Server=localhost;Database=PetrolOtomasyon;Integrated Security=true;");
    }

    public SqlConnection GetConnection()
    {
        return connection;
    }
}
