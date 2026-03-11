using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS.Project_Euler
{
    internal class E1
    {
        public static int MultiplesOf3And5()
        {
            //I'll start you out with a variable named sum initialized to 0
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            //add code here to solve the problem

            //keep this at the bottom of the function so it returns the sum you calculated
            return sum;
        }
    }
}
