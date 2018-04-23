using System;
using System.Collections.Generic;
namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
           //NOTE TO SELF: THIS DID NOT WORK!!! FIX IT EVENTUALLY..?LOL
            List<Object> empty_list =  new List<Object>();
                empty_list.Add(7);
                empty_list.Add(28);
                empty_list.Add(-1);
                empty_list.Add(true);
                empty_list.Add("chair");    
                int sum;
                for (int i = 0; i < 5; i++){
                    Console.WriteLine(empty_list[i]);
                
                if (empty_list[i] is int){
                    sum += empty_list[i];
                } 
                } 
                Console.WriteLine(sum);    
                 
            }

    }
}
