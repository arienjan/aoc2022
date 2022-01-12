using Xunit;

namespace Testaoc
{
    public class Day01Test
    {
        private int[] input = new[] {
                199,
                200,
                208,
                210,
                200,
                207,
                240,
                269,
                260,
                263};

        [Fact]
        public void Test1()
        {

            var result = Day01.Part1.Solution(input);

            Assert.Equal(7, result);
        }

        [Fact]
        public void Test2()
        {

            var result = Day01.Part2.Solution(input);

            Assert.Equal(5, result);
        }
    }
}