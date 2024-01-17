class MiddleChar
{
    public string Solution(string s)
    {
        return s.Length % 2 == 0 ? s[(s.Length - 1) / 2].ToString() + s[(s.Length - 1) / 2 + 1] : s[s.Length / 2].ToString();
    }
}
