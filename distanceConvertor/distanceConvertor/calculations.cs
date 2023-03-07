using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distanceConvertor
{
    internal class calculations
    {
        public void convertor()
        {
            float km,ans;

            Console.WriteLine("Enter the KM Value : ");
            km = float.Parse(Console.ReadLine());

            ans = km * 100000;

            Console.WriteLine("CM Value is : " + km * 100 * 1000);
        }
    }
}
