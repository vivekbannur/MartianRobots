using System;
using System.Collections.Generic;

namespace MartianRobots;

public static class InstructionParser
{
    public static List<IInstruction> Parse(string s)
    {
        var list = new List<IInstruction>(s?.Length ?? 0);
        if (string.IsNullOrWhiteSpace(s)) return list;

        foreach (var ch in s.Trim())
        {
            switch (ch)
            {
                case 'L':
                    list.Add(new Left());
                    break;
                case 'R':
                    list.Add(new Right());
                    break;
                case 'F':
                    list.Add(new Forward());
                    break;
                default:
                    throw new InvalidOperationException($"Unknown instruction '{ch}'");
            }
        }
        return list;
    }
}