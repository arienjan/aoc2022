namespace Day01;

public static class Part1
{
    public static int Solution(IEnumerable<int> input)
    {
        int count = 0;
        int? previous = null;
        foreach (var depth in input)
        {
            if (previous != null && depth > previous)
            {
                count++;
            }
            previous = depth;
        }

        return count;
    }
}
