using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 25, 41, 10, 78, 68, 36, 89, 37 };
            int min = numbers[0] ;
            int max = numbers[0];

            for (int i = 0; i < numbers.Length; i++) 
            { 
                    if (numbers[i] < min) 
                    { 
                        min= numbers[i];
                    }
                    else if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
            }

            Console.WriteLine(min);
            Console.WriteLine(max);

            Console.ReadLine();
        }


    }
}
