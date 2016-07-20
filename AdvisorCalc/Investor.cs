
namespace AdvisorCalc
{
    public class Investor
    {
        public decimal TotalAssets { get; set; }
        public int FeeBps()
        {
            if (TotalAssets < 500000)
            {
                return 5;
            }
            else if (TotalAssets < 2000000)
            {
                return 10;
            }
            else
            {
                return 15;
            }
        }
        public decimal Fee()
        {
            return TotalAssets * 0.0001m * FeeBps();
        }
    }
}
