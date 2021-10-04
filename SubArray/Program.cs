using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the sum of sub elements");
            myArray();

            Console.ReadLine();
        }

        public static void myArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int i = 15;

            for (int j = 0; j < array.Length; j++)
            {
                int subArraySum = 0;

                for (int x = j; x < array.Length; x++)
                {
                    subArraySum = subArraySum + array[x];
                    if (subArraySum == i)
                    {
                        Console.WriteLine("found array at index: " + (j + 1) + " " + (x + 1));
                    }
                }
            }
        }
    }
}
