using System;
using Xunit;

namespace BrainTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestFunctionReturnsFive()
        {
            Brain b = new Brain();
            Assert.Equal(5, b.TestFunction());
        }

        [Fact]
        public void TestFuctionNotReturnsZero()
        {
            Brain b = new Brain();
            Assert.NotEqual(0, b.TestFunction());
        }
    }
}
