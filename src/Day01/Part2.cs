using System.Collections.Generic;
using System.Linq;

namespace Day01;

public static class Part2
{
    public static int Solution(IEnumerable<int?> input)
    {
        var caloriesByElf = new List<int>();

        var total = 0;
        foreach (var item in input)
        {
            if (!item.HasValue)
            {
                caloriesByElf.Add(total);
                total = 0;
                continue;
            }

            total += item.Value;
        }

        return caloriesByElf.OrderByDescending(c => c).Take(3).Sum();
    }
}
