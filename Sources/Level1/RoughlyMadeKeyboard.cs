using System.Collections.Generic;

class RoughlyMadeKeyboard
{
    public int[] Solution(string[] keymap, string[] targets)
    {
        int[] answer = new int[targets.Length];
        var dict = new Dictionary<char, int>();

        for(var i = 0; i < keymap.GetLength(0); i++)
        {
            for(var j = 0; j < keymap[i].Length; j++)
            {
                if (!dict.ContainsKey(keymap[i][j]) || dict[keymap[i][j]] > j + 1)
                {
                    dict[keymap[i][j]] = j + 1;
                }
            }
        }

        for (var i = 0; i < targets.GetLength(0); i++)
        {
            foreach (var c in targets[i])
            {
                if (dict.ContainsKey(c))
                {
                    answer[i] += dict[c];
                }
                else
                {
                    answer[i] = -1;
                    break;
                }
            }
        }

        return answer;
    }
}
