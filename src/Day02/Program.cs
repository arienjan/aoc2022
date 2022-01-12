using Shared;

var input = await InputGetter.ReadInputAsLines<string>(2021, 2);

var result1 = Day02.Part1.Solution(input);

Console.WriteLine(result1);

var result2 = Day02.Part2.Solution(input);

Console.WriteLine(result2);