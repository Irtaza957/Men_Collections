using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Men_Collection.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }

        public List<Product> Products { get; set; }
    }
}
