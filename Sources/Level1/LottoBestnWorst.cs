using System;
using System.Collections.Generic;

class LottoBestnWorst
{
    public int[] Solution(int[] lottos, int[] win_nums)
    {
        int[] answer = new int[2];

        var hashSet = new HashSet<int>(win_nums);
        int correct = 0;
        int incorrect = 0;

        foreach (var num in lottos)
        {
            if (num != 0)
            {
                if (hashSet.Contains(num))
                    correct++;
                else
                    incorrect++;
            }
        }

        answer[0] = Math.Min(1 + incorrect, 6);
        answer[1] = Math.Min(7 - correct, 6);

        return answer;
    }
}
