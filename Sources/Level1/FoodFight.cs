using System.Linq;
using System.Text;

class FoodFight
{
    public string Solution(int[] food)
    {
        var answer = new StringBuilder();

        for(var i = 1; i < food.Length; i++)
        {
            answer.Append(string.Concat(Enumerable.Repeat(i.ToString(), food[i] / 2)));
        }

        var descendingOrder = string.Concat(answer.ToString().OrderByDescending(e => e));
        answer.Append("0").Append(descendingOrder);

        return answer.ToString();
    }
}
