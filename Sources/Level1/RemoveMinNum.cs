using System.Linq;

class RemoveMinNum
{
    public int[] Solution(int[] arr)
    {
        if (arr.Count() == 1)
            return new int[] { -1 };
        return arr.Except(new int[] { arr.Min() }).ToArray();
    }
}
