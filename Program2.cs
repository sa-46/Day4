using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program2
    {
        static void Main()
        {
            int[] A = new int[] { 100, 98, 86, 23, 34, 56, 78, 91, 21, 3, 5 };

            for (int green=0; green <= A.Length - 2; green++)
            {
                for (int red=green+1;red <=A.Length -1; red++)
                {
                    if (A[red] < A[green])
                    {
                        //swap
                        int temp = A[red];
                        A[red] = A[green];
                        A[green] = temp;
                    }
                }
            }


            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("{0} ", A[i]);
            }
        }
    }
}
