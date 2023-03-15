using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee objEmployee = new employee();

            Console.WriteLine("Enter Your Working Hours: ");
            int hours = int.Parse(Console.ReadLine());


            Console.WriteLine(objEmployee.salaryCalculation(hours));

            Console.ReadKey();
        }
    }
}
