using System.ComponentModel.DataAnnotations;
namespace GadgetApp.Models
{
    public class Gadget
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(1, 10000000)]
        public decimal price { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [Range(1, 5)]
        public int rating { get; set; }

        public string Imageurl { get; set; }
    }
}
