using System.Linq;

class FruitSeller
{
    public int Solution(int k, int m, int[] score)
    {
        score = score.OrderByDescending(e => e).ToArray();
        var result = Enumerable.Range(0, score.Length / m)
                .Select(i => score.Skip(i * m).Take(m).Last() * m)
                .ToArray();

        return result.Sum();
    }
}
