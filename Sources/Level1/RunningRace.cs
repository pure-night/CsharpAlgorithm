using System.Collections.Generic;

class RunningRace
{
    public string[] Solution(string[] players, string[] callings)
    {
        var answer = players;
        var rankDict = new Dictionary<string, int>();

        for (var i = 0; i < players.Length; i++)
            rankDict.Add(players[i], i);

        foreach (var call in callings)
        {
            var rank = rankDict[call];

            var loser = answer[rank - 1];
            answer[rank - 1] = answer[rank];
            answer[rank] = loser;

            rankDict[call] = rank - 1;
            rankDict[loser] = rank;
        }

        return answer;
    }
}
