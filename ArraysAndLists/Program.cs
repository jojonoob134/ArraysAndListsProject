using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] oneToTen = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            int num;
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            foreach (int i in oneToTen)
            {
                num = i % 2;
                if (num == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("this are even numbers");
            Console.WriteLine();
            foreach (int i in even)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("this are odd numbers");
            foreach (int i in odd)
            {
                Console.WriteLine(i);
            }
        }
    }
}
