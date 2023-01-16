namespace Day03;

public static class Part1
{
    public static int Solution(IEnumerable<string> input)
    {
        var result = 0;
        foreach (var item in input)
        {
            var letters = item.ToList();
            var comp1 = letters.Take(letters.Count / 2);
            var comp2 = letters.Skip(letters.Count / 2).Take(letters.Count / 2);

            var same = comp1.Intersect(comp2).First();

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
