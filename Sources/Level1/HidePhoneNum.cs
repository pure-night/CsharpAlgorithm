﻿class HidePhoneNum
{
    public string Solution(string phone_number)
    {
        string answer = "";
        for (int i = 0; i < phone_number.Length; i++)
            answer = i < phone_number.Length - 4 ? answer + '*' : answer + phone_number[i];

        return answer;
    }
}
