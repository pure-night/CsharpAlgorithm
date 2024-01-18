class NumsDivisorsSum
{
    public int Solution(int left, int right)
    {
        int answer = 0;
        int count;
        for (int i = left; i <= right; i++)
        {
            count = 1;
            for (int j = 1; j <= i / 2; j++)
            {
                if (i % j == 0)
                    count++;
            }
            answer += count % 2 == 0 ? i : -i;
        }
        return answer;
    }
}
