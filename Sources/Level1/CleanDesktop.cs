using System;
using System.Linq;

class CleanDesktop
{
    public int[] Solution(string[] wallpaper)
    {
        int[] answer = new int[4] { 50, 50, 0, 0 };
        
        for(var i = 0; i < wallpaper.GetLength(0); i++)
        {
            var temp1 = wallpaper[i].IndexOf('#');
            if (temp1 >= 0)
            {
                answer[0] = Math.Min(answer[0], i);
                answer[1] = Math.Min(answer[1], temp1);
                answer[2] = Math.Max(answer[2], i + 1);
                answer[3] = Math.Max(answer[3], temp1 + 1);

                var temp2 = wallpaper[i].LastIndexOf('#');
                if (temp1 != temp2)
                {
                    answer[2] = Math.Max(answer[2], i + 1);
                    answer[3] = Math.Max(answer[3], temp2 + 1);
                }
            }
        }
        
        return answer;
    }
}
