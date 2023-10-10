using NoteBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.Logic
{
    public class TextBook : ITextbook
    {
        public void Celsius()
        {
            // Get Name and convert Fahrenheit to Celsius
            Console.WriteLine("Enter a value here >>");
            string text = Console.ReadLine();
            Console.WriteLine("Hello " + text);
            Console.WriteLine("Enter Fahrenheit >>");
            int fahr = int.Parse(Console.ReadLine().ToString());
            double celsius = (fahr - 32) * (5.0 / 9.0);
            Console.WriteLine("celsius " + celsius);
            Console.Read();
        }
        public void SumOfArray()
        {
            // Chat gpt challange
            // Problem: You are given an array of integers. Your task is to write a function that calculates the sum of all the elements in the array.
            Random random = new Random();
            int Number = random.Next(10, 35);
            int[] arrayInt = new int[Number];
            Console.WriteLine($"Random Number Generated : {Number}");
            Console.WriteLine($"-----------------------------------");
            Console.WriteLine($"Array");
            Console.WriteLine($"-----------------------------------");
            for (int i = 0; i < Number; i++)
            {
                arrayInt[i] = i;
                Console.WriteLine($"Array: {i}");
            }
            
            Console.WriteLine($"Sum of array : {arrayInt.Sum()}");
            Console.Read();
        }
    }
}
