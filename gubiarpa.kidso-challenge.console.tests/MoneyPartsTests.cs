namespace gubiarpa.kidso_challenge.console.tests
{
    public class MoneyPartsTests
    {
        [Theory]
        [InlineData("0.1", 2)]    // [0.05, 0.05] and [0.1]
        [InlineData("0.5", 13)]   // Should produce multiple combinations
        [InlineData("1", 50)]     // Should produce multiple combinations
        public void Build_ReturnsExpectedCombinationCount(string input, int expectedCount)
        {
            // Arrange
            var moneyParts = new MoneyParts();

            // Act
            var result = moneyParts.Build(input);

            // Assert
            Assert.True(result.Count == expectedCount, $"Expected at least {expectedCount} combinations, got {result.Count}");
        }

        [Theory]
        [InlineData("abc")]
        [InlineData("")]
        [InlineData(null)]
        public void Build_ThrowsException_ForInvalidInput(string input)
        {
            var moneyParts = new MoneyParts();
            Assert.Throws<System.ArgumentException>(() => moneyParts.Build(input));
        }

        [Fact]
        public void Build_HandlesExactMatch()
        {
            var moneyParts = new MoneyParts();
            var result = moneyParts.Build("0.05");
            Assert.Contains(result, r => r.SequenceEqual(new List<decimal> { 0.05m }));
        }
    }
}
