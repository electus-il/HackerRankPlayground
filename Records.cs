namespace HackerRankPlayground;

public class Records
{
    public static List<int> Break(List<int> scores)
    {
        int maxScore = scores[0];
        int maxBreak = 0;
        int minScore = scores[0];
        int minBreak = 0;

        foreach (var score in scores)
        {
            if (score > maxScore)
            {
                maxScore = score;
                maxBreak++;
            }else if (score < minScore)
            {
                minScore = score;
                minBreak++;
            }
        }

        Console.WriteLine($"{maxBreak}, {minBreak}");
        return [maxBreak, minBreak];
    }
}