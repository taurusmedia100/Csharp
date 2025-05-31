using Microsoft.AspNetCore.Identity;

namespace Entities.Model
{
    public class User :IdentityUser
    {

        public string FirstName { get; set; }       // Ad
        public string LastName { get; set; }        // Soyad
        public bool IsActive { get; set; } = true;
        public string? ProfileImageUrl { get; set; }
        public string? StripeCustomerId { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public decimal BeforeLastPaymentLastJetonBalance { get; set; }  //sonuncu odenisden evvelki jeton sayi
        public decimal CurrentJetonBalance { get; set; }       // Jeton sayı
        public DateTime CreatedAt { get; set; }     // Qeydiyyat tarixi
        public ICollection<UserPurchase> UserPurchases { get; set; }


    }

}
