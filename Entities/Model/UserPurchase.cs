using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class UserPurchase
    {
        // public ICollection<Purchase> Purchases { get; set; }  // İstifadəçinin aldığı paketlər (naviqasiya)

        public string  PurchaseId { get; set; }
        public Purchase Purchases { get; set; }
        public string UserId { get; set; }
        public User Users { get; set; }

    }
}
