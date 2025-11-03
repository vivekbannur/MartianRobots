namespace MartianRobots;

public static class OrientationOps
{
    public static char TurnRight(char o) => o switch
    { 'N' => 'E', 'E' => 'S', 'S' => 'W', 'W' => 'N', _ => o };

    public static char TurnLeft(char o) => o switch
    { 'N' => 'W', 'W' => 'S', 'S' => 'E', 'E' => 'N', _ => o };

    public static (int movex, int movey) MoveForward(char o) => o switch
    {
        'N' => (0, 1),
        'E' => (1, 0),
        'S' => (0, -1),
        'W' => (-1, 0),
        _ => (0, 0)
    };
}
