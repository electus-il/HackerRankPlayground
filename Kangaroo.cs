namespace HackerRankPlayground;

public class Kangaroo
{
    public static string Jump(int x1, int v1, int x2, int v2)
    {
        int coorDiff = Math.Abs(x1 - x2);
        if (coorDiff % v1 == 0 && coorDiff % v2 == 0)
        {
            Console.WriteLine("YES");
            return "YES";
        }
        else
        {
            Console.WriteLine("NO");
            return "NO";
        }
    }
}