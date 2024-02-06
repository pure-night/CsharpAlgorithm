using System.Collections.Generic;

class ClosestSameChar
{
    public int[] Solution(string s)
    {
        var answer = new List<int>();
        var dict = new Dictionary<char, int>();

        for(var i = 0; i < s.Length; i++)
        {
            answer.Add(dict.ContainsKey(s[i]) ? i - dict[s[i]] : -1);

            dict[s[i]] = i;
        }

        return answer.ToArray();
    }
}
