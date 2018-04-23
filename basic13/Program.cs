using System;
using System.Collections.Generic;

namespace basic13
{
    public class Program
    {
        //Print 1 - 255
        public static void print_1_to_255(){
            for (int i = 1; i <= 255; i++){
            Console.Write(i + " ");
            }
        }
        
        //Print odd numbers between 1-255
        public static void print_odds_1_to_255(){
            for (int i = 1; i <= 255; i++){
                if (i%2 == 1){
                    Console.Write(i + " ");
                }
            }
        }
        
        //Print Sum
        public static void print_sum(){
            int sum=0;
            for (int i = 0; i <= 255; i++){
                sum += i;
                Console.WriteLine("New Number: " + i + " Sum: " + sum);
            }
        }
        
        //Iterating through an Array
        public static void iteratingArray(int[] arr){
            for (int i = 0; i < arr.Length; i++){
                Console.WriteLine(arr[i]);
            }
        }
        public static void find_Max(int[] arr){
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++){
                if (arr[i]> max){
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }

        //Get Average
        public static void get_average(int[] arr){
            int sum = arr[0];
            for (int i = 0; i < arr.Length; i++){
                sum += arr[i];
            }
            int average = sum/arr.Length;
            Console.WriteLine(average);
        }

        //Array with Odd Numbers
        public static void odds_array(){
            int[] arr = new int[255]; 
            for (int i = 1; i <= 255; i++){
                if (i%2 == 1){
                    arr[i] = i;
                    Console.WriteLine(arr[i]);
                }
            }
            Console.WriteLine(arr);
        }
        
        //Greater than Y
        public static void Greater_than_Y(int[] arr, int x){
            int count = 0;
            for (int i = 1; i < arr.Length; i++){
                if (arr[i] > x){
                    count ++;
                }
            }
            Console.WriteLine(count);
        }

        //Square the Values
        public static void square_the_vals(int[] arr){
            for (int i = 0; i < arr.Length; i++){
                arr[i] *= arr[i];
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine(arr);
        }
        //Eliminate Negative Numbers
        public static void eliminate_negs(int[] arr){
            for (int i = 0; i < arr.Length; i++){
                if (arr[i] < 0){
                    arr[i] = 0;
                    Console.WriteLine(arr[i]);
                }
            }
            
        }
        //Min, Max, and Average
        public static void min_max_avg(int[] arr){
            int sum = arr[0];
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++){
                sum += arr[i];
                if (arr[i] > max){
                    max = arr[i];
                }
                if (arr[i] < min){
                    min = arr[i];
                }
            }
            int average = sum/arr.Length;
            Console.WriteLine(average);
            Console.WriteLine(max);
            Console.WriteLine(min);
        }

        //Shifting the values in an array
        public static void shift_arr(int[] arr){
            int temp=arr[1];
            for (int i = 0; i < arr.Length+1; i++){
                temp = arr[i+1];
                arr[i] = arr[temp];
                Console.WriteLine(arr[i]);   
            }
            arr[arr.Length - 1] = 0;          
        }
        //Number to String -> this didn't work...
        public static void num_to_string(object[] arr){
            object BoxedData = arr;
            for (int i = 0; i < arr.Length - 1; i++){
                if (int(arr[i]) < 0){
                    arr[i] = "Dojo"; 
                }            
            }
        }

        static void Main(string[] args)
        {
            int[] arraaay = {6, 1, 11, -88, 4, 0};
            //print_1_to_255();
            //print_odds_1_to_255();
            // print_sum();
            // iteratingArray(arraaay);
            // find_Max(arraaay);
            // get_average(arraaay);
            // odds_array();
            // Greater_than_Y(arraaay, 1);
            // square_the_vals(arraaay);
            // eliminate_negs(arraaay);
            // min_max_avg(arraaay);
            // shift_arr(arraaay);
            num_to_string(arraaay);



        }
    }
}
