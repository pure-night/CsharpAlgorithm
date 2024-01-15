using System;

class SquareDiscrimination
{
    public long Solution(long n)
    {
        var x = Math.Sqrt(n);

        if (x != ((int)x))
            return -1;

        var answer = (long) Math.Pow(x + 1, 2);
        return answer;
    }
}
