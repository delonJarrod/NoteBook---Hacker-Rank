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
            int height =  (int)Math.Ceiling(2.0 * areaVal / baseVal);


            Console.WriteLine($"Base of triangle: {baseVal}, Area of triangle: {areaVal}");
            Console.WriteLine("");
            Console.WriteLine($"Height: {height}");
            Console.Read();
        }
        // challange 4 End
        // -------------------------------------------------------------------------------------------------------------


        // -------------------------------------------------------------------------------------------------------------
        // challange 4 Start
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
        // challange 4 End
        // -------------------------------------------------------------------------------------------------------------
    }
}
