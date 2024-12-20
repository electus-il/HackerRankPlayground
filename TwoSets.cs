namespace HackerRankPlayground;

public class TwoSets
{
    public static void Divide(List<int> list1, List<int> list2)
    {
        for (int i = list1.Max(); i <= list2.Min(); i++)
        {
            foreach (int number in list1)
            {
                if (i % number == 0)
                {
                    foreach (int number2 in list2)
                    {
                        if (number2 % i == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }
    }
}