namespace MartianRobots;

public interface IInstruction
{
    void Apply(Robot r, World w);
}

public sealed class Left : IInstruction
{
    public void Apply(Robot r, World w) => r.TurnLeft();
}

public sealed class Right : IInstruction
{
    public void Apply(Robot r, World w) => r.TurnRight();
}

public sealed class Forward : IInstruction
{
    public void Apply(Robot r, World w) => r.MoveForward(w);
}
