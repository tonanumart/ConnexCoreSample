using System;
using Xunit;
namespace MyFirstUnitTest
{
    public class FirstXUnitTest
    {
        [Fact]
        public void PasingSampleTest()
        {
            Assert.Equal(4,2+2);
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5,2+2);
        }

    }
}
