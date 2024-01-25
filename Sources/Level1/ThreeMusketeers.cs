class ThreeMusketeers
{
    public int Solution(int[] number)
    {
        //TODO 백트래킹으로 풀어볼것.
        int answer = 0;
        int n = number.Length;

        for(var i = 0; i < n - 2; i++)
        {
            for(var j = i + 1; j < n - 1; j++)
            {
                for(var k = j + 1; k < n; k++)
                {
                    if (number[i] + number[j] + number[k] == 0)
                        answer++;
                }
            }
        }

        return answer;
    }
}
