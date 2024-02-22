class MakePrime
{
    public int Solution(int[] nums)
    {
        int answer = 0;

        for (var i = 0; i < nums.Length - 2; i++)
        {
            for (var j = i + 1; j < nums.Length - 1; j++)
            {
                for (var k = j + 1; k < nums.Length; k++)
                {
                    var sum = nums[i] + nums[j] + nums[k];

                    if (IsPrime(sum))
                        answer++;
                }
            }
        }

        return answer;
    }

    private bool IsPrime(int num)
    {
        for (var i = 2; i * i <= num; i++)
            if (num % i == 0)
                return false;

        return true;
    }
}
