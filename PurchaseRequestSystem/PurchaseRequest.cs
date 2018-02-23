using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PurchaseRequestSystem
{
    public class PurchaseRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [MaxLength(255)]
        public string Justification { get; set; }
        public DateTime DateNeeded { get; set; }
        [MaxLength(25)]
        public string DeliveryMode { get; set; }
        public int StatusId { get; set; }
        public decimal Total { get; set; }
        public DateTime SubmittedDate { get; set; }
        public bool Active { get; set; }
        [MaxLength(100)]
        public string ReasonForRejection { get; set; }
        //[DatabaseGenerated] //Come back to this
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        //public int UpdatedByUser { get; set; }

        public virtual User User { get; set; }


    }
}
