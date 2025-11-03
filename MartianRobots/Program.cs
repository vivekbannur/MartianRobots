using System;
using System.Collections.Generic;
using System.Linq;

namespace MartianRobots;

public static class Simulation
{
    public static List<string> Run(string inputData)
    {
        var result = new List<string>();

        // Split and trim all lines
        var input = inputData
            .Split('\n', StringSplitOptions.RemoveEmptyEntries)
            .Select(l => l.Trim())
            .ToList();

        if (input.Count == 0)
            return result;

        // First line → world bounds
        var bounds = input[0].Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var world = new World(int.Parse(bounds[0]), int.Parse(bounds[1]));

        // Process robots in pairs (position + instructions)
        for (int i = 1; i < input.Count; i ++)
        {
            if (string.IsNullOrWhiteSpace(input[i]))
                continue; // skip blank lines safely
            var posParts = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int x = int.Parse(posParts[0]);
            int y = int.Parse(posParts[1]);
            char dir = char.Parse(posParts[2]);

            var robot = new Robot(x, y, dir);

            i++;
            if (i >= input.Count) break; // no instruction line exists
            var instrLine = input[i];

            var instructions = InstructionParser.Parse(instrLine);

            foreach (var instruction in instructions)
            {
                if (robot.IsLost) break;
                instruction.Apply(robot, world);
            }
            result.Add(robot.ToString());
        }
        return result;
    }
}

public class Program
{
    public static void Main()
    {
        var all = Console.In.ReadToEnd();
        foreach (var line in Simulation.Run(all))
            Console.WriteLine(line);
    }
}
