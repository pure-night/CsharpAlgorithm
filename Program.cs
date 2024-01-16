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

        Console.WriteLine(new AddPlaceValue().Solution(1482));

        Console.WriteLine(new Remainder().Solution(1482));

        var temp1 = new IntervalOfNums().Solution(4, 5);
        for(var i = 0; i < temp1.Length; i++)
            Console.Write(temp1[i] + " ");
        Console.WriteLine();

        var temp2 = new FlipNaturalNum().Solution(1482);
        for (var i = 0; i < temp2.Length; i++)
            Console.Write(temp2[i] + " ");
        Console.WriteLine();

        Console.WriteLine(new StringToInt().Solution("-1524"));

        Console.WriteLine(new SquareDiscrimination().Solution(144));

        Console.WriteLine(new NumberDescending().Solution(144));

        Console.WriteLine(new HarshadNumber().Solution(144));

        Console.WriteLine(new SumBetweenNum().Solution(3, 5));

        Console.WriteLine(new CollatzConjecture().Solution(626331));

        Console.WriteLine(new FindKim().Solution(new string[]{ "Jane", "Kim" }));

        var temp3 = new ArrayDivisor().Solution(new int[] { 10, 20, 4, 8, 40, 15 }, 5);
        for (var i = 0; i < temp3.Length; i++)
            Console.Write(temp3[i] + " ");
        Console.WriteLine();

        Console.WriteLine(new AbsoluteSign().Solution(new int[] { 5, 4, 6 }, new bool[] { true, false, true }));

        Console.WriteLine(new HidePhoneNum().Solution("01055554444"));
    }
}
