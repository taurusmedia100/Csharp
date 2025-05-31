namespace Entities.Model
{
    public class JetonPackage
    {
        public int Id { get; set; }
        public string Name { get; set; }  // Məsələn: "Basic", "Standard", "Pro"
        public int JetonCount { get; set; }   // Jeton sayı (məsələn 100 jeton)
        public decimal Price { get; set; }   // Məsələn 4.99 AZN
        public List<Purchase> Purchases { get; set; }  // Bu paketi alan istifadəçilər
    }
}
    