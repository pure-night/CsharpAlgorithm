class FlipNaturalNum
{
    public int[] Solution(long n)
    {
        int length = n.ToString().Length;
        int[] answer = new int[length];
        for (var i = 0; i < length; i++)
        {
            answer[i] = (int)(n % 10);
            n /= 10;
        }
        return answer;
    }
}
