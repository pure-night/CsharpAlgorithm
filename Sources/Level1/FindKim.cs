using System;

class FindKim
{
    public string Solution(string[] seoul)
    {
        return $"김서방은 {Array.FindIndex(seoul, x => x == "Kim")}에 있다";
    }
}
