using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your sentence.");
            string str = Console.ReadLine();

            //reversing
            char[] newArray = str.ToCharArray();
            Array.Reverse(newArray);
            string reverse = new string(newArray);

            Console.WriteLine("The reverse is: " + reverse);

            //check equality
            bool result = reverse.Equals(str);
            if (result == true)
            {
                Console.WriteLine("YES! it is a palindome.");
            }
            else
            {
                Console.WriteLine("No! it is not a palindome.");
            }
            Console.ReadLine();
        }
    }
}
