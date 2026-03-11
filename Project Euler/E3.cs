using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS.Project_Euler
{
    internal class E3
    {
        public static long LargestPrimeFactor(long number)
        {
            long largestFactor = 0;
            for (long i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    largestFactor = i;
                    number /= i;
                }
            }
            return largestFactor;
        }
    }
}
