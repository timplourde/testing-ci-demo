
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvisorCalc
{
    public static class CommissionCalculator
    {
        public static decimal CalculateCommission(AdvisorRank advisorRank, IEnumerable<Investor> investors)
        {
            return investors
                    .Sum(i => i.Fee())
                    .AdjustedByRank(advisorRank);
        }

        private static decimal AdjustedByRank(this decimal commission, AdvisorRank advisorRank)
        {
            switch (advisorRank)
            {
                case AdvisorRank.Junior:
                    return commission * 0.5m;
                case AdvisorRank.Experienced:
                    return commission * 0.75m;
                case AdvisorRank.Senior:
                    return commission;
                default:
                    throw new Exception("Unknown rank!");
            }
        }
    }
}
