using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Introduction
{
    internal class employee
    {
        public int age;
        public string name;
        public void EmpInfo()
        {
            Console.WriteLine("What is you name?");
            name = Convert.ToString(Console.ReadLine());
            

            Console.WriteLine("What is you age?");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your name is : " + name);
            Console.WriteLine("Your age is : " + age);

            Console.ReadLine();
        }
    }
}
