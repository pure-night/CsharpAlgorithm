using System;

class ArrayDivisor
{
    public int[] Solution(int[] arr, int divisor)
    {
        int[] answer = new int[arr.Length];
        int index = 0;
        for(var i = 0; i < arr.Length; i++)
        {
            if (arr[i] % divisor == 0)
                answer[index++] = arr[i];
        }

        if (index != 0)
        {
            Array.Resize(ref answer, index);
            Array.Sort(answer);
            return answer;
        }
        else
        {
            return new int[]{ -1 };
        }
    }
}
