using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PurchaseRequestSystem
{
    public class Vendor
    {
        public Vendor(string code, string name, string address, string city, string state, string zip, string phone, string email, bool isPreApproved, bool active, DateTime dateCreated, DateTime dateUpdated)
        {
            Code = code;
            Name = name;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
            IsPreApproved = isPreApproved;
            Active = active;
            DateCreated = dateCreated;
            DateUpdated = dateUpdated;
        }

        public int Id { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [MaxLength(10)]
        public string Code { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Address { get; set; }
        [Required]
        [MaxLength(255)]
        public string City { get; set; }
        [Required]
        [MaxLength(2)]
        public string State { get; set; }
        [Required]
        [MaxLength(5)]
        public string Zip { get; set; }
        [Required]
        [MaxLength(18)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(75)]
        public string Email { get; set; }
        public bool IsPreApproved { get; set; }
        public bool Active { get; set; }
        //[DatabaseGenerated] //Come back to this
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        //public int UpdatedByUser { get; set; }






    }
}
