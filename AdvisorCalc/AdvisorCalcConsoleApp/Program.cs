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

            var joeCommission = CommissionCalculator.CalculateCommission(AdvisorRank.Junior, investors);

            Console.WriteLine($"Junior advisor commission: {joeCommission.ToString("C")}");

            var susanCommission = CommissionCalculator.CalculateCommission(AdvisorRank.Senior, investors);

            Console.WriteLine($"Senior advisor commission: {susanCommission.ToString("C")}");

            Console.WriteLine("All done, hit a key to end.");
            Console.ReadKey();
        }
    }
}
