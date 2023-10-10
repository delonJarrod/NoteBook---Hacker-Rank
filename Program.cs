using NoteBook.Interfaces;
using NoteBook.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITextbook _textbook = new TextBook();
            IHackerRank _hackerrank = new HackerRank();
            IHackerRank_Mathematics _hackerrank_mathematics = new HackerRank_Mathematics();



            //-------------------------------------------------------------------------------------------------------------------------------------------
            // Hacker Rank Methods
            //-------------------------------------------------------------------------------------------------------------------------------------------


            // 1) Convert text to numbers and conduct maths with the text
            //_hackerrank.TextToMaths();

            // 2) Convert time 07:05:45PM to military time 
            //_hackerrank.timeConversion();

            // 3) Get the heighest and lowest number in array
            // _hackerrank.miniMaxSum();

            // 4) Calculate the ratios of its elements that are positive, negative, and zero. 
            //_hackerrank.plusMinus();

            //5) Check age and display output of category
            //_hackerrank.AgeClassified();

            //6) Fuzz Buzz challange
            //_hackerrank.FuzzBuzz();





            //-------------------------------------------------------------------------------------------------------------------------------------------
            // Hacker Rank Mathematics Methods
            //-------------------------------------------------------------------------------------------------------------------------------------------


            // 1) Find the point - https://www.hackerrank.com/challenges/find-point/problem?isFullScreen=true
            _hackerrank_mathematics.FindThePoint();









            //-------------------------------------------------------------------------------------------------------------------------------------------
            // Text Book Methods
            //-------------------------------------------------------------------------------------------------------------------------------------------


            //_textbook.Celsius();
            //_textbook.SumOfArray();
            // Hacker Rank Methods

        }
    }
}
