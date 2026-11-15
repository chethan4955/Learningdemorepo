using System.ComponentModel.DataAnnotations;

namespace GadgetApp.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}