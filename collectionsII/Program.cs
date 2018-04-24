using System;
using System.Collections.Generic;

namespace collectionsII
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three Basic Arrays
            //      Create an array to hold integer values 0 through 9
            //      Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            //      Create an array of length 10 that alternates between true and false values, starting with true
            // int[] johnny = new int[10];
            // for (int i = 0; i < johnny.Length; i++){
            //     johnny[i] = i;
            //     Console.WriteLine(johnny[i]);
            // }
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            // for (int i = 0; i<names.Length;i++){
            //     Console.WriteLine(names[i]);
            // }
            // bool container = true;
            // bool[] coolArray = new bool[10];
            // for (int i = 0; i < coolArray.Length; i++){
            //     coolArray[i] = container;
            //     container = !container;
            // }
            // foreach (var item in coolArray){
            //     Console.WriteLine(item);
            // }

            // Multiplication Table
            // With the values 1-10, use code to generate a multiplication table like the one below.
            // int[,] multTable = new int[10,10];
            // Console.WriteLine(multTable);
            // for (int i = 1; i <= 10; i++){
            //     foreach(int innerJ in multTable){
            //         multTable[][i] = innerJ;
            //         Console.WriteLine(multTable);
            //     }
            // }
            
            // List of Flavors
            // Create a list of Ice Cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            // Output the length of this list after building it
            // Output the third flavor in the list, then remove this value.
            // Output the new length of the list (Note it should just be one less~)
            // List<string> iceCream = new List<string>();
            // iceCream.Add("pistachio");
            // iceCream.Add("mango");
            // iceCream.Add("peach");
            // iceCream.Add("apricot");
            // iceCream.Add("blueberry");

            // Console.WriteLine(iceCream.Count);
            // Console.WriteLine(iceCream[2]);
            // iceCream.RemoveAt(2);
            // Console.WriteLine(iceCream.Count);
            // for (int i = 0; i < iceCream.Count; i++){
            //     Console.WriteLine(iceCream[i]);
            // }
            
            // Dictionary<string,string> faves = new Dictionary<string,string>();
            // for (int i = 0 ; i< 4; i++){
            //     faves.Add(names[i], iceCream[i]);
            // }
            // foreach(KeyValuePair<string,string>bud in faves){
            //     Console.WriteLine(bud.Key + ": " + bud.Value);
            // }
        }
    }
}
