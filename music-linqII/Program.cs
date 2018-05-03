using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            // var mtVernonArtist = from guy in Artists where guy.Hometown == "Mount Vernon" select new {guy.ArtistName , guy.Age };
            // foreach (var buddy in mtVernonArtist){
            //     Console.WriteLine(buddy);
            // }
            //Who is the youngest artist in our collection of artists?
            // var youngList = from youngin in Artists orderby youngin.Age ascending select new {youngin.ArtistName, youngin.Age};
            // foreach (var findingYoungest in youngList){
            //     Console.WriteLine(findingYoungest);
            //     break;
            // }
            // Console.WriteLine(youngList.First());

            //Display all artists with 'William' somewhere in their real name
            // var will = from bill in Artists 
            //            where bill.RealName.Contains("William") 
            //            select new {bill.ArtistName, bill.RealName, bill.Age};
            // foreach (var buddy in will){
            //     Console.WriteLine(buddy);
            // }
            
            //Display the 3 oldest artist from Atlanta
            // var oldHeads = from geizer in Artists orderby geizer.Age descending
            //                 select new {geizer.ArtistName, geizer.Age, geizer.RealName};

            // foreach (var buddah in oldHeads.Take(3)){
            // Console.WriteLine(buddah);
            // }

            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
