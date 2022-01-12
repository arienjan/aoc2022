using Xunit;

namespace Testaoc
{
    public class Day02Test
    {
        private string[] input = new[] {
                "forward 5",
                "down 5",
                "forward 8",
                "up 3",
                "down 8",
                "forward 2"};

        [Fact]
        public void Test1()
        {

            var result = Day02.Part1.Solution(input);

            Assert.Equal(150, result);
        }

        [Fact]
        public void Test2()
        {

            var result = Day02.Part2.Solution(input);

            Assert.Equal(900, result);
        }
    }
}