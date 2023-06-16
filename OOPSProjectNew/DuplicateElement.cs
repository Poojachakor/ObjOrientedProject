using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProjectNew
{
    internal class DuplicateElement
    {
        public int count = 0;


        public void CheckDuplicateItem()
        {

            int[] array = { 5, 3, 8, 6, 7, 9, 5, 4, 6, 2, 4, 6, 7 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine(array[i]);
                        count++;
                    }
                }
            }
            Console.WriteLine("Duplicate Number of elemts are: " + count);
        }
    }


}

