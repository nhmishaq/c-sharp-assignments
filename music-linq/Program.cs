using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace MUSIC-LINQ
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
            var mt_vernon_artist = from person in Artists
                                   where person.Hometown == "Mount Vernon"
                                   select new { person.ArtistName, person.Age };
            foreach (var artist in mt_vernon_artist){
                Console.WriteLine($"Mount Vernon: {artist.ArtistName}" + "-" $"{artist.Age}");
            }
            //Who is the youngest artist in our collection of artists?
            // from person in Artists
            
            // Where person.age 
            
            //Display all artists with 'William' somewhere in their real name

            //Display the 3 oldest artist from Atlanta

            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
