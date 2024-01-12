using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(new Subtraction().Solution(5, 4));

        Console.WriteLine(new Multiplication().Solution(5, 4));

        Console.WriteLine(new Division().Solution1(10, 4));

        Console.WriteLine(new YearOfBirth().Solution(40));

        Console.WriteLine(new Comparison().Solution(40, 41));

        Console.WriteLine(new Addition().Solution(40, 41));

        Console.WriteLine(new Division().Solution2(10, 4));

        Console.WriteLine(new Protractor().Solution(70));

        Console.WriteLine(new SumOfEven().Solution(50));

        Console.WriteLine(new Average().Solution1(new int[] { 1, 2, 3, 10, 50 }));

        Console.WriteLine(new EvenOrOdd().Solution(50));

        Console.WriteLine(new Average().Solution2(new int[] { 1, 2, 3, 10, 50 }));
    }
}
