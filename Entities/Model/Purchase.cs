namespace Entities.Model
{
    public class Purchase
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int TokenPackageId { get; set; }
        public TokenPackage TokenPackage { get; set; }

        public DateTime PurchaseDate { get; set; }

        public string StripeSessionId { get; set; }
        public string PaymentStatus { get; set; }  // pending, paid, failed və s.
    }
}
