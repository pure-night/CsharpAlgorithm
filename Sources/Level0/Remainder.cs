class Remainder
{
    public int Solution(int n)
    {
        for (var i = 2; i < n; i++)
        {
            if (n % i == 1)
                return i;
        }
        return 0;
    }
}
