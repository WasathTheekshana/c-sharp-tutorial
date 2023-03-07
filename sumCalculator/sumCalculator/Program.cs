using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator objCalculator = new calculator();


            Console.WriteLine("\nSum is " + objCalculator.sum());

            Console.ReadLine();
        }
    }
}
