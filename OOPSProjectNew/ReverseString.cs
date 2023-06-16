using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProjectNew
{
    internal class ReverseString
    {
        public void StringReverse()
        {
            string string1;
            string reverseString = "";
            Console.WriteLine("Enter the String: ");
            string1 = Console.ReadLine();

            string1 = string1.ToLower();

            for (int i = string1.Length - 1; i >= 0; i--)
            {
                reverseString = reverseString + string1[i];
            }

            Console.WriteLine("Reverse string is: " + reverseString);
        }
    }

}

