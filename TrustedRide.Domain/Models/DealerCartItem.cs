namespace TrustedRide.Domain.Models
{
    public class DealerCartItem
    {
        public int DealerCartItemId { get; set; }
        public Car Car { get; set; }
        public int Quantity { get; set; }
        public string DealerCartId { get; set; }
    }
}
