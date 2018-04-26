using System;
using System.Collections.Generic;

namespace puzzlesII
{
    class Program
    {
        static void Main(string[] args)
        {
            // randomArray();
            // TossCoin();
            // TossMultipleCoins(32);
            names();
        }
        // Random Array
        // Create a function called RandomArray() that returns an integer array

        // Place 10 random integer values between 5-25 into the array
        // Print the min and max values of the array
        // Print the sum of all the values
        public static void randomArray(){
            int[] myArr = new int[10];
            Random rand = new Random();
            int sum = 0;
            for (int i = 0; i < myArr.Length; i++){
                myArr[i] = rand.Next(5,25);
                sum += myArr[i];
            }
            int min = myArr[0];
            int max = myArr[0];
            for (int j = 0; j < myArr.Length; j++){
                if (myArr[j] < min) {
                    min = myArr[j];
                }
                if (myArr[j] > max) {
                    max = myArr[j];
                }
            }
            for (int i = 0; i < myArr.Length; i++){
                Console.WriteLine(myArr[i]);
            }
            Console.WriteLine("Min: " + min + " Max: " + max + " Sum: " + sum);
        }

        // Coin Flip
        // Create a function called TossCoin() that returns a string

        // Have the function print "Tossing a Coin!"
        // Randomize a coin toss with a result signaling either side of the coin 
        // Have the function print either "Heads" or "Tails"
        // Finally, return the result
        public static string TossCoin(){
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int magicNumber = rand.Next(1,100);
            string result = "";
            if (magicNumber % 2 == 1){
                Console.WriteLine("Heads!");
                result = "heads";
            }
            if (magicNumber % 2 == 0){
                Console.WriteLine("Tails!");
                result = "tails";
            }
            return result;
        }
        // Create another function called TossMultipleCoins(int num) that returns a Double
        // Have the function call the tossCoin function multiple times based on num value
        // Have the function return a Double that reflects the ratio of head toss to total toss
        public static double TossMultipleCoins(int num){
            string result;
            int headsCount = 0;
            int tailsCount = 0;
            double ratio = 0.0;
            while (num > 0){
                result = TossCoin();
                if (result == "heads"){
                    headsCount++;
                }
                if (result == "tails"){
                    tailsCount++;
                }
                num--;
            }
            if (headsCount > tailsCount){
                ratio = (double)headsCount / (double)tailsCount;
            }
            if (tailsCount > headsCount){
                ratio = (double)tailsCount / (double)headsCount;
            }
            Console.WriteLine("Heads Count: " + headsCount + " Tails Count: " + tailsCount + " Ratio: " + ratio);
            return ratio;
        }
        // Names
        // Build a function Names that returns an array of strings
        // Create an array with the values: Todd, Tiffany, Charlie, Geneva, Sydney
        // Shuffle the array and print the values in the new order
        // Return an array that only includes names longer than 5 characters
        public static string[] names(){
            string[] nameArr = new string[5] {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random();
            int fiveCount = 0;
            for (int i = 0; i < nameArr.Length; i++){
                nameArr[i] = nameArr[rand.Next(i,nameArr.Length)];
            }
            for (int j = 0; j < nameArr.Length; j++){
                if (nameArr[j].Length > 5){
                    fiveCount++;
                }
            }
            string[] resizedNameArr = new string[fiveCount];
            for (int k = 0; k < resizedNameArr.Length; k++){
                if (nameArr[k].Length > 5){
                    resizedNameArr[k] = nameArr[k];
                }
                Console.WriteLine(resizedNameArr[k]);
            }
            return resizedNameArr;
        }

    }
}
