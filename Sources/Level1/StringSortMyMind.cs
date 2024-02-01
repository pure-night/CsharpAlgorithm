using System.Linq;

class StringSortMyMind
{
    public string[] Solution(string[] strings, int n)
    {
        return strings.OrderBy(str => str[n]).ThenBy(str => str).ToArray();
    }
}
