using System.Collections.Generic;

class MakeHamburger
{
    public int Solution(int[] ingredient)
    {
        int answer = 0;
        List<int> checker = new List<int>();
        var iterator = 1;

        foreach(var i in ingredient)
        {

        }

        for(var i = 0; i < ingredient.Length; i++)
        {
            if (checker.Contains(i))
            {
                i += 3;
                continue;
            }

            if (ingredient[i] == 1)
            {
                if (iterator == 4)
                {
                    answer++;
                    checker.Add(i);
                    checker.Add(i - 1);
                    checker.Add(i - 2);
                    checker.Add(i - 3);
                    i -= 5;
                    iterator = 1;
                }
                else
                {
                    iterator = 2;
                }
            }
            else if (ingredient[i] == iterator)
            {
                iterator++;
            }
            else
            {
                iterator = 1;
            }
        }

        return answer;
    }
}
