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
            // Text Book Methods
            ITextbook _textbook = new TextBook();
            //_textbook.Celsius();
            //_textbook.SumOfArray();

            // Hacker Rank Methods
            IHackerRank _hackerrank = new HackerRank();
            _hackerrank.timeConversion();
            //_hackerrank.miniMaxSum();
            //_hackerrank.plusMinus();
            //_hackerrank.TextToMaths();
            //_hackerrank.AgeClassified();
            //_hackerrank.FuzzBuzz();
        }
    }
}
