using System.Text;

class CaesarCipher
{
    public string Solution(string s, int n)
    {
        var answer = new StringBuilder();

        foreach (var c in s)
        {
            if (char.IsLetter(c))
            {
                var baseChar = char.IsUpper(c) ? 'A' : 'a';
                var caesarChar = (char)((c - baseChar + n) % 26 + baseChar);
                answer.Append(caesarChar);
            }
            else
            {
                answer.Append(c);
            }
        }

        return answer.ToString();
    }
}
