class KnightWeapon
{
    public int Solution(int number, int limit, int power)
    {
        int answer = 0;
        int measure;

        for (var i = 1; i <= number; i++)
        {
            measure = 1;

            for(var j = 1; j <= i / 2; j++)
            {
                if (i % j == 0)
                    measure++;
            }
            if (measure > limit)
                measure = power;

            answer += measure;
        }

        return answer;
    }
}
