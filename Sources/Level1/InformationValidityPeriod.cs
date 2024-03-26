using System.Collections.Generic;
using System;

class InformationValidityPeriod
{
    public int[] Solution(string today, string[] terms, string[] privacies)
    {
        var answer = new List<int>();
        var termDict = new Dictionary<char, int>();

        foreach(var term in terms)
        {
            var word = term.Split(' ');
            termDict.Add(char.Parse(word[0]), int.Parse(word[1]));
        }

        for (var i = 0; i < privacies.Length; i++)
        {
            var word = privacies[i].Split(new char[2] { '.', ' ' });

            var month = int.Parse(word[1]) + termDict[char.Parse(word[3])];
            var year = int.Parse(word[0]);

            if(month > 12)
            {
                year += (month - 1) / 12;
                month = (month - 1) % 12 + 1;
            }

            word[0] = year.ToString();
            word[1] = string.Format("{0:00}", month);

            var privacy = $"{word[0]}.{word[1]}.{word[2]}";

            Console.WriteLine(privacy);
            if (string.Compare(privacy, today) <= 0)
            {
                answer.Add(i + 1);
            }
        }

        return answer.ToArray();
    }
}
