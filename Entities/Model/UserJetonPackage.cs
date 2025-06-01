namespace Entities.Model
{
    public class UserJetonPackage
    {
        // public ICollection<Purchase> Purchases { get; set; }  // İstifadəçinin aldığı paketlər (naviqasiya)

        public string JetonPackageId { get; set; }
        public JetonPackage JetonPackage { get; set; }
        public string UserId { get; set; }
        public User Users { get; set; }

    }
}
