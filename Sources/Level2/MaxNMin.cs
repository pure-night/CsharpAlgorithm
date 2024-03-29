using System;

class MaxNMin
{
    public string Solution(string s)
    {
        var min = int.MaxValue;
        var max = int.MinValue;

        var values = s.Split(' ');

        foreach (var value in values)
        {
            min = Math.Min(min, int.Parse(value));
            max = Math.Max(max, int.Parse(value));
        }

        return $"{min} {max}";
    }
}
