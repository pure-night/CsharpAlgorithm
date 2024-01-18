using System;
using System.Linq;

class StringDescOrder
{
    public string Solution(string s)
    {
        var answer = s.ToArray();
        Array.Sort(answer);
        return string.Concat(answer.Reverse());
    }
}
