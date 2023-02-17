using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int ope;

            

            Console.WriteLine("Enter the number one");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number two");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Press a number \n 1 - Sum \n 2 - Substract \n 3 - Multiplication \n 4 - Divide \n");
            ope = int.Parse(Console.ReadLine());

            if (ope == 1)
            {
                Console.WriteLine("Sum is " + (num2 + num1));
            }

            else if (ope == 2)
            {
                Console.WriteLine("Subtraction is " + (num2 - num1));
            }

            else if(ope == 3)
            {
                Console.WriteLine("Multiplication is " + (num2 * num1));
            }

            else if(ope == 4)
            {
                Console.WriteLine("Divition is " + (num2 / num1));
            }

            Console.ReadLine();
            
        }
    }
}
