namespace LearnCS.Algorithms.ShortestPath
{
    internal static class AStar
    {
        class Location
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int score1 { get; set; }
            public int score2 { get; set; }
            public int score3 { get; set; }
            public Location Parent { get; set; }
        }
        public static void Run()
        {
            string[] map =
            [
                "+----------------+",
                "A                 ",
                "XXXXXX       XXX  ",
                "     X       XXX  ",
                "     X       XXX  ",
                "   XXX  XX   X    ",
                "         XXXXXXXXX",
                "XX    X    X      ",
                "                 B",
                "+----------------+",
            ];
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (var line in map)
            {
                Console.WriteLine(line);
            }
            Location current = null;
            Location start = new() { X = 0, Y = 1 };
            Location end = new() { X = 17, Y = 8 };
            List<Location> openList = [];
            List<Location> closedList = [];
            int spot = 0;
            openList.Add(start);
            while (openList.Count > 0)
            {
                int main = openList.Min(l => l.score1);
                current = openList.First(l => l.score1 == main);
                closedList.Add(current);
                Console.SetCursorPosition(current.X, current.Y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(".");
                Console.SetCursorPosition(current.X, current.Y);
                Thread.Sleep(500);
                openList.Remove(current);
                if (closedList.FirstOrDefault(l => l.X == end.X && l.Y == end.Y) != null)
                {
                    break;
                }
                List<Location> neighbors = GetMovableAdjacentSpots(current, map);
                spot++;
                foreach (var item in neighbors)
                {
                    if (closedList.FirstOrDefault(l => l.X == item.X && l.Y == item.Y) != null)
                    {
                        continue;
                    }
                    if (openList.FirstOrDefault(l => l.X == item.X && l.Y == item.Y) == null)
                    {
                        item.score2 = spot;
                        item.score3 = computeSpotHeuristic(item, end);
                        item.score1 = item.score2 + item.score3;
                        item.Parent = current;
                        openList.Insert(0, item);

                    }
                    else
                    {
                        if (spot + item.score3 < item.score1)
                        {
                            item.score2 = spot;
                            item.score1 = item.score2 + item.score3;
                            item.Parent = current;
                        }
                    }
                }
            }
            while (current != null)
            {
                Console.SetCursorPosition(current.X, current.Y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("o");
                Console.SetCursorPosition(current.X, current.Y);
                current = current.Parent;
                Thread.Sleep(500);
            }
            Console.ReadLine();
        }
        static List<Location> GetMovableAdjacentSpots(Location current, string[] map)
        {
            // build four cardinal neighbours
            var proposedLocations = new List<Location>
            {
                new() { X = current.X - 1, Y = current.Y },
                new() { X = current.X + 1, Y = current.Y },
                new() { X = current.X,     Y = current.Y - 1 },
                new() { X = current.X,     Y = current.Y + 1 },
            };

            int height = map.Length;
            // Filter only locations inside the bounds and that are walkable (' ' or 'B').
            return proposedLocations
                .Where(l =>
                    // check row bounds
                    l.Y >= 0 && l.Y < height &&
                    // check column bounds for the specific row (guard against ragged rows)
                    l.X >= 0 && l.X < map[l.Y].Length &&
                    // then check the map cell safely
                    (map[l.Y][l.X] == ' ' || map[l.Y][l.X] == 'B')
                )
                .ToList();
        }
        static int computeSpotHeuristic(Location current, Location end)
        {
            return Math.Abs(current.X - end.X) + Math.Abs(current.Y - end.Y);
        }
    }
}
