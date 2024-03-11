class StringDivide
{
    public int Solution(string s)
    {
        int answer = 1;
        int firstCharNum = 1;
        int otherCharNum = 0;
        char firstChar = s[0];

        for (var i = 1; i < s.Length - 1; i++)
        {
            if (s[i] != firstChar)
                otherCharNum++;
            else
                firstCharNum++;

            if(firstCharNum == otherCharNum)
            {
                answer++;
                firstChar = s[i + 1];
            }
        }

        return answer;
    }
}
