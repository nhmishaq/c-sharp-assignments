using System;
using DbConnection;

namespace simpleCRUDII
{
    class Program
    {
        // DbConnector.Query("Some query string expecting data returned");
        // DbConnector.Execute("Some query with no expected return");

        //Read function
        public static void Read(){
            Console.WriteLine("Here are all the users in the Database");
            string query = $"SELECT * FROM Users";
            var result = DbConnector.Query(query);
            Console.WriteLine("************************************************************************");
            foreach(var user in result) {
                Console.WriteLine("ID: " + user["idUsers"] + " First Name: " + user["FirstName"] + " Last Name: " + user["LastName"] + " Favorite Number: " + user["FavoriteNumber"]);
            }
            Console.WriteLine("************************************************************************");
        }

        //Create function
        public static void Create(){
            Console.WriteLine("Enter First Name: ");
            string first = Console.ReadLine();
            
            Console.WriteLine("Enter Last Name: ");
            string last = Console.ReadLine();

            Console.WriteLine("Enter Favorite Number: ");
            int favNum = Console.Read();

            string query = $"INSERT INTO Users (FirstName, LastName, FavoriteNumber) VALUES (\"{first}\", \"{last}\", \"{favNum}\")";
            DbConnector.Execute(query);
            Read();

        }

        //Update function
        public static void Update(){
            Read();
            Console.WriteLine("Enter the id of the user you wish to update: ");
            string id = Console.ReadLine();

            Console.WriteLine("Enter new first: ");
            string firstNew = Console.ReadLine();

            Console.WriteLine("Enter new last: ");
            string lastNew = Console.ReadLine();

            Console.WriteLine("Enter new num: ");
            string favNumNew = Console.ReadLine();

            string query = $"UPDATE Users SET FirstName=\"{firstNew}\", LastName =\"{lastNew}\", FavoriteNumber = \"{favNumNew}\" WHERE idUsers = {id}";

            DbConnector.Execute(query);
            Read();

        }
        
        //Destroy function
        public static void Delete(){                  
            Console.WriteLine("Enter ID of user to delete: ");
            string delId = Console.ReadLine();
            string query = $"DELETE from Users WHERE idUsers = {delId}";
            DbConnector.Execute(query);
            Read();
        }

        static void Main(string[] args)
        {   
            // Read();
            // Create();
            // Update();
            // Delete();
        }
    }
}
