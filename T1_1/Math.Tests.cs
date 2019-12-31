using System;
using Xunit;

namespace T1_1
{
    public partial class Math
    {
        [Fact]
        public void SimpleAdd()
        {
            Assert.Equal(4, Add(2, 2));
        }
    }
}