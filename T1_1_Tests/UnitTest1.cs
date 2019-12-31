using T1_1;
using Xunit;

namespace T1_1_Tests
{
    public class ProgramTests
    {
        [Fact]
        public void AddTest()
        {
            Assert.Equal(4, Program.Add(2, 2));
        }
    }
}