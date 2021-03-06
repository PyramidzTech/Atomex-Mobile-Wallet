
namespace atomex.ViewModel
{
    public class BakerViewModel : BaseViewModel
    {
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Fee { get; set; }
        public decimal MinDelegation { get; set; }
        public decimal StakingAvailable { get; set; }
        public decimal EstimatedRoi { get; set; }

        public bool IsFull => StakingAvailable <= 0;
        public bool IsMinDelegation => MinDelegation > 0;
    }
}

