using System;
using System.Text;

class OurPassword
{
    public string Solution(string s, string skip, int index)
    {
        var answer = new StringBuilder();
        var temp = ' ';

        foreach (char c in s)
        {
            int j = 0;
            for (int i = 1; i <= index + j; i++)
            {
                temp = (char)(c + (i % 26));
                if (temp > 'z')
                    temp = (char)(temp + 'a' - 'z' - 1);

                if (skip.Contains(temp.ToString()))
                    j += 1;
            }
            answer = answer.Append(temp.ToString());
        }

        return answer.ToString();
    }
}
