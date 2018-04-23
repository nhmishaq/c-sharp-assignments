using System;

namespace firstAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Loop that prints all values from 1-255
            // for (int i = 1; i <= 255; i++){
            //     Console.WriteLine(i);
            // }


            // Create a new loop that prints all values from 1-100 
            //that are divisible by 3 or 5, but not both
            // for (int i = 1 ; i <= 100; i++){
            //     if (i % 3 == 0 && i % 5 != 0){
            //         Console.WriteLine(i);
            //     }
            //     else if (i % 3 != 0 && i % 5 == 0){
            //         Console.WriteLine(i);
            //     }
            //     else {
            //         continue;
            //     }
            // }
            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" 
            // for multiples of 5, and "FizzBuzz" for numbers that are multiples of 
            // both 3 and 5
            // for (int i = 1 ; i <= 100; i++){
            //     if (i % 3 == 0 && i % 5 != 0){
            //         Console.WriteLine(i + "Fizz");
            //     }
            //     else if (i % 3 != 0 && i % 5 == 0){
            //         Console.WriteLine(i + "Buzz");
            //     }
            //     else if  (i % 3 == 0 && i % 5 == 0) {
            //         Console.WriteLine("FizzBuzz");;
            //     }
            //     else {
            //         continue;
            //     }
            // }
            // (Optional) Generate 10 random values and output the respective word, 
            //in relation to step three, for the generated values
            Random rand = new Random ();
            for (int i = 1; i <= 10 ; i++){
                if (rand.Next(1,100) % 3 == 0 && rand.Next(1,100) % 5 != 0){
                    Console.WriteLine(rand.Next(1,100) + "Fizz");
                }
                else if (rand.Next(1,100) % 3 != 0 && rand.Next(1,100) % 5 == 0){
                    Console.WriteLine(rand.Next(1,100) + "Buzz");
                }
                else {
                    continue;
                }
            }
        }
    }
}
