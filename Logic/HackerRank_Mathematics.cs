using NoteBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.Logic
{
    public class HackerRank_Mathematics : IHackerRank_Mathematics
    {


        //*******************************************************************************************************************************************
        // Hacker Rank Mathematics Methods - Easy
        //*******************************************************************************************************************************************


        // -------------------------------------------------------------------------------------------------------------
        // challange 1 Start
        public void FindThePoint()
        {
            try
            {
                Random random = new Random();
                int[] randomNumber = new int[4];

                for (int i = 0; i < 4; i++)
                {
                    randomNumber[i] = random.Next(0, 11);
                }

                Console.WriteLine($"Here are the starting points P = ( {randomNumber[0]} , {randomNumber[1]} ) and Q = ( {randomNumber[2]}, {randomNumber[3]} )");
                int Px = randomNumber[0], Py = randomNumber[1], Qx = randomNumber[2], Qy = randomNumber[3];
                int Rx, Ry;
                int DiffX = Qx - Px;
                int DiffY = Qy - Py;
                Console.WriteLine(" ");
                Console.WriteLine($"We`ll now get the diffrence between points Q and P");
                Console.WriteLine($"Difference: ( {DiffX} , {DiffY} )");
                Console.WriteLine(" ");
                Console.WriteLine($"Point R will equal Q + the difference");

                Rx = Qx + DiffX;
                Ry = Qy + DiffY;
                Console.WriteLine($"Rx: {Rx}, Ry: {Ry}");
                Console.WriteLine($"Point R: ( {Rx} , {Ry} )");
                Console.Read();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error !!!", ex);
            }
        }
        // challange 1 End
        // -------------------------------------------------------------------------------------------------------------


        // -------------------------------------------------------------------------------------------------------------
        // challange 2 Start
        public void maximumDraws()
        {
            Random random = new Random();
            int numberSockColor = random.Next(1, 12);
            Console.WriteLine($"Number of colored socks: {numberSockColor} ");
            Console.WriteLine($"Number of socks to pull is: {numberSockColor + 1} to guarantee success.");
            Console.Read();
        }
        // challange 2 End
        // -------------------------------------------------------------------------------------------------------------


        // -------------------------------------------------------------------------------------------------------------
        // challange 3 Start
        public void handshake()
        {
            Random random = new Random();
            int numberPeople = random.Next(0, 11);
            int[] handShakes = new int[numberPeople];
            for (int i = 0; i < numberPeople; i++)
            {
                handShakes[i] = i;
            }
            Console.WriteLine($"Number of People: {numberPeople}");
            Console.WriteLine($"Number of Handshakes: {handShakes.Sum()}");
            Console.Read();
        }
        // challange 3 End
        // -------------------------------------------------------------------------------------------------------------


        // -------------------------------------------------------------------------------------------------------------
        // challange 4 Start
        public void lowestTriangle()
        {
            Random random = new Random();
            int baseVal = random.Next(5, 20);
            int areaVal = random.Next(50, 100);
            int height = (int)Math.Ceiling(2.0 * areaVal / baseVal);


            Console.WriteLine($"Base of triangle: {baseVal}, Area of triangle: {areaVal}");
            Console.WriteLine("");
            Console.WriteLine($"Height: {height}");
            Console.Read();
        }
        // challange 4 End
        // -------------------------------------------------------------------------------------------------------------


        // -------------------------------------------------------------------------------------------------------------
        // challange 5 Start
        public void gameWithCells()
        {
            Random random = new Random();
            int rows = random.Next(1, 11), colums = random.Next(1, 11);
            int rowsAdd = (rows + 1) / 2, columsAdd = (colums + 1) / 2;
            int cells = rowsAdd * columsAdd;

            Console.WriteLine($"Number of Rows: {rows}, Number of Colums: {colums}");
            Console.WriteLine("");
            Console.WriteLine($"Number of supply drops: {cells}");
            Console.Read();
        }
        // challange 5 End
        // -------------------------------------------------------------------------------------------------------------


        // -------------------------------------------------------------------------------------------------------------
        // challange 6 Start
        public void primeCount()
        {
            Random random = new Random();
            int number = random.Next(1, 101);
            int count = 0;
            for (int i = 0; i < number; i++)
            {
                bool checker = primeCheck(i);
                if (checker)
                {
                    count++;
                }

            }
            Console.WriteLine($"Input Number: {number}");
            Console.WriteLine("");
            Console.WriteLine($"Amount of Prime Numbers: {count}");
            Console.Read();
        }

        private bool primeCheck(int item)
        {
            if (item <= 1)
            {
                return false;
            }
            if (item <= 3)
            {
                return true;
            }
            if (item % 2 == 0 || item % 3 == 0)
            {
                return false;
            }
            for (int i = 5; i * i <= item; i += 6)
            {
                if (item % i == 0 || item % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
        // challange 6 End
        // -------------------------------------------------------------------------------------------------------------


        // -------------------------------------------------------------------------------------------------------------
        // challange 7 Start
        public void connectingTowns()
        {
            int[] routes = new int[1234567];
            int totalRoutes = 1;

            foreach (int route in routes)
            {
                totalRoutes = (totalRoutes * route) % 1234567;
            }

            Console.WriteLine($"total routes: {totalRoutes}");
            Console.Read();
        }
        // challange 7 End
        // -------------------------------------------------------------------------------------------------------------


        // -------------------------------------------------------------------------------------------------------------
        // challange 8 Start
        public void PaperPieces()
        {
            Random random = new Random();
            int n = random.Next(1, 11), m = random.Next(1, 11);
            int cuts = (n - 1) + (m - 1);
            Console.WriteLine($"Number of Rows: {n}, Number of colums {m}");
            Console.WriteLine("");
            for (int i = 0; i < n; i++)
            {
                Console.Write("|");
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" X |");
                }
                Console.WriteLine();

                Console.Write("+");
                for (int j = 0; j < m; j++)
                {
                    Console.Write("---+");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine($"Min number of Cuts {cuts}");
            Console.Read();
        }
        // challange 8 End
        // -------------------------------------------------------------------------------------------------------------


        //*******************************************************************************************************************************************
        // Hacker Rank Mathematics Methods - Medium
        //*******************************************************************************************************************************************


        public void summingSeries()
        {
            Random random = new Random();
            long n = random.Next(500000, 1000000);
            const int MOD = 1000000007;
            long sum = 0;

            for (int i = 0; i < n; i++)
            {
                long Tn = ((long)i * i) - (i - 1) * i;
                sum = (sum + Tn) % MOD;
            }
            Console.WriteLine($"Sn = {n}");
            Console.WriteLine($"Sum = {sum}");
            Console.Read();

        }
    }
}
