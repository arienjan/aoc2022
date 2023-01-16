namespace Day04;

public static class Part1
{
    public static int Solution(IEnumerable<string> input)
    {
        var result = 0;
        foreach (var line in input)
        {
            var groups = line.Split(',').SelectMany(l => l.Split('-')).Select(c => int.Parse(c)).ToList();

            if ((groups[0] <= groups[2] && groups[1] >= groups[3]) || (groups[2] <= groups[0] && groups[3] >= groups[1]))
            {
                result++;
            }
        }
        return result;
    }
}
