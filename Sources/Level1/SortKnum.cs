using System.Linq;

class SortKnum
{
    public int[] Solution(int[] array, int[,] commands)
    {
        return Enumerable.Range(0, commands.GetLength(0))
                     .Select(i => array.Skip(commands[i, 0] - 1)
                                      .Take(commands[i, 1] - commands[i, 0] + 1)
                                      .OrderBy(e => e)
                                      .ElementAt(commands[i, 2] - 1))
                     .ToArray();
    }
}
