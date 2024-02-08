class Cola
{
    public int Solution(int a, int b, int n)
    {
        var answer = 0;
        var extra = 0;
        var remain = n;

        while(remain + extra >= a)
        {
            remain += extra;
            extra = remain % a;
            remain = (remain / a) * b;

            answer += remain;
        }

        return answer;
    }
}
