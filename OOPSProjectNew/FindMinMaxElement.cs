using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProjectNew
{
    internal class FindMinMaxElement
    {
        public void MinimumMaximumElement()
        {
            int[] array = { 5, 8, 3, 9, 2, 7, 1, 6, 4 };

            int min = array[0]; // Assume the first element as the minimum
            int max = array[0]; // Assume the first element as the maximum
                                // Find the minimum and maximum elements in the array
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Minimum element: " + min);
            Console.WriteLine("Maximum element: " + max);
        }
    }
}

