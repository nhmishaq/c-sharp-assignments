using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using DbConnection;

namespace simple_crud
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter first name: ");
            string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            int fnum = Console.Read();

            DbConnector.Query("SELECT idUsers, FirstName, LastName, FavoriteNumber FROM Users");
            DbConnector.Execute ("INSERT INTO Users(FirstName, LastName, FavoriteNumber) VALUES ('{fname}', '{lname}', fnum)");
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();

            host.Run();

            
            
        }
    }
}
