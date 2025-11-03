using System.Collections.Generic;

namespace MartianRobots;

public sealed class World
{
    public int MaxX { get; }
    public int MaxY { get; }

    // Scent keyed by (cell + orientation)
    private readonly HashSet<(int x, int y, char o)> _scents = new();

    public World(int maxX, int maxY)
    {
        if (maxX < 0 || maxY < 0) throw new ArgumentOutOfRangeException();
        if (maxX > 50 || maxY > 50) throw new ArgumentOutOfRangeException("Max coordinate must be ≤ 50");
        MaxX = maxX; MaxY = maxY;
    }

    public bool InBounds(int x, int y) =>
        x >= 0 && x <= MaxX && y >= 0 && y <= MaxY;

    public bool HasScent(int x, int y, char o) => _scents.Contains((x, y, o));
    public void LeaveScent(int x, int y, char o) => _scents.Add((x, y, o));
}
