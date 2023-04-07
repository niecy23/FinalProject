// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        string connString = config.GetConnectionString("DefaultConnection");
        IDbConnection conn = new MySqlConnection(connString);





    }
}
