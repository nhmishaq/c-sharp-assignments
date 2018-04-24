using System;
using System.Collections.Generic;

namespace boxingII
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Object> buddy = new List<Object>();
            buddy.Add(7);
            buddy.Add(28);
            buddy.Add(-1);
            buddy.Add(true);
            buddy.Add("chair");
            for (int i = 0; i<buddy.Count; i++){
                if (buddy[i] is int){
                    Console.WriteLine(buddy[i]);
                }
                if (buddy[i] is string){
                    Console.WriteLine(buddy[i]);
                }
                if (buddy[i] is bool){
                    Console.WriteLine(buddy[i]);
                }
            }
            
            
        }
    }
}
