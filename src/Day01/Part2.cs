namespace Day01;

public static class Part2
{
    public static int Solution(IEnumerable<int> input)
    {
        int count = 0;
        int? previous = null;
        foreach (var depth in input.GetWindows(3))
        {
            if (previous != null && depth > previous)
            {
                count++;
            }
            previous = depth;
        }

        return count;
    }

    public static IEnumerable<int> GetWindows(this IEnumerable<int> input, int size)
    {
        for (int i = 0; i <= input.Count() - size; i++)
        {
            yield return input.Skip(i).Take(3).Sum();
        }
    }
}
