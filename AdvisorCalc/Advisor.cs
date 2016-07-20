
namespace AdvisorCalc
{
    public class Advisor
    {
        public string Name { get; set; }
        public AdvisorRank Rank { get; set; }
    }

    public enum AdvisorRank
    {
        Junior,
        Senior
    }
}
