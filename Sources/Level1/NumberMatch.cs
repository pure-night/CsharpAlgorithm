using System.Collections.Generic;

class NumberMatch
{
    public string Solution(string X, string Y)
    {
        var nums = new int[10];
        var answer = new List<char>();

        foreach (var c in Y)
            nums[c - '0'] += 1;

        foreach(var c in X)
        {
            if (nums[c - '0'] > 0)
            {
                answer.Add(c);
                nums[c - '0'] -= 1;
            }
        }
        if (answer.Count == 0)
            return "-1";

        answer.Sort();
        answer.Reverse();
        if (answer[0] == '0')
            return "0";

        return string.Concat(answer);
    }
}
