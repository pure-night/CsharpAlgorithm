using System;

class NumberDescending
{
    public long Solution(long n)
    {
        char[] temp = n.ToString().ToCharArray();

        Array.Sort(temp);
        Array.Reverse(temp);
        
        long answer = long.Parse(new string(temp));
        return answer;
    }
}
