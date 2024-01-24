using System.Linq;

class OddString
{
    public string Solution(string s)
    {
        string answer = "";

        var str = s.Split(' ');

        for (var i = 0; i < str.Length; i++)
        {
            var word = str[i];

            for (var j = 0; j < word.Length; j++)
            {
                answer += j % 2 == 0 ? char.ToUpper(word[j]) : char.ToLower(word[j]);
            }

            if (i != str.Length - 1)
                answer += " ";
        }

        return answer;
    }
}
