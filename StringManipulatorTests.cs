using StringManipulatorApp;
using Xunit;

namespace StringManipulatorTests 
{
    public class StringManipulatorTests
    {
        private readonly StringManipulator _manipulator;

        public StringManipulatorTests()
        {
            _manipulator = new StringManipulator(); 
        }

        [Fact]
        public void ReverseString_ShouldReverse()
        {
            string result = _manipulator.ReverseString("hello");
            Assert.Equal("olleh", result);
        }

        [Fact]
        public void RemoveWhitespace_ShouldRemoveAllSpaces()
        {
            string result = _manipulator.RemoveWhitespace("a b c");
            Assert.Equal("abc", result);
        }

        [Fact]
        public void ConcatenateStrings_ShouldCombineStrings()
        {
            string result = _manipulator.ConcatenateStrings("hello", "world");
            Assert.Equal("helloworld", result);
        }
    }
}
