namespace Models
{
    public class StripePaymentDTO
    {
        public string ProductName { get; set; }
        public long Amount { get; set; }
        public string ImageUrl { get; set; }
        public string ReturnUrl { get; set; }
    }
}
