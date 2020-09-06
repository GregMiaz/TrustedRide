namespace TrustedRide.Domain.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Car Car { get; set; }
        public Order Order { get; set; }
        public int CarId { get; set; }
        public int OrderId { get; set; }

    }
}
