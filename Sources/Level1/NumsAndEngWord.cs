class NumsAndEngWord
{
    public int Solution(string s)
    {
        var answer = s;
        var numbers = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        for(var i = 0; i < numbers.Length; i++)
        {
            answer = answer.Replace(numbers[i], i.ToString());
        }

        return int.Parse(answer);
    }
}
