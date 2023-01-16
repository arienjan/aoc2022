using Xunit;

namespace Testaoc
{
    public class Day04Test
    {
        private string[] input = new[] {
                "2-4,6-8",
            "2-3,4-5",
            "5-7,7-9",
            "2-8,3-7",
            "6-6,4-6",
            "2-6,4-8" };

        [Fact]
        public void Test2()
        {

            var result = Day04.Part2.Solution(input);

            Assert.Equal(4, result);
        }
    }
}