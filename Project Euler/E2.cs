using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS.Project_Euler
{
    internal class E2
    {
        public static int[] FibSequence(int size = 10)
        {
            int[] result = new int[size];
            result[0] = 0;
            result[1] = 1;
            for (int i = 2; i < size; i++)
            {
                result[i] = result[i - 1] + result[i - 2];
            }
            return result;
        }
    }
}
