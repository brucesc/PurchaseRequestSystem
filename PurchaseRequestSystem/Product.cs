using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace PurchaseRequestSystem
{
    public class Product
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        [Required]
        [MaxLength(50)]
        public string PartNumber { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [MaxLength(255)]
        public string Unit { get; set; }
        [MaxLength(255)]
        public string PhotoPath { get; set; }
        [Required]
        public bool Active { get; set; }
        //[Required]
        //[DatabaseGenerated(DatabaseGeneratedOption=GetDate()] //Come back to this
        //public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        //public int UpdatedByUser { get; set; }

        public virtual Vendor Vendor { get; set; }
    }
}
