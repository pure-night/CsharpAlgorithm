using System.Collections.Generic;

class HallOfFame
{
    public int[] Solution(int k, int[] score)
    {
        var answer = new int[score.Length];
        var list = new List<int>();

        for (int i = 0; i < score.Length; i++)
        {
            if (list.Count == k)
            {
                if (list[0] > score[i])
                {
                    answer[i] = list[0];
                    continue;
                }
                list.RemoveAt(0);
            }
            list.Add(score[i]);
            list.Sort();
            answer[i] = list[0];
        }

        return answer;
    }
}
