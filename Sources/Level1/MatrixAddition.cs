using System.Linq;
using System;

class MatrixAddition
{
    public int[,] Solution(int[,] arr1, int[,] arr2)
    {
        var answer = (int[,])arr1.Clone();
        for(int i = 0; i < answer.GetLength(0); i++)
        {
            for(int j = 0; j < answer.GetLength(1); j++)
            {
                answer[i, j] += arr2[i, j];
            }
        }
        return answer;
    }
}
