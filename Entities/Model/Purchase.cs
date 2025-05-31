namespace Entities.Model
{
    public class Purchase
    {
        public string Id { get; set; }

        public int TokenPackageId { get; set; }
        public JetonPackage TokenPackage { get; set; }

        public DateTime PurchaseDate { get; set; }
        public int Amount { get; set; }
        public string StripeSessionId { get; set; }
        public string PaymentStatus { get; set; }  // pending, paid, failed və s.

        public ICollection<UserPurchase> UserPurchases { get; set; }

    }
}
