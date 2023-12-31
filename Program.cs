﻿using NoteBook.Interfaces;
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
            // Hacker Rank Mathematics Methods - https://www.hackerrank.com/delonjarrod1307 - Medium
            //-------------------------------------------------------------------------------------------------------------------------------------------


            // 1) Summing Series - https://www.hackerrank.com/challenges/summing-the-n-series/problem?isFullScreen=true
            //_hackerrank_mathematics.summingSeries();





            //-------------------------------------------------------------------------------------------------------------------------------------------
            // Hacker Rank Mathematics Methods - https://www.hackerrank.com/delonjarrod1307 - Easy
            //-------------------------------------------------------------------------------------------------------------------------------------------


            // 1) Find the point - https://www.hackerrank.com/challenges/find-point/problem?isFullScreen=true
            //_hackerrank_mathematics.FindThePoint();

            // 2) Find the point - https://www.hackerrank.com/challenges/maximum-draws/problem?isFullScreen=true
            //_hackerrank_mathematics.maximumDraws();

            // 3) Hand shake - https://www.hackerrank.com/challenges/handshake/problem?isFullScreen=true
            //_hackerrank_mathematics.handshake();

            // 4) Lowest Triangle - https://www.hackerrank.com/challenges/lowest-triangle/problem?isFullScreen=true
            //_hackerrank_mathematics.lowestTriangle();

            // 5) Game With Cells - https://www.hackerrank.com/challenges/game-with-cells/problem?isFullScreen=true
            //_hackerrank_mathematics.gameWithCells();

            // 6) Prime Count - https://www.hackerrank.com/challenges/leonardo-and-prime/problem?isFullScreen=true
            //_hackerrank_mathematics.primeCount()            

            // 7) Connecting Towns - https://www.hackerrank.com/challenges/connecting-towns/problem?isFullScreen=true
            //_hackerrank_mathematics.connectingTowns();

            // 8) Paper Pieces - https://www.hackerrank.com/challenges/p1-paper-cutting/problem?isFullScreen=true
            //_hackerrank_mathematics.PaperPieces();





            //-------------------------------------------------------------------------------------------------------------------------------------------
            // Hacker Rank Methods - https://www.hackerrank.com/delonjarrod1307
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
            // Text Book Methods
            //-------------------------------------------------------------------------------------------------------------------------------------------


            //_textbook.Celsius();
            //_textbook.SumOfArray();
            // Hacker Rank Methods





        }
    }
}
