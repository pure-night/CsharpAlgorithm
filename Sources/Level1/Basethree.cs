using System;
using System.Collections.Generic;

class Basethree
{
    public int Solution(int n)
    {
        int answer = 0;
        var list = new List<int>();

        while (n > 0)
        {
            list.Add(n % 3);
            n /= 3;
        }

        list.Reverse();

        for (var i = 0; i < list.Count; i++)
        {
            answer += (int)(list[i] * Math.Pow(3, i));
        }

        return answer;
    }
}
