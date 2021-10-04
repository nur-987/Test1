using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry = new int[] { 3, 0, 0, 2, 0, 4 };

            //Find the 1st largest and 2nd largest number in the array

            int largest = -1, secnd = -1, indxLargest = -1, indxSecnd = -1;
            for (int i = 0; i < arry.Length; i++)
            {
                if (arry[i] > largest)
                {
                    secnd = largest;
                    indxSecnd = indxLargest;

                    largest = arry[i];
                    indxLargest = i;
                }
                else if (arry[i] > secnd)
                {
                    secnd = arry[i];
                    indxSecnd = i;
                }
            }

            //calculate water

            int water = 0;
            if (indxSecnd > indxLargest)
            //tallest block isnt infront
            {
                for (int i = 0; i < indxLargest; i++)
                {
                    water += (largest - arry[i]);
                    //water at that spot, minus its block
                }
                //2nd for loop for the sub pool
                for (int i = indxLargest + 1; i < indxSecnd; i++)
                {
                    water += (secnd - arry[i]);
                }
            }
            else
            //tallest blk is infront
            {
                for (int i = 0; i < indxLargest; i++)
                {
                    water += (secnd - arry[i]);
                    //water at that spot, minus its block
                }
                //2nd for loop for the sub pool
                for (int i = indxSecnd + 1; i < indxLargest; i++)
                {
                    water += (secnd - arry[i]);
                }
            }

            Console.WriteLine("Total amount of water: " + water);
            Console.ReadLine();

        }
    }
}

/*Wrong calculation
 * somehwere in the 2 
 * for loops
 */
