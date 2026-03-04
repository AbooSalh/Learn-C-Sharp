using System.Numerics;

namespace LearnCS.Algorithms
{
    /// <summary>
    /// Utilities for binomial coefficients (combinations).
    /// How many ways to choose <c>k</c> items from <c>n</c> items (order does not matter).
    /// Uses the multiplicative formula to compute n choose k:
    /// result = Product_{i=1..k} (n - k + i) / i
    /// This implementation returns a <see cref="BigInteger"/> to avoid overflow for large inputs.
    /// </summary>
    internal static class NChooseK
    {
        static int NumberOfCombinations(int n, int k)
        {
            if (k == 0 || k == n)
                return 1;
            else
            {
                return NumberOfCombinations(n - 1, k - 1) + NumberOfCombinations(n - 1, k);
            }

        }
    }
}
