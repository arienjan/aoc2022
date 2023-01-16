using System.Collections.Generic;
using System.Linq;

namespace Day02;

public static class Part1
{
    public static int Solution(IEnumerable<string> input)
    {
        var total = 0;

        foreach (var play in input)
        {
            var hands = play.Split(" ");
            var p1 = GetValue(hands[0]);
            var p2 = GetValue(hands[1]);

            var outCome = (p1 - p2) switch
            {
                -1 or 2 => 6, // P2 win
                0 => 3, //Equal
                _ => 0 // Other cases, P1 win
            };

            total += p2 + outCome;
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
