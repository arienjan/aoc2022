using Xunit;

namespace Testaoc
{
    public class Day02Test
    {
        private string[] input = new[] {
                "A Y",
                "B X",
                "C Z"};

        [Fact]
        public void Test1()
        {

            var result = Day02.Part1.Solution(input);

            Assert.Equal(15, result);
        }

        [Fact]
        public void Test2()
        {

            var result = Day02.Part2.Solution(input);

            Assert.Equal(12, result);
        }
    }
}