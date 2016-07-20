using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvisorCalc
{
    public class CommissionCalculator
    {
        public static decimal CalculateCommission(Advisor advisor, IEnumerable<Investor> investors)
        {
            decimal commission = 0;

            foreach(var investor in investors)
            {
                decimal bps = 0;

                if(investor.TotalAssets < 500000)
                {
                    bps = 5;
                }
                else if (investor.TotalAssets < 2000000)
                {
                    bps = 10;
                }
                else
                {
                    bps = 15;
                }
                commission += investor.TotalAssets * 0.0001m * bps;
            }

            if(advisor.Rank == AdvisorRank.Junior)
            {
                return commission * 0.5m;
            }

            return commission;
        }
    }
}
