using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program1
    {
        static void Main()
        {
            int[] A = new int[3];
            A[0] = 100;
            A[1] = 200;
            A[2] = 300;

            int i = 1;
            A[i] = 1000; //A[1] = 1000

            //i = 10;
            //A[i] = 1000; //give exception A[10] = 1000

            int[] B = new int[4] { 1, 2, 3, 0 };
            B[3] = 100;

            i = 1;
            int[] BB = new int[] { i, i++, i++, i++ };

            //Console.WriteLine(BB[0]);
            //Console.WriteLine(BB[1]);
            //Console.WriteLine(BB[2]);
            //Console.WriteLine(BB[3]);

            i = 4;
            int[] C = new int[i]; // C is an array of 4 int.

            i = 5; //size of C doesn't change.

            int[] D = new int[20];
            D = B; // this is not a copy operation
            Console.WriteLine(D[2]); // 3
            D[2] = 300;
            Console.WriteLine(D[2]); // 300
            Console.WriteLine(B[2]); // is it 3 or 300? the answer is 300

            int[] E;
            E = B;
            Console.WriteLine(E[2]); // 3
            E[2] = 300;
            Console.WriteLine(E[2]); // 300
            Console.WriteLine(B[2]); // is it 3 or 300? the answer is 300

            int[] F = new int[4];
            Array.Copy(B,F, B.Length);
            Console.WriteLine(F[1]); //2
            F[1] = 200;
            Console.WriteLine(F[1]);
            Console.WriteLine(B[1]);




        }
    }
}
