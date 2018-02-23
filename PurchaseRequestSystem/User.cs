using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;



namespace PurchaseRequestSystem
{
    public class User
    {
        public User(string username, string password, string firstName, string lastName, string phone, string email, bool isReviewer, bool isAdmin, bool active, DateTime dateCreated, DateTime dateUpdated)
        {
            UserName = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            IsReviewer = isReviewer;
            IsAdmin = IsAdmin;
            Active = active;
            DateCreated = dateCreated;
            DateUpdated = dateUpdated;
        }

        public User(string username, string password, string firstName, string lastName, string phone, string email, bool isReviewer, bool isAdmin, bool active)
        {
            UserName = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            IsReviewer = isReviewer;
            IsAdmin = IsAdmin;
            Active = active;
        }

        public int Id { get; set; }
        [Index(IsUnique=true)]
        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(20)]
        public string Password { get; set; }
        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }
        [MaxLength(12)]
        public string Phone { get; set; }
        [MaxLength(75)]
        public string Email { get; set; } 
        public bool IsReviewer { get; set; } //See if these default to false        
        public bool IsAdmin { get; set; }
        public bool Active { get; set; }
        //[DatabaseGenerated(DatabaseGenerated=computed)]
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        //public int UpdatedByUser { get; set; }
    }
}
