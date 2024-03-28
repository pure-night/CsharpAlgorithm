using System.Collections.Generic;
using System.Linq;

class GetReportResult
{
    public int[] Solution(string[] id_list, string[] report, int k)
    {
        var reportDict = new Dictionary<string, List<string>>();
        var resultDict = new Dictionary<string, int>();

        foreach (var id in id_list)
        {
            reportDict.Add(id, new List<string>());
            resultDict.Add(id, 0);
        }

        foreach (var word in report)
        {
            var user = word.Split(' ');

            if (reportDict[user[1]].Contains(user[0]))
                continue;

            reportDict[user[1]].Add(user[0]);
        }

        foreach (var users in reportDict.Values)
        {
            if(users.Count >= k)
            {
                foreach (var user in users)
                    resultDict[user] += 1;
            }
        }

        return resultDict.Values.ToArray();
    }
}
