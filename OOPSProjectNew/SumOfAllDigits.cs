using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSProjectNew
{
    internal class SumOfAllDigits
    {
        public void Sum()
        {

            int number = 52345;
            int sum = SumOfDigits(number);
            Console.WriteLine("Sum of digits: " + sum);



        }
        static int SumOfDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }

            return sum;
        }
    }
}

