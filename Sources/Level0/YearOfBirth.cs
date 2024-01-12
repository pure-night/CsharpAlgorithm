class YearOfBirth
{
    public int currentYear = 2022;

    public int Solution(int age)
    {
        int answer = currentYear - age + 1;

        return answer;
    }
}
