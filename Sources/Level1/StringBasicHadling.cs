using System.Linq;

class StringBasicHadling
{
    public bool Solution(string s)
    {
        if (s.Length == 4 || s.Length == 6)
            return s.Where(e => e >= 'A' && e <= 'z').ToList().Count == 0;
        else
            return false;
    }
}
