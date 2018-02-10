using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program3
    {
        static void Main()
        {
            //declare a 3 dimensional array
            int[,,] A = new int[,,] //4 x 3 x 2 
            {
                {
                    {1,2 }, {3,4 }, {9,10 }
                },
                {
                    {5,6 }, {7,8 }, {11,12 }
                },
                {
                    {11,12 }, {13,14 }, {9,10 }
                },
                {
                    {15,16 }, {17,18 }, {11,12 }
                }
            };

            Console.WriteLine(A[3, 2, 0]);

            int[,,] B = new int[4,3,2];
        }
    }
}
