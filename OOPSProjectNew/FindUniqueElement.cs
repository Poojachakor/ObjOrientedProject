using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProjectNew
{
    internal class FindUniqueElement
    {
        public void CheckUniqueElement()
        {
            int[] arr1 = { 9, 24, 34, 24, 3, 15, 26, 32, 88 };
            Console.WriteLine("Unique Elements in array are: ");

            for (int i = 0; i < arr1.Length; i++)
            {
                bool flag = false;
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j])
                    {

                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    Console.WriteLine(arr1[i]);
                }
            }
        }
    }
}

