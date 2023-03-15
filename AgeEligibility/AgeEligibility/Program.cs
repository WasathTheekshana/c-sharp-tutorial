using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeEligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Validation objValidation = new Validation();
            UserInput objUserInput = new UserInput();

            objValidation.eligibility(objUserInput.userInput());

            Console.ReadLine();

        }
    }
}
