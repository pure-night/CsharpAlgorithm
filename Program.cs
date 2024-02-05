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

        Console.WriteLine(new AddMissingNum().Solution(new int[] { 1, 2, 4, 0, 6 }));

        Console.WriteLine(new RemoveMinNum().Solution(new int[] { 1, 2, 4, 0, 6 }));

        Console.WriteLine(new MiddleChar().Solution("wdqweyiozxc"));

        Console.WriteLine(new PrintWaterMelon().Solution(5));

        Console.WriteLine(new DotProduct().Solution(new int[] { 1, 4, 5, 7 }, new int[] { 5, 8, 2, 4 }));

        Console.WriteLine(new NumsDivisorsSum().Solution(13, 17));

        Console.WriteLine(new StringDescOrder().Solution("ddwawqqabc"));

        Console.WriteLine(new NotEnoughMoneyCalc().Solution(2500, 50, 2500));

        Console.WriteLine(new StringBasicHadling().Solution("a12345"));

        var temp4 = new MatrixAddition().Solution(new int[,] { { 1, 2 }, { 2, 3 } }, new int[,] { { 3, 4 }, { 5, 6 } });
        for (var i = 0; i < temp4.GetLength(0); i++)
        {
            Console.Write("{ ");
            for (var j = 0; j < temp4.GetLength(1); j++)
                Console.Write(temp4[i, j] + " ");
            Console.Write("} ");
        }
        Console.WriteLine();

        new PrintSquareStar().Solution(new string[] { "5", "4" });


        var temp5 = new LeastCommonMultipleNGreatestCommonFactor().Solution(2, 5);
        for (var i = 0; i < temp5.Length; i++)
        {
            Console.Write(temp5[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine(new OddString().Solution("Try Hard Buddy"));

        Console.WriteLine(new ThreeMusketeers().Solution(new int[] { 1, 5, 4, -1, 0, -4, 2, -2 }));

        Console.WriteLine(new LowSubString().Solution("554862178", "21"));

        Console.WriteLine(new MinRectangle().Solution(new int[,] { {10, 5}, {15, 8}, {20, 5}, {5, 8} }));

        Console.WriteLine(new CaesarCipher().Solution("I aw T", 3));

        Console.WriteLine(new NumsAndEngWord().Solution("three25four4eightseven"));

        var temp6 = new StringSortMyMind().Solution(new string[] { "dafewd", "wrtwa", "dwadwa", "dawda", "hyui" }, 3);
        for (var i = 0; i < temp6.Length; i++)
        {
            Console.Write(temp6[i] + " ");
        }
        Console.WriteLine();

        var temp7 = new SortKnum().Solution(new int[] { 1, 5, 2, 6, 3, 7, 4 }, new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } });
        for (var i = 0; i < temp7.Length; i++)
        {
            Console.Write(temp7[i] + " ");
        }
        Console.WriteLine();

        var temp8 = new AddTwoPick().Solution(new int[] { 2, 5, 8, 4, 3, 9, 0 });
        for (var i = 0; i < temp8.Length; i++)
        {
            Console.Write(temp8[i] + " ");
        }
        Console.WriteLine();
    }
}
