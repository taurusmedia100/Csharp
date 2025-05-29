namespace Entities.Model
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }         // Ad
        public string LastName { get; set; }          // Soyad

        public string Email { get; set; }             // E-mail (unikal)
        public string UserName { get; set; }          // İstifadəçi adı (unikal)

        public string PasswordHash { get; set; }      // Şifrənin hash-lənmiş forması

        public int TokenBalance { get; set; }         // İstifadəçinin hazırkı jeton balansı

        public ICollection<Purchase> Purchases { get; set; }  // İstifadəçinin aldığı paketlər (naviqasiya)
    }

}
