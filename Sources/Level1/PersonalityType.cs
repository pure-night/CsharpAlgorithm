using System;
using System.Collections.Generic;

class PersonalityType
{
    public string Solution(string[] survey, int[] choices)
    {
        var answer = "";
        var dict = new Dictionary<char, int>() {{ 'R', 0 }, { 'T', 0 }, { 'C', 0 }, { 'F', 0 }, { 'J', 0 }, { 'M', 0 }, { 'A', 0 }, { 'N', 0 }};
        
        for(var i = 0; i < survey.Length; i++)
        {
            var value = choices[i] - 4;
            if (value == 0) continue;
            var key = value < 0 ? survey[i][0] : survey[i][1];

            dict[key] += Math.Abs(value);
        }

        answer += dict['R'] >= dict['T'] ? 'R' : 'T';
        answer += dict['C'] >= dict['F'] ? 'C' : 'F';
        answer += dict['J'] >= dict['M'] ? 'J' : 'M';
        answer += dict['A'] >= dict['N'] ? 'A' : 'N';

        return answer;
    }
}
