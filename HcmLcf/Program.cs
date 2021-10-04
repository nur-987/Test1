using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HcmLcf
{
    /// <summary>
    /// 1)	Given two numbers find the GCF (Greatest Common Factor) 
    /// and LCM (Lowest Common Multiple) of the two numbers
    /// </summary>
    class Program
    {
        public static int hcf;
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Find HCF   2) Find LCM");
            int res = Int32.Parse(Console.ReadLine());
            if (res == 1)
            {
                Console.WriteLine("Lets find th HCF of two numbers.");
                Console.WriteLine("What is your first number");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("What is your second number");
                int num2 = Int32.Parse(Console.ReadLine());
                FindingHcf(num1, num2);

            }
            else if (res == 2)
            {
                Console.WriteLine("Lets find th LCM of two numbers.");
                Console.WriteLine("What is your first number");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("What is your second number");
                int num2 = Int32.Parse(Console.ReadLine());
                FindingLCM(num1, num2);
            }
            else
            {
                Console.WriteLine("Wrong response. Try again.");
            }

        }

        public static void FindingHcf(int a, int b)
        {
            int j = (a < b) ? a : b;
            for (int i = 1; i <= j; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    hcf = i;
                }
            }
            Console.WriteLine("The HCF of the two numbers are: " + hcf);
            Console.ReadLine();
        }

        public static void FindingLCM(int a, int b)
        {
            int x, y;
            int lcm;

            if (a > b)
            {
                x = a;
                y = b;
            }
            else
            {
                x = b;
                y = a;
            }
            for (int i = 1; i <= y; i++)
            {
                if ((x * i) % y == 0)
                {
                    lcm = x * i;
                }
            }
            lcm = y;
            Console.WriteLine("LCM of the 2 numbers is: " + lcm);
            Console.ReadLine();
        }
    }
}
