namespace MartianRobots;

public sealed class Robot
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public char Orientation { get; private set; }
    public bool IsLost { get; private set; }

    public Robot(int x, int y, char orientation)
    {
        X = x; Y = y; Orientation = orientation;
    }

    public override string ToString()
    {
        var res = $"{X} {Y} {Orientation}";
        return IsLost ? res + " LOST" : res;
    }
    internal void TurnLeft() => Orientation = OrientationOps.TurnLeft(Orientation);
    internal void TurnRight() => Orientation = OrientationOps.TurnLeft(Orientation);

    internal void TryMove(World world, int movex, int movey)
    {
        if (IsLost) return;

        var newPositionx = X + movex;
        var newPositiony = Y + movey;

        if (!world.InBounds(newPositionx, newPositiony))
        {
            if (world.HasScent(X, Y, Orientation))
                return; // ignore this off-grid move due to scent

            world.LeaveScent(X, Y, Orientation);
            IsLost = true;
            return;
        }
        X = newPositionx; Y = newPositiony;
    }

    internal void MoveForward(World world)
    {
        var (movex, movey) = OrientationOps.MoveForward(Orientation);
        TryMove(world, movex, movey);
    }
}
