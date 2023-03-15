using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeEligibility
{
    internal class Validation
    {
        public void eligibility (int age)
        {
            if (age > 21)
            {
                Console.WriteLine("Eligible");
            }
            else
                Console.WriteLine("Not Eligible");
        }
    }
}
