using System;

class PrintSquareStar
{
    public void Solution(string[] s)
    {
        var answer = "";
        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        var temp = "";
        for (int i = 0; i < a; i++)
            temp += "*";

        answer = temp;
        for (int i = 1; i < b; i++)
            answer += "\n" + temp;

        Console.WriteLine($"{answer}");
    }
}
