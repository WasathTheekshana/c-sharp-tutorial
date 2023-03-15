using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeEligibility
{
    internal class UserInput
    {
        public int userInput()
        {
            Console.WriteLine("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            return age;
        }
    }
}
