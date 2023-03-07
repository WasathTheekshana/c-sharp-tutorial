using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumCalculator
{
    internal class calculator
    {
        public int sum()
        {

            int ans;

            Console.WriteLine("Enter Number One : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number Two : ");
            int num2 = int.Parse(Console.ReadLine());

            ans = num1 + num2;

            return ans;
            
        }
       
    }
}
