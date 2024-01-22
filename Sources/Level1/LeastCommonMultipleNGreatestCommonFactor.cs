class LeastCommonMultipleNGreatestCommonFactor
{
    public int[] Solution(int n, int m)
    {
        int[] answer = new int[2];
        int a = n > m ? n : m;
        int b = a == n ? m : n;
        while (b > 0)
        {
            int tmp = a;
            a = b;
            b = tmp % b;
        }
        answer[0] = a;
        answer[1] = n * m / answer[0];

        return answer;
    }
}
