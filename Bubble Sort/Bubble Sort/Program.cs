using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int temp = arr[0];
            int flag = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the number");
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i+1; j<arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        flag = 1;
                    }

                    if (flag == 0) break;

                }
               
            }

            for (int i = 0; i < arr.Length;i++)
            {
                Console.Write(" " + arr[i]);
            }

            Console.ReadLine();
        }
    }
}
