namespace gubiarpa.kidso_challenge.console.tests
{
    public class OrderRangeTests
    {
        [Theory]
        [InlineData(new int[] { 2, 1, 4, 5 }, new int[] { 2, 4 }, new int[] { 1, 5 })]
        [InlineData(new int[] { 4, 2, 9, 3, 6 }, new int[] { 2, 4, 6 }, new int[] { 3, 9 })]
        [InlineData(new int[] { 58, 60, 55, 48, 57, 73 }, new int[] { 48, 58, 60 }, new int[] { 55, 57, 73 })]
        public void Build_SplitsOddAndEvenNumbersCorrectly(int[] input, int[] expectedOdd, int[] expectedEven)
        {
            /// Arrange
            var orderRange = new OrderRange();

            /// Act
            var (odd, even) = orderRange.Build(input);

            /// Assert
            Assert.Equal(expectedOdd, odd);
            Assert.Equal(expectedEven, even);
        }

        [Fact]
        public void Build_HandlesEmptyInput()
        {
            /// Arrange
            var orderRange = new OrderRange();

            /// Act
            var (odd, even) = orderRange.Build(new List<int>());

            /// Assert
            Assert.Empty(odd);
            Assert.Empty(even);
        }

        [Fact]
        public void Build_ThrowsArgumentNullException_WhenInputIsNull()
        {
            /// Arrange
            var orderRange = new OrderRange();

            /// Act & Assert
            Assert.Throws<ArgumentNullException>(() => orderRange.Build(null));
        }
    }
}