using System;

namespace basic13II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array3;
            array3 = new int[] {-1,32,10,-5,-7,-9};
            shift_arr(array3);
        }
            //Print 1-255
            //Write a program (sets of instructions) that would print all the numbers from 1 to 255.
            public static void print1255(){
                for (int i = 1; i <=255; i++){
                    Console.WriteLine(i);
                }
            }
            //Print odd numbers between 1-255
            //Write a program (sets of instructions) that would print all the odd numbers from 1 to 255.
            public static void printOdds(){
                for (int i = 1; i <=255; i++){
                    if (i%2 == 1){
                        Console.WriteLine(i);
                    }
                }
            }
            //Print Sum
            //Write a program that would print the numbers from 0 to 255 but this time, 
            //it would also print the sum of the numbers that have been printed so far. 
            public static void printSum(){
                int sum = 0;
                for (int i = 1; i <=255; i++){
                    Console.Write("Number: " + i);
                    sum += i;
                    Console.WriteLine(" Sum: " + sum);
        
                }
            }

            // Iterating through an Array
            // Given an array X, say [1,3,5,7,9,13], write a program that would iterate 
            //through each member of the array and print each value on the screen. 
            // Being able to loop through each member of the array is extremely important.
            public static void printArray(int[] arrIn){
                for (int i = 0; i < arrIn.Length; i++){
                    Console.WriteLine(arrIn[i]);
                }
            }

            // Find Max
            // Write a program (sets of instructions) that takes any array and prints the 
            // maximum value in the array. Your program should also work with a given array 
            // that has all negative numbers (e.g. [-3, -5, -7]), or even a mix of positive 
            // numbers, negative numbers and zero.
            public static void findMax(int[] arrIn){
                int max = arrIn[0];
                for (int i = 0; i < arrIn.Length; i++){
                    if (arrIn[i] > max){
                        max = arrIn[i];
                    }
                }
                Console.WriteLine(max);
            }

            // Get Average
            // Write a program that takes an array, and prints the AVERAGE of the values in the 
            // array. For example for an array [2, 10, 3], your program should print an average 
            // of 5. Again, make sure you come up with a simple base case and write instructions 
            // to solve that base case first, then test your instructions for other complicated 
            // cases. You can use a count function with this assignment.

            public static void getAvg(int[] arrIn){
                int sum = 0;
                for (int i = 0; i < arrIn.Length; i++){
                    sum += arrIn[i];
                }
                Console.WriteLine("Average: " + sum/arrIn.Length);
                
            }
            // Array with Odd Numbers
            // Write a program that creates an array 'y' that contains all the odd numbers 
            // between 1 to 255. When the program is done, 'y' should have the value of 
            // [1, 3, 5, 7, ... 255].
            public static void arrayOdds(){
                int[] oddArr = new int[256/2];
                for (int i = 1; i <=256; i++){
                    if (i%2 == 1){
                        for (int j =0; j<= oddArr.Length; j++){
                            oddArr[j] = i;
                            // i++; 
                        }
                     
                        // Console.WriteLine(i);
                    }
                }
                for (int k=0; k <oddArr.Length; k++){
                    Console.WriteLine(oddArr[k]);
                }
                
            }

            // Greater than Y
            // Write a program that takes an array and returns the number of values in that 
            // array whose value is greater than a given value y. For example, if 
            // array = [1, 3, 5, 7] and y = 3. After your program is run it will print 2 
            // (since there are two values in the array that are greater than 3).
            public static int greaterThanY (int[] array, int y){
                int count = 0;
                for (int i = 0; i < array.Length; i++){
                    if (array[i] > y){
                        count++;
                    }
                }
                Console.WriteLine(count);
                return count;
            }
            // Square the Values
            // Given any array x, say [1, 5, 10, -2], create an algorithm (sets of instructions) 
            // that multiplies each value in the array by itself. When the program is done,
            // the array x should have values that have been squared, say [1, 25, 100, 4].
            public static void squares(int[] arrBob){
                for (int i = 0; i < arrBob.Length; i++){
                    arrBob[i] *= arrBob[i];
                }
                for (int i = 0; i < arrBob.Length; i++){
                    Console.WriteLine(arrBob[i]);
                }
            }

            // Eliminate Negative Numbers
            // Given any array x, say [1, 5, 10, -2], create an algorithm that replaces any 
            // negative number with the value of 0. When the program is done, x should have 
            // no negative values, say [1, 5, 10, 0].
            public static void noNegs(int[] arrBen){
                for (int i = 0; i < arrBen.Length; i++){
                    if (arrBen[i] < 0){
                        arrBen[i] = 0;
                    }
                }
                for (int i = 0; i < arrBen.Length; i++){
                    Console.WriteLine(arrBen[i]);
                }
            }

            // Min, Max, and Average
            // Given any array x, say [1, 5, 10, -2], create an algorithm that prints 
            // the maximum number in the array, the minimum value in the array, and the 
            // average of the values in the array.
            public static void minMaxAvg(int[] arrIn){
                int sum = 0;
                int min = arrIn[0];
                int max = arrIn[0];
                for (int i = 0; i < arrIn.Length; i++){
                    sum += arrIn[i];
                    if (arrIn[i] < min){
                        min = arrIn[i];
                    }
                    if (arrIn[i] > max){
                        max = arrIn[i];
                    }
                }
                Console.WriteLine("Average: " + sum/arrIn.Length);
                Console.WriteLine("Minimum: " + min);
                Console.WriteLine("Miximum: " + max);
                
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

        }
    }

