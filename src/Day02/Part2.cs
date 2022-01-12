namespace Day02;

public static class Part2
{
    public static int Solution(IEnumerable<string> input)
    {
        var input2 = input.Select(c => c.Split(' ')[0]).Zip(input.Select(c => int.Parse(c.Split(' ')[1])));
        var pos = (0, 0);
        var aim = 0;
        foreach (var (Command, Value) in input2)
        {
            switch (Command)
            {
                case "forward":
                    pos.Item1 += Value;
                    pos.Item2 += Value * aim;
                    break;
                case "down":
                    aim += Value;
                    break;
                case "up":
                    aim -= Value;
                    break;
                default:
                    break;
            }
        }

        return pos.Item1 * pos.Item2;
    }
}
