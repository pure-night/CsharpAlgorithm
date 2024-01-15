class SumBetweenNum
{
    public long Solution(int a, int b)
    {
        long answer = 0;
        while (a != b)
        {
            answer += a < b ? a++ : b++;
        }
        answer += a;
        return answer;
    }
}
