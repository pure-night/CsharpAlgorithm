class Average
{
    public double Solution(int[] numbers)
    {
        double answer = 0;
        for (var i = 0; i < numbers.Length; i++)
            answer += numbers[i];

        return answer / numbers.Length;
    }
}
