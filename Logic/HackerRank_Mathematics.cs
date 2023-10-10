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
                Console.WriteLine($"Well now get the diffrence between points Q and P");
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

    }
}
