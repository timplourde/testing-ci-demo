using AdvisorCalc;
using System;

namespace AdvisorCalcConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hit a key to start...");
            Console.ReadKey();

            int i = 10 + 2;

            int r = 10;

            var advisorJoe = new Advisor()
            {
                Name = "Joe",
                Rank = AdvisorRank.Junior
            };

            var advisorSusan = new Advisor()
            {
                Name = "Susan",
                Rank = AdvisorRank.Senior
            };

            var investors = new[]
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

            var joeCommission = CommissionCalculator.CalculateCommission(advisorJoe, investors);

            Console.WriteLine($"Joe made {joeCommission.ToString("C")} in commission");

            var susanCommission = CommissionCalculator.CalculateCommission(advisorSusan, investors);

            Console.WriteLine($"Sue made {susanCommission.ToString("C")} in commission");

            Console.WriteLine("All done, hit a key to end.");
            Console.ReadKey();
        }
    }
}
