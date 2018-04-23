using System;

namespace c__assignments
{
    class Program
    {
        static void Main(string[] args)
        {
// Create a Loop that prints all values from 1-255
            // int start = 1;
            // int end = 255;
            // for (int i = start; i <= end; i++)
            // {
            //     Console.WriteLine(i);
            // }

//Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            // for (int i = 1; i <= 100; i++){
            //     if (i % 3 == 0 && i%5 == 0){
            //         continue;
            //     } else if (i%3==0 || i%5==0){
            //         Console.WriteLine(i);
            //     } else{
            //         continue;
            //     }
            // }


// Modify the previous loop to print "Fizz" for multiples of 3, 
// "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples 
// of both 3 and 5
            // for (int i = 1; i <= 100; i++){
            //     if (i % 3 == 0 && i%5 == 0){
            //         Console.WriteLine(i + " FizzBuzz");
            //     } else if (i%3==0 && i%5!=0){
            //         Console.WriteLine(i + " Fizz");
            //     } else if (i%3!=0 && i%5==0){
            //         Console.WriteLine(i + " Buzz");
            //     }
            //     else{
            //         continue;
            //     }
            // }
// (Optional) If you used modulus in the last step, try doing the same without using it. 
// Vice-versa for those who didn't!
            // for (int i = 1; i <= 100; i++){
            //     if (i / 3 == 0 && i/5 == 0){
            //         Console.WriteLine(i + " FizzBuzz");
            //     } else if (i/3==0 && i/5!=0){
            //         Console.WriteLine(i + " Fizz");
            //     } else if (i/3!=0 && i/5==0){
            //         Console.WriteLine(i + " Buzz");
            //     }
            //     else{
            //         continue;
            //     }
            // }
//(Optional) Generate 10 random values and output the respective word, 
//in relation to step three, for the generated values
    Random rand = new Random();
    for(int i = 1; i <= 100; i++)
    {
        if (i % 3 == 0 && i%5 == 0){
            Console.WriteLine(i + " FizzBuzz");
        } else if (i%3==0 && i%5!=0){
            Console.WriteLine(i + " Fizz");
        } else if (i%3!=0 && i%5==0){
            Console.WriteLine(i + " Buzz");
        }
        else{
            continue;
        }
                
        Console.WriteLine(rand.Next(i));
    }


        }
    }
}
