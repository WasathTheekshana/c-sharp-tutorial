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


            Console.WriteLine("Enter Number 1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 1: ");
            int n2 = int.Parse(Console.ReadLine());

            objCalculator.sum(n1, n2);

            Console.ReadLine();
        }
    }
}
