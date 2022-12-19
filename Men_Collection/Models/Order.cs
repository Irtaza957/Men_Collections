using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Men_Collection.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }        
        public string Status { get; set; }
        public DateTime LastUpdated { get; set; }
        // Book
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public virtual Product Products { get; set; }
        // User
        [ForeignKey("Users")]
        public string UserId { get; set; }
        public virtual IdentityUser Users { get; set; }
    }
}
