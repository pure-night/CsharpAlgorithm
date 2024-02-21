using System.Linq;

class MockExam
{
    public int[] Solution(int[] answers)
    {
        var patterns = new int[][]
        {
            new int[] { 1, 2, 3, 4, 5 },
            new int[] { 2, 1, 2, 3, 2, 4, 2, 5 },
            new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 },
        };
        var score = new int[patterns.Length];

        for (int i = 0; i < patterns.GetLength(0); i++)
            for (int j = 0; j < answers.Length; j++)
                score[i] += (answers[j] == patterns[i][j % patterns[i].Length]) ? 1 : 0;

        var maxScore = score.Max();
        return score.Select((value, index) => value == maxScore ? index + 1 : -1).Where(element => element != -1).ToArray();
    }
}
