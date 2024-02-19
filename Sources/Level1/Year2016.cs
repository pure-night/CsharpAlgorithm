using System;

class Year2016
{
    public string Solution(int a, int b)
    {
        DateTime date = new DateTime(2016, a, b);
        string answer = date.DayOfWeek.ToString().ToUpper();
        answer = answer.Substring(0, 3).ToUpper();

        return answer;
    }
}
