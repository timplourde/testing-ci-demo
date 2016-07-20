using Xunit;

namespace AdvisorCalc.Tests
{
    public class InvestorTests
    {
        [Theory]
        [InlineData(400000, 200)]           // 400k, 200
        [InlineData(1000000, 1000)]         // 1m, 1k
        [InlineData(10000000, 15000)]       // 10m, 15k
        public void FeeIsCorrect(decimal totalAssets, decimal expectedFee)
        {
            var investor = new Investor { TotalAssets = totalAssets };
            Assert.Equal(expectedFee, investor.Fee());
        }
    }
}
