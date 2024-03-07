using System.Text;

class Babbling2
{
    public int Solution(string[] babbling)
    {
        int answer = 0;
        var words = new string[] { "aya", "ye", "woo", "ma" };
        StringBuilder sb;


        foreach (var babble in babbling) 
        {
            sb = new StringBuilder(babble);
            foreach (var word in words)
            {
                var doubleWord = word + word;
                if (!sb.ToString().Contains(doubleWord))
                {
                    sb.Replace(word, " ");
                }
            }

            if (sb.ToString().Trim() == "")
                answer++;
        }

        return answer;
    }
}
