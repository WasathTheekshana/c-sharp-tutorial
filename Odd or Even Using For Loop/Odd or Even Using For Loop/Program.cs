using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even_Using_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inp;
            int oddC = 0;
            int evenC = 0;

            for(int i = 0; i <10; i++)
            {
                Console.WriteLine("Enter the number");
                inp = int.Parse(Console.ReadLine());

                if(inp%2==0)
                {
                    evenC++;
                }

                else
                {
                    oddC++;
                }
            }

            Console.WriteLine("Odd Count is " + oddC);
            Console.WriteLine("Even Count is " + evenC);

            Console.ReadLine();
        }
    }
}
