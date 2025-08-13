using Xunit;

namespace CS.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void EvenOrOdd_WithEvenNumber_ReturnsEven()
        {
            var result = Program.EvenOrOdd(4);
            Assert.Equal("Even", result);
        }

        [Fact]
        public void EvenOrOdd_WithOddNumber_ReturnsOdd()
        {
            var result = Program.EvenOrOdd(3);
            Assert.Equal("Odd", result);
        }

        [Fact]
        public void EvenOrOdd_WithZero_ReturnsEven()
        {
            var result = Program.EvenOrOdd(0);
            Assert.Equal("Even", result);
        }
    }
}