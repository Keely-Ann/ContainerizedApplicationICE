using System.ComponentModel.DataAnnotations;

namespace RetailMVC.Models
{
    public class Products
    {
        //Products - ID, Name, Price 

        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }
    }
}
