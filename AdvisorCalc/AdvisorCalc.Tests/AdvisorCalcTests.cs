using System.Collections.Generic;
using Xunit;

namespace AdvisorCalc.Tests
{
    public class AdvisorCalcTests
    {
        private IEnumerable<Investor> _investors;

        public AdvisorCalcTests()
        {
           _investors = new[]
           {
                new Investor
                {
                    TotalAssets = 300000 // 300k
                },
                new Investor
                {
                    TotalAssets = 1000000  // 3m
                },
                new Investor
                {
                    TotalAssets = 5000000 // 5m
                }
            };
        }

        [Fact]
        public void JuniorAdvisorsMakeHalfOfSeniorsCommission()
        {
            // when we calculate the commissions
            var juniorCommission = CommissionCalculator.CalculateCommission(AdvisorRank.Junior, _investors);

            var seniorCommission = CommissionCalculator.CalculateCommission(AdvisorRank.Senior, _investors);

            // the junior's commission will be 50 % of the senior's commission
            Assert.Equal(0.5m, juniorCommission / seniorCommission);
        }

        [Theory]
        [InlineData(AdvisorRank.Junior, 4325)]
        [InlineData(AdvisorRank.Experienced, 6487.5)]
        [InlineData(AdvisorRank.Senior, 8650)]
        public void CommissionsAreCorrectForAdvisorRank(AdvisorRank rank, decimal expectedCommission)
        {
            var actualCommission = CommissionCalculator.CalculateCommission(rank, _investors);

            Assert.Equal(expectedCommission, actualCommission);
        }
    }
}
