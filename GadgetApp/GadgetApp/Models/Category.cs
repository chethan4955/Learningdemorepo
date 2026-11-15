using System.ComponentModel.DataAnnotations;

namespace GadgetApp.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string description {get;set;}

        public string Email {get;set;}

    }
}