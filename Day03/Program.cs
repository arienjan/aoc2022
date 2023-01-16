using Shared;
using System;

var input = await InputGetter.ReadInputAsLines<string>(2022, 3);

var result1 = Day03.Part1.Solution(input);

Console.WriteLine(result1);

var result2 = Day03.Part2.Solution(input);

Console.WriteLine(result2);