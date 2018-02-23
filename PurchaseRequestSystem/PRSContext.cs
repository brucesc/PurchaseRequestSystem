using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace PurchaseRequestSystem
{
    public class PRSContext : DbContext
    {
        public PRSContext() : base()
        { }

        public virtual DbSet<User> users { get; set; }
        public virtual DbSet<Vendor> vendors { get; set; }
        public virtual DbSet<Product> products { get; set; }
        public virtual DbSet<PurchaseRequest> purchaseRequest { get; set; }
        public virtual DbSet<PurchaseRequestLineItem> purchaseRequestLineItem { get; set; }





    }
}
