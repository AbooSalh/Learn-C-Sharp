using LearnCS.Algorithms.ShortestPath;

namespace LearnCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lee.Run(new int[][] {
                new int[] { 1, 0, 1, 1, 1 },
                new int[] { 1, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 0, 1 },
                new int[] { 0, 0, 0, 0, 1 },
                new int[] { 1, 1, 1, 1, 1 }
            }, 0, 0, 4, 4);
        }
    }
}