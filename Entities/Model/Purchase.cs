namespace Entities.Model
{
    public class Purchase
    {
        public string Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Amount { get; set; }
        public string StripeSessionId { get; set; }
        public string PaymentStatus { get; set; }  // pending, paid, failed və s.


        public string JetonPackageId { get; set; }
        public JetonPackage JetonPackage { get; set; }


        public string UserId { get; set; }
        public User User { get; set; }

        //public ICollection<UserJetonPackage> UserPurchases { get; set; }

    }
}
