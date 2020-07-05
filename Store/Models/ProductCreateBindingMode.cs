using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class ProductCreateBindingMode
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
    }
}
