class LowSubString
{
    public int Solution(string t, string p)
    {
        int answer = 0;
        long num = 0;
        long target = long.Parse(p);

        for (int i = 0; i < t.Length - p.Length + 1; i++)
        {
            num = long.Parse(t.Substring(i, p.Length));

            if (num <= target)
                answer++;
        }
        return answer;
    }
}
