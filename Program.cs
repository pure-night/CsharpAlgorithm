using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(new Subtraction().Solution(5, 4));

        Console.WriteLine(new Multiplication().Solution(5, 4));

        Console.WriteLine(new Division().Solution(10, 4));

        Console.WriteLine(new YearOfBirth().Solution(40));

        Console.WriteLine(new Comparison().Solution(40, 41));

        Console.WriteLine(new Addition().Solution(40, 41));
    }
}
