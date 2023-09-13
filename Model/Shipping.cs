namespace ParallelTaskApp.Model
{
    public class Shipping
    {
        public int ShippingId { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public int ShippingStatus { get; set; }
    }
}
