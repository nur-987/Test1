using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your sentence to reverse.");
            string input = Console.ReadLine();
            string[] newStr = input.Split(' ');

            Stack<string> myStack = new Stack<string>();

            foreach (string word in newStr)
            {
                myStack.Push(word);
            }
            foreach (string item in myStack)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();

        }
    }
}
