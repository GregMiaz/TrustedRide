using TrustedRide.Infrastructure.Interfaces;

namespace TrustedRide.ViewModels
{
    public class DealerCartVM
    {
        public IDealerCart DealerCart { get; set; }
        public decimal CartTotal { get; set; }
    }
}
