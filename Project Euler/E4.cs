using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS.Project_Euler
{
    internal class E4
    {
        public static int FindLargestProduct()
        {
            int largest = 0;
            return largest;
        }
    

        private static int makePalindrome(int firstHalf)
        {
            return int.Parse(firstHalf.ToString() + new string([.. firstHalf.ToString().Reverse()]));
        }
    }
}
