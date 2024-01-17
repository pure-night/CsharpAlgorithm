using System;

class AddMissingNum
{
    public int Solution(int[] numbers)
    {
        int answer = 55;
        foreach (var num in numbers)
            answer -= num;

        return answer;
    }
}
