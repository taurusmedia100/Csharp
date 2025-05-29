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
        public int TokenBalance { get; set; }       // Jeton sayı
        public DateTime CreatedAt { get; set; }     // Qeydiyyat tarixi
        public ICollection<Purchase> Purchases { get; set; }  // İstifadəçinin aldığı paketlər (naviqasiya)
    }

}
