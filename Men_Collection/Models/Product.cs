using System;
using System.ComponentModel.DataAnnotations;

namespace Men_Collection.Models
{
    public class Product
    {
        [Key]
        public int product_id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string image { get; set; }
        [Required]
        public string price { get; set; }

        [Foreignkey("ProductCategory")]
        public int CategoryId { get; set; }
        public virtual Category ProductCategory { get; set; }
    }

    internal class ForeignkeyAttribute : Attribute
    {
        private string v;

        public ForeignkeyAttribute(string v)
        {
            this.v = v;
        }
    }
}
