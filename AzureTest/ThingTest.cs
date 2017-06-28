using AzureLibrary;
using Xunit;

namespace TestApp
{
    public class LibraryTests
    {
        [Fact]
        public void TestThing() {
            Assert.Equal(42, new Thing().Get(19, 23));
        }

        [Fact]
        public void TestThing87() {
            Assert.Equal(87, new Thing().Get(40, 47));
        }

        [Fact]
        public void TestThing103() {
            Assert.Equal(103, new Thing().Get(69, 34));
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(69, 60, 9)]
        public void TestThing87(int expected_value, int left, int right) {
            Assert.Equal(expected_value, new Thing().Get(left, right));
        }
    }
}