using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutidimentional_Array___2D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 4];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.Write("\n");
            }

            Console.ReadLine();

        }
    }
}
