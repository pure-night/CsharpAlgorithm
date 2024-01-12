class Average
{
    public double Solution1(int[] numbers)
    {
        double answer = 0;
        for (var i = 0; i < numbers.Length; i++)
            answer += numbers[i];

        return answer / numbers.Length;
    }

    public double Solution2(int[] arr)
    {
        double answer = 0;
        foreach (var i in arr)
        {
            answer += i;
        }
        return answer / arr.Length;
    }
}
