using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_data_to_arrray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = new int[5];
            int min = numbers[0];
            int max = numbers[0];
            
            for(int i = 0; i<numbers.Length; i++)
            {
                Console.WriteLine("Enter number to index" + i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            /*for (int i = 0; i<numbers.Length; i++)
            {
                Console.WriteLine(" " + numbers[i]);
            }*/

            for (int i = 0; i<numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                else if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine(min);
            Console.WriteLine(max); 

            Console.ReadLine();
        }
    }
}
