using System.Linq;
using System.Collections.Generic;

class GymSuit
{
    public int Solution(int n, int[] lost, int[] reserve)
    {
        int answer = n - lost.Length;
        var reserveHash = new HashSet<int>(reserve);
        var sortedLost = lost.OrderBy(num => num).ToArray();

        for (var i = 0; i < sortedLost.Length; i++)
        {
            if (reserveHash.Contains(sortedLost[i]))
            {
                answer++;
                reserveHash.Remove(sortedLost[i]);
                sortedLost[i] = -1;
            }
        }

        foreach (var lostStudent in sortedLost)
        {
            if (reserveHash.Contains(lostStudent - 1))
            {
                answer++;
                reserveHash.Remove(lostStudent - 1);
            }
            else if (reserveHash.Contains(lostStudent + 1))
            {
                answer++;
                reserveHash.Remove(lostStudent + 1);
            }
        }

        return answer;
    }
}
