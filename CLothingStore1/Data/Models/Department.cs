using System.ComponentModel.DataAnnotations;

namespace CLothingStore1.Data.Models
{
    //this determines for men, women, boys, girls, babies
    public class Department
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? name { get; set; }
        public List<Clothing> Clothings { get; set; } = new();
    }
}
