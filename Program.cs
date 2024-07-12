using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Question 1
            /*int[] arr = { 1, 2, 3, 3, 4 };
            int[] arr1 = arr.Distinct().ToArray();
            Array.Sort(arr1);
            foreach (int i in arr1)
            {
                Console.WriteLine(i); // Displaying arr1


            }
            Console.ReadLine();*/


            // Question 2
            /*List<int> arr = new List<int>();
            arr.Add(1); arr.Add(2); arr.Add(8); arr.Add(9);
            foreach (int i in arr)
            {
                Console.WriteLine(i); // Displaying list


            }
            Console.WriteLine("Largest number is " + arr.Max());
            arr.Remove(arr.Max());
            foreach (int i in arr)
            {
                Console.WriteLine(i); // displaying updated list


            }
            Console.WriteLine("Second largest number is " + arr.Max());
            Console.Read();*/


            // Question 3
            /*int[] arr = { 1, 9, 8, 4, 0, 0, 2, 7, 0, 6, 0, 9 };
            int n = arr.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
                if (arr[i] != 0)
                {

                    arr[count++] = arr[i];
                    Console.WriteLine(arr[i]);
                }
            Console.ReadLine();*/

            // Question 4
            /* string name = "swiss";
             char[] name1 = new char[name.Length];
             for (int e = 0; e < name.Length; e++)
             {
                 name1[e] = name[e];
             }

             for (int i = 0; i < name.Length; i++)
             {
                 int d = 1;
                 for (int j = i+1; j < name.Length; j++)

                 {
                     if (name1[i] == name1[j] )
                     {
                         d = 0;
                         break;

                     }

                 }
                 if (d == 1)
                 {
                     Console.WriteLine("Non repeating is " + name1[i]);
                     break;
                 }

             }*/



            //Question 5
            /*int[] arr = { 1, 3, 5, 7 };
            int n = 4;
            int[] arr1 = { 2, 4, 6, 8 };
            int m = arr1.Length;
            int c = n + m ;
            int[] arr2 = new int[c];
            int a = 0, b = 0;
            while (a < n)
            {
                arr2[a] = arr[a++];
            }
            while (b < m)
            {
                arr2[a++] = arr1[b++];
            }
            Array.Sort(arr2);
            foreach (int i in arr2)
            {
                Console.WriteLine(i); // Displaying list


            }*/


            // Question 6

           /* Console.WriteLine("enter numbers with spaces ");
            string[] number1 = Console.ReadLine().Split(" ");
            int[] number = new int[number1.Length];
            for (int i = 0; i < number1.Length; i++)
            {
                number[i] = Convert.ToInt32(number1[i]);
            }
            int minimum = number.Min();
            int maximum = number.Max();
            int actual = 0;
            int expected = 0;
            for (int j = 0; j < number1.Length; j++)
            {
                actual = actual + number[j];
            }
            for (int k = minimum; k <= maximum; k++)
            {
                expected = expected + k;
            }

            Console.WriteLine("The missing number in the array is " + (expected-actual));*/

            // Question 7
            /*int rem, temp, sum = 0;
            Console.Write("Enter Your Number To Check ");
            int number = Convert.ToInt32(Console.ReadLine());
            temp = number;
            while (number > 0)
            {                                     // it is valid only for 3 digit number
                rem = number % 10;                // For 4 digit number we have to multiply rem 4 times with itself
                sum = sum + (rem * rem * rem);   // For generalize program we can use a loop, multiply rem with itself
                number = number / 10;            

            }

            if (temp == sum)
                Console.WriteLine(temp + " Is A Armstrong Number");
            else
                Console.WriteLine(temp + " Is Not A Armstrong Number");
            Console.ReadLine();*/


            // Question 8
            /*string str1 = "Ammaar";
            string str2 = "Ammara";
            char[] prefixes = new char[str1.Length];
            for (int i = 0; i < str1.Length; i++)
            {
                prefixes[i] = str1[i];
            }
            char[] prefixes1= new char[str2.Length];
            for (int j = 0; j < str2.Length; j++)
            {
                prefixes1[j] = str2[j];
            }
            int max1 = int.Min(str1.Length, str2.Length);
            int counter = 0;
            for (int k = 0; k < max1; k++)
            {
                if (prefixes1[k] == prefixes[k])
                {
                    counter++;  
                }
                else
                {
                    break;
                }
            }
            for (int t = 0; t < counter; t++)
            {
                Console.WriteLine(prefixes[t]);
            }*/




            // Question 9
            /*int a = 0, b = 1, c = 0;
            Console.WriteLine("Enter the number > 0 or 1");// Number is the limit of sequence
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                c = a + b;
                Console.WriteLine(c);// as fibonacci starts from 0,1,...
                a = b;
                b = c;
            }
            Console.ReadLine();*/


            // Question 10
            Console.Write("\nEnter five numbers separated by spaces:");
            string[] numbersInput = Console.ReadLine().Split(' ');
            int[] numbersArray = new int[numbersInput.Length];
            for (int i = 0; i < numbersInput.Length; i++)
            {
                numbersArray[i] = Convert.ToInt32(numbersInput[i]);
            }
            Console.Write("\nArray elements: ");
            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.Write(numbersArray[i] + " ");
            }
            //int[] numbersArray = {-3 ,- 8, 9, 9, 5}; // Explicit input
            int sum = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                sum = sum + numbersArray[i];
            }
            Console.WriteLine("\nthe sum is " + sum);// sum of all entries
            Console.WriteLine("the average is " + sum / numbersArray.Length);// average of all entries

            for (int j = 0; j < numbersArray.Length; j++)
            {
                if (numbersArray[j] > 0)
                {
                    Console.WriteLine("Positive integer");
                }
                else
                {
                    Console.WriteLine("Negative integer");
                }
            }
            



        }
    }
}