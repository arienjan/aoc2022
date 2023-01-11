using Shared;
using System;

var input = await InputGetter.ReadInputAsLinesNullableType<int>(2022, 1);

var result1 = Day01.Part1.Solution(input);

Console.WriteLine(result1);

var result2 = Day01.Part2.Solution(input);

Console.WriteLine(result2);