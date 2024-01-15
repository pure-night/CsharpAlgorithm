class HarshadNumber
{
    public bool Solution(int x)
    {
        int sumOfDigit = 0;
        var temp = x;

        while (temp > 0)
        {
            sumOfDigit += temp % 10;
            temp /= 10;
        }

        if (x % sumOfDigit == 0)
            return true;
        else
            return false;
    }
}
