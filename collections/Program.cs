using System;
using System.Collections.Generic;


namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array to hold integer values 0 through 9
            // int[] basicArr = new int[10];
            // for (int i = 0; i < basicArr.Length; i++){
            //     basicArr[i] = i;
            //     Console.Write(basicArr[i]);

            // }
            

            //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = new string[4] {"Tim", "Martin", "Nikki", "Sara"};
            for (int i = 0; i<names.Length; i++){
                Console.WriteLine(names[i]);
            }
            
            //With the values 1-10, use code to generate a multiplication table like the one below.
            // for (int i = 1; i <= 10; i++){
            //     for (int j = 1; j<= 10; j++){
            //         Console.Write(i*j + ",");
            //     }
            //     Console.Write(']');
            //     Console.WriteLine("");
            //     Console.Write('[');
            // }
        
            //Create a list of Ice Cream flavors that holds at least 5 
            //different flavors (feel free to add more than 5!)

            List<string> ice_cream = new List<string>();
            ice_cream.Add("Pistachio");
            ice_cream.Add("chocolate rasberry");
            ice_cream.Add("cookies and creme");
            ice_cream.Add("hazelnut");
            ice_cream.Add("mango");
            // Console.WriteLine("We currently know of {0} ice creme flavors.", ice_cream.Count);
            // Console.WriteLine(ice_cream[2]);
            // ice_cream.RemoveAt(2);
            // Console.WriteLine("We now know of {0} ice creme flavors.", ice_cream.Count);


            // Dictionary<string,string> extendedArray = new Dictionary<string,string>();
            // foreach (KeyValuePair<string,string> entry in extendedArray){
            //     extendedArray.Add(ice_cream[2], null);
            //     Console.WriteLine(entry.Key + "-" + entry.Value);
            // }
            
            Dictionary<string,string> fav_ice_cream = new Dictionary<string,string>();
            Random rand = new Random();
            for(int val = 0; val < 4; val++){            
               fav_ice_cream[names[val]] = ice_cream[rand.Next(1,4)];
                Console.WriteLine(fav_ice_cream[names[val]]);
                Console.WriteLine("fav_ice_cream" + fav_ice_cream["fav_ice_cream"]);
            }
            
        
        }
    }
}
