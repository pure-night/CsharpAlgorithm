using System.Collections.Generic;

class PaintingOver
{
    public int Solution(int n, int m, int[] section)
    {
        var answer = 0;
        var paint = 0;

        for (var i = 0; i < section.Length; i++)
        {
            if (section[i] > paint)
            {
                paint = (section[i] + m) - 1;
                answer++;
            }
        }

        return answer;
    }
}
