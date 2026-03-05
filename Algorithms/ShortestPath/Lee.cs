namespace LearnCS.Algorithms.ShortestPath
{
    internal class Lee
    {
        public class Node
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int distance { get; set; }
            public Node(int x, int y, int distance)
            {
                X = x;
                Y = y;
                this.distance = distance;
            }
        }

        private static int[] row = [-1, 0, 0, 1];
        private static int[] col = [0, -1, 1, 0];

        private static bool IsValid(int[][] matrix, bool[][] visited, int row, int col)
        {
            return (row >= 0) && (row < 10) &&
                   (col >= 0) && (col < 10) &&
                   (matrix[row][col] == 1) &&
                   (!visited[row][col]);
        }

        public static void Run(int[][] matrix, int startX, int startY, int endX, int endY)
        {
            bool[][] visited = new bool[10][];
            visited = visited.Select(_ => new bool[10]).ToArray();
            Queue<Node> queue = new();
            visited[startX][startY] = true;
            queue.Enqueue(new Node(startX, startY, 0));
            int minDistance = int.MaxValue;
            while (queue.Count > 0)
            {
                Node node = queue.Dequeue();

                endX = node.X;
                endY = node.Y;
                int distance = node.distance;

                if (startX == endX && startY == endY)
                {
                    minDistance = distance;
                    break;
                }
                for (int i = 0; i < 4; i++)
                {
                    int nextRow = endX + row[i];
                    int nextCol = endY + col[i];
                    if (IsValid(matrix, visited, nextRow, nextCol))
                    {
                        visited[nextRow][nextCol] = true;
                        queue.Enqueue(new Node(nextRow, nextCol, distance + 1));
                    }
                }
            }
            if (minDistance != int.MaxValue)
            {
                Console.WriteLine($"Shortest Path is {minDistance}");
            }
            else
            {
                Console.WriteLine("Shortest Path doesn't exist");
            }
        }
    }
}
