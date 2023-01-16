namespace Day03;

public static class Part2
{
    public static int Solution(IEnumerable<string> input)
    {
        var result = 0;
        foreach (var item in input.Chunk(3))
        {
            var same = item[0].Intersect(item[1]).Intersect(item[2]).First();

            var intval = same - '0';

            if (char.IsLower(same))
            {
                intval -= 48;
            }
            else
            {
                intval += 10;
            }

            result += intval;
        }

        return result;
    }
}
