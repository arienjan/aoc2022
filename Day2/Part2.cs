using System.Collections.Generic;
using System.Linq;

namespace Day02;

public static class Part2
{
    public static int Solution(IEnumerable<string> input)
    {
        var total = 0;

        foreach (var play in input)
        {
            var hands = play.Split(" ");
            var p1 = GetValue(hands[0]);
            var outCome = GetValue(hands[1]);

            var (p2, score) = outCome switch
            {
                1 => ((p1 + 1) % 3 + 1, 0), // Need to lose
                2 => (p1, 3), // need to draw
                _ => ((p1) % 3 + 1, 6) // Need to win
            };

            total += p2 + score;
        }
        return total;
    }

    private static int GetValue(string hand)
    {
        return hand switch
        {
            "A" or "X" => 1,
            "B" or "Y" => 2,
            "C" or "Z" => 3,
            _ => 0
        };
    }
}
