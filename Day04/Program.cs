using Shared;
using System;

var input = await InputGetter.ReadInputAsLines<string>(2022, 4);

var result1 = Day04.Part1.Solution(input);

Console.WriteLine(result1);

var result2 = Day04.Part2.Solution(input);

Console.WriteLine(result2);