using System.Diagnostics;

namespace LearnCS
{
    internal class Optimization
    {
        static List<int> elements = [];
        static List<int> list1 = [];
        static List<int> list2 = [];
        public static void ForVsForeach()
        {
            for (int i = 0; i < 20000000; i++)
            {
                elements.Add(i);
            }
            Stopwatch sw = new();
            sw.Start();
            for (int i = 0; i < elements.Count; i++)
            {
                list1.Add(i);
            }
            sw.Stop();

            Console.WriteLine($"For loop: {sw.ElapsedMilliseconds} ms");
            sw.Restart();
            foreach (var item in elements)
            {
                list2.Add(item);
            }
            sw.Stop();
            Console.WriteLine($"Foreach loop: {sw.ElapsedMilliseconds} ms");
        }
    }
}
