namespace Day02;

public static class Part1
{
    public static int Solution(IEnumerable<string> input)
    {
        var input2 = input.Select(c => c.Split(' ')[0]).Zip(input.Select(c => int.Parse(c.Split(' ')[1])));
        var pos = (0, 0);
        foreach (var (Command, Value) in input2)
        {
            _ = Command switch
            {
                "forward" => pos.Item1 += Value,
                "down" => pos.Item2 += Value,
                "up" => pos.Item2 -= Value,
                _ => throw new Exception()
            };
        }

        return pos.Item1 * pos.Item2;
    }
}
