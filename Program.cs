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


            //Question 5
            /*int[] arr = {1, 3, 5, 7 };
            int n = 4;
            int[] arr1 = { 2, 4, 6, 8 };
            int m = arr1.Length;
            int c = n + m - 1;
            int[] arr2 = new int[c];
            int a = 0, b = 0; 
            while (a < n)
            {
                arr2[c++] = arr[n++];
            }
            while (b < m)
            {
                arr2[c++] = arr1[m++];
            }
            Array.Sort(arr2);
            foreach (int i in arr2)
            {
                Console.WriteLine(i); // Displaying list


            }*/


            // Question 7
            /*int rem, temp, sum = 0;
            Console.Write("Enter Your Number To Check ");
            int number = Convert.ToInt32(Console.ReadLine());
            temp = number;
            while (number > 0)
            {                                     // it is valid only for 3 digit number
                rem = number % 10;                // For 4 digit number we have to multiply rem 4 times with itself
                sum = sum + (rem * rem * rem);   // For generalize program we can use a loop multiply rem with itself
                number = number / 10;            

            }

            if (temp == sum)
                Console.WriteLine(temp + " Is A Armstrong Number");
            else
                Console.WriteLine(temp + " Is Not A Armstrong Number");
            Console.ReadLine();*/


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
            /*Console.Write("\nEnter five numbers separated by spaces:");
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

            string[] Array1 = Console.ReadLine().Split(' ');
            int[] Array2 = new int[Array1.Length];
            //int[] Array2 = {-3 ,- 8, 9, 9, 5}; // Explicit input
            int sum = 0;
            for (int i = 0; i < Array2.Length; i++)
            {
                sum = sum + Array2[i];
            }
            Console.WriteLine("the sum is" + sum);// sum of all entries
            Console.WriteLine("the average is" + sum / Array2.Length);// average of all entries

            for (int j = 0; j < Array2.Length; j++)
            {
                if (Array2[j] > 0)
                {
                    Console.WriteLine("Positive integer");
                }
                else
                {
                    Console.WriteLine("Negative integer");
                }
            }
            Console.ReadLine();*/



        }
    }
}
