class CollatzConjecture
{
    public int Solution(int num)
    {
        int answer = 0;
        double n = (double)num;

        while(n != 1)
        {
            if (answer >= 500)
                return -1;
            n = (n % 2) == 0 ? (n / 2) : (n * 3) + 1;
            answer++;
        }
        
        return answer;
    }
}
